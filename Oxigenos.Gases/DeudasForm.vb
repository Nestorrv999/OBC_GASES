Public Class DeudasForm
    Implements IModuloPedido


    Private PorcentajeIva As Double
    Private Precio As Double
    Private PagaMas As String
    Private Saldo As Double
    Private FilaSeleccionada As DataRow
    Private SubTotal As Double
    Private TotalIva As Double
    Private Total As Double

    Private Sub DeudasForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.OK
            ElseIf e.KeyCode = System.Windows.Forms.Keys.A Then
                btnGuardar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub DeudasForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        dsPacientes = Pacientes.dsPacientes
        bsDeudas.DataSource = dsPacientes
        bsDeudas.Position = 0
        grdDeudas.CurrentRowIndex = 0

        lblDescripcion.Text = Productos.NombreProducto(cstrDBNULL(Pacientes.dsPacientes.AlquileresPendientes.Rows(0)("CodProducto")))
        Precio = CDbl(Pacientes.dsPacientes.AlquileresPendientes.Rows(0)("Precio"))
        PorcentajeIva = CDbl(Pacientes.dsPacientes.AlquileresPendientes.Rows(0)("Iva"))
        PagaMas = CStr(Pacientes.dsPacientes.AlquileresPendientes.Rows(0)("PagaMas"))
        Saldo = CDbl(Pacientes.dsPacientes.AlquileresPendientes.Rows(0)("Dias"))
        UIHandler.EndWait()
    End Sub

    Private Sub grdDeudas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdDeudas.CurrentCellChanged
        Dim nIndex As Integer
        nIndex = grdDeudas.CurrentRowIndex
        If nIndex >= 0 Then
            FilaSeleccionada = GetCurrentRow(bsDeudas)
            If FilaSeleccionada IsNot Nothing Then
                lblDescripcion.Text = Productos.NombreProducto(cstrDBNULL(FilaSeleccionada("CodProducto")))
                Precio = CDbl(FilaSeleccionada("Precio"))
                PorcentajeIva = CDbl(FilaSeleccionada("Iva"))
                PagaMas = CStr(FilaSeleccionada("PagaMas"))
                Saldo = CDbl(FilaSeleccionada("Dias"))
            End If
        End If
    End Sub

    Public Sub Run(ByVal rowCliente As System.Data.DataRow, ByVal rowPedido As System.Data.DataRow) Implements IModuloPedido.Run
        Pacientes.GetDeudasPendientes(cstrDBNULL(rowCliente("Codigo")))
        If Pacientes.dsPacientes.AlquileresPendientes.Rows.Count = 0 Then
            UIHandler.ShowError("No hay deudas pendientes!!")
            Exit Sub
        End If

        UIHandler.StartWait()
        Dim form As New DeudasForm
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub txtPagar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagar.KeyPress
        If e.KeyChar = vbCr And txtPagar.Text <> "" Then
            If CDec(Me.txtPagar.Text) > Saldo Then
                If PagaMas = "1" Then
                    SubTotal = CDbl(txtPagar.Text) * Precio
                    TotalIva = SubTotal * (PorcentajeIva / 100)
                    Total = SubTotal + TotalIva
                    Me.lblAlquiler.Text = CStr(SubTotal) & "+" & CStr(TotalIva) & "=" & CStr(Total)
                    Me.lblTotal.Text = CStr(Total)
                Else
                    UIHandler.ShowError("Error valor mayor al saldo!!")
                    Me.txtPagar.Text = "0"
                    Me.txtPagar.Focus()
                End If
            Else
                SubTotal = CDbl(txtPagar.Text) * Precio
                TotalIva = SubTotal * (PorcentajeIva / 100)
                Total = SubTotal + TotalIva
                Me.lblAlquiler.Text = CStr(SubTotal) & "+" & CStr(TotalIva) & "=" & CStr(Total)
                Me.lblTotal.Text = CStr(Total)
            End If
            bsDeudas.EndEdit()
            bsDeudas.ResetCurrentItem()
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If Me.txtPagar.Text <> "" Then
            Dim Row As PacientesDataSet.DeudasPagadasRow
            Row = Pacientes.dsPacientes.DeudasPagadas.FindByNoAsignacionNoAlquiler(cstrDBNULL(FilaSeleccionada("NoAsignacion")), _
            cstrDBNULL(FilaSeleccionada("NoAlquiler")))

            If Row Is Nothing Then
                Pacientes.dsPacientes.DeudasPagadas.AddDeudasPagadasRow(cstrDBNULL(FilaSeleccionada("NoAsignacion")), _
                CShort(FilaSeleccionada("Dias")), CDate(FilaSeleccionada("FechaInicio")), CDate(FilaSeleccionada("FechaFin")), _
                CShort(txtPagar.Text), cstrDBNULL(FilaSeleccionada("NoAlquiler")), cstrDBNULL(FilaSeleccionada("CodProducto")), _
                Servicio.Capacidad, Pertenencia.Praxair, "cu", CDec(Precio), CDec(SubTotal), CDec(TotalIva), lblDescripcion.Text)
            Else
                Row.DiasCancelados = CShort(txtPagar.Text)
                Row.SubTotal = CDec(SubTotal)
                Row.MontoIva = CDec(TotalIva)
            End If
            'Pacientes.UpdateDeudasPagadas()
            UIHandler.ShowAlert("Movimiento Guardado!!")
        End If
    End Sub

End Class