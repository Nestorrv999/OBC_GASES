Partial Class PedidosDataSet
    Partial Class DetallePedidoDataTable

        Private Sub DetallePedidoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MontoTotalCreditoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub DetallePedidoDataTable_DetallePedidoRowChanging(ByVal sender As System.Object, ByVal e As DetallePedidoRowChangeEvent) Handles Me.DetallePedidoRowChanging

        End Sub

    End Class

End Class
