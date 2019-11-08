Public Class GestorProductos

    Public ReadOnly Property ProductoActual() As ProductosDataSet.ProductosRow
        Get
            Return Me.dsProductos.Productos(0)
        End Get
    End Property

    Public Sub LoadProductos()
        dtaProductos.Connection = Me.Connection
        dtaProductos.Fill(Me.dsProductos.Productos)
    End Sub

    Public Sub LoadProducto(ByVal CodProducto As String)
        dtaProductos.Connection = Me.Connection
        dtaProductos.FillBy(Me.dsProductos.Productos, CodProducto)
    End Sub

    Public Sub LoadExistencias(ByVal IdHojaRuta As Integer, ByVal CodProducto As String)
        dtaKardex.Connection = Me.Connection
        dtaKardex.FillBy(Me.dsProductos.KardexCamion, IdHojaRuta, CodProducto)
    End Sub

    Public Function GetPrecio(ByVal CodProducto As String, ByVal CodCliente As String, ByVal CodSucursal As String) As PrecioProducto
        Dim Precio As New PrecioProducto
        dtaPrecios.Connection = Me.Connection
        dtaPrecios.FillBy(Me.dsProductos.Precios, CodSucursal, CodCliente, CodProducto)
        If Me.dsProductos.Precios.Count > 0 Then
            Precio.AplicaIVA = (Me.dsProductos.Precios(0).AplicaIva = "S")
            Precio.Precio = Me.dsProductos.Precios(0).PrecioNeto
            Precio.PorcentajeDescuento = Me.dsProductos.Precios(0).PorcentajeDescuento
            Precio.PorcentajeIVA = Me.dsProductos.Precios(0).PorcentajeImpuesto
            Precio.MontoDescuento = CDec(Me.dsProductos.Productos(0).Precio - Precio.Precio)
        Else
            Precio.AplicaIVA = True
            Precio.PorcentajeIVA = CDec(Me.dsProductos.Productos(0).Iva)
            Precio.PorcentajeDescuento = 0
            Precio.Precio = CDec(Me.dsProductos.Productos(0).Precio)
            Precio.MontoDescuento = 0
        End If
        Return Precio
    End Function

    Public Sub InitKardex(ByVal IdHojaRuta As Integer, ByVal CodProducto As String, ByVal Existencias As Decimal)
        dsProductos.KardexCamion.Rows.Clear()
        dsProductos.KardexCamion.AddKardexCamionRow(CodProducto, Existencias, IdHojaRuta)
        dtaKardex.Connection = Me.Connection
        dtaKardex.Update(dsProductos.KardexCamion)
        dsProductos.KardexCamion.AcceptChanges()
    End Sub

    Public Function UpdateKardex() As Boolean
        dtaKardex.Connection = Me.Connection
        dtaKardex.Transaccion = Me.Transaccion
        dtaKardex.Update(dsProductos.KardexCamion(0))
        dsProductos.KardexCamion(0).AcceptChanges()
    End Function


End Class
