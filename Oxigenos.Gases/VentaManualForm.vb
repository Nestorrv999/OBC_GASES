Imports OpenNETCF.Win32

Public Class VentaManualForm

    Public Shared Sub Run()
        UIHandler.StartWait()
        Dim form As New VentaManualForm
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub VentaManualForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
            CInt((280 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
    End Sub

    Private Sub VentaManualForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnSalirVenta_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.C Then
                btnContinuarVenta_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub VentaManualForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        UIHandler.EndWait()
    End Sub

    Private Sub rbVentaProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbVentaProducto.CheckedChanged
        If Not rbVentaProducto.Checked Then
            pnTipoDocumento.Enabled = True
        End If
    End Sub

    Private Sub rbServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbServicio.CheckedChanged
        If Not rbServicio.Checked Then
            pnTipoDocumento.Enabled = False
        End If
    End Sub

    Private Sub btnSalirVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalirVenta.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnContinuarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuarVenta.Click
        If rbVentaProducto.Checked Then
            ' Se llama la captura de cilindros
            LecturaCilindrosVentaForm.Run(Nothing, Nothing)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.Yes
        ElseIf rbServicio.Checked Then
            If rbFactura.Checked Then
                AsignaDocumentoManualForm.Run(TipoMovimientos.Factura, "Factura Servicio Manual", TiposDocumento.FacturaManual, True)
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Yes
            ElseIf rbRemision.Checked Then
                ' Se llama la forma de captura de No. de documento
                AsignaDocumentoManualForm.Run(TipoMovimientos.Remision, "Remision Servicio Manual", TiposDocumento.RemisionManual, True)
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Yes
            Else
                UIHandler.ShowError("Seleccione un tipo de documento!!")
            End If
        End If
    End Sub
End Class