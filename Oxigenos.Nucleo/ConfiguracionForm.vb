Imports OpenNETCF
Imports OpenNETCF.Net

Public Class ConfiguracionForm

    Public Shared Sub Run()
        UIHandler.StartWait()
        Dim frm As New ConfiguracionForm
        UIHandler.ShowDialog(frm)
        frm.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not ProcessHotKeys(Me, e) Then
            If e.Shift And e.KeyCode = Keys.Enter Then ' Guardar
                UIHandler.StartWait()
                SaveConfigData()
                DialogResult = System.Windows.Forms.DialogResult.OK
            ElseIf e.KeyCode = Keys.Escape Then ' Salir sin guardar
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Cancel
            End If
        End If
    End Sub

    Private Sub ConfiguracionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadListData()
        LoadConfigData()
        tcConfiguracion.TabIndex = 0
        txtIDTerminal.Focus()
        UIHandler.EndWait()
    End Sub

    Private Sub LoadListData()
        ' Se carga la lista de conexiones disponibles
        Dim cm As New ConnectionManager
        Dim di As DestinationInfo
        cbConexiones.Items.Add("")
        For Each di In cm.EnumDestinations()
            cbConexiones.Items.Add(di.Description)
        Next

        ' Se inicializa la lista de programas
        cbPrograma.EnumType = GetType(Programas)
    End Sub

    Private Sub LoadConfigData()
        txtIDTerminal.Text = Settings.IDTerminal
        cbDeviceModel.SelectedIndex = Settings.DeviceModel
        cbPrograma.SelectedValue = Settings.Programa
        txtPathWebService.Text = Settings.VirtualDirectory
        txtServerAddress.Text = Settings.IPServidor
        txtServerPort.Text = Settings.PuertoServidor.ToString()
        txtUserWebService.Text = Settings.UsuarioWebService
        txtClaveWebService.Text = Settings.ClaveWebService
        cbConexiones.SelectedItem = Settings.ConexionGPRS
        cbPuerto.SelectedItem = Settings.PrinterPort
        cbImpresora.SelectedIndex = Settings.PrinterModel
        cbTipoPuerto.SelectedIndex = Settings.PrinterPortType
        txtServerAddressGPRS.Text = Settings.IPServidorGPRS
    End Sub

    Private Sub menuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCancelar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub menuGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGuardar.Click
        UIHandler.StartWait()
        SaveConfigData()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SaveConfigData()
        Settings.IDTerminal = txtIDTerminal.Text
        Settings.DeviceModel = CType(cbDeviceModel.SelectedIndex, DeviceModels)
        Settings.Programa = CType(cbPrograma.SelectedValue, Programas)
        Settings.PrinterModel = CType(cbImpresora.SelectedIndex, PrinterModels)
        Settings.PrinterPort = cbPuerto.SelectedItem.ToString()
        Settings.PrinterPortType = CType(cbTipoPuerto.SelectedIndex, PrinterPortTypes)
        Settings.VirtualDirectory = txtPathWebService.Text
        Settings.IPServidor = txtServerAddress.Text
        Settings.PuertoServidor = CInt(txtServerPort.Text)
        Settings.UsuarioWebService = txtUserWebService.Text
        Settings.ClaveWebService = txtClaveWebService.Text
        Settings.ConexionGPRS = cbConexiones.SelectedItem.ToString()
        Settings.IPServidorGPRS = txtServerAddressGPRS.Text
        Settings.SaveConfig()
    End Sub


End Class