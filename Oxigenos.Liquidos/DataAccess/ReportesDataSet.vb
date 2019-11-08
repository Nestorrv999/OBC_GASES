Partial Class ReportesDataSet
    Partial Class PedidosAnuladosDataTable

        Private Sub PedidosAnuladosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodClienteColumn.ColumnName) Then
                'Agregar código de usuario aquí 
            End If

        End Sub

    End Class

End Class
