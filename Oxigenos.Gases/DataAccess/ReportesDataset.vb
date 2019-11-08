Partial Class ReportesDataset
    Partial Class DocumentosGeneradosDataTable

        Private Sub DocumentosGeneradosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CREDITOColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class ControlEnvasesDataTable

        Private Sub ControlEnvasesDataTable_ControlEnvasesRowChanging(ByVal sender As System.Object, ByVal e As ControlEnvasesRowChangeEvent) Handles Me.ControlEnvasesRowChanging

        End Sub

        Private Sub ControlEnvasesDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodProductoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
