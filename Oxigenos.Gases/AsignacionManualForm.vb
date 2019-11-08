Imports OpenNETCF.Win32
Imports Oxigenos.Common

Public Class AsignacionManualForm
    Private NoDocumento As String = ""
    Private sTipoMovimiento As String
    Private sTipoDocumento As Integer
    Private sDescripcionProducto As String = ""
    Private sMensaje As String
    Private RowTalonario As DataRow

    Public Shared Sub Run()
        UIHandler.StartWait()
        Dim form As New AsignacionManualForm
        Dim Row As DataRow = Nothing

        ' Se verifican si existen documentos para realizar la generación
        'Row = Nucleo.GetTalonarioActual(TiposDocumento.AsignacionManual)
        'If Row Is Nothing Then
        ' UIHandler.ShowError("No existen Documentos disponibles para realizar la generación!!")
        'Else
        'form.RowTalonario = Row
        'UIHandler.ShowDialog(form)
        'form.Dispose()
        'End If
        'UIHandler.EndWait()

        If ObtenerNoFactura(Row, TiposDocumento.AsignacionManual) Then
            Nucleo.UpdateTalonario(Row)
            form.RowTalonario = Row
            UIHandler.ShowDialog(form)
            form.Dispose()
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub AsignacionManualForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
        CInt((280 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
    End Sub

    Private Sub AsignacionManualForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub AsignacionManualForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.dsVenta = Venta.dsVenta
        ' Se muestra el No. del documento actual
        Me.lblNoDocumento.Text = CStr(RowTalonario("Prefijo")) & " - " & CStr(RowTalonario("Actual"))
        UIHandler.EndWait()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        GuardarDatos()
    End Sub

    Private Sub GuardarDatos()
        For Each Row As VentaDataSet.DetalleGuiaAsignacionesRecoleccionesRow In dsVenta.DetalleGuiaAsignacionesRecolecciones.Rows
            Row.Prefijo = cstrDBNULL(RowTalonario("Prefijo"))
            Row.NoGuia = cstrDBNULL(RowTalonario("Actual"))
        Next

        dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Asignacion, cstrDBNULL(RowTalonario("Actual")), _
        Nucleo.CodigoSucursal, "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))

        Venta.UpdateFacturasManuales()
        Venta.UpdateDetalleGuiaAsignacionesRecolecciones()

        ' Se incrementa el numero de documento
        'IncrementarNumeroDocumento(RowTalonario)
        Nucleo.UpdateTalonario(RowTalonario)

        Venta = New GestorVenta
        UIHandler.ShowAlert("Generación finalizada correctamente!!")
        UIHandler.EndWait()

        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DecrementarNumeroDocumento(RowTalonario)
        Venta.dsVenta.RejectChanges()

        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If MsgBox("Esta seguro de anular el documento?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            Nucleo.UpdateTalonario(RowTalonario)
            dsVenta.FacturasManuales.AddFacturasManualesRow(LCase(TipoMovimientos.Asignacion), cstrDBNULL(RowTalonario("Actual")), _
            Nucleo.CodigoSucursal, "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
            Venta.UpdateFacturasManuales()
            IncrementarNumeroDocumento(RowTalonario)
            RowTalonario = Nucleo.GetTalonarioActual(TiposDocumento.AsignacionManual)
            If RowTalonario Is Nothing Then
                UIHandler.ShowError("No existen documentos disponibles para la impresión")
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Yes
            Else
                Me.lblNoDocumento.Text = CStr(RowTalonario("Prefijo")) & " - " & CStr(RowTalonario("Actual"))
            End If
        End If
    End Sub
End Class