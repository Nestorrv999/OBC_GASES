<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PrecintosForm
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.menuGuardar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPrecintoExist1 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoCol1 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoCol2 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoExist2 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoCol3 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoExist3 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoCol4 = New DatascanCF.Windows.Forms.TextInputBox
        Me.txtPrecintoExist4 = New DatascanCF.Windows.Forms.TextInputBox
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Shape2 = New DatascanCF.Windows.Forms.Shape
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.menuGuardar)
        Me.mainMenu1.MenuItems.Add(Me.menuCancelar)
        '
        'menuGuardar
        '
        Me.menuGuardar.Text = "Guardar"
        '
        'menuCancelar
        '
        Me.menuCancelar.Text = "Cancelar"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 27)
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(3, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(208, 20)
        Me.Label11.Text = "Precintos"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Existentes"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(122, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Colocados"
        '
        'txtPrecintoExist1
        '
        Me.txtPrecintoExist1.AcceptLetters = True
        Me.txtPrecintoExist1.AcceptNumbers = True
        Me.txtPrecintoExist1.AcceptPunctuations = True
        Me.txtPrecintoExist1.AcceptSpaces = True
        Me.txtPrecintoExist1.AcceptSymbols = True
        Me.txtPrecintoExist1.ErrorMessage = ""
        Me.txtPrecintoExist1.HelpText = Nothing
        Me.txtPrecintoExist1.InvalidChars = ""
        Me.txtPrecintoExist1.Location = New System.Drawing.Point(3, 76)
        Me.txtPrecintoExist1.Name = "txtPrecintoExist1"
        Me.txtPrecintoExist1.Required = False
        Me.txtPrecintoExist1.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoExist1.TabIndex = 0
        Me.txtPrecintoExist1.TabOnEnter = True
        Me.txtPrecintoExist1.ValidChars = ""
        '
        'txtPrecintoCol1
        '
        Me.txtPrecintoCol1.AcceptLetters = True
        Me.txtPrecintoCol1.AcceptNumbers = True
        Me.txtPrecintoCol1.AcceptPunctuations = True
        Me.txtPrecintoCol1.AcceptSpaces = True
        Me.txtPrecintoCol1.AcceptSymbols = True
        Me.txtPrecintoCol1.ErrorMessage = ""
        Me.txtPrecintoCol1.HelpText = Nothing
        Me.txtPrecintoCol1.InvalidChars = ""
        Me.txtPrecintoCol1.Location = New System.Drawing.Point(122, 76)
        Me.txtPrecintoCol1.Name = "txtPrecintoCol1"
        Me.txtPrecintoCol1.Required = False
        Me.txtPrecintoCol1.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoCol1.TabIndex = 1
        Me.txtPrecintoCol1.TabOnEnter = True
        Me.txtPrecintoCol1.ValidChars = ""
        '
        'txtPrecintoCol2
        '
        Me.txtPrecintoCol2.AcceptLetters = True
        Me.txtPrecintoCol2.AcceptNumbers = True
        Me.txtPrecintoCol2.AcceptPunctuations = True
        Me.txtPrecintoCol2.AcceptSpaces = True
        Me.txtPrecintoCol2.AcceptSymbols = True
        Me.txtPrecintoCol2.ErrorMessage = ""
        Me.txtPrecintoCol2.HelpText = Nothing
        Me.txtPrecintoCol2.InvalidChars = ""
        Me.txtPrecintoCol2.Location = New System.Drawing.Point(122, 103)
        Me.txtPrecintoCol2.Name = "txtPrecintoCol2"
        Me.txtPrecintoCol2.Required = False
        Me.txtPrecintoCol2.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoCol2.TabIndex = 3
        Me.txtPrecintoCol2.TabOnEnter = True
        Me.txtPrecintoCol2.ValidChars = ""
        '
        'txtPrecintoExist2
        '
        Me.txtPrecintoExist2.AcceptLetters = True
        Me.txtPrecintoExist2.AcceptNumbers = True
        Me.txtPrecintoExist2.AcceptPunctuations = True
        Me.txtPrecintoExist2.AcceptSpaces = True
        Me.txtPrecintoExist2.AcceptSymbols = True
        Me.txtPrecintoExist2.ErrorMessage = ""
        Me.txtPrecintoExist2.HelpText = Nothing
        Me.txtPrecintoExist2.InvalidChars = ""
        Me.txtPrecintoExist2.Location = New System.Drawing.Point(3, 103)
        Me.txtPrecintoExist2.Name = "txtPrecintoExist2"
        Me.txtPrecintoExist2.Required = False
        Me.txtPrecintoExist2.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoExist2.TabIndex = 2
        Me.txtPrecintoExist2.TabOnEnter = True
        Me.txtPrecintoExist2.ValidChars = ""
        '
        'txtPrecintoCol3
        '
        Me.txtPrecintoCol3.AcceptLetters = True
        Me.txtPrecintoCol3.AcceptNumbers = True
        Me.txtPrecintoCol3.AcceptPunctuations = True
        Me.txtPrecintoCol3.AcceptSpaces = True
        Me.txtPrecintoCol3.AcceptSymbols = True
        Me.txtPrecintoCol3.ErrorMessage = ""
        Me.txtPrecintoCol3.HelpText = Nothing
        Me.txtPrecintoCol3.InvalidChars = ""
        Me.txtPrecintoCol3.Location = New System.Drawing.Point(122, 134)
        Me.txtPrecintoCol3.Name = "txtPrecintoCol3"
        Me.txtPrecintoCol3.Required = False
        Me.txtPrecintoCol3.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoCol3.TabIndex = 5
        Me.txtPrecintoCol3.TabOnEnter = True
        Me.txtPrecintoCol3.ValidChars = ""
        '
        'txtPrecintoExist3
        '
        Me.txtPrecintoExist3.AcceptLetters = True
        Me.txtPrecintoExist3.AcceptNumbers = True
        Me.txtPrecintoExist3.AcceptPunctuations = True
        Me.txtPrecintoExist3.AcceptSpaces = True
        Me.txtPrecintoExist3.AcceptSymbols = True
        Me.txtPrecintoExist3.ErrorMessage = ""
        Me.txtPrecintoExist3.HelpText = Nothing
        Me.txtPrecintoExist3.InvalidChars = ""
        Me.txtPrecintoExist3.Location = New System.Drawing.Point(3, 134)
        Me.txtPrecintoExist3.Name = "txtPrecintoExist3"
        Me.txtPrecintoExist3.Required = False
        Me.txtPrecintoExist3.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoExist3.TabIndex = 4
        Me.txtPrecintoExist3.TabOnEnter = True
        Me.txtPrecintoExist3.ValidChars = ""
        '
        'txtPrecintoCol4
        '
        Me.txtPrecintoCol4.AcceptLetters = True
        Me.txtPrecintoCol4.AcceptNumbers = True
        Me.txtPrecintoCol4.AcceptPunctuations = True
        Me.txtPrecintoCol4.AcceptSpaces = True
        Me.txtPrecintoCol4.AcceptSymbols = True
        Me.txtPrecintoCol4.ErrorMessage = ""
        Me.txtPrecintoCol4.HelpText = Nothing
        Me.txtPrecintoCol4.InvalidChars = ""
        Me.txtPrecintoCol4.Location = New System.Drawing.Point(122, 161)
        Me.txtPrecintoCol4.Name = "txtPrecintoCol4"
        Me.txtPrecintoCol4.Required = False
        Me.txtPrecintoCol4.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoCol4.TabIndex = 7
        Me.txtPrecintoCol4.TabOnEnter = True
        Me.txtPrecintoCol4.ValidChars = ""
        '
        'txtPrecintoExist4
        '
        Me.txtPrecintoExist4.AcceptLetters = True
        Me.txtPrecintoExist4.AcceptNumbers = True
        Me.txtPrecintoExist4.AcceptPunctuations = True
        Me.txtPrecintoExist4.AcceptSpaces = True
        Me.txtPrecintoExist4.AcceptSymbols = True
        Me.txtPrecintoExist4.ErrorMessage = ""
        Me.txtPrecintoExist4.HelpText = Nothing
        Me.txtPrecintoExist4.InvalidChars = ""
        Me.txtPrecintoExist4.Location = New System.Drawing.Point(3, 161)
        Me.txtPrecintoExist4.Name = "txtPrecintoExist4"
        Me.txtPrecintoExist4.Required = False
        Me.txtPrecintoExist4.Size = New System.Drawing.Size(113, 21)
        Me.txtPrecintoExist4.TabIndex = 6
        Me.txtPrecintoExist4.TabOnEnter = True
        Me.txtPrecintoExist4.ValidChars = ""
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(3, 60)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(113, 10)
        Me.Shape1.TabIndex = 13
        Me.Shape1.Text = "Shape1"
        '
        'Shape2
        '
        Me.Shape2.Enabled = False
        Me.Shape2.Location = New System.Drawing.Point(124, 60)
        Me.Shape2.Name = "Shape2"
        Me.Shape2.Size = New System.Drawing.Size(109, 10)
        Me.Shape2.TabIndex = 14
        Me.Shape2.Text = "Shape2"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(85, 203)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 20)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(163, 203)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'PrecintosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Shape2)
        Me.Controls.Add(Me.Shape1)
        Me.Controls.Add(Me.txtPrecintoCol4)
        Me.Controls.Add(Me.txtPrecintoExist4)
        Me.Controls.Add(Me.txtPrecintoCol3)
        Me.Controls.Add(Me.txtPrecintoExist3)
        Me.Controls.Add(Me.txtPrecintoCol2)
        Me.Controls.Add(Me.txtPrecintoExist2)
        Me.Controls.Add(Me.txtPrecintoCol1)
        Me.Controls.Add(Me.txtPrecintoExist1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.mainMenu1
        Me.Name = "PrecintosForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecintoExist1 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoCol1 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoCol2 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoExist2 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoCol3 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoExist3 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoCol4 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents txtPrecintoExist4 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents Shape2 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents menuGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
End Class
