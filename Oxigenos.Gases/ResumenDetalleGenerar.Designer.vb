<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ResumenDetalleGenerar
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPedidos = New Oxigenos.Gases.PedidosDataSet
        Me.grdDetalle = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblQPraxair = New System.Windows.Forms.Label
        Me.lblQContado = New System.Windows.Forms.Label
        Me.lblQCredito = New System.Windows.Forms.Label
        Me.lblQAjeno = New System.Windows.Forms.Label
        Me.btnPrecio = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 31)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(172, 20)
        Me.Label21.Text = "Entrega de Productos"
        '
        'bsDetallePedido
        '
        Me.bsDetallePedido.DataMember = "DetallePedido"
        Me.bsDetallePedido.DataSource = Me.dsPedidos
        Me.bsDetallePedido.Filter = "UnidadesReales > 0"
        '
        'dsPedidos
        '
        Me.dsPedidos.DataSetName = "PedidosDataSet"
        Me.dsPedidos.Prefix = ""
        Me.dsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdDetalle
        '
        Me.grdDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdDetalle.DataSource = Me.bsDetallePedido
        Me.grdDetalle.Location = New System.Drawing.Point(0, 27)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.Size = New System.Drawing.Size(240, 137)
        Me.grdDetalle.TabIndex = 2
        Me.grdDetalle.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn1)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn2)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn3)
        Me.DataGridTableStyle1.MappingName = "DetallePedido"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod. Producto"
        Me.DataGridTextBoxColumn1.MappingName = "CodProducto"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 90
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = "###,##0"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Capacidad"
        Me.DataGridTextBoxColumn2.MappingName = "CapacidadNumerico"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Q.Real"
        Me.DataGridTextBoxColumn3.MappingName = "UnidadesReales"
        Me.DataGridTextBoxColumn3.NullText = "0"
        Me.DataGridTextBoxColumn3.Width = 55
        '
        'lblDescripcion
        '
        Me.lblDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "DescripcionProducto", True))
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 166)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(234, 32)
        Me.lblDescripcion.Text = "Descripcion Producto rrrrrrrrrrrrrrrrrrrrrrrrrrrrr"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.Text = "Q. Prax:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.Text = "Q. Cont:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(123, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 20)
        Me.Label4.Text = "Q. Cred:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(123, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.Text = "Q. Ajen:"
        '
        'lblQPraxair
        '
        Me.lblQPraxair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQPraxair.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasPraxair", True))
        Me.lblQPraxair.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQPraxair.Location = New System.Drawing.Point(67, 199)
        Me.lblQPraxair.Name = "lblQPraxair"
        Me.lblQPraxair.Size = New System.Drawing.Size(42, 20)
        Me.lblQPraxair.Text = "0"
        Me.lblQPraxair.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQContado
        '
        Me.lblQContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasContado", True))
        Me.lblQContado.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQContado.Location = New System.Drawing.Point(67, 219)
        Me.lblQContado.Name = "lblQContado"
        Me.lblQContado.Size = New System.Drawing.Size(42, 20)
        Me.lblQContado.Text = "0"
        Me.lblQContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQCredito
        '
        Me.lblQCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasCredito", True))
        Me.lblQCredito.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQCredito.Location = New System.Drawing.Point(184, 219)
        Me.lblQCredito.Name = "lblQCredito"
        Me.lblQCredito.Size = New System.Drawing.Size(46, 20)
        Me.lblQCredito.Text = "0"
        Me.lblQCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQAjeno
        '
        Me.lblQAjeno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblQAjeno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasCliente", True))
        Me.lblQAjeno.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblQAjeno.Location = New System.Drawing.Point(184, 199)
        Me.lblQAjeno.Name = "lblQAjeno"
        Me.lblQAjeno.Size = New System.Drawing.Size(46, 20)
        Me.lblQAjeno.Text = "0"
        Me.lblQAjeno.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPrecio
        '
        Me.btnPrecio.Location = New System.Drawing.Point(6, 245)
        Me.btnPrecio.Name = "btnPrecio"
        Me.btnPrecio.Size = New System.Drawing.Size(72, 20)
        Me.btnPrecio.TabIndex = 19
        Me.btnPrecio.Text = "&Precio"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(159, 245)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(72, 20)
        Me.btnSiguiente.TabIndex = 20
        Me.btnSiguiente.Text = "&Siguiente"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(84, 245)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(72, 20)
        Me.btnRegresar.TabIndex = 21
        Me.btnRegresar.Text = "Regresar"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'ResumenDetalleGenerar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnPrecio)
        Me.Controls.Add(Me.lblQAjeno)
        Me.Controls.Add(Me.lblQCredito)
        Me.Controls.Add(Me.lblQContado)
        Me.Controls.Add(Me.lblQPraxair)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.grdDetalle)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "ResumenDetalleGenerar"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents grdDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblQPraxair As System.Windows.Forms.Label
    Friend WithEvents lblQContado As System.Windows.Forms.Label
    Friend WithEvents lblQCredito As System.Windows.Forms.Label
    Friend WithEvents lblQAjeno As System.Windows.Forms.Label
    Friend WithEvents btnPrecio As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents dsPedidos As Oxigenos.Gases.PedidosDataSet
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
