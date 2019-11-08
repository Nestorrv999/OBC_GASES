<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PedidosClienteForm
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
        Dim PrimerServicioDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim EstadoDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim NoPedidoDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Me.DireccionLabel = New System.Windows.Forms.Label
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.menuPedidos = New System.Windows.Forms.MenuItem
        Me.menuAtencionPedido = New System.Windows.Forms.MenuItem
        Me.menuNuevoPedido = New System.Windows.Forms.MenuItem
        Me.menuRegresar = New System.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bsCliente = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreLabel1 = New System.Windows.Forms.Label
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.bsPedidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.PedidosTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DireccionLabel1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        EstadoDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrimerServicioDataGridColumnStyleDataGridTextBoxColumn
        '
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "PS"
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.MappingName = "PrimerServicio"
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.Width = 30
        '
        'EstadoDataGridColumnStyleDataGridTextBoxColumn
        '
        EstadoDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        EstadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        EstadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "EST"
        EstadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Estado"
        EstadoDataGridColumnStyleDataGridTextBoxColumn.Width = 30
        '
        'NoPedidoDataGridColumnStyleDataGridTextBoxColumn
        '
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "NoPedido"
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "NoPedido"
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.Width = 100
        '
        'DireccionLabel
        '
        Me.DireccionLabel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DireccionLabel.Location = New System.Drawing.Point(3, 161)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(66, 14)
        Me.DireccionLabel.Text = "Direccion:"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.menuPedidos)
        '
        'menuPedidos
        '
        Me.menuPedidos.MenuItems.Add(Me.menuAtencionPedido)
        Me.menuPedidos.MenuItems.Add(Me.menuNuevoPedido)
        Me.menuPedidos.MenuItems.Add(Me.menuRegresar)
        Me.menuPedidos.Text = "Pedido"
        '
        'menuAtencionPedido
        '
        Me.menuAtencionPedido.Text = "&Atender Pedido"
        '
        'menuNuevoPedido
        '
        Me.menuNuevoPedido.Text = "&Nuevo Pedido..."
        '
        'menuRegresar
        '
        Me.menuRegresar.Text = "Regresar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.NombreLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 39)
        '
        'bsCliente
        '
        Me.bsCliente.DataMember = "Clientes"
        Me.bsCliente.DataSource = Me.dsNucleo
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsCliente, "Nombre", True))
        Me.NombreLabel1.ForeColor = System.Drawing.Color.White
        Me.NombreLabel1.Location = New System.Drawing.Point(3, 19)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(234, 15)
        Me.NombreLabel1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXX"
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "NucleoDataSet"
        Me.dsNucleo.Prefix = ""
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.Text = "Pedidos Cliente"
        '
        'bsPedidos
        '
        Me.bsPedidos.DataMember = "Pedidos"
        Me.bsPedidos.DataSource = Me.dsNucleo
        Me.bsPedidos.Sort = "Estado"
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid1.DataSource = Me.bsPedidos
        Me.DataGrid1.Location = New System.Drawing.Point(-3, 37)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.Size = New System.Drawing.Size(243, 121)
        Me.DataGrid1.TabIndex = 1
        Me.DataGrid1.TableStyles.Add(Me.PedidosTableStyleDataGridTableStyle)
        '
        'PedidosTableStyleDataGridTableStyle
        '
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(NoPedidoDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(PrimerServicioDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(EstadoDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(Me.DataGridTextBoxColumn1)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(Me.DataGridTextBoxColumn2)
        Me.PedidosTableStyleDataGridTableStyle.MappingName = "Pedidos"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "REC"
        Me.DataGridTextBoxColumn1.MappingName = "Recoleccion"
        Me.DataGridTextBoxColumn1.Width = 30
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "NV"
        Me.DataGridTextBoxColumn2.MappingName = "Nuevo"
        Me.DataGridTextBoxColumn2.Width = 30
        '
        'DireccionLabel1
        '
        Me.DireccionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Direccion", True))
        Me.DireccionLabel1.Location = New System.Drawing.Point(3, 175)
        Me.DireccionLabel1.Name = "DireccionLabel1"
        Me.DireccionLabel1.Size = New System.Drawing.Size(234, 32)
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Barrio", True))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(3, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Observacion", True))
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(3, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 20)
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.Text = "Solicito:"
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Solicito", True))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(50, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 20)
        Me.Label5.Text = "Label5"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'PedidosClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.DireccionLabel1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.mainMenu1
        Me.Name = "PedidosClienteForm"
        Me.Text = "Pedidos Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents bsPedidos As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents bsCliente As System.Windows.Forms.BindingSource
    Friend WithEvents menuPedidos As System.Windows.Forms.MenuItem
    Friend WithEvents NombreLabel1 As System.Windows.Forms.Label
    Friend WithEvents menuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents DireccionLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents menuAtencionPedido As System.Windows.Forms.MenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents DireccionLabel As System.Windows.Forms.Label
    Friend WithEvents menuNuevoPedido As System.Windows.Forms.MenuItem
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
End Class
