Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim frm As New EncuestaNiso.FrmEncuestaNiso("0046877", 4)
        frm.ShowDialog()



    End Sub
End Class
