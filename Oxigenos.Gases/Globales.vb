
Module Datos
    Public Barcode As New BarcodeParser
    Public Productos As New GestorProductos
    Public Pedidos As New GestorPedidos
    Public Venta As New GestorVenta
    Public Pacientes As New GestorPacientes
    ''' <summary>
    ''' MTOVAR
    ''' </summary>
    ''' <remarks></remarks>
    Public GuiaCarga As New GestorGuiaCarga
    Public GestorGuiaDocumento As New GestorGuia_Documento
    Public GestorAtencion As New GestorAtencionPedidos

    Public bEntidadBloqueada As Boolean
    Public bRespetaPrecio As Boolean
    Public bVerificarAutorizacion As Boolean
    Public bRemisionValorizada As Boolean
    Public bPagoAlquiler As Boolean
    Public bPagoDeposito As Boolean

    Public PrimeraVez As Boolean = True

    Public Function cstrDBNULL(ByVal sValor As Object, Optional ByVal sValorDefecto As String = "") As String
        If sValor Is Nothing Then
            Return sValorDefecto
        ElseIf sValor.GetType Is Type.GetType("System.DBNull") Then
            If sValorDefecto <> "" Then
                Return sValorDefecto
            Else
                Return ""
            End If
        Else
            Return CStr(sValor)
        End If
    End Function

    Public Function CIntDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Integer = 0) As Integer
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CInt(iValor)
        End If
    End Function

    Public Function CDblDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Double = 0) As Double
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        ElseIf iValor.ToString = "" Then
            Return iValorDefecto
        Else
            Return CDbl(iValor)
        End If
    End Function

    Public Function CShortDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Short = 0) As Short
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CShort(iValor)
        End If
    End Function

    Public Function CDecDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Short = 0) As Decimal
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CDec(iValor)
        End If
    End Function

    Public Function QuitarFormato(ByVal sValor As String) As String
        Return sValor.Replace(",", "")
    End Function

    Public Sub ActualizarCampoShort(ByVal Campo As Object, ByVal Cantidad As Short)
        If Campo Is DBNull.Value Then
            Campo = Cantidad
        Else
            Campo = CShort(Campo) + Cantidad
        End If
    End Sub

    Public Sub ActualizarCampoDouble(ByVal Campo As Object, ByVal Cantidad As Double)
        If Campo Is DBNull.Value Then
            Campo = Cantidad
        Else
            Campo = CDec(Campo) + Cantidad
        End If
    End Sub

    Public Function CalcularPorcentaje(ByVal Precio As Double, ByVal Porcentaje As Double) As Double
        If Porcentaje > 0 Then
            Return (Precio * Porcentaje) / 100
        Else
            Return 0
        End If
    End Function

    Public Function ObtenerNoFactura(ByRef Row As DataRow, ByVal sTipoDocumento As Short) As Boolean
        Row = Nucleo.GetTalonarioActual(sTipoDocumento)

        If Row Is Nothing Then
            UIHandler.ShowError("No existen documentos disponibles para la impresión!!")
            Return False
        Else
            If Row(5).ToString() <> Row(2).ToString() Then
                IncrementarNumeroDocumento(Row)
                While Venta.ObtenerFactura(cstrDBNULL(Row("Actual")))
                    IncrementarNumeroDocumento(Row)
                    Nucleo.UpdateTalonario(Row)
                    Row = Nucleo.GetTalonarioActual(sTipoDocumento)
                End While
            Else
                UIHandler.ShowError("No existen documentos disponibles para la impresión!!")
                Return False
            End If
        End If
        Return True
    End Function

    Public Sub WriteLog(ByVal ex As Exception)
        ' Se guarda la información del error en el archivo
        System.IO.File.Delete("\Log.txt")

        Dim stream As New System.IO.StreamWriter("\Log.txt", True)
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

    'DATASCAN 20170914   
    '    Public Sub VerificaConcistenciaDatos()
    '        Dim _CapaDatos As New ConexionDLL
    '        Dim dt As New DataTable, dt1 As New DataTable, dt2 As New DataTable
    '        Dim sSql As String
    '        sSql = ""
    '        Try
    'DeNuevo:
    '            'BUSCA DUPLICADOS EN MAESTROGUIAS Y DETALLEGUIAASIGNACIONESRECOLECCIONES
    '            sSql = "SELECT MAX(NoMovimiento) as NoMovimiento, TipoDocumento, NoFactura, PrefijoFactura"
    '            sSql = sSql & " FROM MaestroGuias"
    '            'sSql = sSql & " WHERE TipoDocumento IN('A', 'R')"
    '            sSql = sSql & " GROUP BY TipoDocumento, NoFactura, PrefijoFactura"
    '            sSql = sSql & " HAVING COUNT(TipoDocumento) > 1 AND COUNT(NoFactura) > 1 AND COUNT(PrefijoFactura) > 1"
    '            sSql = sSql & " UNION"
    '            sSql = sSql & " SELECT MAX(NoMovimiento) as NoMovimiento, TipoGuia as TipoDocumento, NoGuia as NoFactura, Prefijo as PrefijoFactura"
    '            sSql = sSql & " FROM DetalleGuiaAsignacionesRecolecciones"
    '            'sSql = sSql & " WHERE TipoGuia IN('A', 'R')"
    '            sSql = sSql & " GROUP BY TipoGuia, NoGuia, Prefijo"
    '            sSql = sSql & " HAVING COUNT(TipoGuia) > 1 AND COUNT(NoGuia) > 1 AND COUNT(Prefijo) > 1"
    '            ''Logger.Write("VERIFICA DUPLICADOS MAESTROGUIAS")
    '            dt = _CapaDatos.SqlQuery(sSql)
    '            If Not dt Is Nothing Then
    '                If dt.Rows.Count > 0 Then
    '                    ''Logger.Write("ENCUENTRO DUPLICADOS")

    '                    For x As Integer = 0 To (dt.Rows.Count - 1)
    '                        Dim sNoMovimiento As String = dt.Rows(x)("NoMovimiento").ToString()
    '                        Dim sTipoDocumento As String = dt.Rows(x)("TipoDocumento").ToString()
    '                        Dim sNoFactura As String = dt.Rows(x)("NoFactura").ToString()
    '                        Dim sPrefijoFactura As String = dt.Rows(x)("PrefijoFactura").ToString()
    '                        Dim sNroTalonarioCorrecto As String = sNoFactura
    '                        Dim iCodTipoDocumento As Integer

    '                        'OBTIENE EL NUMERO DE FACTURA DE MAESTRO POR TIPO DE DOCUMENTO
    '                        sSql = "SELECT MAX(NoFactura) AS MAX_NoFactura, TipoDocumento, PrefijoFactura"
    '                        sSql = sSql & " FROM MaestroGuias"
    '                        sSql = sSql & " WHERE TipoDocumento = '" & sTipoDocumento & "'"
    '                        sSql = sSql & " AND PrefijoFactura = '" & sPrefijoFactura & "'"
    '                        sSql = sSql & " GROUP BY TipoDocumento, PrefijoFactura"
    '                        dt1 = _CapaDatos.SqlQuery(sSql)
    '                        If Not dt1 Is Nothing Then
    '                            If dt1.Rows.Count > 0 Then
    '                                'OBTIENE EL NUMERO DE FACTURA DE TALONARIOS POR TIPO DE DOCUMENTO
    '                                sSql = "SELECT d.CodTipoDocumento, MAX(t.Consecutivo) AS Consecutivo,t.Actual"
    '                                sSql = sSql & " FROM Documentos d INNER JOIN Talonarios t"
    '                                sSql = sSql & " ON d.CodTipoDocumento = t.CodTipoDocumento"
    '                                sSql = sSql & " AND d.Sigla = '" & dt1.Rows(x)("TipoDocumento").ToString() & "'"
    '                                sSql = sSql & " AND t.Prefijo = '" & dt1.Rows(x)("PrefijoFactura").ToString() & "'"
    '                                sSql = sSql & " GROUP BY d.CodTipoDocumento, t.Actual"
    '                                dt2 = _CapaDatos.SqlQuery(sSql)
    '                                'Logger.Write("Consulta el maximo numero consecutivo en la tabla talonarios")
    '                                If Not dt2 Is Nothing Then
    '                                    If dt2.Rows.Count > 0 Then
    '                                        iCodTipoDocumento = CInt(dt2.Rows(0)("CodTipoDocumento").ToString())
    '                                        'COMPARA EL NUMERO FACTURA DE TALONARIOS CONTRA EL DE MAESTROGUIAS
    '                                        If dt2.Rows(0)("Actual").ToString() <> dt1.Rows(x)("MAX_NoFactura").ToString() Then
    '                                            sNroTalonarioCorrecto = CStr(Val(dt1.Rows(x)("MAX_NoFactura").ToString()))
    '                                        End If
    '                                    End If
    '                                End If
    '                            End If
    '                        End If

    '                        sNroTalonarioCorrecto = CStr(Val(sNroTalonarioCorrecto.ToString()) + 1)
    '                        sNroTalonarioCorrecto = Format(Val(sNroTalonarioCorrecto), "00000000")

    '                        If sTipoDocumento = "A" Or sTipoDocumento = "R" Then
    '                            'SI ES ASIGNACION O RECOLECCION DEBE ACTUALIZAR LAS TRES TABLAS SIMULTANEAMENTE
    '                            sSql = "select 1"
    '                            sSql = sSql & " from DetalleGuiaAsignacionesRecolecciones"
    '                            sSql = sSql & " where TipoGuia = '" & sTipoDocumento & "'"
    '                            sSql = sSql & " and NoGuia = '" & sNoFactura & "'"
    '                            sSql = sSql & " and Prefijo = '" & sPrefijoFactura & "'"
    '                            sSql = sSql & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                            dt2 = _CapaDatos.SqlQuery(sSql)
    '                            If Not dt2 Is Nothing Then
    '                                If dt2.Rows.Count > 0 Then
    '                                    'ACTUALIZA LA TABLA DETALLEGUIAASIGNACIONESRECOLECCIONES                                       
    '                                    sSql = "update DetalleGuiaAsignacionesRecolecciones"
    '                                    sSql = sSql & " set NoGuia = '" & sNroTalonarioCorrecto & "'"
    '                                    sSql = sSql & " where TipoGuia = '" & sTipoDocumento & "'"
    '                                    sSql = sSql & " and NoGuia = '" & sNoFactura & "'"
    '                                    sSql = sSql & " and Prefijo = '" & sPrefijoFactura & "'"
    '                                    sSql = sSql & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                    _CapaDatos.SqlCommand(sSql)
    '                                    'Logger.Write("ACTUALIZA LA TABLA DETALLEGUIAASIGNACIONESRECOLECCIONES: " & sSql)

    '                                    'ACTUALIZA LA TABLA MAESTROGUIA                                     
    '                                    sSql = "update MaestroGuias"
    '                                    sSql = sSql & " set NoFactura = '" & sNroTalonarioCorrecto & "'"
    '                                    sSql = sSql & " where TipoDocumento = '" & sTipoDocumento & "'"
    '                                    sSql = sSql & " and NoFactura = '" & sNoFactura & "'"
    '                                    sSql = sSql & " and PrefijoFactura = '" & sPrefijoFactura & "'"
    '                                    sSql = sSql & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                    _CapaDatos.SqlCommand(sSql)
    '                                    'Logger.Write("ACTUALIZA LA TABLA MAESTROGUIA: " & sSql)

    '                                    'ACTUALIZA LA TABLA TALONARIOS 
    '                                    sSql = "UPDATE Talonarios"
    '                                    sSql = sSql & " SET actual = '" & sNroTalonarioCorrecto & "'"
    '                                    sSql = sSql & " WHERE CodTipoDocumento = '" & iCodTipoDocumento & "'"
    '                                    sSql = sSql & " AND Prefijo = '" & sPrefijoFactura & "'"
    '                                    _CapaDatos.SqlCommand(sSql)
    '                                    'Logger.Write("ACTUALIZA LA TABLA TALONARIOS por el metodo VerificaDatosAsignacionesRecolecciones() :" & sSql)
    '                                End If
    '                            End If
    '                        Else
    '                            'SI NO ES ASIGNACION NI ES RECOLECCION DEBE ACTUALIZAR LAS DOS TABLAS SIMULTANEAMENTE
    '                            'ACTUALIZA LA TABLA MAESTROGUIA                                     
    '                            sSql = "update MaestroGuias"
    '                            sSql = sSql & " set NoFactura = '" & sNroTalonarioCorrecto & "'"
    '                            sSql = sSql & " where TipoDocumento = '" & sTipoDocumento & "'"
    '                            sSql = sSql & " and NoFactura = '" & sNoFactura & "'"
    '                            sSql = sSql & " and PrefijoFactura = '" & sPrefijoFactura & "'"
    '                            sSql = sSql & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                            _CapaDatos.SqlCommand(sSql)
    '                            'Logger.Write("ACTUALIZA LA TABLA MAESTROGUIA: " & sSql)

    '                            'ACTUALIZA LA TABLA TALONARIOS 
    '                            sSql = "UPDATE Talonarios"
    '                            sSql = sSql & " SET actual = '" & sNroTalonarioCorrecto & "'"
    '                            sSql = sSql & " WHERE CodTipoDocumento = '" & iCodTipoDocumento & "'"
    '                            sSql = sSql & " AND Prefijo = '" & sPrefijoFactura & "'"
    '                            _CapaDatos.SqlCommand(sSql)
    '                            'Logger.Write("ACTUALIZA LA TABLA TALONARIOS por el metodo VerificaDatosAsignacionesRecolecciones() :" & sSql)
    '                        End If
    '                    Next
    '                    GoTo DeNuevo
    '                End If
    '            End If
    '        Catch ex As SqlCeException
    '            'Logger.Write("Ocurrio un error en la funcion VerificaDatosAsignacionesRecolecciones()" & Chr(13) & _
    '            '" CONSULTA EMPLEADA: " & sSql & _
    '            '" ERROR TECNICO: " & ex.Message.ToString())
    '            WriteLog(ex)
    '        End Try
    '    End Sub

    '    Private Sub VerificaDatosAsignacionesRecolecciones()
    '        Dim _ValidacionMaestroGuias As New ConexionDLL
    '        Dim dt As New DataTable, dt1 As New DataTable, dt2 As New DataTable
    '        Dim sSql As String
    '        sSql = ""
    '        Try
    'DeNuevo:
    '            'BUSCA DUPLICADOS EN LAS ASIGNACIONES Y RECOLECCIONES
    '            sSql = "SELECT MAX(NoMovimiento) as NoMovimiento, TipoDocumento, NoFactura, PrefijoFactura" _
    '            & " FROM MaestroGuias" _
    '            & " WHERE TipoDocumento IN('A', 'R')" _
    '            & " GROUP BY TipoDocumento, NoFactura, PrefijoFactura" _
    '            & " HAVING COUNT(TipoDocumento) > 1 AND COUNT(NoFactura) > 1 AND COUNT(PrefijoFactura) > 1" _
    '            & " UNION" _
    '            & " SELECT MAX(NoMovimiento) as NoMovimiento, TipoGuia as TipoDocumento, NoGuia as NoFactura, Prefijo as PrefijoFactura" _
    '            & " FROM DetalleGuiaAsignacionesRecolecciones" _
    '            & " WHERE TipoGuia IN('A', 'R')" _
    '            & " GROUP BY TipoGuia, NoGuia, Prefijo" _
    '            & " HAVING COUNT(TipoGuia) > 1 AND COUNT(NoGuia) > 1 AND COUNT(Prefijo) > 1"

    '            'Logger.Write("VERIFICA DUPLICADOS DE ASIGNACION Y RECOLECCION")
    '            dt = _ValidacionMaestroGuias.SqlQuery(sSql)
    '            If Not dt Is Nothing Then
    '                If dt.Rows.Count > 0 Then
    '                    For x As Integer = 0 To (dt.Rows.Count - 1)
    '                        'OBTIENE EL NUMERO DE TALONARIO Y LE AUMENTA 1
    '                        'Logger.Write("OBTIENE EL NUMERO DE TALONARIO Y LE AUMENTA 1")
    '                        sSql = "SELECT (t.Actual) as Actual, d.CodTipoDocumento" _
    '                        & " FROM Documentos d INNER JOIN" _
    '                        & " Talonarios t ON d.CodTipoDocumento = t.CodTipoDocumento" _
    '                        & " WHERE d.Sigla = '" & dt.Rows(x)("TipoDocumento").ToString() & "'"
    '                        dt1 = _ValidacionMaestroGuias.SqlQuery(sSql)
    '                        If Not dt1 Is Nothing Then
    '                            If dt1.Rows.Count > 0 Then
    '                                Dim sNroTalonarioCorrecto As String = CStr(Val(dt1.Rows(0)("Actual").ToString()) + 1)
    '                                Dim sTipoDocumento As String = dt.Rows(x)("TipoDocumento").ToString()
    '                                Dim sNoFactura As String = dt.Rows(x)("NoFactura").ToString()
    '                                Dim sPrefijoFactura As String = dt.Rows(x)("PrefijoFactura").ToString()
    '                                Dim sNoMovimiento As String = dt.Rows(x)("NoMovimiento").ToString()
    '                                sNroTalonarioCorrecto = Format(Val(sNroTalonarioCorrecto), "00000000")

    '                                sSql = "select * from MaestroGuias " _
    '                                        & " where TipoDocumento = '" & sTipoDocumento & "'" _
    '                                        & " and NoFactura = '" & sNoFactura & "'" _
    '                                        & " and PrefijoFactura = '" & sPrefijoFactura & "'" _
    '                                        & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                dt2 = _ValidacionMaestroGuias.SqlQuery(sSql)
    '                                If Not dt2 Is Nothing Then
    '                                    If dt2.Rows.Count > 0 Then
    '                                        'Logger.Write("SI TIENE DATOS")
    '                                    End If
    '                                End If

    '                                'ACTUALIZA LA TABLA MAESTROGUIA                                     
    '                                sSql = "update MaestroGuias" _
    '                                & " set NoFactura = '" & sNroTalonarioCorrecto & "'" _
    '                                & " where TipoDocumento = '" & sTipoDocumento & "'" _
    '                                & " and NoFactura = '" & sNoFactura & "'" _
    '                                & " and PrefijoFactura = '" & sPrefijoFactura & "'" _
    '                                & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                _ValidacionMaestroGuias.SqlCommand(sSql)
    '                                'Logger.Write("ACTUALIZA LA TABLA MAESTROGUIA: " & _
    '                                                               sSql)

    '                                sSql = "select * from DetalleGuiaAsignacionesRecolecciones " _
    '                                & " where TipoGuia = '" & sTipoDocumento & "'" _
    '                                & " and NoGuia = '" & sNoFactura & "'" _
    '                                & " and Prefijo = '" & sPrefijoFactura & "'" _
    '                                & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                dt2 = _ValidacionMaestroGuias.SqlQuery(sSql)
    '                                If Not dt2 Is Nothing Then
    '                                    If dt2.Rows.Count > 0 Then
    '                                        'Logger.Write("SI TIENE DATOS")
    '                                    End If
    '                                End If

    '                                'ACTUALIZA LA TABLA DETALLEGUIAASIGNACIONESRECOLECCIONES                                       
    '                                sSql = "update DetalleGuiaAsignacionesRecolecciones" _
    '                                & " set NoGuia = '" & sNroTalonarioCorrecto & "'" _
    '                                & " where TipoGuia = '" & sTipoDocumento & "'" _
    '                                & " and NoGuia = '" & sNoFactura & "'" _
    '                                & " and Prefijo = '" & sPrefijoFactura & "'" _
    '                                & " and NoMovimiento = '" & sNoMovimiento & "'"
    '                                _ValidacionMaestroGuias.SqlCommand(sSql)
    '                                'Logger.Write("ACTUALIZA LA TABLA DETALLEGUIAASIGNACIONESRECOLECCIONES: " & _
    '                                sSql)


    '                                'ACTUALIZA LA TABLA TALONARIOS 
    '                                sSql = "UPDATE Talonarios" _
    '                                & " SET actual = '" & sNroTalonarioCorrecto & "'" _
    '                                & " WHERE CodTipoDocumento = '" & dt1.Rows(0)("CodTipoDocumento").ToString() & "'" _
    '                                & " AND Prefijo = '" & sPrefijoFactura & "'"
    '                                _ValidacionMaestroGuias.SqlCommand(sSql)
    '                                'Logger.Write("ACTUALIZA LA TABLA TALONARIOS por el metodo VerificaDatosAsignacionesRecolecciones() :" + Chr(13) + sSql)
    '                            End If
    '                        End If
    '                    Next
    '                    GoTo DeNuevo
    '                End If
    '            End If
    '        Catch ex As SqlCeException
    '            'Logger.Write("Ocurrio un error en la funcion VerificaDatosAsignacionesRecolecciones()" & Chr(13) & _
    '             "CONSULTA EMPLEADA: " & sSql & _
    '             "ERROR TECNICO: " & ex.Message.ToString())
    '        End Try
    '    End Sub
    'FIN DATASCAN 20170914

End Module
