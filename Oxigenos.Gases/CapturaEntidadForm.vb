Imports OpenNETCF.Win32
Public Class CapturaEntidadForm
    Private sCodCliente As String
    Private Row As DataRow

    Public Shared Function Run(ByVal CodCliente As String) As DataRow
        UIHandler.StartWait()
        Dim form As New CapturaEntidadForm
        form.sCodCliente = CodCliente
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
        Return form.Row
    End Function

    Private Sub CapturaEntidadForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'DATASCAN 20171025
        'ANTES:
        'Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
        'CInt((280 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
        'AHORA:
        Win32Window.MoveWindow(Me.Handle, 0, 70, Shape1.Width, Shape1.Height)
        'FIN DATASCAN 20170914
    End Sub

    Private Sub CapturaEntidadForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.S Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.A Then
                btnAceptar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub CapturaEntidadForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dsPacientes = Pacientes.dsPacientes
        Pacientes.GetEntidadesCliente(sCodCliente)
        bsEntidades.DataSource = Me.dsPacientes
        bsEntidades.Position = 0
        UIHandler.EndWait()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        If MsgBox("Esta seguro de grabar el pedido sin entidad?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            Row = Nothing
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim nIndex As Integer
        nIndex = grdEntidades.CurrentRowIndex()
        If nIndex >= 0 Then
            Row = GetCurrentRow(bsEntidades)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.Yes
        Else
            UIHandler.ShowError("Seleccione la entidad!!")
            Exit Sub
        End If
    End Sub
End Class