<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InformacionClienteForm
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

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InformacionClienteForm))
        Me.NitLabel = New System.Windows.Forms.Label
        Me.DiaAtencionLabel = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuRegresar = New System.Windows.Forms.MenuItem
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ClientesTableAdapter = New Oxigenos.Principal.NucleoDataSetTableAdapters.ClientesTableAdapter
        Me.NitLabel1 = New System.Windows.Forms.Label
        Me.DiaAtencionLabel1 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.lblTipoPago = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NitLabel
        '
        Me.NitLabel.Location = New System.Drawing.Point(6, 55)
        Me.NitLabel.Name = "NitLabel"
        Me.NitLabel.Size = New System.Drawing.Size(52, 17)
        Me.NitLabel.Text = "Nit:"
        '
        'DiaAtencionLabel
        '
        Me.DiaAtencionLabel.Location = New System.Drawing.Point(6, 212)
        Me.DiaAtencionLabel.Name = "DiaAtencionLabel"
        Me.DiaAtencionLabel.Size = New System.Drawing.Size(77, 17)
        Me.DiaAtencionLabel.Text = "Dia Atencion:"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuRegresar)
        Me.MenuItem1.Text = "Cliente"
        '
        'menuRegresar
        '
        Me.menuRegresar.Text = "Regresar"
        '
        'bsClientes
        '
        Me.bsClientes.DataMember = "Clientes"
        Me.bsClientes.DataSource = Me.dsNucleo
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "NucleoDataSet"
        Me.dsNucleo.Prefix = ""
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Barrio", True))
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(6, 168)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(231, 16)
        Me.Label16.Text = "ACACIAS SUR"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Direccion", True))
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(6, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(231, 34)
        Me.Label15.Text = "CL 64 B #18L - 16 SECTOR EL DIAMANTE"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(3, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(176, 16)
        Me.Label14.Text = "Dirección Cliente"
        '
        'Label8
        '
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "TipoCliente", True))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(89, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 17)
        Me.Label8.Text = "Paciente"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(6, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.Text = "Tipo Cliente:"
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Nombre", True))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 34)
        Me.Label3.Text = "XXXXXXXXXXXXXXXXXXXXXXXX" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "XXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Codigo", True))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(64, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 17)
        Me.Label2.Text = "Código"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.Text = "Código"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 26)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 3)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(234, 20)
        Me.Label21.Text = "Información Adicional Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(6, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 20)
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'NitLabel1
        '
        Me.NitLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Nit", True))
        Me.NitLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NitLabel1.Location = New System.Drawing.Point(64, 55)
        Me.NitLabel1.Name = "NitLabel1"
        Me.NitLabel1.Size = New System.Drawing.Size(125, 17)
        Me.NitLabel1.Text = "NIT"
        '
        'DiaAtencionLabel1
        '
        Me.DiaAtencionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "DiaAtencion", True))
        Me.DiaAtencionLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DiaAtencionLabel1.Location = New System.Drawing.Point(89, 212)
        Me.DiaAtencionLabel1.Name = "DiaAtencionLabel1"
        Me.DiaAtencionLabel1.Size = New System.Drawing.Size(85, 17)
        Me.DiaAtencionLabel1.Text = "Dia Atención"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'lblTipoPago
        '
        Me.lblTipoPago.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "DescripTipoPago", True))
        Me.lblTipoPago.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoPago.Location = New System.Drawing.Point(89, 233)
        Me.lblTipoPago.Name = "lblTipoPago"
        Me.lblTipoPago.Size = New System.Drawing.Size(145, 17)
        Me.lblTipoPago.Text = "Credito"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(6, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 17)
        Me.Label5.Text = "Tipo Pago:"
        '
        'InformacionClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTipoPago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DiaAtencionLabel)
        Me.Controls.Add(Me.DiaAtencionLabel1)
        Me.Controls.Add(Me.NitLabel)
        Me.Controls.Add(Me.NitLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.MainMenu1
        Me.Name = "InformacionClienteForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
    Friend WithEvents menuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ClientesTableAdapter As Oxigenos.Principal.NucleoDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents NitLabel1 As System.Windows.Forms.Label
    Friend WithEvents DiaAtencionLabel1 As System.Windows.Forms.Label
    Friend WithEvents NitLabel As System.Windows.Forms.Label
    Friend WithEvents DiaAtencionLabel As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents lblTipoPago As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
