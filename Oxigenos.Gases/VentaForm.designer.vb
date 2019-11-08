<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VentaForm
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
        Me.mnuServicio = New System.Windows.Forms.MenuItem
        Me.menuLectura = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnuCancelar = New System.Windows.Forms.MenuItem
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblNoPedido = New System.Windows.Forms.Label
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPedidos = New Oxigenos.Gases.PedidosDataSet
        Me.lblCredito = New System.Windows.Forms.Label
        Me.lblCantidadAjeno = New System.Windows.Forms.Label
        Me.lblContado = New System.Windows.Forms.Label
        Me.lblCantidadPraxair = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.txtCantidadRecoger = New DatascanCF.Windows.Forms.NumericInputBox
        Me.lblQRecoger = New System.Windows.Forms.Label
        Me.btnAux = New System.Windows.Forms.Button
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.grdDetallePedido = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CodProducto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Capacidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CantidadPedida = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CantidadReal = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Asignaciones = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Recolecciones = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lblQAsignar = New System.Windows.Forms.Label
        Me.lblQAsignada = New System.Windows.Forms.Label
        Me.txtQReal = New System.Windows.Forms.Label
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.mnuServicio)
        Me.MenuItem1.MenuItems.Add(Me.menuLectura)
        Me.MenuItem1.MenuItems.Add(Me.MenuItem7)
        Me.MenuItem1.MenuItems.Add(Me.mnuCancelar)
        Me.MenuItem1.Text = "Venta"
        '
        'mnuServicio
        '
        Me.mnuServicio.Text = "&Servicio"
        '
        'menuLectura
        '
        Me.menuLectura.Text = "&Lectura"
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = "-"
        '
        'mnuCancelar
        '
        Me.mnuCancelar.Text = "Regresar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.lblNoPedido)
        Me.Panel3.Controls.Add(Me.lblTitulo)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 34)
        '
        'lblNoPedido
        '
        Me.lblNoPedido.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoPedido.ForeColor = System.Drawing.Color.White
        Me.lblNoPedido.Location = New System.Drawing.Point(161, 16)
        Me.lblNoPedido.Name = "lblNoPedido"
        Me.lblNoPedido.Size = New System.Drawing.Size(84, 18)
        Me.lblNoPedido.Text = "1234567890"
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(162, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(53, 14)
        Me.lblTitulo.Text = "No.Ped."
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(126, 20)
        Me.Label21.Text = "Atención Venta"
        '
        'bsDetallePedido
        '
        Me.bsDetallePedido.DataMember = "DetallePedido"
        Me.bsDetallePedido.DataSource = Me.dsPedidos
        '
        'dsPedidos
        '
        Me.dsPedidos.DataSetName = "PedidosDataSet"
        Me.dsPedidos.Prefix = ""
        Me.dsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCredito
        '
        Me.lblCredito.BackColor = System.Drawing.Color.SkyBlue
        Me.lblCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasCredito", True))
        Me.lblCredito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCredito.Location = New System.Drawing.Point(177, 195)
        Me.lblCredito.Name = "lblCredito"
        Me.lblCredito.Size = New System.Drawing.Size(52, 20)
        Me.lblCredito.Text = "0"
        Me.lblCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCantidadAjeno
        '
        Me.lblCantidadAjeno.BackColor = System.Drawing.Color.SkyBlue
        Me.lblCantidadAjeno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasCliente", True))
        Me.lblCantidadAjeno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidadAjeno.Location = New System.Drawing.Point(177, 175)
        Me.lblCantidadAjeno.Name = "lblCantidadAjeno"
        Me.lblCantidadAjeno.Size = New System.Drawing.Size(52, 20)
        Me.lblCantidadAjeno.Text = "0"
        Me.lblCantidadAjeno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblContado
        '
        Me.lblContado.BackColor = System.Drawing.Color.SkyBlue
        Me.lblContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasContado", True))
        Me.lblContado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblContado.Location = New System.Drawing.Point(58, 195)
        Me.lblContado.Name = "lblContado"
        Me.lblContado.Size = New System.Drawing.Size(52, 20)
        Me.lblContado.Text = "0"
        Me.lblContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCantidadPraxair
        '
        Me.lblCantidadPraxair.BackColor = System.Drawing.Color.SkyBlue
        Me.lblCantidadPraxair.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasPraxair", True))
        Me.lblCantidadPraxair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCantidadPraxair.Location = New System.Drawing.Point(58, 175)
        Me.lblCantidadPraxair.Name = "lblCantidadPraxair"
        Me.lblCantidadPraxair.Size = New System.Drawing.Size(52, 20)
        Me.lblCantidadPraxair.Text = "0"
        Me.lblCantidadPraxair.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(118, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 20)
        Me.Label4.Text = "Q. Cred:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(118, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.Text = "Q. Ajen:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.Text = "Q. Cont:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.Text = "Q. Prax:"
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "DescripcionProducto", True))
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionProducto.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(3, 146)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(233, 29)
        '
        'txtCantidadRecoger
        '
        Me.txtCantidadRecoger.AcceptZero = False
        Me.txtCantidadRecoger.AllowNegative = False
        Me.txtCantidadRecoger.BackColor = System.Drawing.Color.Yellow
        Me.txtCantidadRecoger.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "Recolecciones", True))
        Me.txtCantidadRecoger.Decimals = 0
        Me.txtCantidadRecoger.ErrorMessage = ""
        Me.txtCantidadRecoger.Format = ""
        Me.txtCantidadRecoger.HelpText = Nothing
        Me.txtCantidadRecoger.Location = New System.Drawing.Point(73, 242)
        Me.txtCantidadRecoger.MaxLength = 2
        Me.txtCantidadRecoger.Name = "txtCantidadRecoger"
        Me.txtCantidadRecoger.Required = False
        Me.txtCantidadRecoger.Size = New System.Drawing.Size(37, 21)
        Me.txtCantidadRecoger.TabIndex = 48
        Me.txtCantidadRecoger.TabOnEnter = True
        Me.txtCantidadRecoger.Visible = False
        '
        'lblQRecoger
        '
        Me.lblQRecoger.Location = New System.Drawing.Point(3, 242)
        Me.lblQRecoger.Name = "lblQRecoger"
        Me.lblQRecoger.Size = New System.Drawing.Size(72, 20)
        Me.lblQRecoger.Text = "Q.Recoger:"
        Me.lblQRecoger.Visible = False
        '
        'btnAux
        '
        Me.btnAux.Location = New System.Drawing.Point(148, 237)
        Me.btnAux.Name = "btnAux"
        Me.btnAux.Size = New System.Drawing.Size(81, 20)
        Me.btnAux.TabIndex = 60
        Me.btnAux.Text = "&Modificar"
        Me.btnAux.Visible = False
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'grdDetallePedido
        '
        Me.grdDetallePedido.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdDetallePedido.DataSource = Me.bsDetallePedido
        Me.grdDetallePedido.Location = New System.Drawing.Point(0, 30)
        Me.grdDetallePedido.Name = "grdDetallePedido"
        Me.grdDetallePedido.Size = New System.Drawing.Size(240, 113)
        Me.grdDetallePedido.TabIndex = 72
        Me.grdDetallePedido.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.CodProducto)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Capacidad)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.CantidadPedida)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.CantidadReal)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Asignaciones)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Recolecciones)
        Me.DataGridTableStyle1.MappingName = "DetallePedido"
        '
        'CodProducto
        '
        Me.CodProducto.Format = ""
        Me.CodProducto.FormatInfo = Nothing
        Me.CodProducto.HeaderText = "Cod.Prod."
        Me.CodProducto.MappingName = "CodProducto"
        Me.CodProducto.NullText = ""
        Me.CodProducto.Width = 55
        '
        'Capacidad
        '
        Me.Capacidad.Format = "###,##0"
        Me.Capacidad.FormatInfo = Nothing
        Me.Capacidad.HeaderText = "Capa."
        Me.Capacidad.MappingName = "CapacidadNumerico"
        Me.Capacidad.NullText = ""
        Me.Capacidad.Width = 40
        '
        'CantidadPedida
        '
        Me.CantidadPedida.Format = ""
        Me.CantidadPedida.FormatInfo = Nothing
        Me.CantidadPedida.HeaderText = "Q.Ped."
        Me.CantidadPedida.MappingName = "UnidadesPedidas"
        Me.CantidadPedida.NullText = "0"
        Me.CantidadPedida.Width = 40
        '
        'CantidadReal
        '
        Me.CantidadReal.Format = ""
        Me.CantidadReal.FormatInfo = Nothing
        Me.CantidadReal.HeaderText = "Q.Real"
        Me.CantidadReal.MappingName = "UnidadesReales"
        Me.CantidadReal.NullText = "0"
        Me.CantidadReal.Width = 40
        '
        'Asignaciones
        '
        Me.Asignaciones.Format = ""
        Me.Asignaciones.FormatInfo = Nothing
        Me.Asignaciones.HeaderText = "Q.Asig."
        Me.Asignaciones.MappingName = "Asignaciones"
        Me.Asignaciones.NullText = "0"
        Me.Asignaciones.Width = 40
        '
        'Recolecciones
        '
        Me.Recolecciones.Format = ""
        Me.Recolecciones.FormatInfo = Nothing
        Me.Recolecciones.HeaderText = "Q.Recog."
        Me.Recolecciones.MappingName = "Recolecciones"
        Me.Recolecciones.NullText = "0"
        '
        'lblQAsignar
        '
        Me.lblQAsignar.Location = New System.Drawing.Point(3, 219)
        Me.lblQAsignar.Name = "lblQAsignar"
        Me.lblQAsignar.Size = New System.Drawing.Size(52, 20)
        Me.lblQAsignar.Text = "Q.Real:"
        Me.lblQAsignar.Visible = False
        '
        'lblQAsignada
        '
        Me.lblQAsignada.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "Asignaciones", True))
        Me.lblQAsignada.Location = New System.Drawing.Point(116, 237)
        Me.lblQAsignada.Name = "lblQAsignada"
        Me.lblQAsignada.Size = New System.Drawing.Size(26, 20)
        Me.lblQAsignada.Visible = False
        '
        'txtQReal
        '
        Me.txtQReal.BackColor = System.Drawing.Color.LimeGreen
        Me.txtQReal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesReales", True))
        Me.txtQReal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtQReal.Location = New System.Drawing.Point(58, 219)
        Me.txtQReal.Name = "txtQReal"
        Me.txtQReal.Size = New System.Drawing.Size(52, 20)
        Me.txtQReal.Text = "0"
        Me.txtQReal.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.txtQReal.Visible = False
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtQReal)
        Me.Controls.Add(Me.lblQAsignada)
        Me.Controls.Add(Me.lblQAsignar)
        Me.Controls.Add(Me.grdDetallePedido)
        Me.Controls.Add(Me.btnAux)
        Me.Controls.Add(Me.txtCantidadRecoger)
        Me.Controls.Add(Me.lblQRecoger)
        Me.Controls.Add(Me.lblCredito)
        Me.Controls.Add(Me.lblCantidadAjeno)
        Me.Controls.Add(Me.lblContado)
        Me.Controls.Add(Me.lblCantidadPraxair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDescripcionProducto)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "VentaForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuServicio As System.Windows.Forms.MenuItem
    Friend WithEvents menuLectura As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents lblCredito As System.Windows.Forms.Label
    Friend WithEvents lblCantidadAjeno As System.Windows.Forms.Label
    Friend WithEvents lblContado As System.Windows.Forms.Label
    Friend WithEvents lblCantidadPraxair As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents dsPedidos As Oxigenos.Gases.PedidosDataSet
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents txtCantidadRecoger As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents lblQRecoger As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents mnuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents btnAux As System.Windows.Forms.Button
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents grdDetallePedido As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CodProducto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Capacidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CantidadPedida As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CantidadReal As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Asignaciones As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Recolecciones As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblQAsignar As System.Windows.Forms.Label
    Friend WithEvents lblNoPedido As System.Windows.Forms.Label
    Friend WithEvents lblQAsignada As System.Windows.Forms.Label
    Friend WithEvents txtQReal As System.Windows.Forms.Label
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
End Class
