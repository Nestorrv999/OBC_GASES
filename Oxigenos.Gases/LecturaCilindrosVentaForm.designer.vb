<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LecturaCilindrosVentaForm
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.tcLectura = New System.Windows.Forms.TabControl
        Me.tpLectura = New System.Windows.Forms.TabPage
        Me.pnCargue = New System.Windows.Forms.Panel
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDescripcionTipoProducto = New System.Windows.Forms.Label
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.lblNolecturas = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblSep1 = New System.Windows.Forms.Label
        Me.lblDescripcionTipoPertenencia = New System.Windows.Forms.Label
        Me.lblSep2 = New System.Windows.Forms.Label
        Me.lblTipoPertenencia = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblSecuencial = New System.Windows.Forms.Label
        Me.lblTipoProducto = New System.Windows.Forms.Label
        Me.txtBarras = New DatascanCF.Windows.Forms.TextInputBox
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.lblCapacidad = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblProducto = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.pnTipoDocumento = New System.Windows.Forms.Panel
        Me.btnCancelarTipoDoc = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbRemision = New System.Windows.Forms.RadioButton
        Me.rbFactura = New System.Windows.Forms.RadioButton
        Me.Shape2 = New DatascanCF.Windows.Forms.Shape
        Me.pnLecturaAjenos = New System.Windows.Forms.Panel
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtSerial = New DatascanCF.Windows.Forms.TextInputBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.tpResumen = New System.Windows.Forms.TabPage
        Me.bsDetallePedido = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDesProducto = New System.Windows.Forms.Label
        Me.dsPedidos = New Oxigenos.Gases.PedidosDataSet
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.CodProducto = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Capacidad = New System.Windows.Forms.DataGridTextBoxColumn
        Me.UnidadesReales = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.Panel3.SuspendLayout()
        Me.tcLectura.SuspendLayout()
        Me.tpLectura.SuspendLayout()
        Me.pnCargue.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnTipoDocumento.SuspendLayout()
        Me.pnLecturaAjenos.SuspendLayout()
        Me.tpResumen.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
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
        Me.Label21.Text = "Cargue de Camión"
        '
        'tcLectura
        '
        Me.tcLectura.Controls.Add(Me.tpLectura)
        Me.tcLectura.Controls.Add(Me.tpResumen)
        Me.tcLectura.Location = New System.Drawing.Point(0, 0)
        Me.tcLectura.Name = "tcLectura"
        Me.tcLectura.SelectedIndex = 0
        Me.tcLectura.Size = New System.Drawing.Size(240, 268)
        Me.tcLectura.TabIndex = 1
        '
        'tpLectura
        '
        Me.tpLectura.Controls.Add(Me.pnCargue)
        Me.tpLectura.Controls.Add(Me.Panel1)
        Me.tpLectura.Controls.Add(Me.pnTipoDocumento)
        Me.tpLectura.Controls.Add(Me.pnLecturaAjenos)
        Me.tpLectura.Location = New System.Drawing.Point(0, 0)
        Me.tpLectura.Name = "tpLectura"
        Me.tpLectura.Size = New System.Drawing.Size(240, 245)
        Me.tpLectura.Text = "Lectura"
        '
        'pnCargue
        '
        Me.pnCargue.Controls.Add(Me.lblDescripcionTipoProducto)
        Me.pnCargue.Controls.Add(Me.btnGrabar)
        Me.pnCargue.Controls.Add(Me.btnRegresar)
        Me.pnCargue.Controls.Add(Me.lblNolecturas)
        Me.pnCargue.Controls.Add(Me.Label2)
        Me.pnCargue.Controls.Add(Me.Label1)
        Me.pnCargue.Controls.Add(Me.btnBuscar)
        Me.pnCargue.Controls.Add(Me.Label13)
        Me.pnCargue.Controls.Add(Me.Label19)
        Me.pnCargue.Controls.Add(Me.lblSep1)
        Me.pnCargue.Controls.Add(Me.lblDescripcionTipoPertenencia)
        Me.pnCargue.Controls.Add(Me.lblSep2)
        Me.pnCargue.Controls.Add(Me.lblTipoPertenencia)
        Me.pnCargue.Controls.Add(Me.Label15)
        Me.pnCargue.Controls.Add(Me.lblSecuencial)
        Me.pnCargue.Controls.Add(Me.lblTipoProducto)
        Me.pnCargue.Controls.Add(Me.txtBarras)
        Me.pnCargue.Controls.Add(Me.lblDescripcionProducto)
        Me.pnCargue.Controls.Add(Me.lblCapacidad)
        Me.pnCargue.Controls.Add(Me.Label11)
        Me.pnCargue.Controls.Add(Me.lblProducto)
        Me.pnCargue.Controls.Add(Me.Label8)
        Me.pnCargue.Controls.Add(Me.lblSucursal)
        Me.pnCargue.Controls.Add(Me.Label6)
        Me.pnCargue.Location = New System.Drawing.Point(-1, 26)
        Me.pnCargue.Name = "pnCargue"
        Me.pnCargue.Size = New System.Drawing.Size(240, 219)
        '
        'bsProductos
        '
        Me.bsProductos.DataMember = "Productos"
        Me.bsProductos.DataSource = Me.dsProductos
        '
        'lblDescripcionTipoProducto
        '
        Me.lblDescripcionTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "TipoProducto", True))
        Me.lblDescripcionTipoProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionTipoProducto.Location = New System.Drawing.Point(90, 35)
        Me.lblDescripcionTipoProducto.Name = "lblDescripcionTipoProducto"
        Me.lblDescripcionTipoProducto.Size = New System.Drawing.Size(128, 19)
        Me.lblDescripcionTipoProducto.Text = "Oxigeno Medicinal"
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(96, 187)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(64, 20)
        Me.btnGrabar.TabIndex = 269
        Me.btnGrabar.Text = "&Generar"
        Me.btnGrabar.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(166, 187)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(64, 20)
        Me.btnRegresar.TabIndex = 246
        Me.btnRegresar.Text = "Regresar"
        '
        'lblNolecturas
        '
        Me.lblNolecturas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNolecturas.Location = New System.Drawing.Point(11, 200)
        Me.lblNolecturas.Name = "lblNolecturas"
        Me.lblNolecturas.Size = New System.Drawing.Size(72, 19)
        Me.lblNolecturas.Text = "0"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.Text = "Barra:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(205, 8)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(29, 20)
        Me.btnBuscar.TabIndex = 206
        Me.btnBuscar.Text = ">>"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(9, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.Text = "Secuencial:"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(11, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 20)
        Me.Label19.Text = "No. Lecturas"
        '
        'lblSep1
        '
        Me.lblSep1.Location = New System.Drawing.Point(76, 35)
        Me.lblSep1.Name = "lblSep1"
        Me.lblSep1.Size = New System.Drawing.Size(10, 20)
        Me.lblSep1.Text = "-"
        Me.lblSep1.Visible = False
        '
        'lblDescripcionTipoPertenencia
        '
        Me.lblDescripcionTipoPertenencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionTipoPertenencia.ForeColor = System.Drawing.Color.Red
        Me.lblDescripcionTipoPertenencia.Location = New System.Drawing.Point(117, 167)
        Me.lblDescripcionTipoPertenencia.Name = "lblDescripcionTipoPertenencia"
        Me.lblDescripcionTipoPertenencia.Size = New System.Drawing.Size(116, 20)
        Me.lblDescripcionTipoPertenencia.Text = "PRAXAIR"
        '
        'lblSep2
        '
        Me.lblSep2.ForeColor = System.Drawing.Color.Red
        Me.lblSep2.Location = New System.Drawing.Point(106, 167)
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Size = New System.Drawing.Size(12, 20)
        Me.lblSep2.Text = "-"
        Me.lblSep2.Visible = False
        '
        'lblTipoPertenencia
        '
        Me.lblTipoPertenencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoPertenencia.ForeColor = System.Drawing.Color.Red
        Me.lblTipoPertenencia.Location = New System.Drawing.Point(91, 167)
        Me.lblTipoPertenencia.Name = "lblTipoPertenencia"
        Me.lblTipoPertenencia.Size = New System.Drawing.Size(20, 20)
        Me.lblTipoPertenencia.Text = "1"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(9, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 20)
        Me.Label15.Text = "Pertenencia:"
        '
        'lblSecuencial
        '
        Me.lblSecuencial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecuencial.Location = New System.Drawing.Point(91, 147)
        Me.lblSecuencial.Name = "lblSecuencial"
        Me.lblSecuencial.Size = New System.Drawing.Size(95, 20)
        Me.lblSecuencial.Text = "1622540"
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "CodTipoProducto", True))
        Me.lblTipoProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoProducto.Location = New System.Drawing.Point(60, 35)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(10, 20)
        Me.lblTipoProducto.Text = "1"
        '
        'txtBarras
        '
        Me.txtBarras.AcceptLetters = True
        Me.txtBarras.AcceptNumbers = True
        Me.txtBarras.AcceptPunctuations = True
        Me.txtBarras.AcceptSpaces = True
        Me.txtBarras.AcceptSymbols = True
        Me.txtBarras.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.txtBarras.ErrorMessage = ""
        Me.txtBarras.HelpText = Nothing
        Me.txtBarras.InvalidChars = ""
        Me.txtBarras.Location = New System.Drawing.Point(60, 8)
        Me.txtBarras.MaxLength = 24
        Me.txtBarras.Name = "txtBarras"
        Me.txtBarras.Required = False
        Me.txtBarras.Size = New System.Drawing.Size(139, 21)
        Me.txtBarras.TabIndex = 207
        Me.txtBarras.TabOnEnter = True
        Me.txtBarras.ValidChars = ""
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "Descripcion", True))
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(8, 93)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(232, 30)
        Me.lblDescripcionProducto.Text = "OXIGENO CIL. MEDICINAL"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacidad.Location = New System.Drawing.Point(91, 127)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(95, 20)
        Me.lblCapacidad.Text = "6.000"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 127)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.Text = "Capacidad:"
        '
        'lblProducto
        '
        Me.lblProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "Codigo", True))
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.Location = New System.Drawing.Point(91, 73)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(70, 20)
        Me.lblProducto.Text = "101403"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.Text = "Producto:"
        '
        'lblSucursal
        '
        Me.lblSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSucursal.Location = New System.Drawing.Point(91, 54)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(25, 20)
        Me.lblSucursal.Text = "01"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.Text = "Sucursal:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 28)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.Text = "Lectura Cilindros"
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
        Me.pnTipoDocumento.Location = New System.Drawing.Point(26, 83)
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
        Me.Shape2.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape2.TabIndex = 15
        Me.Shape2.Text = "Shape2"
        '
        'pnLecturaAjenos
        '
        Me.pnLecturaAjenos.Controls.Add(Me.btnCancelar)
        Me.pnLecturaAjenos.Controls.Add(Me.txtSerial)
        Me.pnLecturaAjenos.Controls.Add(Me.Label3)
        Me.pnLecturaAjenos.Controls.Add(Me.Shape1)
        Me.pnLecturaAjenos.Location = New System.Drawing.Point(26, 106)
        Me.pnLecturaAjenos.Name = "pnLecturaAjenos"
        Me.pnLecturaAjenos.Size = New System.Drawing.Size(189, 106)
        Me.pnLecturaAjenos.Visible = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(62, 67)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(70, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtSerial
        '
        Me.txtSerial.AcceptLetters = True
        Me.txtSerial.AcceptNumbers = True
        Me.txtSerial.AcceptPunctuations = True
        Me.txtSerial.AcceptSpaces = True
        Me.txtSerial.AcceptSymbols = True
        Me.txtSerial.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.txtSerial.ErrorMessage = ""
        Me.txtSerial.HelpText = Nothing
        Me.txtSerial.InvalidChars = ""
        Me.txtSerial.Location = New System.Drawing.Point(21, 42)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Required = False
        Me.txtSerial.Size = New System.Drawing.Size(146, 21)
        Me.txtSerial.TabIndex = 6
        Me.txtSerial.TabOnEnter = True
        Me.txtSerial.ValidChars = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(24, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 18)
        Me.Label3.Text = "Ingrese Serial Ajeno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(6, 3)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(177, 100)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 10
        Me.Shape1.Text = "Shape1"
        '
        'tpResumen
        '
        Me.tpResumen.Controls.Add(Me.lblDesProducto)
        Me.tpResumen.Controls.Add(Me.DataGrid1)
        Me.tpResumen.Controls.Add(Me.Panel2)
        Me.tpResumen.Location = New System.Drawing.Point(0, 0)
        Me.tpResumen.Name = "tpResumen"
        Me.tpResumen.Size = New System.Drawing.Size(232, 242)
        Me.tpResumen.Text = "Resumen"
        '
        'bsDetallePedido
        '
        Me.bsDetallePedido.DataMember = "DetallePedido"
        Me.bsDetallePedido.DataSource = Me.dsPedidos
        Me.bsDetallePedido.Filter = ""
        '
        'lblDesProducto
        '
        Me.lblDesProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDetallePedido, "DescripcionProducto", True))
        Me.lblDesProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDesProducto.Location = New System.Drawing.Point(3, 216)
        Me.lblDesProducto.Name = "lblDesProducto"
        Me.lblDesProducto.Size = New System.Drawing.Size(230, 27)
        '
        'dsPedidos
        '
        Me.dsPedidos.DataSetName = "PedidosDataSet"
        Me.dsPedidos.Prefix = ""
        Me.dsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGrid1
        '
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGrid1.DataSource = Me.bsDetallePedido
        Me.DataGrid1.Location = New System.Drawing.Point(0, 28)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(240, 185)
        Me.DataGrid1.TabIndex = 2
        Me.DataGrid1.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.CodProducto)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.Capacidad)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.UnidadesReales)
        Me.DataGridTableStyle1.MappingName = "DetallePedido"
        '
        'CodProducto
        '
        Me.CodProducto.Format = ""
        Me.CodProducto.FormatInfo = Nothing
        Me.CodProducto.HeaderText = "Cod.Act."
        Me.CodProducto.MappingName = "CodProducto"
        Me.CodProducto.NullText = ""
        Me.CodProducto.Width = 70
        '
        'Capacidad
        '
        Me.Capacidad.Format = "###,##0"
        Me.Capacidad.FormatInfo = Nothing
        Me.Capacidad.HeaderText = "Capacidad"
        Me.Capacidad.MappingName = "CapacidadNumerico"
        Me.Capacidad.NullText = "0"
        Me.Capacidad.Width = 70
        '
        'UnidadesReales
        '
        Me.UnidadesReales.Format = ""
        Me.UnidadesReales.FormatInfo = Nothing
        Me.UnidadesReales.HeaderText = "Cantidad"
        Me.UnidadesReales.MappingName = "UnidadesReales"
        Me.UnidadesReales.NullText = "0"
        Me.UnidadesReales.Width = 70
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(240, 28)
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.Text = "Resumen"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.Text = "Lectura Cilindros"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LecturaCilindrosVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.tcLectura)
        Me.Controls.Add(Me.Panel3)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "LecturaCilindrosVentaForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.tcLectura.ResumeLayout(False)
        Me.tpLectura.ResumeLayout(False)
        Me.pnCargue.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnTipoDocumento.ResumeLayout(False)
        Me.pnLecturaAjenos.ResumeLayout(False)
        Me.tpResumen.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents tcLectura As System.Windows.Forms.TabControl
    Friend WithEvents tpLectura As System.Windows.Forms.TabPage
    Friend WithEvents pnLecturaAjenos As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSerial As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents pnCargue As System.Windows.Forms.Panel
    Friend WithEvents lblNolecturas As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblSep1 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionTipoPertenencia As System.Windows.Forms.Label
    Friend WithEvents lblSep2 As System.Windows.Forms.Label
    Friend WithEvents lblTipoPertenencia As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSecuencial As System.Windows.Forms.Label
    Friend WithEvents lblTipoProducto As System.Windows.Forms.Label
    Friend WithEvents txtBarras As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionTipoProducto As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dsPedidos As Oxigenos.Gases.PedidosDataSet
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents bsDetallePedido As System.Windows.Forms.BindingSource
    Friend WithEvents tpResumen As System.Windows.Forms.TabPage
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents CodProducto As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Capacidad As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UnidadesReales As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents lblDesProducto As System.Windows.Forms.Label
    Friend WithEvents pnTipoDocumento As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbRemision As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnCancelarTipoDoc As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Shape2 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet

End Class
