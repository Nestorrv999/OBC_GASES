Imports OpenNETCF.Win32

Public Class DireccionesClienteForm
    Private m_rowCliente As NucleoDataSet.ClientesRow

    Public Shared Sub Run(ByVal rowCliente As NucleoDataSet.ClientesRow)
        UIHandler.StartWait()
        Dim frm As New DireccionesClienteForm
        frm.m_rowCliente = rowCliente
        UIHandler.ShowDialog(frm)
        UIHandler.EndWait()
    End Sub

    Private Sub DireccionesClienteForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
           CInt((290 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
    End Sub

    Private Sub DireccionesClienteForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then ' Salir sin guardar
                btnAceptar_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.Left Then
                btnAnterior_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.Right Then
                btnSiguiente_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub DireccionesClienteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        dsNucleo = GestorNucleo.dsNucleo
        bsClientes.DataSource = dsNucleo
        bsDirecciones.DataSource = dsNucleo
        SetCurrentRow(bsClientes, m_rowCliente)
        bsDirecciones.SuspendBinding()
        GestorNucleo.LoadDireccionesCliente(m_rowCliente)
        If bsDirecciones.Count <= 1 Then
            lblPosicion.Visible = False
            btnSiguiente.Visible = False
            btnAnterior.Visible = False
        End If
        bsDirecciones.ResumeBinding()
        UIHandler.EndWait()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        bsDirecciones.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        bsDirecciones.MoveNext()
    End Sub

    Private Sub bsDirecciones_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsDirecciones.CurrentChanged
        If bsDirecciones.Count > 1 Then
            lblPosicion.Text = (bsDirecciones.Position + 1).ToString() & " de " & bsDirecciones.Count
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class