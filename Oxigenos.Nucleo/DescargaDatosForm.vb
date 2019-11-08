Imports OpenNETCF.Net
Imports System.Net
Imports System.Windows.Forms
Imports System.Data

Public Class DescargaDatosForm
    Implements IEstadoCarga

    Private m_ws As OxigenosWS.DataAccess
    Private m_Thread As OpenNETCF.Threading.Thread2
    Private m_IdProceso As Integer = ProcesosComunicacion.DescargaCompleta
    Private m_DescripProceso As String = "Descarga Datos"
    Private m_sData As String = Nothing
    Private m_bCancelado As Boolean = False
    Private Delegate Sub ActualizarMensajeHandler(ByVal sData As String)
    Private Delegate Sub SetProgresoHandler(ByVal Progreso As Integer)
    Private m_QueryList As ListQuerysDescarga
    Private m_bUsarGPRS As Boolean
    Private m_Rows() As DataRow
    Private m_Fields As String
    Private m_TableName As String


    Public Shared Function Run(ByVal IdProceso As Integer, ByVal sNombreProceso As String, _
    ByVal QueryList As ListQuerysDescarga, ByVal bUsarGPRS As Boolean) As Boolean

        Dim result As Boolean = False

        ' Si asi se especifica se intenta primero establecer la conexión GPRS
        UIHandler.StartWait()
        If bUsarGPRS Then
            If Not GPRS.Conectar() Then
                UIHandler.EndWait()
                MsgBox("Paila")
                Return False

            End If
            MsgBox("Entro")
        End If

        ' Se crea la instancia de la forma y se inicia el proceso
        Dim frm As New DescargaDatosForm
        frm.m_IdProceso = IdProceso
        frm.m_DescripProceso = sNombreProceso
        frm.m_QueryList = QueryList
        frm.m_bUsarGPRS = bUsarGPRS
        result = (UIHandler.ShowDialog(frm) = System.Windows.Forms.DialogResult.OK)

        frm.Dispose()
        ' Finalmente se cierra la conexión
        If bUsarGPRS Then
            GPRS.Desconectar()
        End If
        UIHandler.EndWait()
        Return result
    End Function

    Public Shared Function Run(ByVal IdProceso As Integer, ByVal sNombreProceso As String, _
    ByVal Rows() As DataRow, ByVal Fields As String, ByVal sTableName As String, _
    ByVal bUsarGPRS As Boolean) As Boolean

        Dim result As Boolean = False

        ' Si asi se especifica se intenta primero establecer la conexión GPRS
        UIHandler.StartWait()
        If bUsarGPRS Then
            If Not GPRS.Conectar() Then
                UIHandler.EndWait()
                Return False
            End If
        End If

        ' Se crea la instancia de la forma y se inicia el proceso
        Dim frm As New DescargaDatosForm
        frm.m_IdProceso = IdProceso
        frm.m_DescripProceso = sNombreProceso
        frm.m_Rows = Rows
        frm.m_Fields = Fields
        frm.m_TableName = sTableName
        frm.m_bUsarGPRS = bUsarGPRS
        result = (UIHandler.ShowDialog(frm) = System.Windows.Forms.DialogResult.OK)
        frm.Dispose()
        ' Finalmente se cierra la conexión
        If bUsarGPRS Then
            GPRS.Desconectar()
        End If
        UIHandler.EndWait()
        Return result
    End Function

    Private Sub DecargaDatosForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Se inicializan controles
        UiHandler1.Parent = Me
        pnlInfoTablas.Visible = False
        Me.lblProceso.Text = Me.m_DescripProceso

        ' Se inicia el hilo de ejecución de la integración de datos y se habilita el timer
        ' de reset de estado Idle del sistema
        timerResetIdleState.Enabled = True
        m_Thread = New OpenNETCF.Threading.Thread2(AddressOf EnviarDatosThread)
        m_Thread.Start()
        UIHandler.EndWait()
    End Sub

    Private Sub ConfigurarWebService()
        m_ws = New OxigenosWS.DataAccess
        If m_bUsarGPRS Then
            m_ws.Url = "http://" & Settings.IPServidorGPRS & ":" & Settings.PuertoServidor & "/" & _
                Settings.VirtualDirectory & "/DataAccess.asmx"
        Else
            m_ws.Url = "http://" & Settings.IPServidor & ":" & Settings.PuertoServidor & "/" & _
                Settings.VirtualDirectory & "/DataAccess.asmx"
        End If
        m_ws.Timeout = TIMEOUT_WEBSERVICE
        If Settings.UsuarioWebService <> "" Then
            m_ws.Credentials = New NetworkCredential(Settings.UsuarioWebService, Settings.ClaveWebService)
        End If
    End Sub

    Private Sub EnviarDatosThread()
        Try
            IniciarObtenerDatos("Obteniendo datos locales...")
            If m_QueryList IsNot Nothing Then
                m_sData = GestorNucleo.GetSerializedData(Me.m_QueryList, Me)
            ElseIf m_Rows IsNot Nothing Then
                m_sData = TextSerializer.Serialize(Me.m_Rows, m_Fields, m_TableName)
            End If
            IniciarEnvioDatos("Enviando datos al servidor")
            If Not Me.Cancelado Then
                ConfigurarWebService()
                m_ws.SendDatos(Settings.IDTerminal, Programa.Codigo, m_IdProceso, m_sData)
                If m_IdProceso = ProcesosComunicacion.DescargaCompleta Then
                    GestorNucleo.dsNucleo.Parametros(0).DescargaRealizada = True
                    GestorNucleo.UpdateParametros()
                End If
                MostrarProcesoTerminado("Proceso de descarga de datos terminado exitosamente")
            End If
        Catch ex As Exception
            MostrarError(ex.GetType().ToString & vbCrLf & ex.Message)
            WriteLog(ex)
        End Try
    End Sub

    Private Sub InternalMostrarProcesoTerminado(ByVal sMensaje As String)
        pnlInfoTablas.Visible = False
        pnlTerminado.Visible = True
        pnlTerminado.BringToFront()
        lblMensajeFinal.Text = sMensaje
    End Sub

    Private Sub MostrarProcesoTerminado(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalMostrarProcesoTerminado)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub IniciarObtenerDatos(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalIniciarObtenerDatos)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub InternalIniciarEnvioDatos(ByVal sMensaje As String)
        pnlInfoTablas.Visible = False
        pnlEnviar.Visible = True
        AnimateCtl1.StartAnimation()
        lblFase.Text = sMensaje
    End Sub

    Private Sub IniciarEnvioDatos(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalIniciarEnvioDatos)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub InternalIniciarObtenerDatos(ByVal sMensaje As String)
        pnlInfoTablas.Visible = True
        lblFase.Text = sMensaje
    End Sub

    Private Sub MostrarError(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalMostrarError)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub InternalMostrarError(ByVal sMensaje As String)
        pnlError.Visible = True
        pnlError.BringToFront()
        lblError.Text = sMensaje
    End Sub

    Private Sub timerResetIdleState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerResetIdleState.Tick
        OpenNETCF.WindowsCE.PowerManagement.ResetSystemIdleTimer()
    End Sub

    Private Sub btnTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminar.Click
        UIHandler.StartWait()
        timerResetIdleState.Enabled = False
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        m_bCancelado = True
        lblFase.Text = "Cancelando..."
        pnlInfoTablas.Visible = False
        pbAvanceTotal.Visible = False
        btnCancelar.Enabled = False
        Application.DoEvents()
        If m_Thread IsNot Nothing AndAlso m_Thread.State <> OpenNETCF.Threading.ThreadState.Stopped Then
            If Not m_Thread.Join(5000) Then
                Try
                    m_Thread.Abort()
                Catch
                End Try
            End If
        End If
        UIHandler.StartWait()
        timerResetIdleState.Enabled = False
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnCerrarByError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarByError.Click
        UIHandler.StartWait()
        timerResetIdleState.Enabled = False
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Public Shared Sub WriteLog(ByVal ex As Exception)
        ' Se guarda la información del error en el archivo
        Dim stream As New System.IO.StreamWriter("\ErroresIntegracion.TXT", True)
        Dim bld As New System.Text.StringBuilder()
        Dim inner As Exception = ex.InnerException

        stream.WriteLine("==============================================================================")
        stream.WriteLine(Now.ToString() & "Ha ocurrido una excepción: " & ex.GetType().FullName)
        stream.WriteLine(ex.Message)
        If Not inner Is Nothing Then
            stream.WriteLine("Inner Exception: " & inner.ToString())
        End If
        If ex.GetType() Is GetType(System.Data.SqlServerCe.SqlCeException) Then
            Dim sqlex As System.Data.SqlServerCe.SqlCeException
            Dim err As System.Data.SqlServerCe.SqlCeError
            sqlex = DirectCast(ex, System.Data.SqlServerCe.SqlCeException)

            ' Enumerate each error to a message box.
            For Each err In sqlex.Errors
                stream.WriteLine(" Error Code: " & err.HResult.ToString("X"))
                stream.WriteLine(" Message   : " & err.Message)
                stream.WriteLine(" Minor Err.: " & err.NativeError)
                stream.WriteLine(" Source    : " & err.Source)

                ' Retrieve the error parameter numbers for each error.
                Dim numPar As Integer
                For Each numPar In err.NumericErrorParameters
                    If 0 <> numPar Then
                        stream.WriteLine(" Num. Par. : " & numPar)
                    End If
                Next numPar

                ' Retrieve the error parameters for each error.
                Dim errPar As String
                For Each errPar In err.ErrorParameters
                    If String.Empty <> errPar Then
                        bld.Append((ControlChars.Cr & " Err. Par. : " & errPar))
                    End If
                Next errPar
            Next err
        End If
        stream.WriteLine("Stack Trace: " & ex.StackTrace.ToString())
        stream.Close()
    End Sub


#Region " Implementación IEstadoCarga "

    Public ReadOnly Property Cancelado() As Boolean Implements IEstadoCarga.Cancelado
        Get
            Return m_bCancelado
        End Get
    End Property

    Private Sub InternalIniciarTabla(ByVal sNombreTabla As String)
        pbAvanceTabla.Value = 0
        lblTabla.Text = "Procesando " & sNombreTabla
    End Sub

    Private Sub SetProgresosTabla(ByVal Progreso As Integer)
        pbAvanceTabla.Value = Progreso
    End Sub

    Private Sub SetProgresoTotal(ByVal Progreso As Integer)
        pbAvanceTotal.Value = Progreso
    End Sub

    Public Sub IniciarTabla(ByVal sNombreTabla As String) Implements IEstadoCarga.IniciarTabla
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf Me.InternalIniciarTabla)
        Me.Invoke(funcHandler, sNombreTabla)
    End Sub

    Public WriteOnly Property ProgresoTabla() As Integer Implements IEstadoCarga.ProgresoTabla
        Set(ByVal value As Integer)
            Dim funcHandler As New SetProgresoHandler(AddressOf Me.SetProgresosTabla)
            Me.Invoke(funcHandler, value)
        End Set
    End Property

    Public WriteOnly Property ProgresoTotal() As Integer Implements IEstadoCarga.ProgresoTotal
        Set(ByVal value As Integer)
            Dim funcHandler As New SetProgresoHandler(AddressOf Me.SetProgresoTotal)
            Me.Invoke(funcHandler, value)
        End Set
    End Property

#End Region

End Class