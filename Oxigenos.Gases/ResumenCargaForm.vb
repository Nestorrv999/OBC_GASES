Public Class ResumenCargaForm
    Public Shared Sub Run()
        ' Se hacen validaciones 
        If Productos.dsProductos.KardexCamion.Rows.Count = 0 Then
            Productos.LoadKardexCamion()
            If Productos.dsProductos.KardexCamion.Rows.Count = 0 Then
                UIHandler.ShowAlert("No hay datos Capturados!!")
                Exit Sub
            End If
        End If

        UIHandler.StartWait()
        Dim form As New ResumenCargaForm
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub ResumenCargaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                mnuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub frmResumenCarga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.dsProductos = Productos.dsProductos
        bsKardexCamion.DataSource = dsProductos.KardexCamion
        bsKardexCamion.Position = 0
        ' Se calculan las sumatorias
        lblReventaPropios.Text = cstrDBNULL(dsProductos.KardexCamion.Compute("Sum(SaldoPraxair)", "CodTipoProducto = " & TipoProducto.Producto), "0")
        lblReventaAjenoLleno.Text = cstrDBNULL(dsProductos.KardexCamion.Compute("Sum(SaldoCliente)", "CodTipoProducto = " & TipoProducto.Producto), "0")
        lblActivosPropio.Text = cstrDBNULL(dsProductos.KardexCamion.Compute("Sum(SaldoPraxair)", "CodTipoProducto = " & TipoProducto.Activo), "0")
        lblActivoAjenoLleno.Text = cstrDBNULL(dsProductos.Carga.Compute("count(CodProducto)", "CodTipoProducto = " & TipoProducto.Activo & "And Secuencial <> ' 'And Pertenencia = " & Pertenencia.Cliente), "0")
        lblActivoAjenoVacio.Text = cstrDBNULL(dsProductos.Carga.Compute("count(CodProducto)", "CodTipoProducto = " & TipoProducto.Activo & "And Secuencial = ' ' And Pertenencia = " & Pertenencia.Cliente), "0")
        UIHandler.EndWait()
    End Sub

    Private Sub mnuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub grdResumen_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdResumen.CurrentCellChanged
        Dim nIndex As Integer
        Dim FilaSeleccionada As DataRow
        nIndex = grdResumen.CurrentRowIndex
        If nIndex >= 0 Then
            FilaSeleccionada = GetCurrentRow(bsKardexCamion)
            If FilaSeleccionada IsNot Nothing Then
                lblProducto.Text = Productos.NombreProducto(cstrDBNULL(FilaSeleccionada("CodProducto")))
            End If
        End If
    End Sub
End Class