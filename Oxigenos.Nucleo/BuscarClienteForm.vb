Imports OpenNETCF.Win32

Public Class BuscarClienteForm

    Private m_sFiltro As String = ""

    Public Shared Function Run() As String
        UIHandler.StartWait()
        Dim frm As New BuscarClienteForm
        Dim sFiltro As String
        UIHandler.ShowDialog(frm)
        sFiltro = frm.m_sFiltro
        UIHandler.EndWait()
        Return sFiltro
    End Function

    Private Sub BuscarClienteForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then ' Salir sin guardar
                btnCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub BuscarClienteForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadCriteriosBusqueda()
        txtBusqueda.Focus()
        UIHandler.EndWait()
    End Sub

    Private Sub LoadCriteriosBusqueda()
        cbCriterios.Items.Clear()
        cbCriterios.Items.Add(KeyedListItem.NewItem("Codigo", "Código cliente"))
        cbCriterios.Items.Add(KeyedListItem.NewItem("Nombre", "Nombre cliente"))
        cbCriterios.Items.Add(KeyedListItem.NewItem("Direccion", "Dirección"))
        cbCriterios.Items.Add(KeyedListItem.NewItem("Barrio", "Barrio"))
        Me.cbCriterios.SelectedIndex = 1
    End Sub

    Private Sub BuscarClienteForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
        '    CInt((280 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
        Win32Window.MoveWindow(Me.Handle, 0, 0, Shape1.Width, Shape1.Height)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtBusqueda.Text = "" Then
            m_sFiltro = ""
        Else
            Dim sCampo As String = KeyedListItem.GetKeyValue(cbCriterios.SelectedItem)
            m_sFiltro = sCampo & " LIKE '%" & txtBusqueda.Text & "%'"
        End If
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class