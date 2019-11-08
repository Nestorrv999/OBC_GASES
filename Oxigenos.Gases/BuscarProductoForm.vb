Imports System.Data
'Imports OpenNETCF.Win32
Imports Oxigenos.Common

Public Class BuscarProductoForm
    Public Row As DataRow
    Public sTipoProducto As String
    Public Cantidad As Short = 0
    Public RequiereAsignacion As Boolean

    Public Shared Function Run(ByVal TipoProducto As String, ByRef Cantidad As Short, _
    ByVal RequiereAsignacion As Boolean) As DataRow
        UIHandler.StartWait()
        Dim form As New BuscarProductoForm
        Dim Row As DataRow = Nothing
        form.sTipoProducto = TipoProducto
        form.RequiereAsignacion = RequiereAsignacion
        UIHandler.ShowDialog(form)
        Row = form.Row
        Cantidad = CShort(form.Cantidad)
        form.Dispose()
        UIHandler.EndWait()
        Return Row
    End Function

    Private Sub BuscarProductoForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnCancelar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.C Then
                btnCancelar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.Enter Then
                If txtCantidad.Visible = False Then
                    btnAceptar_Click(Me, Nothing)
                Else
                    If txtCantidad.Text <> "" Then
                        btnAceptar_Click(Me, Nothing)
                    Else
                        txtCantidad.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub BuscarProductoForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.dsProductos = Productos.dsProductos

        If sTipoProducto = "" And RequiereAsignacion = True Then
            Productos.LoadByRequiereAsignacion()
        Else
            Productos.LoadByTipoProducto(sTipoProducto)
        End If

        If dsProductos.Productos.Rows.Count = 0 Then
            UIHandler.ShowError("No hay datos para mostrar!!")
            Exit Sub
        End If

        bsProductos.DataSource = dsProductos
        bsProductos.Position = 0
        If sTipoProducto = TipoProducto.Servicio Then
            lblCantidad.Visible = True
            txtCantidad.Visible = True
            txtCantidad.Focus()
        Else
            lblCantidad.Visible = False
            txtCantidad.Visible = False
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        ValidarDatos()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub grdProductos_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdProductos.CurrentCellChanged
        If Me.txtCantidad.Visible Then
            Me.txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = vbCr Then
            ValidarDatos()
        End If
    End Sub

    Public Sub ValidarDatos()
        Dim nIndex As Integer
        nIndex = grdProductos.CurrentRowIndex()
        If nIndex >= 0 Then
            If Me.txtCantidad.Visible Then
                If Me.txtCantidad.Text = "" Then
                    UIHandler.ShowAlert("Ingrese la cantidad!!")
                    Me.txtCantidad.Focus()
                    Exit Sub
                End If
                If CInt(Me.txtCantidad.Text) <= 0 Then
                    UIHandler.ShowAlert("La Cantidad debe ser mayor a cero!!")
                    Me.txtCantidad.Text = ""
                    Me.txtCantidad.Focus()
                    Exit Sub
                End If
                Cantidad = CShort(Me.txtCantidad.Text)
            Else
                Cantidad = 0
            End If
            Row = GetCurrentRow(bsProductos)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            UIHandler.ShowError("Seleccione un Producto!!")
        End If
    End Sub
End Class