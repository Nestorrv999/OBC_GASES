Public Class ReportesForm
    Implements IModuloPrograma

    Private m_Reportes As GestorReportes

    Private Sub menuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Public Sub Run() Implements Common.IModuloPrograma.Run
        ' Se hacen las validaciones para dar inicio al cargue
        'If Nucleo.KilometrajeInicial <> " " And Nucleo.KilometrajeInicial <> "0" Then
        '    UIHandler.ShowError("La ruta ya se inicio!!")
        '    ' se muestra el resumen del camión
        '    ResumenCargaForm.Run()
        'Else
        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
        'End If
    End Sub

    Private Sub ReportesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                menuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub ReportesForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        m_Reportes = New GestorReportes
        btnPedidosAnulados.Focus()
        UIHandler.EndWait()
    End Sub

    Private Sub btnPedidosAnulados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPedidosAnulados.Click
        Try
            Dim dt As DataTable = m_Reportes.GetPedidosAnulados()
            Dim report As New PrinterReport("PEDIDOS ANULADOS", dt)
            report.Columnas("Nombre").Total = "Total Registros: " & dt.Rows.Count.ToString()
            Nucleo.Imprimir(report)
        Catch
        End Try
    End Sub

    Private Sub btnDocumentosGenerados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocumentosGenerados.Click
        Try
            Dim dt As DataTable = m_Reportes.GetDocumentosGenerados
            Dim report As New PrinterReport("RESUMEN DOCUMENTOS GENERADOS", dt)
            report.Columnas("Valor").Total = CDbl(dt.Compute("SUM(Valor)", "")).ToString("#,##0.00")
            Nucleo.Imprimir(report)
        Catch
        End Try
    End Sub
End Class