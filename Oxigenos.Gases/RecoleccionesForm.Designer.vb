<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RecoleccionesForm
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
        Me.txtCantidad = New DatascanCF.Windows.Forms.NumericInputBox
        Me.dsVenta = New Oxigenos.Gases.VentaDataSet
        Me.cbPertenencia = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.txtCapacidad = New DatascanCF.Windows.Forms.NumericInputBox
        Me.txtProducto = New DatascanCF.Windows.Forms.TextInputBox
        Me.lblDescripcionProducto = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.lblSerial = New System.Windows.Forms.Label
        Me.txtSerial = New DatascanCF.Windows.Forms.TextInputBox
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblItems = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.pnRecoleccion = New System.Windows.Forms.Panel
        Me.txtCilindro = New DatascanCF.Windows.Forms.TextInputBox
        Me.lblCilindro = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.pnRecoleccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.AcceptZero = False
        Me.txtCantidad.AllowNegative = False
        Me.txtCantidad.Decimals = 0
        Me.txtCantidad.ErrorMessage = ""
        Me.txtCantidad.Format = ""
        Me.txtCantidad.HelpText = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(81, 158)
        Me.txtCantidad.MaxLength = 6
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Required = False
        Me.txtCantidad.Size = New System.Drawing.Size(60, 21)
        Me.txtCantidad.TabIndex = 40
        Me.txtCantidad.TabOnEnter = True
        '
        'dsVenta
        '
        Me.dsVenta.DataSetName = "VentaDataSet"
        Me.dsVenta.Prefix = ""
        Me.dsVenta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbPertenencia
        '
        Me.cbPertenencia.Items.Add("PRAXAIR")
        Me.cbPertenencia.Items.Add("CLIENTE")
        Me.cbPertenencia.Location = New System.Drawing.Point(81, 46)
        Me.cbPertenencia.Name = "cbPertenencia"
        Me.cbPertenencia.Size = New System.Drawing.Size(100, 22)
        Me.cbPertenencia.TabIndex = 36
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(187, 72)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(33, 20)
        Me.btnBuscar.TabIndex = 43
        Me.btnBuscar.Text = ">>"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.Text = "Capacidad:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.AcceptZero = False
        Me.txtCapacidad.AllowNegative = False
        Me.txtCapacidad.Decimals = 3
        Me.txtCapacidad.ErrorMessage = ""
        Me.txtCapacidad.Format = ""
        Me.txtCapacidad.HelpText = Nothing
        Me.txtCapacidad.Location = New System.Drawing.Point(81, 131)
        Me.txtCapacidad.MaxLength = 6
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Required = False
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 21)
        Me.txtCapacidad.TabIndex = 38
        Me.txtCapacidad.TabOnEnter = True
        '
        'txtProducto
        '
        Me.txtProducto.AcceptLetters = True
        Me.txtProducto.AcceptNumbers = True
        Me.txtProducto.AcceptPunctuations = True
        Me.txtProducto.AcceptSpaces = True
        Me.txtProducto.AcceptSymbols = True
        Me.txtProducto.ErrorMessage = ""
        Me.txtProducto.HelpText = Nothing
        Me.txtProducto.InvalidChars = ""
        Me.txtProducto.Location = New System.Drawing.Point(81, 72)
        Me.txtProducto.MaxLength = 8
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Required = False
        Me.txtProducto.Size = New System.Drawing.Size(100, 21)
        Me.txtProducto.TabIndex = 37
        Me.txtProducto.TabOnEnter = True
        Me.txtProducto.ValidChars = ""
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(4, 96)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(233, 30)
        Me.lblDescripcionProducto.Text = "OXIGENO CIL. MEDICINAL"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.Text = "Producto:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.Text = "Propiedad:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.lblTitulo)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 32)
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(3, 5)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(113, 20)
        Me.lblTitulo.Text = "Recolección"
        '
        'lblSerial
        '
        Me.lblSerial.Location = New System.Drawing.Point(4, 159)
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
        Me.txtSerial.ErrorMessage = ""
        Me.txtSerial.HelpText = Nothing
        Me.txtSerial.InvalidChars = ""
        Me.txtSerial.Location = New System.Drawing.Point(81, 158)
        Me.txtSerial.MaxLength = 8
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Required = False
        Me.txtSerial.Size = New System.Drawing.Size(100, 21)
        Me.txtSerial.TabIndex = 39
        Me.txtSerial.TabOnEnter = True
        Me.txtSerial.ValidChars = ""
        Me.txtSerial.Visible = False
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(4, 159)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(71, 20)
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.Visible = False
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 20)
        Me.Label4.Text = "No. Items Capturados:"
        '
        'lblItems
        '
        Me.lblItems.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblItems.ForeColor = System.Drawing.Color.Red
        Me.lblItems.Location = New System.Drawing.Point(142, 250)
        Me.lblItems.Name = "lblItems"
        Me.lblItems.Size = New System.Drawing.Size(78, 20)
        Me.lblItems.Text = "0"
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(3, 235)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(234, 10)
        Me.Shape1.TabIndex = 42
        Me.Shape1.Text = "Shape1"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(107, 209)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(74, 20)
        Me.btnRegresar.TabIndex = 41
        Me.btnRegresar.Text = "Regresar"
        '
        'pnRecoleccion
        '
        Me.pnRecoleccion.Controls.Add(Me.txtCilindro)
        Me.pnRecoleccion.Controls.Add(Me.lblCilindro)
        Me.pnRecoleccion.Controls.Add(Me.btnRegresar)
        Me.pnRecoleccion.Controls.Add(Me.Shape1)
        Me.pnRecoleccion.Controls.Add(Me.lblItems)
        Me.pnRecoleccion.Controls.Add(Me.Label3)
        Me.pnRecoleccion.Controls.Add(Me.Label4)
        Me.pnRecoleccion.Controls.Add(Me.lblSerial)
        Me.pnRecoleccion.Location = New System.Drawing.Point(0, 0)
        Me.pnRecoleccion.Name = "pnRecoleccion"
        Me.pnRecoleccion.Size = New System.Drawing.Size(240, 268)
        '
        'txtCilindro
        '
        Me.txtCilindro.AcceptLetters = True
        Me.txtCilindro.AcceptNumbers = True
        Me.txtCilindro.AcceptPunctuations = True
        Me.txtCilindro.AcceptSpaces = True
        Me.txtCilindro.AcceptSymbols = True
        Me.txtCilindro.Enabled = False
        Me.txtCilindro.ErrorMessage = ""
        Me.txtCilindro.HelpText = Nothing
        Me.txtCilindro.InvalidChars = ""
        Me.txtCilindro.Location = New System.Drawing.Point(81, 185)
        Me.txtCilindro.MaxLength = 8
        Me.txtCilindro.Name = "txtCilindro"
        Me.txtCilindro.Required = False
        Me.txtCilindro.Size = New System.Drawing.Size(100, 21)
        Me.txtCilindro.TabIndex = 52
        Me.txtCilindro.TabOnEnter = True
        Me.txtCilindro.ValidChars = ""
        Me.txtCilindro.Visible = False
        '
        'lblCilindro
        '
        Me.lblCilindro.Location = New System.Drawing.Point(4, 188)
        Me.lblCilindro.Name = "lblCilindro"
        Me.lblCilindro.Size = New System.Drawing.Size(71, 20)
        Me.lblCilindro.Text = "Secuencia:"
        Me.lblCilindro.Visible = False
        '
        'RecoleccionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cbPertenencia)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCapacidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.lblDescripcionProducto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.pnRecoleccion)
        Me.Menu = Me.MainMenu1
        Me.Name = "RecoleccionesForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.pnRecoleccion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCantidad As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents dsVenta As Oxigenos.Gases.VentaDataSet
    Friend WithEvents cbPertenencia As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents txtCapacidad As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents txtProducto As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents lblDescripcionProducto As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSerial As System.Windows.Forms.Label
    Friend WithEvents txtSerial As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblItems As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents pnRecoleccion As System.Windows.Forms.Panel
    Friend WithEvents lblCilindro As System.Windows.Forms.Label
    Friend WithEvents txtCilindro As DatascanCF.Windows.Forms.TextInputBox
End Class
