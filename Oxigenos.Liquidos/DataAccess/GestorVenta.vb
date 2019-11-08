Public Class GestorVenta

    Public Sub LoadTanquesCliente(ByVal m_rowCliente As Data.DataRow)
        Me.dtaTanquesCliente.Connection = Me.Connection
        Me.dtaTanquesCliente.Fill(Me.dsVenta.TanquesCliente, CStr(m_rowCliente("Codigo")), _
            Productos.ProductoActual.Codigo)
    End Sub

    Public Sub LoadAforos(ByVal rowTanque As VentaDataSet.TanquesClienteRow)
        Me.dtaAforos.Connection = Me.Connection
        Me.dtaAforos.Fill(Me.dsVenta.Aforos, rowTanque.IdFabricante, _
            rowTanque.IdTipo, rowTanque.IdFamilia, rowTanque.IdGrupoRecipiente)
    End Sub

    Public Sub SaveVenta()
        'Me.OpenConnection(True)
        Try
            Me.dtaDetallePedido.Connection = Me.Connection
            Me.dtaDetallePedido.Transaccion = Me.Transaccion
            Me.dtaDetalleFactura.Connection = Me.Connection
            Me.dtaDetalleFactura.Transaccion = Me.Transaccion
            Me.dtaMaestroFacturas.Connection = Me.Connection
            Me.dtaDetallePedido.Update(Me.dsVenta.DetallePedido)
            Me.dtaMaestroFacturas.Update(Me.dsVenta.MaestroFacturas)
            Me.dtaDetalleFactura.Update(Me.dsVenta.DetalleFactura)
            Me.dsVenta.DetallePedido.AcceptChanges()
            Me.dsVenta.MaestroFacturas.AcceptChanges()
            Me.dsVenta.DetalleFactura.AcceptChanges()
            Me.realizarCommit()
        Catch ex As Exception
            Throw New Exception(ex.ToString)
            'Me.realizarRollback()
        Finally
            'Me.CloseConnection()
        End Try
    End Sub

End Class
