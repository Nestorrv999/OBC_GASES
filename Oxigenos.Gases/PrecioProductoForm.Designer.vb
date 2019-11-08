<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PrecioProductoForm
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
        Me.mnuRegresar = New System.Windows.Forms.MenuItem
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPedidos = New Oxigenos.Gases.PedidosDataSet
        Me.lblCodProducto = New System.Windows.Forms.Label
        Me.lblCapacidad = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblPrecioContado = New System.Windows.Forms.Label
        Me.lblDescuentoContado = New System.Windows.Forms.Label
        Me.lblImpuestoContado = New System.Windows.Forms.Label
        Me.lblTotalContado = New System.Windows.Forms.Label
        Me.lblTotalCredito = New System.Windows.Forms.Label
        Me.lblImpuestoCredito = New System.Windows.Forms.Label
        Me.lblDescuentoCredito = New System.Windows.Forms.Label
        Me.lblPrecioCredito = New System.Windows.Forms.Label
        Me.lblCantidadCredito = New System.Windows.Forms.Label
        Me.lblCantidadContado = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.mnuRegresar)
        Me.MenuItem1.Text = "Opciones"
        '
        'mnuRegresar
        '
        Me.mnuRegresar.Text = "Regresar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.lblTitulo)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 31)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(3, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(155, 20)
        Me.lblTitulo.Text = "Precio Producto"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.Text = "Producto:"
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
        'lblCodProducto
        '
        Me.lblCodProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "CodProducto", True))
        Me.lblCodProducto.Location = New System.Drawing.Point(79, 41)
        Me.lblCodProducto.Name = "lblCodProducto"
        Me.lblCodProducto.Size = New System.Drawing.Size(110, 20)
        '
        'lblCapacidad
        '
        Me.lblCapacidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "CapacidadNumerico", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,##0"))
        Me.lblCapacidad.Location = New System.Drawing.Point(79, 63)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(110, 20)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(3, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.Text = "Capacidad:"
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "DescripcionProducto", True))
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(3, 86)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(234, 30)
        Me.lblDescripcionProducto.Text = "OXIGENO CIL. MEDICINAL"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.Location = New System.Drawing.Point(84, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.Text = "Contado"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.Location = New System.Drawing.Point(164, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.Text = "Crédito"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 15)
        Me.Label5.Text = "Pre. Uni."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(3, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.Text = "Desc."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 15)
        Me.Label7.Text = "Imp."
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(3, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 15)
        Me.Label8.Text = "Total."
        '
        'lblPrecioContado
        '
        Me.lblPrecioContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrecioContado.Location = New System.Drawing.Point(84, 168)
        Me.lblPrecioContado.Name = "lblPrecioContado"
        Me.lblPrecioContado.Size = New System.Drawing.Size(58, 15)
        Me.lblPrecioContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescuentoContado
        '
        Me.lblDescuentoContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuentoContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "TotalDescuentoContado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblDescuentoContado.Location = New System.Drawing.Point(84, 187)
        Me.lblDescuentoContado.Name = "lblDescuentoContado"
        Me.lblDescuentoContado.Size = New System.Drawing.Size(58, 15)
        Me.lblDescuentoContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpuestoContado
        '
        Me.lblImpuestoContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblImpuestoContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "TotalIvaContado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblImpuestoContado.Location = New System.Drawing.Point(84, 207)
        Me.lblImpuestoContado.Name = "lblImpuestoContado"
        Me.lblImpuestoContado.Size = New System.Drawing.Size(58, 15)
        Me.lblImpuestoContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalContado
        '
        Me.lblTotalContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotalContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "MontoTotalContado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblTotalContado.Location = New System.Drawing.Point(84, 225)
        Me.lblTotalContado.Name = "lblTotalContado"
        Me.lblTotalContado.Size = New System.Drawing.Size(58, 15)
        Me.lblTotalContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalCredito
        '
        Me.lblTotalCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotalCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "MontoTotalCredito", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblTotalCredito.Location = New System.Drawing.Point(164, 225)
        Me.lblTotalCredito.Name = "lblTotalCredito"
        Me.lblTotalCredito.Size = New System.Drawing.Size(58, 15)
        Me.lblTotalCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpuestoCredito
        '
        Me.lblImpuestoCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblImpuestoCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "TotalIvaCredito", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblImpuestoCredito.Location = New System.Drawing.Point(164, 207)
        Me.lblImpuestoCredito.Name = "lblImpuestoCredito"
        Me.lblImpuestoCredito.Size = New System.Drawing.Size(58, 15)
        Me.lblImpuestoCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescuentoCredito
        '
        Me.lblDescuentoCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuentoCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "TotalDescuentoCredito", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblDescuentoCredito.Location = New System.Drawing.Point(164, 187)
        Me.lblDescuentoCredito.Name = "lblDescuentoCredito"
        Me.lblDescuentoCredito.Size = New System.Drawing.Size(58, 15)
        Me.lblDescuentoCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrecioCredito
        '
        Me.lblPrecioCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrecioCredito.Location = New System.Drawing.Point(164, 168)
        Me.lblPrecioCredito.Name = "lblPrecioCredito"
        Me.lblPrecioCredito.Size = New System.Drawing.Size(58, 15)
        Me.lblPrecioCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCantidadCredito
        '
        Me.lblCantidadCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCantidadCredito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasCredito", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblCantidadCredito.Location = New System.Drawing.Point(164, 149)
        Me.lblCantidadCredito.Name = "lblCantidadCredito"
        Me.lblCantidadCredito.Size = New System.Drawing.Size(58, 15)
        Me.lblCantidadCredito.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCantidadContado
        '
        Me.lblCantidadContado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCantidadContado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "UnidadesVendidasContado", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0", "###,###,###"))
        Me.lblCantidadContado.Location = New System.Drawing.Point(84, 149)
        Me.lblCantidadContado.Name = "lblCantidadContado"
        Me.lblCantidadContado.Size = New System.Drawing.Size(58, 15)
        Me.lblCantidadContado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(3, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 15)
        Me.Label11.Text = "Cantidad."
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'PrecioProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCantidadCredito)
        Me.Controls.Add(Me.lblCantidadContado)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblTotalCredito)
        Me.Controls.Add(Me.lblImpuestoCredito)
        Me.Controls.Add(Me.lblDescuentoCredito)
        Me.Controls.Add(Me.lblPrecioCredito)
        Me.Controls.Add(Me.lblTotalContado)
        Me.Controls.Add(Me.lblImpuestoContado)
        Me.Controls.Add(Me.lblDescuentoContado)
        Me.Controls.Add(Me.lblPrecioContado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDescripcionProducto)
        Me.Controls.Add(Me.lblCapacidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCodProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Menu = Me.mainMenu1
        Me.Name = "PrecioProductoForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCodProducto As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPrecioContado As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoContado As System.Windows.Forms.Label
    Friend WithEvents lblImpuestoContado As System.Windows.Forms.Label
    Friend WithEvents lblTotalContado As System.Windows.Forms.Label
    Friend WithEvents lblTotalCredito As System.Windows.Forms.Label
    Friend WithEvents lblImpuestoCredito As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoCredito As System.Windows.Forms.Label
    Friend WithEvents lblPrecioCredito As System.Windows.Forms.Label
    Friend WithEvents dsPedidos As Oxigenos.Gases.PedidosDataSet
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents lblCantidadCredito As System.Windows.Forms.Label
    Friend WithEvents lblCantidadContado As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
