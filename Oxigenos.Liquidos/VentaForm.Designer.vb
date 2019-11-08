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
        Dim MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim CantidadDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim PrecioTotalDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Dim CodTanqueDataGridColumnStyleDataGridTextBoxColumn As System.Windows.Forms.DataGridTextBoxColumn
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuTerminar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.menuNuevaEntrega = New System.Windows.Forms.MenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVenta = New Oxigenos.Liquidos.VentaDataSet
        Me.DetallePedidoDataGrid = New System.Windows.Forms.DataGrid
        Me.DetallePedidoTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblTotalVenta = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlVenta = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.bsTanquesCliente = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTanque = New System.Windows.Forms.ComboBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.rbtnPorCaudalimetro = New System.Windows.Forms.RadioButton
        Me.rbtnPorPesoTanque = New System.Windows.Forms.RadioButton
        Me.rbtnPorPesoCamion = New System.Windows.Forms.RadioButton
        Me.rbtnNiveles = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        CantidadDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel2.SuspendLayout()
        Me.pnlVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn
        '
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Tipo"
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn.MappingName = "MetodoEntrega"
        MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn.Width = 30
        '
        'CantidadDataGridColumnStyleDataGridTextBoxColumn
        '
        CantidadDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        CantidadDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        CantidadDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Cantidad"
        CantidadDataGridColumnStyleDataGridTextBoxColumn.MappingName = "Cantidad"
        '
        'PrecioTotalDataGridColumnStyleDataGridTextBoxColumn
        '
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Prc. Total"
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn.MappingName = "PrecioTotal"
        PrecioTotalDataGridColumnStyleDataGridTextBoxColumn.Width = 70
        '
        'CodTanqueDataGridColumnStyleDataGridTextBoxColumn
        '
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn.Format = ""
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn.FormatInfo = Nothing
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn.HeaderText = "Tanque"
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn.MappingName = "CodTanque"
        CodTanqueDataGridColumnStyleDataGridTextBoxColumn.Width = 80
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.menuNuevaEntrega)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuTerminar)
        Me.MenuItem1.MenuItems.Add(Me.menuCancelar)
        Me.MenuItem1.Text = "Venta"
        '
        'menuTerminar
        '
        Me.menuTerminar.Text = "Terminar"
        '
        'menuCancelar
        '
        Me.menuCancelar.Text = "Cancelar"
        '
        'menuNuevaEntrega
        '
        Me.menuNuevaEntrega.Text = "&Nueva"
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
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.Text = "Ventas"
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
        'DetallePedidoDataGrid
        '
        Me.DetallePedidoDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DetallePedidoDataGrid.DataSource = Me.bsDetallePedido
        Me.DetallePedidoDataGrid.Location = New System.Drawing.Point(0, 27)
        Me.DetallePedidoDataGrid.Name = "DetallePedidoDataGrid"
        Me.DetallePedidoDataGrid.RowHeadersVisible = False
        Me.DetallePedidoDataGrid.Size = New System.Drawing.Size(240, 144)
        Me.DetallePedidoDataGrid.TabIndex = 0
        Me.DetallePedidoDataGrid.TableStyles.Add(Me.DetallePedidoTableStyleDataGridTableStyle)
        '
        'DetallePedidoTableStyleDataGridTableStyle
        '
        Me.DetallePedidoTableStyleDataGridTableStyle.GridColumnStyles.Add(CodTanqueDataGridColumnStyleDataGridTextBoxColumn)
        Me.DetallePedidoTableStyleDataGridTableStyle.GridColumnStyles.Add(MetodoEntregaDataGridColumnStyleDataGridTextBoxColumn)
        Me.DetallePedidoTableStyleDataGridTableStyle.GridColumnStyles.Add(CantidadDataGridColumnStyleDataGridTextBoxColumn)
        Me.DetallePedidoTableStyleDataGridTableStyle.GridColumnStyles.Add(PrecioTotalDataGridColumnStyleDataGridTextBoxColumn)
        Me.DetallePedidoTableStyleDataGridTableStyle.MappingName = "DetallePedido"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.Text = "Total Venta:"
        '
        'lblTotalVenta
        '
        Me.lblTotalVenta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVenta.Location = New System.Drawing.Point(84, 237)
        Me.lblTotalVenta.Name = "lblTotalVenta"
        Me.lblTotalVenta.Size = New System.Drawing.Size(153, 20)
        Me.lblTotalVenta.Text = "$0.00"
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(-1, 224)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(241, 10)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.TopLine
        Me.Shape1.TabIndex = 6
        Me.Shape1.Text = "Shape1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 20)
        '
        'pnlVenta
        '
        Me.pnlVenta.BackColor = System.Drawing.Color.Honeydew
        Me.pnlVenta.Controls.Add(Me.Label4)
        Me.pnlVenta.Controls.Add(Me.cbTanque)
        Me.pnlVenta.Controls.Add(Me.btnCancelar)
        Me.pnlVenta.Controls.Add(Me.btnContinuar)
        Me.pnlVenta.Controls.Add(Me.rbtnPorCaudalimetro)
        Me.pnlVenta.Controls.Add(Me.rbtnPorPesoTanque)
        Me.pnlVenta.Controls.Add(Me.rbtnPorPesoCamion)
        Me.pnlVenta.Controls.Add(Me.rbtnNiveles)
        Me.pnlVenta.Controls.Add(Me.Label3)
        Me.pnlVenta.Location = New System.Drawing.Point(-1, 27)
        Me.pnlVenta.Name = "pnlVenta"
        Me.pnlVenta.Size = New System.Drawing.Size(241, 241)
        Me.pnlVenta.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "Método Entrega:"
        '
        'bsTanquesCliente
        '
        Me.bsTanquesCliente.DataMember = "TanquesCliente"
        Me.bsTanquesCliente.DataSource = Me.dsVenta
        '
        'cbTanque
        '
        Me.cbTanque.DataSource = Me.bsTanquesCliente
        Me.cbTanque.DisplayMember = "Descripcion"
        Me.cbTanque.Location = New System.Drawing.Point(5, 28)
        Me.cbTanque.Name = "cbTanque"
        Me.cbTanque.Size = New System.Drawing.Size(233, 22)
        Me.cbTanque.TabIndex = 0
        Me.cbTanque.ValueMember = "NoTanque"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(166, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(86, 210)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(72, 20)
        Me.btnContinuar.TabIndex = 5
        Me.btnContinuar.Text = "Continuar"
        '
        'rbtnPorCaudalimetro
        '
        Me.rbtnPorCaudalimetro.Location = New System.Drawing.Point(33, 165)
        Me.rbtnPorCaudalimetro.Name = "rbtnPorCaudalimetro"
        Me.rbtnPorCaudalimetro.Size = New System.Drawing.Size(152, 17)
        Me.rbtnPorCaudalimetro.TabIndex = 4
        Me.rbtnPorCaudalimetro.TabStop = False
        Me.rbtnPorCaudalimetro.Text = " Por Caudalimetro"
        '
        'rbtnPorPesoTanque
        '
        Me.rbtnPorPesoTanque.Location = New System.Drawing.Point(33, 139)
        Me.rbtnPorPesoTanque.Name = "rbtnPorPesoTanque"
        Me.rbtnPorPesoTanque.Size = New System.Drawing.Size(141, 20)
        Me.rbtnPorPesoTanque.TabIndex = 3
        Me.rbtnPorPesoTanque.TabStop = False
        Me.rbtnPorPesoTanque.Text = "Por Peso Tanque"
        '
        'rbtnPorPesoCamion
        '
        Me.rbtnPorPesoCamion.Location = New System.Drawing.Point(33, 113)
        Me.rbtnPorPesoCamion.Name = "rbtnPorPesoCamion"
        Me.rbtnPorPesoCamion.Size = New System.Drawing.Size(141, 17)
        Me.rbtnPorPesoCamion.TabIndex = 2
        Me.rbtnPorPesoCamion.TabStop = False
        Me.rbtnPorPesoCamion.Text = " Por Peso Camion"
        '
        'rbtnNiveles
        '
        Me.rbtnNiveles.Checked = True
        Me.rbtnNiveles.Location = New System.Drawing.Point(33, 87)
        Me.rbtnNiveles.Name = "rbtnNiveles"
        Me.rbtnNiveles.Size = New System.Drawing.Size(100, 17)
        Me.rbtnNiveles.TabIndex = 1
        Me.rbtnNiveles.Text = " Por Niveles"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Tanque:"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'VentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Shape1)
        Me.Controls.Add(Me.lblTotalVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DetallePedidoDataGrid)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.mainMenu1
        Me.Name = "VentaForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.pnlVenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents menuTerminar As System.Windows.Forms.MenuItem
    Friend WithEvents dsVenta As Oxigenos.Liquidos.VentaDataSet
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents DetallePedidoDataGrid As System.Windows.Forms.DataGrid
    Friend WithEvents DetallePedidoTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents menuNuevaEntrega As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalVenta As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlVenta As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbTanque As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents rbtnPorCaudalimetro As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPorPesoTanque As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPorPesoCamion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNiveles As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bsTanquesCliente As System.Windows.Forms.BindingSource
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
End Class
