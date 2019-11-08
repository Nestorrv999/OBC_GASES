Public Class VentaPorNivelesForm

    Private m_rowPedido As Data.DataRow
    Private m_rowCliente As Data.DataRow
    Private m_rowTanque As VentaDataSet.TanquesClienteRow
    Private m_rowDetalle As VentaDataSet.DetallePedidoRow

    Public Shared Sub Run(ByVal rowCliente As Data.DataRow, ByVal rowPedido As Data.DataRow, _
    ByVal rowTanque As VentaDataSet.TanquesClienteRow)
        UIHandler.StartWait()
        Dim frm As New VentaPorNivelesForm
        frm.m_rowCliente = rowCliente
        frm.m_rowPedido = rowPedido
        frm.m_rowTanque = rowTanque
        UIHandler.ShowDialog(frm)
        frm.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub VentaPorNivelesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                btnCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub VentaPorNivelesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadData()
        txtNivelInicial.Focus()
        UIHandler.EndWait()
    End Sub

    Private Sub LoadData()
        dsVenta = Venta.dsVenta
        bsDetallePedido.DataSource = dsVenta
        Venta.LoadAforos(Me.m_rowTanque)
        bsDetallePedido.AddNew()
        m_rowDetalle = CType(GetCurrentRow(bsDetallePedido), VentaDataSet.DetallePedidoRow)
        m_rowDetalle.NoPedido = CStr(m_rowPedido("NoPedido"))
        m_rowDetalle.CodTanque = m_rowTanque.NoTanque
        m_rowDetalle.CodProducto = Productos.ProductoActual.Codigo
        m_rowDetalle.MetodoEntrega = MetodosEntrega.PorNiveles
        m_rowDetalle.PesoInicial = 0
        m_rowDetalle.PesoFinal = 0
        bsDetallePedido.EndEdit()
        bsDetallePedido.ResetCurrentItem()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, menuGuardar.Click
        ' Se valida la información y se calculan el precio del producto
        Try
            UIHandler.StartWait()
            bsDetallePedido.EndEdit()
            Dim CantIni, CantFin As Integer
            Dim rowAforo As VentaDataSet.AforosRow
            Dim Precio As PrecioProducto
            If m_rowDetalle.NivelFinal <= m_rowDetalle.NivelInicial Then
                Throw New Exception("Nivel final debe ser mayor al nivel inicial")
            End If
            rowAforo = dsVenta.Aforos.FindByNivel(m_rowDetalle.NivelInicial)
            If rowAforo Is Nothing Then
                Throw New Exception("No esta definido el nivel inicial en la tabla de aforo")
            End If
            CantIni = rowAforo.Cantidad
            rowAforo = dsVenta.Aforos.FindByNivel(m_rowDetalle.NivelFinal)
            If rowAforo Is Nothing Then
                Throw New Exception("No esta definido el nivel inicial en la tabla de aforo")
            End If
            CantFin = rowAforo.Cantidad
            If CInt(m_rowDetalle.Kilometraje) < CInt(Nucleo.KiloMetrajeFinal) Then
                Throw New Exception("Kilometraje especificado es menor al último kilometraje registrado")
            End If
            m_rowDetalle.Cantidad = CantFin - CantIni
            Precio = Productos.GetPrecio(Productos.ProductoActual.Codigo, _
                CStr(m_rowCliente("Codigo")), CStr(m_rowCliente("CodSucursal")))
            m_rowDetalle.PrecioUnitario = Precio.Precio
            m_rowDetalle.PrecioTotal = Precio.Precio * m_rowDetalle.Cantidad
            m_rowDetalle.PocentajeDescuento = Precio.PorcentajeDescuento
            m_rowDetalle.PorcentajeImpuesto = Precio.PorcentajeIVA
            m_rowDetalle.MontoDescuento = CDec((Precio.MontoDescuento * m_rowDetalle.Cantidad) / 100)
            m_rowDetalle.MontoImpuesto = CDec((Precio.PorcentajeIVA * m_rowDetalle.PrecioTotal) / 100)
            Productos.dsProductos.KardexCamion(0).Existencias -= m_rowDetalle.Cantidad
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            UIHandler.EndWait()
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, menuCancelar.Click
        bsDetallePedido.CancelEdit()
        bsDetallePedido.RemoveCurrent()
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub menuPrecintos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPrecintos.Click
        PrecintosForm.Run(CStr(m_rowPedido("NoPedido")), m_rowTanque.NoTanque)
    End Sub
End Class