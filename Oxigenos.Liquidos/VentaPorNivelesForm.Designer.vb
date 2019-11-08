<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VentaPorNivelesForm
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
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuGuardar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.menuPrecintos = New System.Windows.Forms.MenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVenta = New Oxigenos.Liquidos.VentaDataSet
        Me.txtNivelInicial = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPresionInicial = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNivelFinal = New DatascanCF.Windows.Forms.NumericInputBox
        Me.txtPresionFinal = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtKilometraje = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.menuPrecintos)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuGuardar)
        Me.MenuItem1.MenuItems.Add(Me.menuCancelar)
        Me.MenuItem1.Text = "Opciiones"
        '
        'menuGuardar
        '
        Me.menuGuardar.Text = "Guardar"
        '
        'menuCancelar
        '
        Me.menuCancelar.Text = "Cancelar"
        '
        'menuPrecintos
        '
        Me.menuPrecintos.Text = "Precintos..."
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
        Me.Label11.Text = "Venta Por Niveles"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.Text = "Nivel Inicial"
        '
        'bsDetallePedido
        '
        Me.bsDetallePedido.DataMember = "DetallePedido"
        Me.bsDetallePedido.DataSource = Me.dsVenta
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtNivelInicial
        '
        Me.txtNivelInicial.AcceptZero = False
        Me.txtNivelInicial.AllowNegative = False
        Me.txtNivelInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "NivelInicial", True))
        Me.txtNivelInicial.Decimals = 0
        Me.txtNivelInicial.ErrorMessage = ""
        Me.txtNivelInicial.Format = ""
        Me.txtNivelInicial.HelpText = Nothing
        Me.txtNivelInicial.Location = New System.Drawing.Point(115, 77)
        Me.txtNivelInicial.MaxLength = 8
        Me.txtNivelInicial.Name = "txtNivelInicial"
        Me.txtNivelInicial.Required = False
        Me.txtNivelInicial.Size = New System.Drawing.Size(100, 21)
        Me.txtNivelInicial.TabIndex = 0
        Me.txtNivelInicial.TabOnEnter = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.Text = "Presión Inicial"
        '
        'txtPresionInicial
        '
        Me.txtPresionInicial.AcceptZero = False
        Me.txtPresionInicial.AllowNegative = False
        Me.txtPresionInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "PresionInicial", True))
        Me.txtPresionInicial.Decimals = 0
        Me.txtPresionInicial.ErrorMessage = ""
        Me.txtPresionInicial.Format = ""
        Me.txtPresionInicial.HelpText = Nothing
        Me.txtPresionInicial.Location = New System.Drawing.Point(115, 104)
        Me.txtPresionInicial.MaxLength = 8
        Me.txtPresionInicial.Name = "txtPresionInicial"
        Me.txtPresionInicial.Required = False
        Me.txtPresionInicial.Size = New System.Drawing.Size(100, 21)
        Me.txtPresionInicial.TabIndex = 1
        Me.txtPresionInicial.TabOnEnter = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Nivel Final"
        '
        'txtNivelFinal
        '
        Me.txtNivelFinal.AcceptZero = False
        Me.txtNivelFinal.AllowNegative = False
        Me.txtNivelFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "NivelFinal", True))
        Me.txtNivelFinal.Decimals = 0
        Me.txtNivelFinal.ErrorMessage = ""
        Me.txtNivelFinal.Format = ""
        Me.txtNivelFinal.HelpText = Nothing
        Me.txtNivelFinal.Location = New System.Drawing.Point(115, 131)
        Me.txtNivelFinal.MaxLength = 8
        Me.txtNivelFinal.Name = "txtNivelFinal"
        Me.txtNivelFinal.Required = False
        Me.txtNivelFinal.Size = New System.Drawing.Size(100, 21)
        Me.txtNivelFinal.TabIndex = 2
        Me.txtNivelFinal.TabOnEnter = True
        '
        'txtPresionFinal
        '
        Me.txtPresionFinal.AcceptZero = False
        Me.txtPresionFinal.AllowNegative = False
        Me.txtPresionFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "PresionFinal", True))
        Me.txtPresionFinal.Decimals = 0
        Me.txtPresionFinal.ErrorMessage = ""
        Me.txtPresionFinal.Format = ""
        Me.txtPresionFinal.HelpText = Nothing
        Me.txtPresionFinal.Location = New System.Drawing.Point(115, 158)
        Me.txtPresionFinal.MaxLength = 8
        Me.txtPresionFinal.Name = "txtPresionFinal"
        Me.txtPresionFinal.Required = False
        Me.txtPresionFinal.Size = New System.Drawing.Size(100, 21)
        Me.txtPresionFinal.TabIndex = 3
        Me.txtPresionFinal.TabOnEnter = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.Text = "Presión Final"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(76, 234)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 20)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(154, 234)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.Text = "Tanque:"
        '
        'Label6
        '
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "CodTanque", True))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(61, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.Text = "Codigo"
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "Tanque", True))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(234, 20)
        Me.Label7.Text = "Descripcion"
        '
        'txtKilometraje
        '
        Me.txtKilometraje.AcceptZero = False
        Me.txtKilometraje.AllowNegative = False
        Me.txtKilometraje.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "Kilometraje", True))
        Me.txtKilometraje.Decimals = 0
        Me.txtKilometraje.ErrorMessage = ""
        Me.txtKilometraje.Format = ""
        Me.txtKilometraje.HelpText = Nothing
        Me.txtKilometraje.Location = New System.Drawing.Point(115, 187)
        Me.txtKilometraje.MaxLength = 7
        Me.txtKilometraje.Name = "txtKilometraje"
        Me.txtKilometraje.Required = False
        Me.txtKilometraje.Size = New System.Drawing.Size(100, 21)
        Me.txtKilometraje.TabIndex = 4
        Me.txtKilometraje.TabOnEnter = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.Text = "Kilometraje"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'VentaPorNivelesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtKilometraje)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtPresionFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNivelFinal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPresionInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNivelInicial)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Menu = Me.mainMenu1
        Me.Name = "VentaPorNivelesForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents menuPrecintos As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNivelInicial As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPresionInicial As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNivelFinal As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents txtPresionFinal As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtKilometraje As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dsVenta As Oxigenos.Liquidos.VentaDataSet
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
