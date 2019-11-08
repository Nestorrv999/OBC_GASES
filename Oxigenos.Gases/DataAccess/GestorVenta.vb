Imports System.Data
Public Class GestorVenta
    Public Sub ActualizarReimpresion(ByVal NumeroImp As Integer, ByVal Factura As String, ByVal CodCliente As String, ByVal TipoDocumento As String)
        dtaMaestroGuias.Connection = Me.Connection
        dtaMaestroGuias.UpdateQuery(NumeroImp, Factura, CodCliente, TipoDocumento)
    End Sub
    Public Sub ObtenerPrecio(ByVal RowCliente As DataRow, ByVal sCodEntidad As String, _
    ByVal bAutorizado As Boolean, ByVal bRespertaPrecio As Boolean, ByVal sCodProducto As String, _
    ByRef PrecioNeto As Double, ByRef PorcentajeDescuento As Double, ByVal TotalDescuento As Double, _
    ByRef Row As ProductosDataSet.ProductosRow)

        Dim dt As VentaDataSet.PreciosDataTable
        Dim Result As Boolean = True
        Me.dtaPrecios.Connection = Connection

        If bAutorizado Then
            ' Se busca el precio por entidad
            dt = Me.dtaPrecios.GetPrecio(Nucleo.CodigoSucursal, sCodEntidad, sCodProducto)
            If dt.Rows.Count > 0 Then
                If Row.Codigo.Substring(0, 1) = "1" Then
                    If cstrDBNULL(dt(0)("Acarreo")).ToUpper.TrimEnd = "S" Then
                        PorcentajeDescuento = dt(0).PorcentajeDescuento
                        PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                        TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                    Else
                        PorcentajeDescuento = 0
                        PrecioNeto = 0
                        TotalDescuento = 0
                    End If
                Else
                    PorcentajeDescuento = dt(0).PorcentajeDescuento
                    PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                    TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                End If
            Else
                ' Se toma el precio full de la tabla de productos
                If Row.Codigo.Substring(0, 1) = "1" Then
                    If cstrDBNULL(RowCliente("Acarreo")).ToUpper.TrimEnd = "S" Then
                        PorcentajeDescuento = 0
                        PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                        TotalDescuento = Row.Precio - PrecioNeto
                    Else
                        PorcentajeDescuento = 0
                        PrecioNeto = 0
                        TotalDescuento = 0
                    End If
                Else
                    PorcentajeDescuento = 0
                    PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                    TotalDescuento = Row.Precio - PrecioNeto
                End If
            End If
        Else
            If bRespertaPrecio Then
                ' Se busca por la entidad
                dt = Me.dtaPrecios.GetPrecio(Nucleo.CodigoSucursal, sCodEntidad, sCodProducto)
                If dt.Rows.Count > 0 Then
                    If Row.Codigo.Substring(0, 1) = "1" Then
                        If cstrDBNULL(dt(0)("Acarreo")).ToUpper.TrimEnd = "S" Then
                            PorcentajeDescuento = dt(0).PorcentajeDescuento
                            PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                            TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                        Else
                            PorcentajeDescuento = 0
                            PrecioNeto = 0
                            TotalDescuento = 0
                        End If
                    Else
                        PorcentajeDescuento = dt(0).PorcentajeDescuento
                        PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                        TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                    End If
                Else
                    'Se busca por paciente
                    dt = Me.dtaPrecios.GetPrecio(Nucleo.CodigoSucursal, cstrDBNULL(RowCliente("Codigo")), sCodProducto)
                    If dt.Rows.Count > 0 Then
                        If Row.Codigo.Substring(0, 1) = "1" Then
                            If cstrDBNULL(dt(0)("Acarreo")).ToUpper.TrimEnd = "S" Then
                                PorcentajeDescuento = dt(0).PorcentajeDescuento
                                PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                                TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                            Else
                                PorcentajeDescuento = 0
                                PrecioNeto = 0
                                TotalDescuento = 0
                            End If
                        Else
                            PorcentajeDescuento = dt(0).PorcentajeDescuento
                            PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                            TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                        End If
                    Else
                        ' Se toma el precio full de la tabla de productos
                        If Row.Codigo.Substring(0, 1) = "1" Then
                            If cstrDBNULL(RowCliente("Acarreo")).ToUpper.TrimEnd = "S" Then
                                PorcentajeDescuento = 0
                                PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                                TotalDescuento = Row.Precio - PrecioNeto
                            Else
                                PorcentajeDescuento = 0
                                PrecioNeto = 0
                                TotalDescuento = 0
                            End If
                        Else
                            PorcentajeDescuento = 0
                            PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                            TotalDescuento = Row.Precio - PrecioNeto
                        End If
                    End If
                End If
            Else
                ' Se busca por cliente/paciente
                dt = Me.dtaPrecios.GetPrecio(Nucleo.CodigoSucursal, cstrDBNULL(RowCliente("Codigo")), sCodProducto)
                If dt.Rows.Count > 0 Then
                    If Row.Codigo.Substring(0, 1) = "1" Then
                        If cstrDBNULL(dt(0)("Acarreo")).ToUpper.TrimEnd = "S" Then
                            PorcentajeDescuento = dt(0).PorcentajeDescuento
                            PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                            TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                        Else
                            PorcentajeDescuento = 0
                            PrecioNeto = 0
                            TotalDescuento = 0
                        End If
                    Else
                        PorcentajeDescuento = dt(0).PorcentajeDescuento
                        PrecioNeto = (dt(0).PrecioNeto * (1 - PorcentajeDescuento / 100))
                        TotalDescuento = dt(0).PrecioNeto - PrecioNeto
                    End If
                Else
                    ' Se toma el precio full de la tabla de productos
                    If Row.Codigo.Substring(0, 1) = "1" Then
                        If cstrDBNULL(RowCliente("Acarreo")).ToUpper.TrimEnd = "S" Then
                            PorcentajeDescuento = 0
                            PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                            TotalDescuento = Row.Precio - PrecioNeto
                        Else
                            PorcentajeDescuento = 0
                            PrecioNeto = 0
                            TotalDescuento = 0
                        End If
                    Else
                        PorcentajeDescuento = 0
                        PrecioNeto = (Row.Precio * (1 - PorcentajeDescuento / 100))
                        TotalDescuento = Row.Precio - PrecioNeto
                    End If
                End If
            End If
        End If
    End Sub

    Public Function ObtenerFactura(ByVal Factura As String) As Boolean
        Dim dt As VentaDataSet.MaestroFacturasDataTable
        Me.dtaMaestroFacturas.Connection = Connection
        dt = Me.dtaMaestroFacturas.GetFactura(Factura)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SerialYaCargado(ByVal strCliente As String, ByVal strSecuencial As String) As Boolean
        Dim dt As VentaDataSet.DetalleGuiaRecoleccionesAjenosDataTable
        Me.dtaDetalleGuiaRecoleccionesAjenos.Connection = Connection
        dt = Me.dtaDetalleGuiaRecoleccionesAjenos.GetDataBySucursalClienteSerial(strcliente, strSecuencial)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function numeroMovimiento() As String
        Me.dtaMaestroGuias.Connection = Connection
        Return CStr(CInt(CIntDBNull(Me.dtaMaestroGuias.NumMovimientoActual, 0) + 1))
    End Function

#Region "Generacion de Documentos"
    Public Function NombreDocumento(ByVal TipoDocumento As Integer) As String
        Try
            Me.dtaDocumentos.Connection = Connection
            Me.dtaDocumentos.FillDocumento(dsVenta.Documentos, TipoDocumento)
            If dsVenta.Documentos.Rows.Count > 0 Then
                Return dsVenta.Documentos.Rows(0)("Descripcion").ToString
            Else
                Return ""
            End If
        Catch ex As Exception
            MsgBox("Error en Función NombreDocumento GestorVenta", MsgBoxStyle.Critical)
            Return ""
        End Try
    End Function

    Public Sub UpdateMaestroFacturas()
        Me.dtaMaestroFacturas.Connection = Connection
        'Me.dtaMaestroFacturas.Transaccion = Transaccion
        Me.dtaMaestroFacturas.Update(dsVenta.MaestroFacturas)
        dsVenta.MaestroFacturas.AcceptChanges()
    End Sub

    Public Sub UpdateDetalleFactura()
        Me.dtaDetalleFactura.Connection = Connection
        'Me.dtaDetalleFactura.Transaccion = Transaccion
        Me.dtaDetalleFactura.Update(dsVenta.DetalleFactura)
        dsVenta.DetalleFactura.AcceptChanges()
    End Sub
    Public Function ReimpresionMaestroGuia(ByVal reimpresion As Integer, ByVal Factura As String, ByVal Cliente As String, ByVal numImpresiones As Integer, ByVal TipoDocumento As String) As Boolean
        Try
            Dim rw() As VentaDataSet.MaestroGuiasRow
            Me.dtaMaestroGuias.Connection = Connection
            rw = CType(dsVenta.MaestroGuias.Select("nofactura = '" & Factura.Trim & "' AND CODCLIENTE = '" & Cliente & "'"), VentaDataSet.MaestroGuiasRow())

            If rw.Length > 0 Then
                rw(0).Reimpresion = reimpresion
                rw(0).Reimpresion = numImpresiones
                Me.dtaMaestroGuias.UpdateQuery(numImpresiones, Factura, Cliente, tipodocumento)
                dsVenta.MaestroGuias.AcceptChanges()                
                'UpdateMaestroGuias(rw(0))
                'dtaMaestroGuias.Update(rw)
            Else
                Return False
            End If
            'Me.dtaMaestroGuias.UpdateQuery(reimpresion, Factura)
            'dsVenta.MaestroGuias.AcceptChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Sub UpdateMaestroGuias(ByVal rw As VentaDataSet.MaestroGuiasRow)
        Me.dtaMaestroGuias.Connection = Connection
        Me.dtaMaestroGuias.Update(rw)
        dsVenta.MaestroGuias.AcceptChanges()
    End Sub
    Public Sub UpdateMaestroGuias()
        Me.dtaMaestroGuias.Connection = Connection
        '        Me.dtaMaestroGuias.Transaccion = Transaccion
        Me.dtaMaestroGuias.Update(dsVenta.MaestroGuias)
        dsVenta.MaestroGuias.AcceptChanges()        
    End Sub


    Public Function NoCopias(ByVal Tipodocumento As Integer) As DataTable
        Try

            Me.dtaNocopias.Connection = Connection
            Me.dtaNocopias.FillBy(dsVenta.CopiasDocumentos, Tipodocumento)
            Return dsVenta.CopiasDocumentos
        Catch e As Exception
            Return Nothing
        End Try
    End Function
    Public Sub UpdateDetalleGuiaAsignacionesRecolecciones()
        Me.dtaDetalleGuiaAsignacionesRecolecciones.Connection = Connection
        'Me.dtaDetalleGuiaAsignacionesRecolecciones.Transaccion = Transaccion
        Me.dtaDetalleGuiaAsignacionesRecolecciones.Update(dsVenta.DetalleGuiaAsignacionesRecolecciones)
        dsVenta.DetalleGuiaAsignacionesRecolecciones.AcceptChanges()
    End Sub

    Public Sub UpdateDetalleGuiaFacturasRemisiones()
        Me.dtaDetalleGuiaFacturasRemisiones.Connection = Connection
        '  Me.dtaDetalleGuiaFacturasRemisiones.Transaccion = Transaccion
        Me.dtaDetalleGuiaFacturasRemisiones.Update(dsVenta.DetalleGuiaFacturasRemisiones)
        dsVenta.DetalleGuiaFacturasRemisiones.AcceptChanges()
    End Sub

    Public Sub UpdateDetalleGuiaRecoleccionesAjenos()
        Me.dtaDetalleGuiaRecoleccionesAjenos.Connection = Connection
        'Me.dtaDetalleGuiaRecoleccionesAjenos.Transaccion = Transaccion
        Me.dtaDetalleGuiaRecoleccionesAjenos.Update(dsVenta.DetalleGuiaRecoleccionesAjenos)
        dsVenta.DetalleGuiaRecoleccionesAjenos.AcceptChanges()

        ''DATASCAN 20170915
        'Dim _ConexionDLL As New ConexionDLL()
        'Dim dt As New DataTable()
        'Dim sSql As String

        'Dim Cantidad As Integer
        'Dim NoMovimiento As String
        'Dim NoGuia As String
        'Dim CodProducto As String

        'sSql = "SELECT da.NoMovimiento, da.NoGuia, da.CodProducto, da.Secuencial" _
        '    & " FROM DetalleGuiaAsignacionesRecolecciones d INNER JOIN" _
        '    & " DetalleGuiaRecoleccionesAjenos da ON d.NoMovimiento = da.NoMovimiento" _
        '    & " AND d.NoGuia = da.NoGuia" _
        '    & " AND d.CodProducto = da.CodProducto" _
        '    & " AND d.TipoGuia = 'R'" _
        '    & " AND d.Pertenencia = 2" _
        '    & " ORDER BY da.NoGuia, da.CodProducto"
        'dt = _ConexionDLL.SqlQuery(sSql)
        'If Not dt Is Nothing Then            
        '    For x As Integer = 0 To dt.Rows.Count - 1
        '        Cantidad = CInt(dt.Rows(x)("Cantidad").ToString())
        '        NoMovimiento = dt.Rows(x)("NoMovimiento").ToString()
        '        NoGuia = dt.Rows(x)("NoGuia").ToString()
        '        CodProducto = dt.Rows(x)("CodProducto").ToString()

        '        sSql = "UPDATE DetalleGuiaAsignacionesRecolecciones" _
        '        & " SET Cantidad = " & Cantidad _
        '        & " WHERE NoMovimiento = " & NoMovimiento _
        '        & " AND NoGuia = '" & NoGuia & "'" _
        '        & " AND CodProducto = '" & CodProducto & "'" _
        '        & " AND Pertenencia = 2"
        '        _ConexionDLL.SqlCommand(sSql)
        '    Next
        'End If
        ''FIN DATASCAN 20170915
    End Sub

    Public Sub UpdateFacturasManuales()
        Me.dtaFacturasManuales.Connection = Connection
        'Me.dtaFacturasManuales.Transaccion = Transaccion
        Me.dtaFacturasManuales.Update(dsVenta.FacturasManuales)
        dsVenta.FacturasManuales.AcceptChanges()
    End Sub

#End Region

End Class
