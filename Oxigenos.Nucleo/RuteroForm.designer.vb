<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RuteroForm
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
    Private menuRuteroClientes As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NoPedidoDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim CodClienteDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim PrimerServicioDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim RecoleccionDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim EstadoDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim NuevoDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RuteroForm))
        Me.menuRuteroClientes = New System.Windows.Forms.MainMenu
        Me.menuRutero = New System.Windows.Forms.MenuItem
        Me.menuBuscarCliente = New System.Windows.Forms.MenuItem
        Me.menuRegresar = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuCliente = New System.Windows.Forms.MenuItem
        Me.menuDireccionesCliente = New System.Windows.Forms.MenuItem
        Me.menuInformacionCliente = New System.Windows.Forms.MenuItem
        Me.menuPedidosCliente = New System.Windows.Forms.MenuItem
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.pnlVistaClientes = New System.Windows.Forms.Panel
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnQuitarFiltroCliente = New System.Windows.Forms.LinkLabel
        Me.btnVistaClientes = New OpenNETCF.Windows.Forms.PictureBox2
        Me.grdClientes = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ToolBar3 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.pnlVistaPedidos = New System.Windows.Forms.Panel
        Me.bsPedidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblClientePedido = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grdPedidos = New System.Windows.Forms.DataGrid
        Me.PedidosTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnVistaPedidos = New OpenNETCF.Windows.Forms.PictureBox2
        Me.btnQuitarFiltroPedidos = New System.Windows.Forms.LinkLabel
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.menuVista = New System.Windows.Forms.ContextMenu
        Me.menuVistaClientes = New System.Windows.Forms.MenuItem
        Me.menuVistaPedidos = New System.Windows.Forms.MenuItem
        Me.menuRuteroPedidos = New System.Windows.Forms.MainMenu
        Me.menuRutero2 = New System.Windows.Forms.MenuItem
        Me.menuBuscarPedido = New System.Windows.Forms.MenuItem
        Me.menuRegresar2 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.menuAtencionPedido = New System.Windows.Forms.MenuItem
        Me.menuDireccionesEntrega2 = New System.Windows.Forms.MenuItem
        Me.menuInformacionCliente2 = New System.Windows.Forms.MenuItem
        Me.timerNovedades = New System.Windows.Forms.Timer
        Me.pnlIniciando = New System.Windows.Forms.Panel
        Me.AnimateCtl1 = New OpenNETCF.Windows.Forms.AnimateCtl
        Me.lblMensajeProceso = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        CodClienteDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        EstadoDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        NuevoDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        Me.pnlVistaClientes.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlVistaPedidos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlIniciando.SuspendLayout()
        Me.SuspendLayout()
        '
        'NoPedidoDataGridColumnStyleDataGridTextBoxColumn
        '
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Pédido"
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "NoPedido"
        NoPedidoDataGridColumnStyleDataGridTextBoxColumn.Width = 60
        '
        'CodClienteDataGridColumnStyleDataGridTextBoxColumn
        '
        CodClienteDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        CodClienteDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        CodClienteDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Cliente"
        CodClienteDataGridColumnStyleDataGridTextBoxColumn.MappingName = "CodCliente"
        CodClienteDataGridColumnStyleDataGridTextBoxColumn.Width = 60
        '
        'PrimerServicioDataGridColumnStyleDataGridTextBoxColumn
        '
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "PS"
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.MappingName = "PrimerServicio"
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.NullText = ""
        PrimerServicioDataGridColumnStyleDataGridTextBoxColumn.Width = 20
        '
        'RecoleccionDataGridColumnStyleDataGridTextBoxColumn
        '
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "RE"
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Recoleccion"
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.NullText = ""
        RecoleccionDataGridColumnStyleDataGridTextBoxColumn.Width = 20
        '
        'EstadoDataGridColumnStyleDataGridTextBoxColumn
        '
        EstadoDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        EstadoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        EstadoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Estado"
        EstadoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Estado"
        EstadoDataGridColumnStyleDataGridTextBoxColumn.NullText = ""
        EstadoDataGridColumnStyleDataGridTextBoxColumn.Width = 20
        '
        'NuevoDataGridColumnStyleDataGridTextBoxColumn
        '
        NuevoDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        NuevoDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        NuevoDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Nuevo"
        NuevoDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Nuevo"
        NuevoDataGridColumnStyleDataGridTextBoxColumn.NullText = ""
        NuevoDataGridColumnStyleDataGridTextBoxColumn.Width = 30
        '
        'menuRuteroClientes
        '
        Me.menuRuteroClientes.MenuItems.Add(Me.menuRutero)
        Me.menuRuteroClientes.MenuItems.Add(Me.menuCliente)
        '
        'menuRutero
        '
        Me.menuRutero.MenuItems.Add(Me.menuBuscarCliente)
        Me.menuRutero.MenuItems.Add(Me.menuRegresar)
        Me.menuRutero.MenuItems.Add(Me.MenuItem1)
        Me.menuRutero.Text = "Rutero"
        '
        'menuBuscarCliente
        '
        Me.menuBuscarCliente.Text = "&Buscar Cliente ..."
        '
        'menuRegresar
        '
        Me.menuRegresar.Text = "Regresar"
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Descarga manual"
        '
        'menuCliente
        '
        Me.menuCliente.MenuItems.Add(Me.menuDireccionesCliente)
        Me.menuCliente.MenuItems.Add(Me.menuInformacionCliente)
        Me.menuCliente.MenuItems.Add(Me.menuPedidosCliente)
        Me.menuCliente.Text = "Cliente"
        '
        'menuDireccionesCliente
        '
        Me.menuDireccionesCliente.Text = "&Direcciones Entrega..."
        '
        'menuInformacionCliente
        '
        Me.menuInformacionCliente.Text = "&Informacion Cliente..."
        '
        'menuPedidosCliente
        '
        Me.menuPedidosCliente.Text = "&Pedidos cliente..."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.Text = "Pedidos"
        '
        'ToolBar2
        '
        Me.ToolBar2.Name = "ToolBar2"
        '
        'pnlVistaClientes
        '
        Me.pnlVistaClientes.Controls.Add(Me.Label2)
        Me.pnlVistaClientes.Controls.Add(Me.Label1)
        Me.pnlVistaClientes.Controls.Add(Me.Panel3)
        Me.pnlVistaClientes.Controls.Add(Me.grdClientes)
        Me.pnlVistaClientes.Location = New System.Drawing.Point(0, 0)
        Me.pnlVistaClientes.Name = "pnlVistaClientes"
        Me.pnlVistaClientes.Size = New System.Drawing.Size(240, 266)
        '
        'bsClientes
        '
        Me.bsClientes.DataMember = "Clientes"
        Me.bsClientes.DataSource = Me.dsNucleo
        Me.bsClientes.Sort = "Nombre"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Barrio", True))
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(3, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 18)
        Me.Label2.Text = "Barrio"
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "NucleoDataSet"
        Me.dsNucleo.Prefix = ""
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Direccion", True))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(4, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.Text = "Dirección cliente"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.btnQuitarFiltroCliente)
        Me.Panel3.Controls.Add(Me.btnVistaClientes)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 24)
        '
        'btnQuitarFiltroCliente
        '
        Me.btnQuitarFiltroCliente.ForeColor = System.Drawing.Color.Yellow
        Me.btnQuitarFiltroCliente.Location = New System.Drawing.Point(163, 4)
        Me.btnQuitarFiltroCliente.Name = "btnQuitarFiltroCliente"
        Me.btnQuitarFiltroCliente.Size = New System.Drawing.Size(74, 20)
        Me.btnQuitarFiltroCliente.TabIndex = 1
        Me.btnQuitarFiltroCliente.Text = "Quitar Filtro"
        Me.btnQuitarFiltroCliente.Visible = False
        '
        'btnVistaClientes
        '
        Me.btnVistaClientes.BackColor = System.Drawing.Color.SeaGreen
        Me.btnVistaClientes.Image = CType(resources.GetObject("btnVistaClientes.Image"), System.Drawing.Image)
        Me.btnVistaClientes.Location = New System.Drawing.Point(4, 3)
        Me.btnVistaClientes.Name = "btnVistaClientes"
        Me.btnVistaClientes.Size = New System.Drawing.Size(120, 18)
        Me.btnVistaClientes.TransparentColor = System.Drawing.Color.Black
        '
        'grdClientes
        '
        Me.grdClientes.BackgroundColor = System.Drawing.Color.White
        Me.grdClientes.DataSource = Me.bsClientes
        Me.grdClientes.Location = New System.Drawing.Point(0, 23)
        Me.grdClientes.Name = "grdClientes"
        Me.grdClientes.RowHeadersVisible = False
        Me.grdClientes.Size = New System.Drawing.Size(240, 175)
        Me.grdClientes.TabIndex = 6
        Me.grdClientes.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn1)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn2)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn3)
        Me.DataGridTableStyle1.MappingName = "Clientes"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "Codigo"
        Me.DataGridTextBoxColumn1.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "Nombre"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Est."
        Me.DataGridTextBoxColumn3.MappingName = "EstadoVisita"
        Me.DataGridTextBoxColumn3.Width = 25
        '
        'ToolBar3
        '
        Me.ToolBar3.Buttons.Add(Me.ToolBarButton3)
        Me.ToolBar3.Name = "ToolBar3"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        '
        'pnlVistaPedidos
        '
        Me.pnlVistaPedidos.Controls.Add(Me.lblClientePedido)
        Me.pnlVistaPedidos.Controls.Add(Me.Label4)
        Me.pnlVistaPedidos.Controls.Add(Me.Label5)
        Me.pnlVistaPedidos.Controls.Add(Me.Label6)
        Me.pnlVistaPedidos.Controls.Add(Me.grdPedidos)
        Me.pnlVistaPedidos.Controls.Add(Me.Panel1)
        Me.pnlVistaPedidos.Location = New System.Drawing.Point(0, 0)
        Me.pnlVistaPedidos.Name = "pnlVistaPedidos"
        Me.pnlVistaPedidos.Size = New System.Drawing.Size(240, 267)
        '
        'bsPedidos
        '
        Me.bsPedidos.DataMember = "Pedidos"
        Me.bsPedidos.DataSource = Me.dsNucleo
        Me.bsPedidos.Sort = "Estado, NoPedido"
        '
        'lblClientePedido
        '
        Me.lblClientePedido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Cliente", True))
        Me.lblClientePedido.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblClientePedido.ForeColor = System.Drawing.Color.Black
        Me.lblClientePedido.Location = New System.Drawing.Point(3, 177)
        Me.lblClientePedido.Name = "lblClientePedido"
        Me.lblClientePedido.Size = New System.Drawing.Size(232, 16)
        '
        'Label4
        '
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Observacion", True))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(3, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 18)
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Barrio", True))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(3, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 16)
        '
        'Label6
        '
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPedidos, "Direccion", True))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(3, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 29)
        '
        'grdPedidos
        '
        Me.grdPedidos.BackgroundColor = System.Drawing.Color.White
        Me.grdPedidos.DataSource = Me.bsPedidos
        Me.grdPedidos.Location = New System.Drawing.Point(0, 23)
        Me.grdPedidos.Name = "grdPedidos"
        Me.grdPedidos.RowHeadersVisible = False
        Me.grdPedidos.Size = New System.Drawing.Size(240, 151)
        Me.grdPedidos.TabIndex = 1
        Me.grdPedidos.TableStyles.Add(Me.PedidosTableStyleDataGridTableStyle)
        '
        'PedidosTableStyleDataGridTableStyle
        '
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(NoPedidoDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(CodClienteDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(PrimerServicioDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(RecoleccionDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(EstadoDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.GridColumnStyles.Add(NuevoDataGridColumnStyleDataGridTextBoxColumn)
        Me.PedidosTableStyleDataGridTableStyle.MappingName = "Pedidos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.btnVistaPedidos)
        Me.Panel1.Controls.Add(Me.btnQuitarFiltroPedidos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 24)
        '
        'btnVistaPedidos
        '
        Me.btnVistaPedidos.Image = CType(resources.GetObject("btnVistaPedidos.Image"), System.Drawing.Image)
        Me.btnVistaPedidos.Location = New System.Drawing.Point(3, 3)
        Me.btnVistaPedidos.Name = "btnVistaPedidos"
        Me.btnVistaPedidos.Size = New System.Drawing.Size(121, 19)
        Me.btnVistaPedidos.TransparentColor = System.Drawing.Color.Black
        '
        'btnQuitarFiltroPedidos
        '
        Me.btnQuitarFiltroPedidos.ForeColor = System.Drawing.Color.Yellow
        Me.btnQuitarFiltroPedidos.Location = New System.Drawing.Point(167, 5)
        Me.btnQuitarFiltroPedidos.Name = "btnQuitarFiltroPedidos"
        Me.btnQuitarFiltroPedidos.Size = New System.Drawing.Size(74, 20)
        Me.btnQuitarFiltroPedidos.TabIndex = 2
        Me.btnQuitarFiltroPedidos.Text = "Quitar Filtro"
        Me.btnQuitarFiltroPedidos.Visible = False
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'menuVista
        '
        Me.menuVista.MenuItems.Add(Me.menuVistaClientes)
        Me.menuVista.MenuItems.Add(Me.menuVistaPedidos)
        '
        'menuVistaClientes
        '
        Me.menuVistaClientes.Text = "Vista Clientes"
        '
        'menuVistaPedidos
        '
        Me.menuVistaPedidos.Text = "Vista Pedidos"
        '
        'menuRuteroPedidos
        '
        Me.menuRuteroPedidos.MenuItems.Add(Me.menuRutero2)
        Me.menuRuteroPedidos.MenuItems.Add(Me.MenuItem6)
        '
        'menuRutero2
        '
        Me.menuRutero2.MenuItems.Add(Me.menuBuscarPedido)
        Me.menuRutero2.MenuItems.Add(Me.menuRegresar2)
        Me.menuRutero2.Text = "Rutero"
        '
        'menuBuscarPedido
        '
        Me.menuBuscarPedido.Text = "&Buscar Pedido ..."
        '
        'menuRegresar2
        '
        Me.menuRegresar2.Text = "Regresar"
        '
        'MenuItem6
        '
        Me.MenuItem6.MenuItems.Add(Me.menuAtencionPedido)
        Me.MenuItem6.MenuItems.Add(Me.menuDireccionesEntrega2)
        Me.MenuItem6.MenuItems.Add(Me.menuInformacionCliente2)
        Me.MenuItem6.Text = "Pedido"
        '
        'menuAtencionPedido
        '
        Me.menuAtencionPedido.Text = "&Atención Pédido..."
        '
        'menuDireccionesEntrega2
        '
        Me.menuDireccionesEntrega2.Text = "&Direcciones Entrega..."
        '
        'menuInformacionCliente2
        '
        Me.menuInformacionCliente2.Text = "&Información Cliente..."
        '
        'timerNovedades
        '
        Me.timerNovedades.Interval = 10000
        '
        'pnlIniciando
        '
        Me.pnlIniciando.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlIniciando.Controls.Add(Me.AnimateCtl1)
        Me.pnlIniciando.Controls.Add(Me.lblMensajeProceso)
        Me.pnlIniciando.Controls.Add(Me.Shape1)
        Me.pnlIniciando.Location = New System.Drawing.Point(25, 103)
        Me.pnlIniciando.Name = "pnlIniciando"
        Me.pnlIniciando.Size = New System.Drawing.Size(190, 62)
        Me.pnlIniciando.Visible = False
        '
        'AnimateCtl1
        '
        Me.AnimateCtl1.DelayInterval = 200        
        Me.AnimateCtl1.FrameHeight = 11
        Me.AnimateCtl1.FrameWidth = 45
        Me.AnimateCtl1.Height = 11
        Me.AnimateCtl1.Image = CType(resources.GetObject("AnimateCtl1.Image"), System.Drawing.Image)
        Me.AnimateCtl1.Location = New System.Drawing.Point(73, 36)
        Me.AnimateCtl1.LoopCount = 0
        Me.AnimateCtl1.Name = "AnimateCtl1"
        Me.AnimateCtl1.Size = New System.Drawing.Size(45, 11)
        Me.AnimateCtl1.TabIndex = 2
        Me.AnimateCtl1.Width = 45
        '
        'lblMensajeProceso
        '
        Me.lblMensajeProceso.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblMensajeProceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeProceso.Location = New System.Drawing.Point(14, 13)
        Me.lblMensajeProceso.Name = "lblMensajeProceso"
        Me.lblMensajeProceso.Size = New System.Drawing.Size(162, 20)
        Me.lblMensajeProceso.Text = "Cargando Datos..."
        Me.lblMensajeProceso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Shape1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(190, 62)
        Me.Shape1.TabIndex = 1
        Me.Shape1.Text = "Shape1"
        '
        'RuteroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlIniciando)
        Me.Controls.Add(Me.pnlVistaPedidos)
        Me.Controls.Add(Me.pnlVistaClientes)
        Me.KeyPreview = True
        Me.Menu = Me.menuRuteroClientes
        Me.Name = "RuteroForm"
        Me.Text = "Praxair"
        Me.pnlVistaClientes.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlVistaPedidos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlIniciando.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents menuRutero As System.Windows.Forms.MenuItem
    Friend WithEvents menuBuscarCliente As System.Windows.Forms.MenuItem
    Friend WithEvents menuCliente As System.Windows.Forms.MenuItem
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents pnlVistaClientes As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grdClientes As System.Windows.Forms.DataGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar3 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents menuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents menuDireccionesCliente As System.Windows.Forms.MenuItem
    Friend WithEvents menuPedidosCliente As System.Windows.Forms.MenuItem
    Friend WithEvents pnlVistaPedidos As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents menuInformacionCliente As System.Windows.Forms.MenuItem
    Friend WithEvents btnQuitarFiltroCliente As System.Windows.Forms.LinkLabel
    Friend WithEvents bsPedidos As System.Windows.Forms.BindingSource
    Friend WithEvents grdPedidos As System.Windows.Forms.DataGrid
    Friend WithEvents PedidosTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnQuitarFiltroPedidos As System.Windows.Forms.LinkLabel
    Friend WithEvents btnVistaPedidos As OpenNETCF.Windows.Forms.PictureBox2
    Friend WithEvents btnVistaClientes As OpenNETCF.Windows.Forms.PictureBox2
    Friend WithEvents menuVista As System.Windows.Forms.ContextMenu
    Friend WithEvents menuVistaClientes As System.Windows.Forms.MenuItem
    Friend WithEvents menuVistaPedidos As System.Windows.Forms.MenuItem
    Private WithEvents menuRuteroPedidos As System.Windows.Forms.MainMenu
    Friend WithEvents menuRutero2 As System.Windows.Forms.MenuItem
    Friend WithEvents menuBuscarPedido As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents menuDireccionesEntrega2 As System.Windows.Forms.MenuItem
    Friend WithEvents menuAtencionPedido As System.Windows.Forms.MenuItem
    Friend WithEvents menuInformacionCliente2 As System.Windows.Forms.MenuItem
    Friend WithEvents lblClientePedido As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents timerNovedades As System.Windows.Forms.Timer
    Friend WithEvents menuRegresar2 As System.Windows.Forms.MenuItem
    Friend WithEvents pnlIniciando As System.Windows.Forms.Panel
    Friend WithEvents AnimateCtl1 As OpenNETCF.Windows.Forms.AnimateCtl
    Friend WithEvents lblMensajeProceso As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
End Class
