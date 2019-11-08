Public Class InformacionClienteForm

    Private m_rowCliente As NucleoDataSet.ClientesRow

    Public Shared Sub Run(ByVal rowCliente As NucleoDataSet.ClientesRow)
        UIHandler.StartWait()
        Dim frm As New InformacionClienteForm
        GestorNucleo.LoadTiposPago()
        GestorNucleo.LoadTiposCliente()
        frm.m_rowCliente = rowCliente
        UIHandler.ShowDialog(frm)
        frm.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub InformacionClienteForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then ' Salir sin guardar
                menuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub InformacionClienteForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        bsClientes.DataSource = GestorNucleo.dsNucleo
        SetCurrentRow(bsClientes, m_rowCliente)
        UIHandler.EndWait()
    End Sub

    Private Sub menuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class