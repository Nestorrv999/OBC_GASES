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
        Me.pnTipoDocs = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.ckDeposito = New System.Windows.Forms.CheckBox
        Me.ckRecoleccion = New System.Windows.Forms.CheckBox
        Me.ckAsignacion = New System.Windows.Forms.CheckBox
        Me.ckRemision = New System.Windows.Forms.CheckBox
        Me.ckFactura = New System.Windows.Forms.CheckBox
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.pnTipoDocumento = New System.Windows.Forms.Panel
        Me.btnCancelarTipoDoc = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbRemision = New System.Windows.Forms.RadioButton
        Me.rbFactura = New System.Windows.Forms.RadioButton
        Me.Shape2 = New DatascanCF.Windows.Forms.Shape
        Me.pnResumenFactura = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label44 = New System.Windows.Forms.Label
        Me.btnDetalleRegresar = New System.Windows.Forms.Button
        Me.lblPosicion = New System.Windows.Forms.Label
        Me.bsDetalleFactura = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblPrecioUnitario = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblProducto = New System.Windows.Forms.Label
        Me.lblParcial = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblDescuento = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblImpuesto = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.bsFactura = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotalFactura = New System.Windows.Forms.Label
        Me.lblDepositoGarantia = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar
        Me.lblAFavor = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSubTitak = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.bsDetalleRemision = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCapacidad = New System.Windows.Forms.Label
        Me.pnDetalleRemision = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label43 = New System.Windows.Forms.Label
        Me.btnRegresarRemision = New System.Windows.Forms.Button
        Me.lblPosicionRemision = New System.Windows.Forms.Label
        Me.lblCantidadRemision = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblPrecioUnitarioRemision = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblDescripcionRemision = New System.Windows.Forms.Label
        Me.lblProductoRemision = New System.Windows.Forms.Label
        Me.lblParcialRemision = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblDescuentoRemision = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblImpuestoRemision = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.btnGrabarRemision = New System.Windows.Forms.Button
        Me.Label31 = New System.Windows.Forms.Label
        Me.bsRemision = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label32 = New System.Windows.Forms.Label
        Me.lblDepositoGarantiaRemision = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar
        Me.lblDescuentoFavorRemisio = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.lblTotalRemision = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.lblSubTotalRemision = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lblCapacidadRemision = New System.Windows.Forms.Label
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.pnTipoDocs.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnTipoDocumento.SuspendLayout()
        Me.pnResumenFactura.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnDetalleRemision.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnTipoDocs
        '
        Me.pnTipoDocs.Controls.Add(Me.Panel3)
        Me.pnTipoDocs.Controls.Add(Me.btnRegresar)
        Me.pnTipoDocs.Controls.Add(Me.btnContinuar)
        Me.pnTipoDocs.Controls.Add(Me.ckDeposito)
        Me.pnTipoDocs.Controls.Add(Me.ckRecoleccion)
        Me.pnTipoDocs.Controls.Add(Me.ckAsignacion)
        Me.pnTipoDocs.Controls.Add(Me.ckRemision)
        Me.pnTipoDocs.Controls.Add(Me.ckFactura)
        Me.pnTipoDocs.Controls.Add(Me.Shape1)
        Me.pnTipoDocs.Location = New System.Drawing.Point(0, 0)
        Me.pnTipoDocs.Name = "pnTipoDocs"
        Me.pnTipoDocs.Size = New System.Drawing.Size(238, 268)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.lblTitulo)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 26)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(3, 4)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(201, 20)
        Me.lblTitulo.Text = "Documentos a Generar"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(35, 204)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(79, 20)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "Regresar"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(120, 204)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(79, 20)
        Me.btnContinuar.TabIndex = 5
        Me.btnContinuar.Text = "&Siguiente"
        '
        'ckDeposito
        '
        Me.ckDeposito.AutoCheck = False
        Me.ckDeposito.BackColor = System.Drawing.Color.LemonChiffon
        Me.ckDeposito.Location = New System.Drawing.Point(72, 155)
        Me.ckDeposito.Name = "ckDeposito"
        Me.ckDeposito.Size = New System.Drawing.Size(100, 20)
        Me.ckDeposito.TabIndex = 4
        Me.ckDeposito.Text = "Depósito"
        '
        'ckRecoleccion
        '
        Me.ckRecoleccion.AutoCheck = False
        Me.ckRecoleccion.BackColor = System.Drawing.Color.LemonChiffon
        Me.ckRecoleccion.Location = New System.Drawing.Point(72, 129)
        Me.ckRecoleccion.Name = "ckRecoleccion"
        Me.ckRecoleccion.Size = New System.Drawing.Size(100, 20)
        Me.ckRecoleccion.TabIndex = 3
        Me.ckRecoleccion.Text = "Recolección"
        '
        'ckAsignacion
        '
        Me.ckAsignacion.AutoCheck = False
        Me.ckAsignacion.BackColor = System.Drawing.Color.LemonChiffon
        Me.ckAsignacion.Location = New System.Drawing.Point(72, 103)
        Me.ckAsignacion.Name = "ckAsignacion"
        Me.ckAsignacion.Size = New System.Drawing.Size(100, 20)
        Me.ckAsignacion.TabIndex = 2
        Me.ckAsignacion.Text = "Asignación"
        '
        'ckRemision
        '
        Me.ckRemision.AutoCheck = False
        Me.ckRemision.BackColor = System.Drawing.Color.LemonChiffon
        Me.ckRemision.Location = New System.Drawing.Point(72, 77)
        Me.ckRemision.Name = "ckRemision"
        Me.ckRemision.Size = New System.Drawing.Size(100, 20)
        Me.ckRemision.TabIndex = 1
        Me.ckRemision.Text = "Remisión"
        '
        'ckFactura
        '
        Me.ckFactura.AutoCheck = False
        Me.ckFactura.BackColor = System.Drawing.Color.LemonChiffon
        Me.ckFactura.Location = New System.Drawing.Point(72, 51)
        Me.ckFactura.Name = "ckFactura"
        Me.ckFactura.Size = New System.Drawing.Size(100, 20)
        Me.ckFactura.TabIndex = 0
        Me.ckFactura.Text = "Factura"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(25, 35)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(189, 164)
        Me.Shape1.TabIndex = 7
        Me.Shape1.Text = "Shape1"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'pnTipoDocumento
        '
        Me.pnTipoDocumento.BackColor = System.Drawing.Color.Linen
        Me.pnTipoDocumento.Controls.Add(Me.btnCancelarTipoDoc)
        Me.pnTipoDocumento.Controls.Add(Me.btnAceptar)
        Me.pnTipoDocumento.Controls.Add(Me.Label9)
        Me.pnTipoDocumento.Controls.Add(Me.rbRemision)
        Me.pnTipoDocumento.Controls.Add(Me.rbFactura)
        Me.pnTipoDocumento.Controls.Add(Me.Shape2)
        Me.pnTipoDocumento.Location = New System.Drawing.Point(25, 65)
        Me.pnTipoDocumento.Name = "pnTipoDocumento"
        Me.pnTipoDocumento.Size = New System.Drawing.Size(191, 129)
        Me.pnTipoDocumento.Visible = False
        '
        'btnCancelarTipoDoc
        '
        Me.btnCancelarTipoDoc.Location = New System.Drawing.Point(21, 94)
        Me.btnCancelarTipoDoc.Name = "btnCancelarTipoDoc"
        Me.btnCancelarTipoDoc.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelarTipoDoc.TabIndex = 13
        Me.btnCancelarTipoDoc.Text = "&Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(99, 94)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 20)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "&Aceptar"
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
        Me.Shape2.TabIndex = 15
        Me.Shape2.Text = "Shape2"
        '
        'pnResumenFactura
        '
        Me.pnResumenFactura.Controls.Add(Me.Panel4)
        Me.pnResumenFactura.Controls.Add(Me.btnDetalleRegresar)
        Me.pnResumenFactura.Controls.Add(Me.lblPosicion)
        Me.pnResumenFactura.Controls.Add(Me.lblCantidad)
        Me.pnResumenFactura.Controls.Add(Me.Label26)
        Me.pnResumenFactura.Controls.Add(Me.lblPrecioUnitario)
        Me.pnResumenFactura.Controls.Add(Me.Label24)
        Me.pnResumenFactura.Controls.Add(Me.lblDescripcion)
        Me.pnResumenFactura.Controls.Add(Me.lblProducto)
        Me.pnResumenFactura.Controls.Add(Me.lblParcial)
        Me.pnResumenFactura.Controls.Add(Me.Label20)
        Me.pnResumenFactura.Controls.Add(Me.lblDescuento)
        Me.pnResumenFactura.Controls.Add(Me.Label18)
        Me.pnResumenFactura.Controls.Add(Me.lblImpuesto)
        Me.pnResumenFactura.Controls.Add(Me.Label16)
        Me.pnResumenFactura.Controls.Add(Me.btnGrabar)
        Me.pnResumenFactura.Controls.Add(Me.Label14)
        Me.pnResumenFactura.Controls.Add(Me.lblTotalFactura)
        Me.pnResumenFactura.Controls.Add(Me.lblDepositoGarantia)
        Me.pnResumenFactura.Controls.Add(Me.Label12)
        Me.pnResumenFactura.Controls.Add(Me.HScrollBar1)
        Me.pnResumenFactura.Controls.Add(Me.lblAFavor)
        Me.pnResumenFactura.Controls.Add(Me.Label10)
        Me.pnResumenFactura.Controls.Add(Me.lblTotal)
        Me.pnResumenFactura.Controls.Add(Me.Label8)
        Me.pnResumenFactura.Controls.Add(Me.lblSubTitak)
        Me.pnResumenFactura.Controls.Add(Me.Label4)
        Me.pnResumenFactura.Controls.Add(Me.Label1)
        Me.pnResumenFactura.Controls.Add(Me.lblCapacidad)
        Me.pnResumenFactura.Location = New System.Drawing.Point(1, 0)
        Me.pnResumenFactura.Name = "pnResumenFactura"
        Me.pnResumenFactura.Size = New System.Drawing.Size(238, 268)
        Me.pnResumenFactura.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Location = New System.Drawing.Point(-1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 19)
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(3, 2)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(172, 16)
        Me.Label44.Text = "Detalle de la Factura"
        '
        'btnDetalleRegresar
        '
        Me.btnDetalleRegresar.Location = New System.Drawing.Point(5, 196)
        Me.btnDetalleRegresar.Name = "btnDetalleRegresar"
        Me.btnDetalleRegresar.Size = New System.Drawing.Size(71, 29)
        Me.btnDetalleRegresar.TabIndex = 68
        Me.btnDetalleRegresar.Text = "Regresar"
        '
        'lblPosicion
        '
        Me.lblPosicion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPosicion.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosicion.Location = New System.Drawing.Point(158, 149)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(71, 20)
        Me.lblPosicion.Text = "0 de 0"
        Me.lblPosicion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bsDetalleFactura
        '
        Me.bsDetalleFactura.DataMember = "DetalleFactura"
        Me.bsDetalleFactura.DataSource = Me.dsVenta
        Me.bsDetalleFactura.Filter = "TipoFactura = 'F'"
        '
        'lblCantidad
        '
        Me.lblCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCantidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "Cantidad", True))
        Me.lblCantidad.Location = New System.Drawing.Point(201, 77)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(32, 16)
        Me.lblCantidad.Text = "0"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label26.Location = New System.Drawing.Point(157, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(45, 20)
        Me.Label26.Text = "Cant.:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrecioUnitario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "PrecioUnitario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(79, 78)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(76, 16)
        Me.lblPrecioUnitario.Text = "0"
        Me.lblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(3, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(73, 20)
        Me.Label24.Text = "PU:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDescripcion.Location = New System.Drawing.Point(5, 39)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(228, 29)
        '
        'lblProducto
        '
        Me.lblProducto.BackColor = System.Drawing.Color.White
        Me.lblProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "CodProducto", True))
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.Location = New System.Drawing.Point(79, 21)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(76, 16)
        '
        'lblParcial
        '
        Me.lblParcial.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblParcial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoTotalItem", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblParcial.Location = New System.Drawing.Point(79, 97)
        Me.lblParcial.Name = "lblParcial"
        Me.lblParcial.Size = New System.Drawing.Size(76, 16)
        Me.lblParcial.Text = "0"
        Me.lblParcial.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(4, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 20)
        Me.Label20.Text = "Parcial:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescuento
        '
        Me.lblDescuento.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoDescuento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblDescuento.Location = New System.Drawing.Point(79, 115)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(76, 16)
        Me.lblDescuento.Text = "0"
        Me.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(0, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 20)
        Me.Label18.Text = "Descuento:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpuesto
        '
        Me.lblImpuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblImpuesto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoImpuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblImpuesto.Location = New System.Drawing.Point(79, 133)
        Me.lblImpuesto.Name = "lblImpuesto"
        Me.lblImpuesto.Size = New System.Drawing.Size(76, 16)
        Me.lblImpuesto.Text = "0"
        Me.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(4, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 20)
        Me.Label16.Text = "Impuesto:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(4, 231)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(72, 29)
        Me.btnGrabar.TabIndex = 55
        Me.btnGrabar.Text = "&Grabar"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(66, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 20)
        Me.Label14.Text = "Tot. Factura:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bsFactura
        '
        Me.bsFactura.DataMember = "MaestroFacturas"
        Me.bsFactura.DataSource = Me.dsVenta
        Me.bsFactura.Filter = "TipoFactura = 'F'"
        '
        'lblTotalFactura
        '
        Me.lblTotalFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalFactura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsFactura, "MontoFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblTotalFactura.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalFactura.Location = New System.Drawing.Point(158, 247)
        Me.lblTotalFactura.Name = "lblTotalFactura"
        Me.lblTotalFactura.Size = New System.Drawing.Size(71, 16)
        Me.lblTotalFactura.Text = "0"
        Me.lblTotalFactura.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDepositoGarantia
        '
        Me.lblDepositoGarantia.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDepositoGarantia.Location = New System.Drawing.Point(158, 229)
        Me.lblDepositoGarantia.Name = "lblDepositoGarantia"
        Me.lblDepositoGarantia.Size = New System.Drawing.Size(71, 16)
        Me.lblDepositoGarantia.Text = "0"
        Me.lblDepositoGarantia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(64, 228)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.Text = "Dep. Gar:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HScrollBar1
        '
        Me.HScrollBar1.LargeChange = 1
        Me.HScrollBar1.Location = New System.Drawing.Point(78, 173)
        Me.HScrollBar1.Maximum = 0
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(151, 14)
        Me.HScrollBar1.TabIndex = 54
        '
        'lblAFavor
        '
        Me.lblAFavor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAFavor.Location = New System.Drawing.Point(158, 211)
        Me.lblAFavor.Name = "lblAFavor"
        Me.lblAFavor.Size = New System.Drawing.Size(71, 16)
        Me.lblAFavor.Text = "0"
        Me.lblAFavor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(65, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 20)
        Me.Label10.Text = "(-) A Favor:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsFactura, "MontoFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblTotal.Location = New System.Drawing.Point(158, 193)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(71, 16)
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(65, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.Text = "Total:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubTitak
        '
        Me.lblSubTitak.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubTitak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "MontoTotalItem", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblSubTitak.Location = New System.Drawing.Point(78, 151)
        Me.lblSubTitak.Name = "lblSubTitak"
        Me.lblSubTitak.Size = New System.Drawing.Size(76, 16)
        Me.lblSubTitak.Text = "0"
        Me.lblSubTitak.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(4, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.Text = "Sub Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(5, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.Text = "Producto:"
        '
        'bsDetalleRemision
        '
        Me.bsDetalleRemision.DataMember = "DetalleFactura"
        Me.bsDetalleRemision.DataSource = Me.dsVenta
        Me.bsDetalleRemision.Filter = "TipoFactura = 'B'"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.BackColor = System.Drawing.Color.White
        Me.lblCapacidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "Capacidad", True))
        Me.lblCapacidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacidad.Location = New System.Drawing.Point(161, 21)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(72, 16)
        '
        'pnDetalleRemision
        '
        Me.pnDetalleRemision.Controls.Add(Me.Panel1)
        Me.pnDetalleRemision.Controls.Add(Me.btnRegresarRemision)
        Me.pnDetalleRemision.Controls.Add(Me.lblPosicionRemision)
        Me.pnDetalleRemision.Controls.Add(Me.lblCantidadRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label15)
        Me.pnDetalleRemision.Controls.Add(Me.lblPrecioUnitarioRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label19)
        Me.pnDetalleRemision.Controls.Add(Me.lblDescripcionRemision)
        Me.pnDetalleRemision.Controls.Add(Me.lblProductoRemision)
        Me.pnDetalleRemision.Controls.Add(Me.lblParcialRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label25)
        Me.pnDetalleRemision.Controls.Add(Me.lblDescuentoRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label28)
        Me.pnDetalleRemision.Controls.Add(Me.lblImpuestoRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label30)
        Me.pnDetalleRemision.Controls.Add(Me.btnGrabarRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label31)
        Me.pnDetalleRemision.Controls.Add(Me.Label32)
        Me.pnDetalleRemision.Controls.Add(Me.lblDepositoGarantiaRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label34)
        Me.pnDetalleRemision.Controls.Add(Me.HScrollBar2)
        Me.pnDetalleRemision.Controls.Add(Me.lblDescuentoFavorRemisio)
        Me.pnDetalleRemision.Controls.Add(Me.Label36)
        Me.pnDetalleRemision.Controls.Add(Me.lblTotalRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label38)
        Me.pnDetalleRemision.Controls.Add(Me.lblSubTotalRemision)
        Me.pnDetalleRemision.Controls.Add(Me.Label40)
        Me.pnDetalleRemision.Controls.Add(Me.Label41)
        Me.pnDetalleRemision.Controls.Add(Me.lblCapacidadRemision)
        Me.pnDetalleRemision.Location = New System.Drawing.Point(0, 0)
        Me.pnDetalleRemision.Name = "pnDetalleRemision"
        Me.pnDetalleRemision.Size = New System.Drawing.Size(239, 268)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label43)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 19)
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(3, 2)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(172, 16)
        Me.Label43.Text = "Detalle de la Remisión"
        '
        'btnRegresarRemision
        '
        Me.btnRegresarRemision.Location = New System.Drawing.Point(5, 198)
        Me.btnRegresarRemision.Name = "btnRegresarRemision"
        Me.btnRegresarRemision.Size = New System.Drawing.Size(71, 29)
        Me.btnRegresarRemision.TabIndex = 96
        Me.btnRegresarRemision.Text = "Regresar"
        '
        'lblPosicionRemision
        '
        Me.lblPosicionRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPosicionRemision.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosicionRemision.Location = New System.Drawing.Point(158, 151)
        Me.lblPosicionRemision.Name = "lblPosicionRemision"
        Me.lblPosicionRemision.Size = New System.Drawing.Size(71, 20)
        Me.lblPosicionRemision.Text = "0 de 0"
        Me.lblPosicionRemision.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCantidadRemision
        '
        Me.lblCantidadRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCantidadRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "Cantidad", True))
        Me.lblCantidadRemision.Location = New System.Drawing.Point(201, 79)
        Me.lblCantidadRemision.Name = "lblCantidadRemision"
        Me.lblCantidadRemision.Size = New System.Drawing.Size(32, 16)
        Me.lblCantidadRemision.Text = "0"
        Me.lblCantidadRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(157, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 20)
        Me.Label15.Text = "Cant.:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPrecioUnitarioRemision
        '
        Me.lblPrecioUnitarioRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrecioUnitarioRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "PrecioUnitario", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblPrecioUnitarioRemision.Location = New System.Drawing.Point(79, 80)
        Me.lblPrecioUnitarioRemision.Name = "lblPrecioUnitarioRemision"
        Me.lblPrecioUnitarioRemision.Size = New System.Drawing.Size(76, 16)
        Me.lblPrecioUnitarioRemision.Text = "0"
        Me.lblPrecioUnitarioRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(3, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 20)
        Me.Label19.Text = "PU:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescripcionRemision
        '
        Me.lblDescripcionRemision.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "Descripcion", True))
        Me.lblDescripcionRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionRemision.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblDescripcionRemision.Location = New System.Drawing.Point(5, 41)
        Me.lblDescripcionRemision.Name = "lblDescripcionRemision"
        Me.lblDescripcionRemision.Size = New System.Drawing.Size(228, 29)
        '
        'lblProductoRemision
        '
        Me.lblProductoRemision.BackColor = System.Drawing.Color.White
        Me.lblProductoRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "CodProducto", True))
        Me.lblProductoRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductoRemision.Location = New System.Drawing.Point(79, 23)
        Me.lblProductoRemision.Name = "lblProductoRemision"
        Me.lblProductoRemision.Size = New System.Drawing.Size(76, 16)
        '
        'lblParcialRemision
        '
        Me.lblParcialRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblParcialRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "MontoTotalItem", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblParcialRemision.Location = New System.Drawing.Point(79, 99)
        Me.lblParcialRemision.Name = "lblParcialRemision"
        Me.lblParcialRemision.Size = New System.Drawing.Size(76, 16)
        Me.lblParcialRemision.Text = "0"
        Me.lblParcialRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(4, 99)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 20)
        Me.Label25.Text = "Parcial:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDescuentoRemision
        '
        Me.lblDescuentoRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuentoRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "MontoDescuento", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblDescuentoRemision.Location = New System.Drawing.Point(79, 117)
        Me.lblDescuentoRemision.Name = "lblDescuentoRemision"
        Me.lblDescuentoRemision.Size = New System.Drawing.Size(76, 16)
        Me.lblDescuentoRemision.Text = "0"
        Me.lblDescuentoRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label28.Location = New System.Drawing.Point(0, 117)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 20)
        Me.Label28.Text = "Descuento:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblImpuestoRemision
        '
        Me.lblImpuestoRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblImpuestoRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "MontoImpuesto", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblImpuestoRemision.Location = New System.Drawing.Point(79, 135)
        Me.lblImpuestoRemision.Name = "lblImpuestoRemision"
        Me.lblImpuestoRemision.Size = New System.Drawing.Size(76, 16)
        Me.lblImpuestoRemision.Text = "0"
        Me.lblImpuestoRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(4, 135)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 20)
        Me.Label30.Text = "Impuesto:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGrabarRemision
        '
        Me.btnGrabarRemision.Location = New System.Drawing.Point(4, 233)
        Me.btnGrabarRemision.Name = "btnGrabarRemision"
        Me.btnGrabarRemision.Size = New System.Drawing.Size(72, 29)
        Me.btnGrabarRemision.TabIndex = 95
        Me.btnGrabarRemision.Text = "&Grabar"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(66, 247)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(92, 20)
        Me.Label31.Text = "Tot. Factura:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'bsRemision
        '
        Me.bsRemision.DataMember = "MaestroFacturas"
        Me.bsRemision.DataSource = Me.dsVenta
        Me.bsRemision.Filter = "TipoFactura = 'B'"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label32.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRemision, "MontoFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.Label32.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(158, 249)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 16)
        Me.Label32.Text = "0"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDepositoGarantiaRemision
        '
        Me.lblDepositoGarantiaRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDepositoGarantiaRemision.Location = New System.Drawing.Point(158, 231)
        Me.lblDepositoGarantiaRemision.Name = "lblDepositoGarantiaRemision"
        Me.lblDepositoGarantiaRemision.Size = New System.Drawing.Size(71, 16)
        Me.lblDepositoGarantiaRemision.Text = "0"
        Me.lblDepositoGarantiaRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label34.Location = New System.Drawing.Point(64, 230)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(93, 20)
        Me.Label34.Text = "Dep. Gar:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'HScrollBar2
        '
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Location = New System.Drawing.Point(78, 175)
        Me.HScrollBar2.Maximum = 0
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(151, 14)
        Me.HScrollBar2.TabIndex = 94
        '
        'lblDescuentoFavorRemisio
        '
        Me.lblDescuentoFavorRemisio.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescuentoFavorRemisio.Location = New System.Drawing.Point(158, 213)
        Me.lblDescuentoFavorRemisio.Name = "lblDescuentoFavorRemisio"
        Me.lblDescuentoFavorRemisio.Size = New System.Drawing.Size(71, 16)
        Me.lblDescuentoFavorRemisio.Text = "0"
        Me.lblDescuentoFavorRemisio.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.Location = New System.Drawing.Point(65, 212)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 20)
        Me.Label36.Text = "(-) A Favor:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalRemision
        '
        Me.lblTotalRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTotalRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsRemision, "MontoFactura", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblTotalRemision.Location = New System.Drawing.Point(158, 195)
        Me.lblTotalRemision.Name = "lblTotalRemision"
        Me.lblTotalRemision.Size = New System.Drawing.Size(71, 16)
        Me.lblTotalRemision.Text = "0"
        Me.lblTotalRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(65, 194)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 20)
        Me.Label38.Text = "Total:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSubTotalRemision
        '
        Me.lblSubTotalRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSubTotalRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleRemision, "MontoTotalItem", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "###,###,###"))
        Me.lblSubTotalRemision.Location = New System.Drawing.Point(78, 153)
        Me.lblSubTotalRemision.Name = "lblSubTotalRemision"
        Me.lblSubTotalRemision.Size = New System.Drawing.Size(76, 16)
        Me.lblSubTotalRemision.Text = "0"
        Me.lblSubTotalRemision.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(4, 153)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 20)
        Me.Label40.Text = "Sub Total:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label41.Location = New System.Drawing.Point(5, 23)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 12)
        Me.Label41.Text = "Producto:"
        '
        'lblCapacidadRemision
        '
        Me.lblCapacidadRemision.BackColor = System.Drawing.Color.White
        Me.lblCapacidadRemision.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetalleFactura, "Capacidad", True))
        Me.lblCapacidadRemision.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacidadRemision.Location = New System.Drawing.Point(161, 23)
        Me.lblCapacidadRemision.Name = "lblCapacidadRemision"
        Me.lblCapacidadRemision.Size = New System.Drawing.Size(72, 16)
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GeneracionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnResumenFactura)
        Me.Controls.Add(Me.pnTipoDocumento)
        Me.Controls.Add(Me.pnTipoDocs)
        Me.Controls.Add(Me.pnDetalleRemision)
        Me.Menu = Me.mainMenu1
        Me.Name = "GeneracionForm"
        Me.Text = "Praxair"
        Me.pnTipoDocs.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnTipoDocumento.ResumeLayout(False)
        Me.pnResumenFactura.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnDetalleRemision.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnTipoDocs As System.Windows.Forms.Panel
    Friend WithEvents ckDeposito As System.Windows.Forms.CheckBox
    Friend WithEvents ckRecoleccion As System.Windows.Forms.CheckBox
    Friend WithEvents ckAsignacion As System.Windows.Forms.CheckBox
    Friend WithEvents ckRemision As System.Windows.Forms.CheckBox
    Friend WithEvents ckFactura As System.Windows.Forms.CheckBox
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents pnTipoDocumento As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarTipoDoc As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbRemision As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Shape2 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pnResumenFactura As System.Windows.Forms.Panel
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblPrecioUnitario As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblParcial As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblDescuento As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblImpuesto As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFactura As System.Windows.Forms.Label
    Friend WithEvents lblDepositoGarantia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar
    Friend WithEvents lblAFavor As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSubTitak As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents bsDetalleFactura As System.Windows.Forms.BindingSource
    Friend WithEvents bsFactura As System.Windows.Forms.BindingSource
    Friend WithEvents btnDetalleRegresar As System.Windows.Forms.Button
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents pnDetalleRemision As System.Windows.Forms.Panel
    Friend WithEvents btnRegresarRemision As System.Windows.Forms.Button
    Friend WithEvents lblPosicionRemision As System.Windows.Forms.Label
    Friend WithEvents lblCantidadRemision As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblPrecioUnitarioRemision As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionRemision As System.Windows.Forms.Label
    Friend WithEvents lblProductoRemision As System.Windows.Forms.Label
    Friend WithEvents lblParcialRemision As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblDescuentoRemision As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblImpuestoRemision As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnGrabarRemision As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblDepositoGarantiaRemision As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Friend WithEvents lblDescuentoFavorRemisio As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblTotalRemision As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotalRemision As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lblCapacidadRemision As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents bsDetalleRemision As System.Windows.Forms.BindingSource
    Friend WithEvents bsRemision As System.Windows.Forms.BindingSource
End Class
