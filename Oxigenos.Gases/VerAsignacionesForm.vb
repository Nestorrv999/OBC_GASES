Imports system.Windows.Forms

Public Class VerAsignacionesForm
    Private sTipoAsignacion As String = ""
    Private Result As Boolean = False
    Private m_iCantidad As Integer = 0


    Public Shared Function Run(ByVal TipoAsignacion As String, ByVal Cantidad As Integer) As Boolean
        UIHandler.StartWait()
        Dim form As New VerAsignacionesForm
        Dim bResult As Boolean
        form.sTipoAsignacion = TipoAsignacion
        form.m_iCantidad = Cantidad
        UIHandler.ShowDialog(form)
        bResult = form.Result
        form.Dispose()
        UIHandler.EndWait()
        Return bResult
    End Function

    Private Sub VerAsignacionesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.A Then
                btnAceptar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub VerAsignacionesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dsPacientes = Pacientes.dsPacientes
        lstAsignaciones.Items.Clear()
        Me.LlenarListaAsignaciones()
        lblDescripcion.Text = Pacientes.GetDescripcionTipoAsignacion(sTipoAsignacion)
        lblTipoAsignacion.Text = sTipoAsignacion
        UIHandler.EndWait()
    End Sub


    Private Sub LlenarListaAsignaciones()
        Dim nwItem As ListViewItem
        Dim UltimoAsignacion As String = ""
        Dim CodEntidad As String = ""
        Dim i, j, Count As Integer

        Count = 0
        For Each Row As PacientesDataSet.AsignacionesRow In Me.dsPacientes.Asignaciones

            If Pacientes.GetProductoTipoAsignacion(sTipoAsignacion) = Pacientes.GetProductoTipoAsignacion(Row.CodTipoAsignacion) Then
                If Row.IsNull("Modificado") Then
                    nwItem = New ListViewItem(Row.NoAsignacion.ToString)
                    nwItem.SubItems.Add(Row.CodEntidad.ToString)
                    nwItem.Checked = False
                    UltimoAsignacion = Row.NoAsignacion.ToString

                    CodEntidad = Row.CodEntidad.ToString

                    Me.lstAsignaciones.Items.Add(nwItem)
                    Count += 1
                End If
            End If

            UltimoAsignacion = Row.NoAsignacion.ToString
        Next

        If Count = 0 And UltimoAsignacion.Equals("") Then
            UltimoAsignacion = Nucleo.NumeroMovimiento
        End If

        If Count < m_iCantidad Then
            j = m_iCantidad - Count
            For i = 1 To j
                UltimoAsignacion = CStr(CLng(UltimoAsignacion) + 1)
                If Me.dsPacientes.Asignaciones.Rows.Count = 0 Then
                    UltimoAsignacion = UltimoAsignacion.PadLeft(6).Replace(" ", "0")
                End If
                nwItem = New ListViewItem(UltimoAsignacion)
                nwItem.SubItems.Add(CodEntidad)
                nwItem.Checked = False
                Me.lstAsignaciones.Items.Add(nwItem)
            Next
        End If
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim iSeleccionado As Integer = 0
        Dim RowAsignacion As PacientesDataSet.AsignacionesRow

        For Each nItem As ListViewItem In Me.lstAsignaciones.Items
            If nItem.Checked Then
                iSeleccionado = iSeleccionado + 1
            End If
        Next

        If iSeleccionado <> Me.m_iCantidad Then
            UIHandler.ShowError("No ha seleccionado las asignaciones necesarias!!")
            Exit Sub
        Else
            For Each nItem As ListViewItem In Me.lstAsignaciones.Items
                If nItem.Checked Then
                    RowAsignacion = Me.dsPacientes.Asignaciones.FindByNoAsignacion(nItem.Text)
                    If RowAsignacion IsNot Nothing Then
                        RowAsignacion.Modificado = "1"
                        RowAsignacion.NoRecoleccion = "Actual"
                        RowAsignacion.FechaCorte = Today()
                    End If
                End If
            Next
        End If

        Result = True
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub
End Class