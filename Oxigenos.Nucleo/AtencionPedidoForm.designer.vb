<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AtencionPedidoForm
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
        Me.menuPedido = New System.Windows.Forms.MenuItem
        Me.menuAnularPedido = New System.Windows.Forms.MenuItem
        Me.menuRegresar = New System.Windows.Forms.MenuItem
        Me.bsPedidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.menuPedido)
        '
        'menuPedido
        '
        Me.menuPedido.MenuItems.Add(Me.menuAnularPedido)
        Me.menuPedido.MenuItems.Add(Me.menuRegresar)
        Me.menuPedido.Text = "Pedido"
        '
        'menuAnularPedido
        '
        Me.menuAnularPedido.Text = "Anular Pedido..."
        '
        'menuRegresar
        '
        Me.menuRegresar.Text = "Regresar"
        '
        'bsPedidos
        '
        Me.bsPedidos.DataMember = "Pedidos"
        Me.bsPedidos.DataSource = Me.dsNucleo
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "NucleoDataSet"
        Me.dsNucleo.Prefix = ""
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Solicito", True))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(70, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.Text = "HILDA"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.Text = "Solicita:"
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "CodEntidad", True))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(70, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 20)
        Me.Label7.Text = "00001016"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.Text = "Entidad:"
        '
        'Label9
        '
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Entidad", True))
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(4, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(225, 20)
        Me.Label9.Text = "INS. DE SEGURO SOCIAL"
        '
        'Label10
        '
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "FechaProgramada", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(90, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.Text = "20/07/2007"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 20)
        Me.Label11.Text = "Prog, Entrega:"
        '
        'Label12
        '
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "HoraProgramada", True))
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(174, 198)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 20)
        Me.Label12.Text = "11:17"
        '
        'Label13
        '
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Observacion", True))
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(4, 232)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(233, 25)
        Me.Label13.Text = "Favor cobrar dos Canulas"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(4, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 20)
        Me.Label14.Text = "Observaciones:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 32)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(4, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 25)
        Me.Label21.Text = "Atencion Pedido"
        '
        'Label15
        '
        Me.Label15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "NoPedido", True))
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(70, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 16)
        Me.Label15.Text = "0010814024"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(4, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 20)
        Me.Label16.Text = "Pedido:"
        '
        'Label17
        '
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "CodSucursal", True))
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(70, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(145, 13)
        Me.Label17.Text = "01"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(3, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 20)
        Me.Label18.Text = "Sucursal:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 68)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 20)
        Me.Label4.Text = "CL 64 b # 18 L - 16 LA ACACIA"
        '
        'bsClientes
        '
        Me.bsClientes.DataMember = "Clientes"
        Me.bsClientes.DataSource = Me.dsNucleo
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Nombre", True))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(4, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 20)
        Me.Label3.Text = "ZAMBRANO, SANTIAGO"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Codigo", True))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(70, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.Text = "0004660"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.Text = "Cliente:"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'AtencionPedidoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Menu = Me.mainMenu1
        Me.Name = "AtencionPedidoForm"
        Me.Text = "Praxar"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents menuPedido As System.Windows.Forms.MenuItem
    Friend WithEvents menuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents bsPedidos As System.Windows.Forms.BindingSource
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents menuAnularPedido As System.Windows.Forms.MenuItem
End Class
