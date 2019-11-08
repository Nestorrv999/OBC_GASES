<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class GeneracionForm
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
        Me.menuGrabar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnCancelarTipoDoc = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbRemision = New System.Windows.Forms.RadioButton
        Me.rbFactura = New System.Windows.Forms.RadioButton
        Me.Shape2 = New DatascanCF.Windows.Forms.Shape
        Me.bsDetalleFactura = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsVenta = New Oxigenos.Liquidos.VentaDataSet
        Me.bsFactura = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnDetalleDocumento = New System.Windows.Forms.Panel
        Me.lblPosicionRemision = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblPrecioUnitarioRemision = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblDescripcionRemision = New System.Windows.Forms.Label
        Me.lblDescuentoRemision = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblImpuestoRemision = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblDepositoGarantiaRemision = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.lblSubTotalRemision = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblCapacidadRemision = New System.Windows.Forms.Label
        Me.lblProductoRemision = New System.Windows.Forms.Label
        Me.pnTipoDocumento = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.DetalleFacturaTableAdapter = New Oxigenos.Liquidos.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
        Me.MaestroFacturasTableAdapter = New Oxigenos.Liquidos.VentaDataSetTableAdapters.MaestroFacturasTableAdapter
        Me.Panel3.SuspendLayout()
        Me.pnDetalleDocumento.SuspendLayout()
        Me.pnTipoDocumento.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.menuGrabar)
        Me.mainMenu1.MenuItems.Add(Me.menuCancelar)
        '
        'menuGrabar
        '
        Me.menuGrabar.Text = "Grabar"
        '
        'menuCancelar
        '
        Me.menuCancelar.Text = "Cancelar"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Linen
        Me.Panel3.Controls.Add(Me.btnCancelarTipoDoc)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.rbRemision)
        Me.Panel3.Controls.Add(Me.rbFactura)
        Me.Panel3.Controls.Add(Me.Shape2)
        Me.Panel3.Location = New System.Drawing.Point(20, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(191, 129)
        '
        'btnCancelarTipoDoc
        '
        Me.btnCancelarTipoDoc.Location = New System.Drawing.Point(21, 94)
        Me.btnCancelarTipoDoc.Name = "btnCancelarTipoDoc"
        Me.btnCancelarTipoDoc.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelarTipoDoc.TabIndex = 13
        Me.btnCancelarTipoDoc.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(99, 94)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 20)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(6, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 29)
        Me.Label9.Text = "Seleccione el Tipo de Documento"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rbRemision
        '
        Me.rbRemision.Location = New System.Drawing.Point(47, 69)
        Me.rbRemision.Name = "rbRemision"
        Me.rbRemision.Size = New System.Drawing.Size(96, 19)
        Me.rbRemision.TabIndex = 10
        Me.rbRemision.TabStop = False
        Me.rbRemision.Text = "Remisión"
        '
        'rbFactura
        '
        Me.rbFactura.Checked = True
        Me.rbFactura.Location = New System.Drawing.Point(47, 46)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(96, 19)
        Me.rbFactura.TabIndex = 9
        Me.rbFactura.Text = "Factura"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Linen
        Me.Shape2.Enabled = False
        Me.Shape2.Location = New System.Drawing.Point(2, 2)
        Me.Shape2.Name = "Shape2"
        Me.Shape2.Size = New System.Drawing.Size(187, 124)
        'Me.Shape2.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape2.TabIndex = 15
        Me.Shape2.Text = "Shape2"
        '
        'bsDetalleFactura
        '
        Me.bsDetalleFactura.DataMember = "DetalleFactura"
        Me.bsDetalleFactura.DataSource = Me.dsVenta
        Me.bsDetalleFactura.Filter = "TipoFactura = 'F'"
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsFactura
        '
        Me.bsFactura.DataMember = "MaestroFacturas"
        Me.bsFactura.DataSource = Me.dsVenta
        Me.bsFactura.Filter = "TipoFactura = 'F'"
        '
        'pnDetalleDocumento
        '
        Me.pnDetalleDocumento.Controls.Add(Me.lblPosicionRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label13)
        Me.pnDetalleDocumento.Controls.Add(Me.Label15)
        Me.pnDetalleDocumento.Controls.Add(Me.lblPrecioUnitarioRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label19)
        Me.pnDetalleDocumento.Controls.Add(Me.lblDescripcionRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.lblDescuentoRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label28)
        Me.pnDetalleDocumento.Controls.Add(Me.lblImpuestoRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label30)
        Me.pnDetalleDocumento.Controls.Add(Me.Label31)
        Me.pnDetalleDocumento.Controls.Add(Me.Label32)
        Me.pnDetalleDocumento.Controls.Add(Me.lblDepositoGarantiaRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label34)
        Me.pnDetalleDocumento.Controls.Add(Me.HScrollBar2)
        Me.pnDetalleDocumento.Controls.Add(Me.lblSubTotal)
        Me.pnDetalleDocumento.Controls.Add(Me.Label38)
        Me.pnDetalleDocumento.Controls.Add(Me.lblSubTotalRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.Label40)
        Me.pnDetalleDocumento.Controls.Add(Me.Label41)
        Me.pnDetalleDocumento.Controls.Add(Me.lblCapacidadRemision)
        Me.pnDetalleDocumento.Controls.Add(Me.lblProductoRemision)
        Me.pnDetalleDocumento.Location = New System.Drawing.Point(-1, 21)
        Me.pnDetalleDocumento.Name = "pnDetalleDocumento"
        Me.pnDetalleDocumento.Size = New System.Drawing.Size(241, 247)
        '
        'lblPosicionRemision
        '
        Me.lblPosicionRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPosicionRemision.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosicionRemision.Location = New System.Drawing.Point(2, 151)
        Me.lblPosicionRemision.Name = "lblPosicionRemision"
        Me.lblPosicionRemision.Size = New System.Drawing.Size(75, 15)
        Me.lblPosicionRemision.Text = "1 de 1"
        Me.lblPosicionRemision.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblPosicionRemision.Visible = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "Cantidad", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.Label13.Location = New System.Drawing.Point(79, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 16)
        Me.Label13.Text = "0"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(33, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 20)
        Me.Label15.Text = "Cant.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrecioUnitarioRemision
        '
        Me.lblPrecioUnitarioRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrecioUnitarioRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "PrecioUnitario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.lblPrecioUnitarioRemision.Location = New System.Drawing.Point(79, 55)
        Me.lblPrecioUnitarioRemision.Name = "lblPrecioUnitarioRemision"
        Me.lblPrecioUnitarioRemision.Size = New System.Drawing.Size(111, 16)
        Me.lblPrecioUnitarioRemision.Text = "0"
        Me.lblPrecioUnitarioRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(3, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 20)
        Me.Label19.Text = "PU:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescripcionRemision
        '
        Me.lblDescripcionRemision.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "Descripcion", True))
        Me.lblDescripcionRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionRemision.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDescripcionRemision.Location = New System.Drawing.Point(5, 23)
        Me.lblDescripcionRemision.Name = "lblDescripcionRemision"
        Me.lblDescripcionRemision.Size = New System.Drawing.Size(228, 29)
        '
        'lblDescuentoRemision
        '
        Me.lblDescuentoRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuentoRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoDescuento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.lblDescuentoRemision.Location = New System.Drawing.Point(79, 92)
        Me.lblDescuentoRemision.Name = "lblDescuentoRemision"
        Me.lblDescuentoRemision.Size = New System.Drawing.Size(111, 16)
        Me.lblDescuentoRemision.Text = "0"
        Me.lblDescuentoRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(0, 92)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 20)
        Me.Label28.Text = "Descuento:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpuestoRemision
        '
        Me.lblImpuestoRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblImpuestoRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoImpuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.lblImpuestoRemision.Location = New System.Drawing.Point(79, 110)
        Me.lblImpuestoRemision.Name = "lblImpuestoRemision"
        Me.lblImpuestoRemision.Size = New System.Drawing.Size(111, 16)
        Me.lblImpuestoRemision.Text = "0"
        Me.lblImpuestoRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(4, 110)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 20)
        Me.Label30.Text = "Impuesto:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(5, 216)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 20)
        Me.Label31.Text = "Tot. Factura:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsFactura, "MontoFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(103, 216)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(126, 16)
        Me.Label32.Text = "0"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDepositoGarantiaRemision
        '
        Me.lblDepositoGarantiaRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDepositoGarantiaRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsFactura, "ImpuestoTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.lblDepositoGarantiaRemision.Location = New System.Drawing.Point(103, 196)
        Me.lblDepositoGarantiaRemision.Name = "lblDepositoGarantiaRemision"
        Me.lblDepositoGarantiaRemision.Size = New System.Drawing.Size(126, 16)
        Me.lblDepositoGarantiaRemision.Text = "0"
        Me.lblDepositoGarantiaRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label34.Location = New System.Drawing.Point(-20, 196)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(117, 20)
        Me.Label34.Text = "Total IVA:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HScrollBar2
        '
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Location = New System.Drawing.Point(79, 151)
        Me.HScrollBar2.Maximum = 0
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(151, 14)
        Me.HScrollBar2.TabIndex = 94
        Me.HScrollBar2.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(103, 177)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(126, 16)
        Me.lblSubTotal.Text = "0"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(5, 177)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 20)
        Me.Label38.Text = "SubTotal:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubTotalRemision
        '
        Me.lblSubTotalRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubTotalRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoTotalItem", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "#,##0.00"))
        Me.lblSubTotalRemision.Location = New System.Drawing.Point(79, 128)
        Me.lblSubTotalRemision.Name = "lblSubTotalRemision"
        Me.lblSubTotalRemision.Size = New System.Drawing.Size(111, 16)
        Me.lblSubTotalRemision.Text = "0"
        Me.lblSubTotalRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(4, 128)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 20)
        Me.Label40.Text = "Sub Total:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label41.Location = New System.Drawing.Point(5, 5)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 12)
        Me.Label41.Text = "Producto:"
        '
        'lblCapacidadRemision
        '
        Me.lblCapacidadRemision.BackColor = System.Drawing.Color.White
        Me.lblCapacidadRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "CodProducto", True))
        Me.lblCapacidadRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacidadRemision.Location = New System.Drawing.Point(134, 5)
        Me.lblCapacidadRemision.Name = "lblCapacidadRemision"
        Me.lblCapacidadRemision.Size = New System.Drawing.Size(99, 16)
        '
        'lblProductoRemision
        '
        Me.lblProductoRemision.BackColor = System.Drawing.Color.White
        Me.lblProductoRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductoRemision.Location = New System.Drawing.Point(79, 5)
        Me.lblProductoRemision.Name = "lblProductoRemision"
        Me.lblProductoRemision.Size = New System.Drawing.Size(76, 16)
        '
        'pnTipoDocumento
        '
        Me.pnTipoDocumento.Controls.Add(Me.Panel3)
        Me.pnTipoDocumento.Location = New System.Drawing.Point(0, 20)
        Me.pnTipoDocumento.Name = "pnTipoDocumento"
        Me.pnTipoDocumento.Size = New System.Drawing.Size(240, 247)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.lblTitulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 22)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(4, 2)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(157, 20)
        Me.lblTitulo.Text = "Generar Documentos"
        '
        'DetalleFacturaTableAdapter
        '
        Me.DetalleFacturaTableAdapter.ClearBeforeFill = True
        '
        'MaestroFacturasTableAdapter
        '
        Me.MaestroFacturasTableAdapter.ClearBeforeFill = True
        '
        'GeneracionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnTipoDocumento)
        Me.Controls.Add(Me.pnDetalleDocumento)
        Me.Menu = Me.mainMenu1
        Me.Name = "GeneracionForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.pnDetalleDocumento.ResumeLayout(False)
        Me.pnTipoDocumento.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarTipoDoc As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbRemision As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Shape2 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents dsVenta As Oxigenos.Liquidos.VentaDataSet
    Friend WithEvents dsProductos As Oxigenos.Liquidos.ProductosDataSet
    Friend WithEvents bsDetalleFactura As System.Windows.Forms.BindingSource
    Friend WithEvents bsFactura As System.Windows.Forms.BindingSource
    Friend WithEvents pnDetalleDocumento As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPrecioUnitarioRemision As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionRemision As System.Windows.Forms.Label
    Friend WithEvents lblProductoRemision As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoRemision As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblImpuestoRemision As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblDepositoGarantiaRemision As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalRemision As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblCapacidadRemision As System.Windows.Forms.Label
    Friend WithEvents pnTipoDocumento As System.Windows.Forms.Panel
    Friend WithEvents menuGrabar As System.Windows.Forms.MenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblPosicionRemision As System.Windows.Forms.Label
    Friend WithEvents DetalleFacturaTableAdapter As Oxigenos.Liquidos.VentaDataSetTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents MaestroFacturasTableAdapter As Oxigenos.Liquidos.VentaDataSetTableAdapters.MaestroFacturasTableAdapter
End Class
