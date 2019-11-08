<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ConfiguracionForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionForm))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuGuardar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.tcConfiguracion = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cbDeviceModel = New System.Windows.Forms.ComboBox
        Me.cbImpresora = New System.Windows.Forms.ComboBox
        Me.cbTipoPuerto = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbPuerto = New System.Windows.Forms.ComboBox
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbPrograma = New DatascanCF.Windows.Forms.EnumComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIDTerminal = New DatascanCF.Windows.Forms.TextInputBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtClaveWebService = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtUserWebService = New DatascanCF.Windows.Forms.TextInputBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPathWebService = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtServerAddress = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtServerPort = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.txtServerAddressGPRS = New DatascanCF.Windows.Forms.TextInputBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbConexiones = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.tcConfiguracion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuGuardar)
        Me.MenuItem1.MenuItems.Add(Me.menuCancelar)
        resources.ApplyResources(Me.MenuItem1, "MenuItem1")
        '
        'menuGuardar
        '
        resources.ApplyResources(Me.menuGuardar, "menuGuardar")
        '
        'menuCancelar
        '
        resources.ApplyResources(Me.menuCancelar, "menuCancelar")
        '
        'tcConfiguracion
        '
        Me.tcConfiguracion.Controls.Add(Me.TabPage1)
        Me.tcConfiguracion.Controls.Add(Me.TabPage2)
        Me.tcConfiguracion.Controls.Add(Me.TabPage3)
        resources.ApplyResources(Me.tcConfiguracion, "tcConfiguracion")
        Me.tcConfiguracion.Name = "tcConfiguracion"
        Me.tcConfiguracion.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cbDeviceModel)
        Me.TabPage1.Controls.Add(Me.cbImpresora)
        Me.TabPage1.Controls.Add(Me.cbTipoPuerto)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.cbPuerto)
        Me.TabPage1.Controls.Add(Me.Shape1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.cbPrograma)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtIDTerminal)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label13)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'cbDeviceModel
        '
        Me.cbDeviceModel.Items.Add(resources.GetString("cbDeviceModel.Items"))
        Me.cbDeviceModel.Items.Add(resources.GetString("cbDeviceModel.Items1"))
        resources.ApplyResources(Me.cbDeviceModel, "cbDeviceModel")
        Me.cbDeviceModel.Name = "cbDeviceModel"
        '
        'cbImpresora
        '
        Me.cbImpresora.Items.Add(resources.GetString("cbImpresora.Items"))
        Me.cbImpresora.Items.Add(resources.GetString("cbImpresora.Items1"))
        Me.cbImpresora.Items.Add(resources.GetString("cbImpresora.Items2"))
        resources.ApplyResources(Me.cbImpresora, "cbImpresora")
        Me.cbImpresora.Name = "cbImpresora"
        '
        'cbTipoPuerto
        '
        Me.cbTipoPuerto.Items.Add(resources.GetString("cbTipoPuerto.Items"))
        Me.cbTipoPuerto.Items.Add(resources.GetString("cbTipoPuerto.Items1"))
        resources.ApplyResources(Me.cbTipoPuerto, "cbTipoPuerto")
        Me.cbTipoPuerto.Name = "cbTipoPuerto"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'cbPuerto
        '
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items1"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items2"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items3"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items4"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items5"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items6"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items7"))
        Me.cbPuerto.Items.Add(resources.GetString("cbPuerto.Items8"))
        resources.ApplyResources(Me.cbPuerto, "cbPuerto")
        Me.cbPuerto.Name = "cbPuerto"
        '
        'Shape1
        '
        resources.ApplyResources(Me.Shape1, "Shape1")
        Me.Shape1.Name = "Shape1"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'cbPrograma
        '
        Me.cbPrograma.EnumType = Nothing
        Me.cbPrograma.ErrorMessage = ""
        Me.cbPrograma.HelpText = ""
        resources.ApplyResources(Me.cbPrograma, "cbPrograma")
        Me.cbPrograma.Name = "cbPrograma"
        Me.cbPrograma.Required = True
        Me.cbPrograma.TabOnEnter = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtIDTerminal
        '
        Me.txtIDTerminal.AcceptLetters = True
        Me.txtIDTerminal.AcceptNumbers = True
        Me.txtIDTerminal.AcceptPunctuations = True
        Me.txtIDTerminal.AcceptSpaces = True
        Me.txtIDTerminal.AcceptSymbols = True
        Me.txtIDTerminal.ErrorMessage = ""
        resources.ApplyResources(Me.txtIDTerminal, "txtIDTerminal")
        Me.txtIDTerminal.HelpText = Nothing
        Me.txtIDTerminal.InvalidChars = ""
        Me.txtIDTerminal.Name = "txtIDTerminal"
        Me.txtIDTerminal.Required = False
        Me.txtIDTerminal.TabOnEnter = True
        Me.txtIDTerminal.ValidChars = ""
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtClaveWebService)
        Me.TabPage2.Controls.Add(Me.txtUserWebService)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtPathWebService)
        Me.TabPage2.Controls.Add(Me.txtServerAddress)
        Me.TabPage2.Controls.Add(Me.txtServerPort)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        '
        'txtClaveWebService
        '
        Me.txtClaveWebService.AcceptLetters = True
        Me.txtClaveWebService.AcceptNumbers = True
        Me.txtClaveWebService.AcceptPunctuations = True
        Me.txtClaveWebService.AcceptSpaces = True
        Me.txtClaveWebService.AcceptSymbols = True
        Me.txtClaveWebService.ErrorMessage = ""
        Me.txtClaveWebService.HelpText = Nothing
        Me.txtClaveWebService.InvalidChars = ""
        resources.ApplyResources(Me.txtClaveWebService, "txtClaveWebService")
        Me.txtClaveWebService.Name = "txtClaveWebService"
        Me.txtClaveWebService.Required = False
        Me.txtClaveWebService.TabOnEnter = True
        Me.txtClaveWebService.ValidChars = ""
        '
        'txtUserWebService
        '
        Me.txtUserWebService.AcceptLetters = True
        Me.txtUserWebService.AcceptNumbers = True
        Me.txtUserWebService.AcceptPunctuations = True
        Me.txtUserWebService.AcceptSpaces = True
        Me.txtUserWebService.AcceptSymbols = True
        Me.txtUserWebService.ErrorMessage = ""
        Me.txtUserWebService.HelpText = Nothing
        Me.txtUserWebService.InvalidChars = ""
        resources.ApplyResources(Me.txtUserWebService, "txtUserWebService")
        Me.txtUserWebService.Name = "txtUserWebService"
        Me.txtUserWebService.Required = False
        Me.txtUserWebService.TabOnEnter = True
        Me.txtUserWebService.ValidChars = ""
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'txtPathWebService
        '
        Me.txtPathWebService.AcceptLetters = True
        Me.txtPathWebService.AcceptNumbers = True
        Me.txtPathWebService.AcceptPunctuations = True
        Me.txtPathWebService.AcceptSpaces = True
        Me.txtPathWebService.AcceptSymbols = True
        Me.txtPathWebService.ErrorMessage = ""
        Me.txtPathWebService.HelpText = Nothing
        Me.txtPathWebService.InvalidChars = ""
        resources.ApplyResources(Me.txtPathWebService, "txtPathWebService")
        Me.txtPathWebService.Name = "txtPathWebService"
        Me.txtPathWebService.Required = False
        Me.txtPathWebService.TabOnEnter = True
        Me.txtPathWebService.ValidChars = ""
        '
        'txtServerAddress
        '
        Me.txtServerAddress.AcceptLetters = True
        Me.txtServerAddress.AcceptNumbers = True
        Me.txtServerAddress.AcceptPunctuations = True
        Me.txtServerAddress.AcceptSpaces = True
        Me.txtServerAddress.AcceptSymbols = True
        Me.txtServerAddress.ErrorMessage = ""
        Me.txtServerAddress.HelpText = Nothing
        Me.txtServerAddress.InvalidChars = ""
        resources.ApplyResources(Me.txtServerAddress, "txtServerAddress")
        Me.txtServerAddress.Name = "txtServerAddress"
        Me.txtServerAddress.Required = False
        Me.txtServerAddress.TabOnEnter = True
        Me.txtServerAddress.ValidChars = ""
        '
        'txtServerPort
        '
        Me.txtServerPort.AcceptZero = False
        Me.txtServerPort.AllowNegative = False
        Me.txtServerPort.Decimals = 0
        Me.txtServerPort.ErrorMessage = ""
        Me.txtServerPort.Format = ""
        Me.txtServerPort.HelpText = Nothing
        resources.ApplyResources(Me.txtServerPort, "txtServerPort")
        Me.txtServerPort.Name = "txtServerPort"
        Me.txtServerPort.Required = False
        Me.txtServerPort.TabOnEnter = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtServerAddressGPRS)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.cbConexiones)
        Me.TabPage3.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        '
        'txtServerAddressGPRS
        '
        Me.txtServerAddressGPRS.AcceptLetters = True
        Me.txtServerAddressGPRS.AcceptNumbers = True
        Me.txtServerAddressGPRS.AcceptPunctuations = True
        Me.txtServerAddressGPRS.AcceptSpaces = True
        Me.txtServerAddressGPRS.AcceptSymbols = True
        Me.txtServerAddressGPRS.ErrorMessage = ""
        Me.txtServerAddressGPRS.HelpText = Nothing
        Me.txtServerAddressGPRS.InvalidChars = ""
        resources.ApplyResources(Me.txtServerAddressGPRS, "txtServerAddressGPRS")
        Me.txtServerAddressGPRS.Name = "txtServerAddressGPRS"
        Me.txtServerAddressGPRS.Required = False
        Me.txtServerAddressGPRS.TabOnEnter = True
        Me.txtServerAddressGPRS.ValidChars = ""
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'cbConexiones
        '
        resources.ApplyResources(Me.cbConexiones, "cbConexiones")
        Me.cbConexiones.Name = "cbConexiones"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tcConfiguracion)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Label11)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Name = "Label11"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'ConfiguracionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        resources.ApplyResources(Me, "$this")
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.mainMenu1
        Me.Name = "ConfiguracionForm"
        Me.tcConfiguracion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcConfiguracion As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cbPrograma As DatascanCF.Windows.Forms.EnumComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDTerminal As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtPathWebService As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtServerAddress As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtServerPort As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtServerAddressGPRS As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbConexiones As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtClaveWebService As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtUserWebService As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents cbPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbTipoPuerto As System.Windows.Forms.ComboBox
    Friend WithEvents cbImpresora As System.Windows.Forms.ComboBox
    Friend WithEvents cbDeviceModel As System.Windows.Forms.ComboBox
End Class
