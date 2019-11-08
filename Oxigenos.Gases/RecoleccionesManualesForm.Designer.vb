<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RecoleccionesManualesForm
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.txtCapacidad = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblItems = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.cbPertenencia = New System.Windows.Forms.ComboBox
        Me.txtCantidad = New DatascanCF.Windows.Forms.NumericInputBox
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.lblSerial = New System.Windows.Forms.Label
        Me.txtSerial = New DatascanCF.Windows.Forms.TextInputBox
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.txtProducto = New DatascanCF.Windows.Forms.TextInputBox
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(177, 20)
        Me.lblTitulo.Text = "Recolección Manual"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.Text = "Propiedad:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.Text = "Producto:"
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(3, 106)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(234, 30)
        Me.lblDescripcionProducto.Text = "OXIGENO CIL. MEDICINAL"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.AcceptZero = False
        Me.txtCapacidad.AllowNegative = False
        Me.txtCapacidad.Decimals = 3
        Me.txtCapacidad.ErrorMessage = ""
        Me.txtCapacidad.Format = ""
        Me.txtCapacidad.HelpText = Nothing
        Me.txtCapacidad.Location = New System.Drawing.Point(80, 145)
        Me.txtCapacidad.MaxLength = 6
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Required = False
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 21)
        Me.txtCapacidad.TabIndex = 3
        Me.txtCapacidad.TabOnEnter = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.Text = "No. Items Capturados:"
        '
        'lblItems
        '
        Me.lblItems.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblItems.ForeColor = System.Drawing.Color.Red
        Me.lblItems.Location = New System.Drawing.Point(141, 244)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(78, 20)
        Me.lblItems.Text = "0"
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 231)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(240, 10)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.BottomLine
        Me.Shape1.TabIndex = 18
        Me.Shape1.Text = "Shape1"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(186, 77)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = ">>"
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbPertenencia
        '
        Me.cbPertenencia.Items.Add("PRAXAIR")
        Me.cbPertenencia.Items.Add("CLIENTE")
        Me.cbPertenencia.Location = New System.Drawing.Point(80, 45)
        Me.cbPertenencia.Name = "cbPertenencia"
        Me.cbPertenencia.Size = New System.Drawing.Size(100, 22)
        Me.cbPertenencia.TabIndex = 1
        '
        'txtCantidad
        '
        Me.txtCantidad.AcceptZero = False
        Me.txtCantidad.AllowNegative = False
        Me.txtCantidad.Decimals = 0
        Me.txtCantidad.ErrorMessage = ""
        Me.txtCantidad.Format = ""
        Me.txtCantidad.HelpText = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(80, 172)
        Me.txtCantidad.MaxLength = 6
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Required = False
        Me.txtCantidad.Size = New System.Drawing.Size(60, 21)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TabOnEnter = True
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(3, 172)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(71, 20)
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.Visible = False
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(80, 205)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(74, 20)
        Me.btnRegresar.TabIndex = 5
        Me.btnRegresar.Text = "Regresar"
        '
        'lblSerial
        '
        Me.lblSerial.Location = New System.Drawing.Point(3, 172)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(71, 20)
        Me.lblSerial.Text = "Serial:"
        '
        'txtSerial
        '
        Me.txtSerial.AcceptLetters = True
        Me.txtSerial.AcceptNumbers = True
        Me.txtSerial.AcceptPunctuations = True
        Me.txtSerial.AcceptSpaces = True
        Me.txtSerial.AcceptSymbols = True
        'Me.txtSerial.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.txtSerial.ErrorMessage = ""
        Me.txtSerial.HelpText = Nothing
        Me.txtSerial.InvalidChars = ""
        Me.txtSerial.Location = New System.Drawing.Point(80, 172)
        Me.txtSerial.MaxLength = 8
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Required = False
        Me.txtSerial.Size = New System.Drawing.Size(100, 21)
        Me.txtSerial.TabIndex = 4
        Me.txtSerial.TabOnEnter = True
        Me.txtSerial.ValidChars = ""
        Me.txtSerial.Visible = False
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(160, 205)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(74, 20)
        Me.btnGenerar.TabIndex = 36
        Me.btnGenerar.Text = "&Generar"
        '
        'txtProducto
        '
        Me.txtProducto.AcceptLetters = True
        Me.txtProducto.AcceptNumbers = True
        Me.txtProducto.AcceptPunctuations = True
        Me.txtProducto.AcceptSpaces = True
        Me.txtProducto.AcceptSymbols = True
        'Me.txtProducto.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.txtProducto.ErrorMessage = ""
        Me.txtProducto.HelpText = Nothing
        Me.txtProducto.InvalidChars = ""
        Me.txtProducto.Location = New System.Drawing.Point(80, 77)
        Me.txtProducto.MaxLength = 8
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Required = False
        Me.txtProducto.Size = New System.Drawing.Size(100, 21)
        Me.txtProducto.TabIndex = 46
        Me.txtProducto.TabOnEnter = True
        Me.txtProducto.ValidChars = ""
        '
        'RecoleccionesManualesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cbPertenencia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Shape1)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDescripcionProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblCantidad)
        Me.Menu = Me.MainMenu1
        Me.Name = "RecoleccionesManualesForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents cbPertenencia As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidad As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents txtSerial As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents txtProducto As DatascanCF.Windows.Forms.TextInputBox
End Class
