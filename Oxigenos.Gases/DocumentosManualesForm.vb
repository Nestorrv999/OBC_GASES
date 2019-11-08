Public Class DocumentosManualesForm
    Implements IModuloRutero

    Public Sub Run() Implements Common.IModuloRutero.Run
        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        ' Se valida que se seleccione una opción
        If rbContratos.Checked Or rbDepositos.Checked Or rbRecolecciones.Checked Or _
        rbVenta.Checked Then
            If rbVenta.Checked Then
                VentaManualForm.Run()
            ElseIf rbRecolecciones.Checked Then
                ' Se llama la forma de recolección manual
                RecoleccionesManualesForm.Run()
            ElseIf rbDepositos.Checked Then
                AsignaDocumentoManualForm.Run(TipoMovimientos.Deposito, "Deposito Manual", TiposDocumento.DepositoManual)
            ElseIf rbContratos.Checked Then
                AsignaDocumentoManualForm.Run(TipoMovimientos.Contrato, "Contrato Manual", 1)
            End If
        Else
            UIHandler.ShowError("Seleccione una opción!!")
        End If
    End Sub

    Private Sub DocumentosManualesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.C Then
                btnContinuar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub DocumentosManualesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UiHandler1.Parent = Me
        Venta = New GestorVenta
        UIHandler.EndWait()
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        If Venta.dsVenta.CilindrosLeidos.Rows.Count > 0 Then
            If MsgBox("No se generaron documentos, Los datos capturados se perderan!!" & vbCrLf & "Confirma Salir?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Yes
            End If
        Else
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.Yes
        End If
    End Sub
End Class