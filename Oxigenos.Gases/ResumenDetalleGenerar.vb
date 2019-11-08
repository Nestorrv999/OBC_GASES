Imports Oxigenos.Common

Public Class ResumenDetalleGenerar
    Implements IModuloPedido
    Private m_rowPedido As DataRow
    Private m_rowCliente As DataRow

    Public Sub Run(ByVal rowCliente As System.Data.DataRow, ByVal rowPedido As System.Data.DataRow) Implements Common.IModuloPedido.Run
        If Venta.dsVenta.CilindrosLeidos.Rows.Count = 0 And Pacientes.dsPacientes.DeudasPagadas.Rows.Count = 0 And _
        CIntDBNull(Pedidos.dsPedidos.DetallePedido.Compute("Count(NoPedido)", "UnidadesReales > 0"), 0) = 0 Then
            UIHandler.ShowError("No se ha realizado ningún movimiento!!")
            Exit Sub
        End If

        Dim objprograma As New Programa
        Dim sMensaje As String = ""
        If Not objprograma.ValidarInicioRutero(sMensaje) Then
            UIHandler.ShowError(sMensaje)
            Exit Sub
        End If

        ' Se valida si se realizó venta
        UIHandler.StartWait()
        If CIntDBNull(Venta.dsVenta.CilindrosLeidos.Compute("Count(Secuencial)", "Secuencial <> '' And CodTipoProducto <> ''"), 0) > 0 Or _
        CIntDBNull(Pedidos.dsPedidos.DetallePedido.Compute("Count(NoPedido)", "UnidadesReales > 0"), 0) > 0 Then
            Me.m_rowCliente = rowCliente
            Me.m_rowPedido = rowPedido
            UIHandler.ShowDialog(Me)
            Me.Dispose()
        Else
            GeneracionForm.Run(rowCliente, rowPedido)
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub ResumenDetalleGenerar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.S Then
                btnSiguiente_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.P Then
                btnPrecio_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub ResumenDetalleGenerar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.dsPedidos = Pedidos.dsPedidos
        Me.bsDetallePedido.DataSource = Me.dsPedidos.DetallePedido
        Me.bsDetallePedido.Position = 0
        UIHandler.EndWait()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        GeneracionForm.Run(m_rowCliente, m_rowPedido)
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrecio.Click
        Dim FilaSeleccionada As DataRow
        If bsDetallePedido.Count > 0 Then
            FilaSeleccionada = CType(GetCurrentRow(bsDetallePedido), PedidosDataSet.DetallePedidoRow)
            PrecioProductoForm.run(CType(FilaSeleccionada, PedidosDataSet.DetallePedidoRow), cstrDBNULL(m_rowCliente("CodTipoCliente")), cstrDBNULL(m_rowCliente("TipoPago")))
        End If
    End Sub
End Class