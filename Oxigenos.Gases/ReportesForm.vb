Public Class ReportesForm
    Implements IModuloPrograma

    Private m_Reportes As GestorReportes

    Private Sub menuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Public Sub Run() Implements Common.IModuloPrograma.Run
        If Nucleo.KiloMetrajeFinal = " " Or Nucleo.KiloMetrajeFinal = "0" Then
            UIHandler.ShowError("La ruta no se ha finalizado!!")
        Else
            UIHandler.StartWait()
            UIHandler.ShowDialog(Me)
            Me.Dispose()
            UIHandler.EndWait()
        End If
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
            If Nucleo.Impresora = PrinterModels.ZebraPortatil Then
                Dim dt As ReportesDataset.DocumentosGeneradosDataTable = CType(m_Reportes.GetDocumentosGenerados(), ReportesDataset.DocumentosGeneradosDataTable)
                Dim rw As ReportesDataset.DocumentosGeneradosRow
                Dim doc As New PrinterDocument
                Dim sSigla, sReimpresion As String
                doc.Tipo = TipoReporte.DocumentosGenerados

                For Each rw In dt
                    If rw.IsSiglaNull Then
                        sSigla = ""
                    Else
                        sSigla = rw.Sigla
                    End If
                    If rw.IsReimpresionNull Then
                        sReimpresion = ""
                    Else
                        sReimpresion = rw.Reimpresion.ToString
                    End If
                    doc.SetDetalleDocumentosGenerados(rw.Tipo, rw.prefijo, rw.DOCUMENTO, rw.CLIENTE, CStr(rw.Nombre), CStr(rw.CONTADO), CStr(rw.CREDITO), rw.ESTADO, sReimpresion)
                Next
                doc.SetDetalleDocumentosGenerados("-----", "-----", "---------", "-------", "-------------", "---------", "---------", "---", "---")
                doc.SetDetalleDocumentosGenerados("", "", "", "", "TOTAL", CDbl(dt.Compute("SUM(Contado)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(Credito)", "")).ToString("#,##0.00"), "", "")
                Nucleo.Imprimir(doc)
            Else
                Dim dt As DataTable = m_Reportes.GetDocumentosGenerados()
                Dim report As New PrinterReport("RESUMEN DOCUMENTOS GENERADOS", dt)
                report.Columnas("CREDITO").Total = CDbl(dt.Compute("SUM(Credito)", "")).ToString("#,##0.00")
                report.Columnas("CONTADO").Total = CDbl(dt.Compute("SUM(Contado)", "")).ToString("#,##0.00")
                Nucleo.Imprimir(report)
            End If
        Catch ex As Exception
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub btnControlEnvases_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlEnvases.Click
        Try
            If Nucleo.Impresora = PrinterModels.ZebraPortatil Then
                Dim dt As ReportesDataset.ControlEnvasesDataTable = CType(m_Reportes.GetControlEnvases(), ReportesDataset.ControlEnvasesDataTable)
                Dim rw As ReportesDataset.ControlEnvasesRow
                Dim doc As New PrinterDocument
                doc.Tipo = TipoReporte.ControlEnvases

                For Each rw In dt
                    doc.SetDetalleControlEnvases(rw.CodProducto, rw.DESCRIPCION, rw.Capacidad, rw.PERTENENCIA, CStr(rw.SalidaLlenos), CStr(rw.SalidaVacios), CStr(rw.Ventas), CStr(rw.Asignaciones), CStr(rw.Recolecciones), CStr(rw.VaciosEntregados), CStr(rw.RetornoLlenos), CStr(rw.RetornoVacios))
                Next
                doc.SetDetalleControlEnvases("", "", "", "", "--------", "--------", "--------", "--------", "--------", "--------", "--------", "--------")
                doc.SetDetalleControlEnvases("", "", "", "", CDbl(dt.Compute("SUM(SalidaLlenos)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(SalidaVacios)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(Ventas)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(Asignaciones)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(Recolecciones)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(VaciosEntregados)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(RetornoLlenos)", "")).ToString("#,##0.00"), CDbl(dt.Compute("SUM(RetornoVacios)", "")).ToString("#,##0.00"))

                Nucleo.Imprimir(doc)
            Else

                Dim dt As DataTable = m_Reportes.GetControlEnvases()
                Dim report As New PrinterReport("RESUMEN CONTROL ENVASES", dt)
                report.Columnas("SalidaLlenos").Total = CDbl(dt.Compute("SUM(SalidaLlenos)", "")).ToString("#,##0.00")
                report.Columnas("SalidaVacios").Total = CDbl(dt.Compute("SUM(SalidaVacios)", "")).ToString("#,##0.00")
                report.Columnas("Ventas").Total = CDbl(dt.Compute("SUM(Ventas)", "")).ToString("#,##0.00")
                report.Columnas("Asignaciones").Total = CDbl(dt.Compute("SUM(Asignaciones)", "")).ToString("#,##0.00")
                report.Columnas("Recolecciones").Total = CDbl(dt.Compute("SUM(Recolecciones)", "")).ToString("#,##0.00")
                report.Columnas("VaciosEntregados").Total = CDbl(dt.Compute("SUM(VaciosEntregados)", "")).ToString("#,##0.00")
                report.Columnas("RetornoLlenos").Total = CDbl(dt.Compute("SUM(RetornoLlenos)", "")).ToString("#,##0.00")
                report.Columnas("RetornoVacios").Total = CDbl(dt.Compute("SUM(RetornoVacios)", "")).ToString("#,##0.00")
                Nucleo.Imprimir(report)
            End If

        Catch ex As Exception
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub
End Class