Imports OpenNETCF.Net
Imports OpenNETCF.WindowsCE
Imports System.Net

Public Class CargaDatosForm
    Implements IEstadoCarga

    Private m_ws As OxigenosWS.DataAccess

    Private m_Thread As OpenNETCF.Threading.Thread2
    Private m_IdProceso As Integer = ProcesosComunicacion.CargaCompleta
    Private m_bUpdateCurrentRows As Boolean = False
    Private m_DescripProceso As String = "Descarga datos"
    Private m_sData As String = Nothing
    Private m_bCancelado As Boolean = False
    Private m_bUsarGPRS As Boolean = False
    Private Delegate Sub ActualizarMensajeHandler(ByVal sData As String)
    Private Delegate Sub SetProgresoHandler(ByVal Progreso As Integer)


    Public Shared Function Run(ByVal IdProceso As Integer, ByVal sNombreProceso As String, _
    ByVal bUpdateCurrentRows As Boolean, ByVal bUsarGPRS As Boolean) As Boolean

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
        Dim frm As New CargaDatosForm
        frm.m_IdProceso = IdProceso
        frm.m_DescripProceso = sNombreProceso
        frm.m_bUpdateCurrentRows = bUpdateCurrentRows
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


    Private Sub CargaDatosForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Se inicializan controles
        UiHandler1.Parent = Me
        pnlInfoTablas.Visible = False
        Me.lblProceso.Text = Me.m_DescripProceso

        ' Se inicia el hilo de ejecución de la integración de datos y se habilita el timer
        ' de reset de estado Idle del sistema
        timerResetIdleState.Enabled = True
        m_Thread = New OpenNETCF.Threading.Thread2(AddressOf IntegrarDatosThread)
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

    Private Sub IntegrarDatosThread()
        Dim sFecha As String = ""
        Try
            IniciarObtenerDatos("Obteniendo datos del servidor...")
            ConfigurarWebService()

            ' Se sincroniza la hora del sistema con la hora del servidor
            m_ws.Timeout = 10000
            sFecha = m_ws.GetFechaSistema()
            DateTimeHelper.LocalTime = DateTime.ParseExact(sFecha, "dd/MM/yyyy HH:mm:ss", Nothing)
            m_ws.Timeout = TIMEOUT_WEBSERVICE

            ''---------------------
            ''Solo para depuración lo que hace es cargar un archivo de txt de backup de la carga de un
            ''día()
            'Dim ofD As New OpenFileDialog
            'If ofD.ShowDialog() = DialogResult.OK Then
            ' Dim sr As New System.IO.StreamReader(ofD.FileName, System.Text.Encoding.Default, True)
            ' m_sData = sr.ReadToEnd()
            ' sr.Close()
            ' End If
            ''---------------------

            'TOCA QUITAR
            m_sData = m_ws.GetDatosCarga(Settings.IDTerminal, Me.m_IdProceso, Programa.Codigo)
            IniciarIntegracionDatos("Integrando datos...")
            If Not Me.Cancelado Then
                GestorNucleo.IntegrarDatos(Me.m_sData, Me.m_bUpdateCurrentRows, Me)
            End If
            'TOCA QUITAR
            m_ws.ConfirmarCarga(Settings.IDTerminal, Me.m_IdProceso, Programa.Codigo)
            MostrarProcesoTerminado("Proceso de carga de datos terminado exitosamente")
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
        btnTerminar.Focus()
    End Sub

    Private Sub MostrarProcesoTerminado(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalMostrarProcesoTerminado)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub IniciarObtenerDatos(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalIniciarObtenerDatos)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub IniciarIntegracionDatos(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalIniciarIntegracionDatos)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub InternalIniciarObtenerDatos(ByVal sMensaje As String)
        lblFase.Text = sMensaje
        pnlInfoTablas.Visible = False
        pnlObtenerDatos.Visible = True
        AnimateCtl1.StartAnimation()
    End Sub

    Private Sub InternalIniciarIntegracionDatos(ByVal sMensaje As String)
        lblFase.Text = sMensaje
        AnimateCtl1.StopAnimation()
        pnlObtenerDatos.Visible = False
        pnlInfoTablas.Visible = True
    End Sub

    Private Sub MostrarError(ByVal sMensaje As String)
        Dim funcHandler As New ActualizarMensajeHandler(AddressOf InternalMostrarError)
        Me.Invoke(funcHandler, sMensaje)
    End Sub

    Private Sub InternalMostrarError(ByVal sMensaje As String)
        pnlError.Visible = True
        pnlError.BringToFront()
        lblError.Text = sMensaje
        btnCerrarByError.Focus()
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