Partial Class NucleoDataSet
    Partial Class ParametrosDataTable

        Private Sub ParametrosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FechaDocumentosColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class ClientesDataTable

        Private Sub ClientesDataTable_ClientesRowChanging(ByVal sender As System.Object, ByVal e As ClientesRowChangeEvent) Handles Me.ClientesRowChanging

        End Sub

    End Class

    Partial Class TiposPagoDataTable

        Private Sub TiposPagoDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodTipoPagoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub TiposPagoDataTable_TiposPagoRowChanging(ByVal sender As System.Object, ByVal e As TiposPagoRowChangeEvent) Handles Me.TiposPagoRowChanging

        End Sub

    End Class

    Partial Class TalonariosDataTable

        Private Sub TalonariosDataTable_TalonariosRowChanging(ByVal sender As System.Object, ByVal e As TalonariosRowChangeEvent) Handles Me.TalonariosRowChanging

        End Sub

        Private Sub TalonariosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CodTipoDocumentoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
