
'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F02
'-----------------------------------------------------------------------------------------------------------------

'--MTOVAR_CO_147_ESP_REQ_GPRS_F02

''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
Public Class GestorGuiaCarga
    ''' <summary>
    ''' Procedimiento la creaciòn de guia de carga al iniciar la ruta
    ''' </summary>
    ''' <param name="sId_Carga">identificador de carga o mensaje chofer</param>
    ''' <param name="dFecha_inicio">Fecha de inicio de viaje con hora</param>
    ''' <param name="sKilometraje_ini">kilometraje de inicio de viaje</param>
    ''' <remarks></remarks>
    Public Sub crearGuiaCarga(ByVal sId_Carga As String, _
    ByVal dFecha_inicio As System.DateTime, _
    ByVal sKilometraje_ini As String)
        'creando la fila
        Dim RowGuiaCarga As GuiaDeCargaDataSet.GuiaCargaRow
        RowGuiaCarga = Me.dsGuiaDeCarga.GuiaCarga.NewGuiaCargaRow
        RowGuiaCarga.Id_carga = sId_Carga
        RowGuiaCarga.Fecha_inicio = dFecha_inicio
        RowGuiaCarga.Kilometraje_ini = sKilometraje_ini

        Me.dsGuiaDeCarga.GuiaCarga.AddGuiaCargaRow(RowGuiaCarga)
        ''

        Me.dtaGuiaCarga.Connection = Connection
        Me.dtaGuiaCarga.Update(Me.dsGuiaDeCarga.GuiaCarga)
        ''guardando los cambios.
        Me.dsGuiaDeCarga.AcceptChanges()


    End Sub


    ''' <summary>
    ''' Obteniendo el valor del mensaje chofer
    ''' </summary>
    ''' <returns> valor del campo mensaje chofer de la tabla parametros</returns>
    ''' <remarks></remarks>
    Public Function obtenerMensajeChofer() As String
        Me.dtaParametros.Connection = Connection
        Me.dsGuiaDeCarga.Parametros.Rows.Clear()
        Me.dtaParametros.Fill(Me.dsGuiaDeCarga.Parametros)
        Dim dr As DataRow = Me.dsGuiaDeCarga.Parametros.Rows(0) ''es la primera y unica fila
        Return dr("MensajeChofer").ToString
    End Function

    ''' <summary>
    ''' Obteniendo el valor del número de guia
    ''' </summary>
    ''' <returns>Número de guia</returns>
    ''' <remarks></remarks>
    Public Function obtenerNumGuia() As String
        Me.dtaGuiaCarga.Connection = Connection
        Me.dsGuiaDeCarga.Parametros.Rows.Clear()
        Me.dtaGuiaCarga.Fill(Me.dsGuiaDeCarga.GuiaCarga)
        Dim dr As DataRow = Me.dsGuiaDeCarga.GuiaCarga.Rows(0) ''es la primera y unica fila
        Return dr("Numero_guia").ToString
    End Function
   

    ''' <summary>
    ''' Procedimiento para actualizar los datos de kilometraje fin y fecha fin en el momento de cerrar la ruta
    ''' </summary>
    ''' <param name="sKilometrajeCierre"></param>
    ''' <param name="dFechaFin"></param>
    ''' <remarks></remarks>
    Public Sub actualizarGuiaCarga(ByVal sKilometrajeCierre As String, ByVal dFechaFin As System.DateTime)
        Me.dtaGuiaCarga.Connection = Connection

        Try
            'If Me.Connection.State <> ConnectionState.Open Then
            '    Try
            '        Me.Connection.Open()
            '    Catch ex As Exception

            '    End Try
            'End If

            Me.dtaGuiaCarga.ActualizacionFinRuta(dFechaFin, sKilometrajeCierre, obtenerMensajeChofer())



            Me.dtaGuiaCarga.Connection = Connection
            Me.dtaGuiaCarga.Update(Me.dsGuiaDeCarga.GuiaCarga)
            ''guardando los cambios.
            Me.dsGuiaDeCarga.AcceptChanges()
        Catch ex As Exception

            'Finally
            '    Me.Connection.Close()
        End Try
        


    End Sub


    Public Sub WriteLog(ByVal ex As Exception)
        ' Se guarda la información del error en el archivo
        Dim stream As New System.IO.StreamWriter("\ErrorGuiaCarga.TXT", True)
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


End Class
''FIN MTOVAR_CO_147_ESP_REQ_GPRS_F02