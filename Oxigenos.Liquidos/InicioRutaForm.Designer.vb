<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InicioRutaForm
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
        Me.menuGuardar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.menuIniciarRuta = New System.Windows.Forms.MenuItem
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.bsTanqueros = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsHojasRuta = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.dsHojasRuta = New Oxigenos.Liquidos.HojasRutaDataSet
        Me.bsTractores = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbProducto = New OpenNETCF.Windows.Forms.ComboBox2(Me.components)
        Me.dsProductos = New Oxigenos.Liquidos.ProductosDataSet
        Me.bsChoferes = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox22 = New OpenNETCF.Windows.Forms.ComboBox2(Me.components)
        Me.bsLugaresCarga = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox21 = New OpenNETCF.Windows.Forms.ComboBox2(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.NumericInputBox3 = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextInputBox1 = New DatascanCF.Windows.Forms.TextInputBox
        Me.NumericInputBox2 = New DatascanCF.Windows.Forms.NumericInputBox
        Me.NumericInputBox1 = New DatascanCF.Windows.Forms.NumericInputBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.menuIniciarRuta)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuGuardar)
        Me.MenuItem1.MenuItems.Add(Me.menuCancelar)
        Me.MenuItem1.Text = "Opciones"
        '
        'menuGuardar
        '
        Me.menuGuardar.Text = "Guardar"
        '
        'menuCancelar
        '
        Me.menuCancelar.Text = "Cancelar"
        '
        'menuIniciarRuta
        '
        Me.menuIniciarRuta.Text = "Iniciar Ruta"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
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
        Me.Label11.Size = New System.Drawing.Size(172, 20)
        Me.Label11.Text = "Inicio Ruta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 239)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 239)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.cbProducto)
        Me.TabPage1.Controls.Add(Me.ComboBox22)
        Me.TabPage1.Controls.Add(Me.ComboBox21)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 216)
        Me.TabPage1.Text = "General"
        '
        'bsTanqueros
        '
        Me.bsTanqueros.DataMember = "Tanqueros"
        Me.bsTanqueros.DataSource = Me.dsHojasRuta
        '
        'bsHojasRuta
        '
        Me.bsHojasRuta.DataMember = "HojasRuta"
        Me.bsHojasRuta.DataSource = Me.dsHojasRuta
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "Tanquero", True))
        Me.ComboBox2.DataSource = Me.bsTanqueros
        Me.ComboBox2.DisplayMember = "Descripcion"
        Me.ComboBox2.Location = New System.Drawing.Point(9, 59)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(224, 22)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "Codigo"
        '
        'dsHojasRuta
        '
        Me.dsHojasRuta.DataSetName = "HojasRutaDataSet"
        Me.dsHojasRuta.Prefix = ""
        Me.dsHojasRuta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsTractores
        '
        Me.bsTractores.DataMember = "Tractores"
        Me.bsTractores.DataSource = Me.dsHojasRuta
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "Cabezote", True))
        Me.ComboBox1.DataSource = Me.bsTractores
        Me.ComboBox1.DisplayMember = "Descripcion"
        Me.ComboBox1.Location = New System.Drawing.Point(9, 102)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 22)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "Codigo"
        '
        'bsProductos
        '
        Me.bsProductos.DataMember = "Productos"
        Me.bsProductos.DataSource = Me.dsProductos
        '
        'cbProducto
        '
        Me.cbProducto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "CodProducto", True))
        Me.cbProducto.DataSource = Me.bsProductos
        Me.cbProducto.DisplayMember = "Descripcion"
        Me.cbProducto.Location = New System.Drawing.Point(8, 16)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(225, 22)
        Me.cbProducto.TabIndex = 0
        Me.cbProducto.ValueMember = "Codigo"
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsChoferes
        '
        Me.bsChoferes.DataMember = "Choferes"
        Me.bsChoferes.DataSource = Me.dsHojasRuta
        '
        'ComboBox22
        '
        Me.ComboBox22.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "CodConductor", True))
        Me.ComboBox22.DataSource = Me.bsChoferes
        Me.ComboBox22.DisplayMember = "Nombre"
        Me.ComboBox22.Location = New System.Drawing.Point(9, 144)
        Me.ComboBox22.Name = "ComboBox22"
        Me.ComboBox22.Size = New System.Drawing.Size(225, 22)
        Me.ComboBox22.TabIndex = 3
        Me.ComboBox22.ValueMember = "Codigo"
        '
        'bsLugaresCarga
        '
        Me.bsLugaresCarga.DataMember = "LugaresCarga"
        Me.bsLugaresCarga.DataSource = Me.dsHojasRuta
        '
        'ComboBox21
        '
        Me.ComboBox21.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "CodLugarCargue", True))
        Me.ComboBox21.DataSource = Me.bsLugaresCarga
        Me.ComboBox21.DisplayMember = "Descripcion"
        Me.ComboBox21.Location = New System.Drawing.Point(8, 182)
        Me.ComboBox21.Name = "ComboBox21"
        Me.ComboBox21.Size = New System.Drawing.Size(225, 22)
        Me.ComboBox21.TabIndex = 4
        Me.ComboBox21.ValueMember = "Codigo"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.Text = "Tractor:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.Text = "Vehiculo:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "Conductor"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Lugar de cargue:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NumericInputBox3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.TextInputBox1)
        Me.TabPage2.Controls.Add(Me.NumericInputBox2)
        Me.TabPage2.Controls.Add(Me.NumericInputBox1)
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(232, 213)
        Me.TabPage2.Text = "Datos Adicionales"
        '
        'NumericInputBox3
        '
        Me.NumericInputBox3.AcceptZero = False
        Me.NumericInputBox3.AllowNegative = False
        Me.NumericInputBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "KilometrajeIniicial", True))
        Me.NumericInputBox3.Decimals = 0
        Me.NumericInputBox3.ErrorMessage = ""
        Me.NumericInputBox3.Format = ""
        Me.NumericInputBox3.HelpText = Nothing
        Me.NumericInputBox3.Location = New System.Drawing.Point(99, 61)
        Me.NumericInputBox3.MaxLength = 8
        Me.NumericInputBox3.Name = "NumericInputBox3"
        Me.NumericInputBox3.Required = False
        Me.NumericInputBox3.Size = New System.Drawing.Size(100, 21)
        Me.NumericInputBox3.TabIndex = 2
        Me.NumericInputBox3.TabOnEnter = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.Text = "KM Inicial:"
        '
        'TextInputBox1
        '
        Me.TextInputBox1.AcceptLetters = True
        Me.TextInputBox1.AcceptNumbers = True
        Me.TextInputBox1.AcceptPunctuations = True
        Me.TextInputBox1.AcceptSpaces = True
        Me.TextInputBox1.AcceptSymbols = True
        'Me.TextInputBox1.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.TextInputBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "NumRemision", True))
        Me.TextInputBox1.ErrorMessage = ""
        Me.TextInputBox1.HelpText = Nothing
        Me.TextInputBox1.InvalidChars = ""
        Me.TextInputBox1.Location = New System.Drawing.Point(99, 146)
        Me.TextInputBox1.MaxLength = 10
        Me.TextInputBox1.Name = "TextInputBox1"
        Me.TextInputBox1.Required = False
        Me.TextInputBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextInputBox1.TabIndex = 5
        Me.TextInputBox1.TabOnEnter = True
        Me.TextInputBox1.ValidChars = ""
        '
        'NumericInputBox2
        '
        Me.NumericInputBox2.AcceptZero = False
        Me.NumericInputBox2.AllowNegative = False
        Me.NumericInputBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "PesoFinal", True))
        Me.NumericInputBox2.Decimals = 0
        Me.NumericInputBox2.ErrorMessage = ""
        Me.NumericInputBox2.Format = ""
        Me.NumericInputBox2.HelpText = Nothing
        Me.NumericInputBox2.Location = New System.Drawing.Point(99, 119)
        Me.NumericInputBox2.MaxLength = 8
        Me.NumericInputBox2.Name = "NumericInputBox2"
        Me.NumericInputBox2.Required = False
        Me.NumericInputBox2.Size = New System.Drawing.Size(100, 21)
        Me.NumericInputBox2.TabIndex = 4
        Me.NumericInputBox2.TabOnEnter = True
        '
        'NumericInputBox1
        '
        Me.NumericInputBox1.AcceptZero = False
        Me.NumericInputBox1.AllowNegative = False
        Me.NumericInputBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "PesoInicial", True))
        Me.NumericInputBox1.Decimals = 0
        Me.NumericInputBox1.ErrorMessage = ""
        Me.NumericInputBox1.Format = ""
        Me.NumericInputBox1.HelpText = Nothing
        Me.NumericInputBox1.Location = New System.Drawing.Point(99, 90)
        Me.NumericInputBox1.MaxLength = 8
        Me.NumericInputBox1.Name = "NumericInputBox1"
        Me.NumericInputBox1.Required = False
        Me.NumericInputBox1.Size = New System.Drawing.Size(100, 21)
        Me.NumericInputBox1.TabIndex = 3
        Me.NumericInputBox1.TabOnEnter = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsHojasRuta, "SalidaInicioRuta", True))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(69, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(141, 22)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsHojasRuta, "LLegadaInicioRuta", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(69, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 22)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(10, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 20)
        Me.Label12.Text = "Salida:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.Text = "LLegada:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.Text = "Num. Remisión:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 20)
        Me.Label10.Text = "Pesada Final"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.Text = "Pesada Inicial:"
        '
        'InicioRutaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "InicioRutaForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuIniciarRuta As System.Windows.Forms.MenuItem
    Friend WithEvents menuGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbProducto As OpenNETCF.Windows.Forms.ComboBox2
    Friend WithEvents ComboBox22 As OpenNETCF.Windows.Forms.ComboBox2
    Friend WithEvents ComboBox21 As OpenNETCF.Windows.Forms.ComboBox2
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextInputBox1 As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents NumericInputBox2 As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents NumericInputBox1 As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericInputBox3 As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents dsHojasRuta As Oxigenos.Liquidos.HojasRutaDataSet
    Friend WithEvents bsHojasRuta As System.Windows.Forms.BindingSource
    Friend WithEvents bsChoferes As System.Windows.Forms.BindingSource
    Friend WithEvents bsLugaresCarga As System.Windows.Forms.BindingSource
    Friend WithEvents dsProductos As Oxigenos.Liquidos.ProductosDataSet
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bsTanqueros As System.Windows.Forms.BindingSource
    Friend WithEvents bsTractores As System.Windows.Forms.BindingSource
End Class
