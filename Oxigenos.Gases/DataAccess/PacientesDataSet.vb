Partial Class PacientesDataSet
    Partial Class CopagosPendientesDataTable

        Private Sub CopagosPendientesDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.FlagCopagoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class DepositosEntidadDataTable

        Private Sub DepositosEntidadDataTable_DepositosEntidadRowChanging(ByVal sender As System.Object, ByVal e As DepositosEntidadRowChangeEvent) Handles Me.DepositosEntidadRowChanging

        End Sub

    End Class

End Class
