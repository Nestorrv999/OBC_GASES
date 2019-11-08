
Public Class FrmEncuestaNiso



    Public Sub New(ByVal codigoCliente As String, ByVal origen As Integer)
        Me.InitializeComponent()

        ParametrosIniciales.codigoCliente = codigoCliente
        ParametrosIniciales.origen = origen

     


    End Sub

    Private Sub chkSatisfecho1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSatisfecho1.CheckStateChanged

        Me.chkInsatisfecho1.Checked = Not chkSatisfecho1.Checked




    End Sub

    Private Sub chkInsatisfecho1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInsatisfecho1.CheckStateChanged
        chkSatisfecho1.Checked = Not Me.chkInsatisfecho1.Checked
    End Sub

    Private Sub chkSatisfecho2_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSatisfecho2.CheckStateChanged
        Me.chkInstatisfecho2.Checked = Not chkSatisfecho2.Checked
    End Sub

    Private Sub chkInstatisfecho2_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInstatisfecho2.CheckStateChanged
        chkSatisfecho2.Checked = Not Me.chkInstatisfecho2.Checked
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim frmDatos As New FrmEncuestaNiso2()

        frmDatos.Satisfecho1 = Me.chkSatisfecho2.Checked
        frmDatos.Satisfecho2 = Me.chkSatisfecho2.Checked

        frmDatos.insatisfecho1 = Me.chkInstatisfecho2.Checked
        frmDatos.insatisfecho2 = Me.chkInstatisfecho2.Checked

        frmDatos.ShowDialog()

        Me.Dispose()

    End Sub

    Private Sub FrmEncuestaNiso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ws As New wsNiso.WebService1()
        Dim ds As New Data.DataSet
        ds = ws.GetCliente(ParametrosIniciales.codigoCliente)

        If ds.Tables(0).Rows.Count < 1 Then
            Me.Dispose()
        End If

    End Sub
End Class