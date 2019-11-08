Public Class PrecioProductoForm
    Private m_RowPedido As PedidosDataSet.DetallePedidoRow
    Private sCodTipoCliente As String
    Private sTipoPagoCliente As String

    Public Shared Sub run(ByVal RowPedido As PedidosDataSet.DetallePedidoRow, ByVal CodTipoCliente As String, _
    ByVal sTipoPago As String)
        UIHandler.StartWait()
        Dim form As New PrecioProductoForm
        form.m_RowPedido = RowPedido
        form.sCodTipoCliente = CodTipoCliente
        form.sTipoPagoCliente = sTipoPago
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub PrecioProductoForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                mnuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub PrecioProductoForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.dsPedidos = Pedidos.dsPedidos
        Me.bsDetallePedido.DataSource = Pedidos.dsPedidos
        SetCurrentRow(bsDetallePedido, m_RowPedido)
        Me.lblDescripcionProducto.Text = Productos.NombreProducto(Me.lblCodProducto.Text)
        If m_RowPedido.UnidadesVendidasCredito > 0 Then
            Me.lblPrecioCredito.Text = Format(m_RowPedido.PrecioCredito, "###,###,###")
        End If
        If m_RowPedido.UnidadesVendidasContado > 0 Then
            Me.lblPrecioContado.Text = Format(m_RowPedido.PrecioContado, "###,###,###")
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub mnuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub
End Class