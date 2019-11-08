<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CargueCamionForm
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
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuOpcionesCargue = New System.Windows.Forms.MenuItem
        Me.mnuTransmitirDatos = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuResumen = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.mnuRegresar = New System.Windows.Forms.MenuItem
        Me.pnCargue = New System.Windows.Forms.Panel
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
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTipoProducto = New System.Windows.Forms.Label
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.txtBarras = New DatascanCF.Windows.Forms.TextInputBox
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.lblCapacidad = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.lblProducto = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblDescripcionTipoProducto = New System.Windows.Forms.Label
        Me.pnLecturaAjenos = New System.Windows.Forms.Panel
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtSerial = New DatascanCF.Windows.Forms.TextInputBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.pnCargue.SuspendLayout()
        Me.pnLecturaAjenos.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.mnuOpcionesCargue)
        '
        'mnuOpcionesCargue
        '
        Me.mnuOpcionesCargue.MenuItems.Add(Me.mnuTransmitirDatos)
        Me.mnuOpcionesCargue.MenuItems.Add(Me.MenuItem6)
        Me.mnuOpcionesCargue.MenuItems.Add(Me.mnuResumen)
        Me.mnuOpcionesCargue.MenuItems.Add(Me.MenuItem4)
        Me.mnuOpcionesCargue.MenuItems.Add(Me.mnuRegresar)
        Me.mnuOpcionesCargue.Text = "Opciones"
        '
        'mnuTransmitirDatos
        '
        Me.mnuTransmitirDatos.Text = "&Transmitir Datos"
        '
        'MenuItem6
        '
        Me.MenuItem6.Text = "-"
        '
        'mnuResumen
        '
        Me.mnuResumen.Text = "Ver &Resumen"
        '
        'MenuItem4
        '
        Me.MenuItem4.Text = "-"
        '
        'mnuRegresar
        '
        Me.mnuRegresar.Text = "Regresar"
        '
        'pnCargue
        '
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
        Me.pnCargue.Controls.Add(Me.lblDescripcionTipoProducto)
        Me.pnCargue.Location = New System.Drawing.Point(0, 28)
        Me.pnCargue.Name = "pnCargue"
        Me.pnCargue.Size = New System.Drawing.Size(240, 240)
        '
        'lblNolecturas
        '
        Me.lblNolecturas.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNolecturas.Location = New System.Drawing.Point(9, 214)
        Me.lblNolecturas.Name = "lblNolecturas"
        Me.lblNolecturas.Size = New System.Drawing.Size(72, 20)
        Me.lblNolecturas.Text = "1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.Text = "Barra:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(204, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(29, 20)
        Me.btnBuscar.TabIndex = 206
        Me.btnBuscar.Text = ">>"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(9, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 20)
        Me.Label13.Text = "Secuencial:"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(7, 194)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 20)
        Me.Label19.Text = "No. Lecturas:"
        '
        'lblSep1
        '
        Me.lblSep1.Location = New System.Drawing.Point(104, 42)
        Me.lblSep1.Name = "lblSep1"
        Me.lblSep1.Size = New System.Drawing.Size(10, 20)
        Me.lblSep1.Text = "-"
        Me.lblSep1.Visible = False
        '
        'lblDescripcionTipoPertenencia
        '
        Me.lblDescripcionTipoPertenencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionTipoPertenencia.ForeColor = System.Drawing.Color.Red
        Me.lblDescripcionTipoPertenencia.Location = New System.Drawing.Point(117, 174)
        Me.lblDescripcionTipoPertenencia.Name = "lblDescripcionTipoPertenencia"
        Me.lblDescripcionTipoPertenencia.Size = New System.Drawing.Size(116, 20)
        Me.lblDescripcionTipoPertenencia.Text = "PRAXAIR"
        '
        'lblSep2
        '
        Me.lblSep2.ForeColor = System.Drawing.Color.Red
        Me.lblSep2.Location = New System.Drawing.Point(106, 174)
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Size = New System.Drawing.Size(12, 20)
        Me.lblSep2.Text = "-"
        Me.lblSep2.Visible = False
        '
        'lblTipoPertenencia
        '
        Me.lblTipoPertenencia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoPertenencia.ForeColor = System.Drawing.Color.Red
        Me.lblTipoPertenencia.Location = New System.Drawing.Point(91, 174)
        Me.lblTipoPertenencia.Name = "lblTipoPertenencia"
        Me.lblTipoPertenencia.Size = New System.Drawing.Size(20, 20)
        Me.lblTipoPertenencia.Text = "1"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(9, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(74, 20)
        Me.Label15.Text = "Pertenencia:"
        '
        'lblSecuencial
        '
        Me.lblSecuencial.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSecuencial.Location = New System.Drawing.Point(91, 154)
        Me.lblSecuencial.Name = "lblSecuencial"
        Me.lblSecuencial.Size = New System.Drawing.Size(95, 20)
        Me.lblSecuencial.Text = "1622540"
        '
        'bsProductos
        '
        Me.bsProductos.DataMember = "Productos"
        Me.bsProductos.DataSource = Me.dsProductos
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "CodTipoProducto", True))
        Me.lblTipoProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoProducto.Location = New System.Drawing.Point(91, 42)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(10, 20)
        Me.lblTipoProducto.Text = "1"
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.txtBarras.Location = New System.Drawing.Point(55, 12)
        Me.txtBarras.MaxLength = 24
        Me.txtBarras.Name = "txtBarras"
        Me.txtBarras.Required = False
        Me.txtBarras.Size = New System.Drawing.Size(143, 21)
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
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(8, 100)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(225, 30)
        Me.lblDescripcionProducto.Text = "OXIGENO CIL. MEDICINAL"
        '
        'lblCapacidad
        '
        Me.lblCapacidad.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCapacidad.Location = New System.Drawing.Point(91, 134)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(95, 20)
        Me.lblCapacidad.Text = "6.000"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.Text = "Capacidad:"
        '
        'lblProducto
        '
        Me.lblProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "Codigo", True))
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.Location = New System.Drawing.Point(91, 80)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(70, 20)
        Me.lblProducto.Text = "101403"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.Text = "Producto:"
        '
        'lblSucursal
        '
        Me.lblSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSucursal.Location = New System.Drawing.Point(91, 61)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(25, 20)
        Me.lblSucursal.Text = "01"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 20)
        Me.Label6.Text = "Sucursal:"
        '
        'lblDescripcionTipoProducto
        '
        Me.lblDescripcionTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProductos, "TipoProducto", True))
        Me.lblDescripcionTipoProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionTipoProducto.Location = New System.Drawing.Point(115, 42)
        Me.lblDescripcionTipoProducto.Name = "lblDescripcionTipoProducto"
        Me.lblDescripcionTipoProducto.Size = New System.Drawing.Size(109, 20)
        Me.lblDescripcionTipoProducto.Text = "Producto"
        '
        'pnLecturaAjenos
        '
        Me.pnLecturaAjenos.Controls.Add(Me.btnCancelar)
        Me.pnLecturaAjenos.Controls.Add(Me.txtSerial)
        Me.pnLecturaAjenos.Controls.Add(Me.Label3)
        Me.pnLecturaAjenos.Controls.Add(Me.Shape1)
        Me.pnLecturaAjenos.Location = New System.Drawing.Point(24, 98)
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
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'CargueCamionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnCargue)
        Me.Controls.Add(Me.pnLecturaAjenos)
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "CargueCamionForm"
        Me.Text = "Praxair"
        Me.pnCargue.ResumeLayout(False)
        Me.pnLecturaAjenos.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuOpcionesCargue As System.Windows.Forms.MenuItem
    Friend WithEvents mnuResumen As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTransmitirDatos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents pnCargue As System.Windows.Forms.Panel
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
    Friend WithEvents lblNolecturas As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents lblCapacidad As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionTipoProducto As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents pnLecturaAjenos As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtSerial As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler

End Class
