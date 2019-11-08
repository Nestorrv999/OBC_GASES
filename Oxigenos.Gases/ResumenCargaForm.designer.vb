<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ResumenCargaForm
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
        Dim TipoProducto As System.Windows.Forms.DataGridTextBoxColumn
        Dim SaldoCliente As System.Windows.Forms.DataGridTextBoxColumn
        Dim Capacidad As System.Windows.Forms.DataGridTextBoxColumn
        Dim CodProducto As System.Windows.Forms.DataGridTextBoxColumn
        Dim CargadoPraxair As System.Windows.Forms.DataGridTextBoxColumn
        Dim CargadoCliente As System.Windows.Forms.DataGridTextBoxColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResumenCargaForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblProducto = New System.Windows.Forms.Label
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuRegresar = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblActivosPropio = New System.Windows.Forms.Label
        Me.lblReventaPropios = New System.Windows.Forms.Label
        Me.lblActivoAjenoLleno = New System.Windows.Forms.Label
        Me.lblActivoAjenoVacio = New System.Windows.Forms.Label
        Me.lblReventaAjenoLleno = New System.Windows.Forms.Label
        Me.lblReventaAjenoVacio = New System.Windows.Forms.Label
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.bsKardexCamion = New System.Windows.Forms.BindingSource(Me.components)
        Me.KardexCamionTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.SaldoPraxair = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grdResumen = New System.Windows.Forms.DataGrid
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        TipoProducto = New System.Windows.Forms.DataGridTextBoxColumn
        SaldoCliente = New System.Windows.Forms.DataGridTextBoxColumn
        Capacidad = New System.Windows.Forms.DataGridTextBoxColumn
        CodProducto = New System.Windows.Forms.DataGridTextBoxColumn
        CargadoPraxair = New System.Windows.Forms.DataGridTextBoxColumn
        CargadoCliente = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TipoProducto
        '
        TipoProducto.Format = ""
        TipoProducto.FormatInfo = Nothing
        TipoProducto.HeaderText = "Tipo"
        TipoProducto.MappingName = "CodTipoProducto"
        TipoProducto.NullText = ""
        TipoProducto.Width = 30
        '
        'SaldoCliente
        '
        SaldoCliente.Format = ""
        SaldoCliente.FormatInfo = Nothing
        SaldoCliente.HeaderText = "S.Ajen"
        SaldoCliente.MappingName = "SaldoCliente"
        SaldoCliente.NullText = "0"
        SaldoCliente.Width = 40
        '
        'Capacidad
        '
        Capacidad.Format = "###,##0"
        Capacidad.FormatInfo = Nothing
        Capacidad.HeaderText = "Cap."
        Capacidad.MappingName = "CapacidadNumerico"
        Capacidad.NullText = ""
        Capacidad.Width = 40
        '
        'CodProducto
        '
        CodProducto.Format = ""
        CodProducto.FormatInfo = Nothing
        CodProducto.HeaderText = "Producto"
        CodProducto.MappingName = "CodProducto"
        CodProducto.NullText = ""
        CodProducto.Width = 60
        '
        'CargadoPraxair
        '
        CargadoPraxair.Format = ""
        CargadoPraxair.FormatInfo = Nothing
        CargadoPraxair.HeaderText = "O.Praxair"
        CargadoPraxair.MappingName = "CantidadPraxair"
        CargadoPraxair.NullText = "0"
        CargadoPraxair.Width = 40
        '
        'CargadoCliente
        '
        CargadoCliente.Format = ""
        CargadoCliente.FormatInfo = Nothing
        CargadoCliente.HeaderText = "O.Ajen"
        CargadoCliente.MappingName = "CantidadCliente"
        CargadoCliente.NullText = "0"
        CargadoCliente.Width = 40
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 24)
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(4, 1)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(211, 20)
        Me.Label23.Text = "Resumen de Carga"
        '
        'lblProducto
        '
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblProducto.ForeColor = System.Drawing.Color.Red
        Me.lblProducto.Location = New System.Drawing.Point(5, 156)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(228, 15)
        Me.lblProducto.Text = "OXIGENO MEDICINAL"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem1)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.Text = "Propio"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(149, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.Text = "Lleno"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(191, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.Text = "Vacío"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(168, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.Text = "Ajeno"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(10, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.Text = "Cilind/Equipo"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.Text = "Producto"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblActivosPropio
        '
        Me.lblActivosPropio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblActivosPropio.Location = New System.Drawing.Point(95, 217)
        Me.lblActivosPropio.Name = "lblActivosPropio"
        Me.lblActivosPropio.Size = New System.Drawing.Size(46, 16)
        Me.lblActivosPropio.Text = "0"
        '
        'lblReventaPropios
        '
        Me.lblReventaPropios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReventaPropios.Location = New System.Drawing.Point(95, 235)
        Me.lblReventaPropios.Name = "lblReventaPropios"
        Me.lblReventaPropios.Size = New System.Drawing.Size(40, 16)
        Me.lblReventaPropios.Text = "0"
        '
        'lblActivoAjenoLleno
        '
        Me.lblActivoAjenoLleno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblActivoAjenoLleno.Location = New System.Drawing.Point(145, 217)
        Me.lblActivoAjenoLleno.Name = "lblActivoAjenoLleno"
        Me.lblActivoAjenoLleno.Size = New System.Drawing.Size(38, 16)
        Me.lblActivoAjenoLleno.Text = "0"
        '
        'lblActivoAjenoVacio
        '
        Me.lblActivoAjenoVacio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblActivoAjenoVacio.Location = New System.Drawing.Point(189, 217)
        Me.lblActivoAjenoVacio.Name = "lblActivoAjenoVacio"
        Me.lblActivoAjenoVacio.Size = New System.Drawing.Size(37, 16)
        Me.lblActivoAjenoVacio.Text = "0"
        '
        'lblReventaAjenoLleno
        '
        Me.lblReventaAjenoLleno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReventaAjenoLleno.Location = New System.Drawing.Point(145, 235)
        Me.lblReventaAjenoLleno.Name = "lblReventaAjenoLleno"
        Me.lblReventaAjenoLleno.Size = New System.Drawing.Size(40, 16)
        Me.lblReventaAjenoLleno.Text = "0"
        '
        'lblReventaAjenoVacio
        '
        Me.lblReventaAjenoVacio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReventaAjenoVacio.Location = New System.Drawing.Point(189, 235)
        Me.lblReventaAjenoVacio.Name = "lblReventaAjenoVacio"
        Me.lblReventaAjenoVacio.Size = New System.Drawing.Size(37, 16)
        Me.lblReventaAjenoVacio.Text = "0"
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsKardexCamion
        '
        Me.bsKardexCamion.DataMember = "KardexCamion"
        Me.bsKardexCamion.DataSource = Me.dsProductos
        '
        'KardexCamionTableStyleDataGridTableStyle
        '
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(CodProducto)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(Capacidad)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(Me.SaldoPraxair)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(SaldoCliente)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(TipoProducto)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(CargadoPraxair)
        Me.KardexCamionTableStyleDataGridTableStyle.GridColumnStyles.Add(CargadoCliente)
        Me.KardexCamionTableStyleDataGridTableStyle.MappingName = "KardexCamion"
        '
        'SaldoPraxair
        '
        Me.SaldoPraxair.Format = ""
        Me.SaldoPraxair.FormatInfo = Nothing
        Me.SaldoPraxair.HeaderText = "S.Prax"
        Me.SaldoPraxair.MappingName = "SaldoPraxair"
        Me.SaldoPraxair.NullText = "0"
        Me.SaldoPraxair.Width = 40
        '
        'grdResumen
        '
        Me.grdResumen.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdResumen.DataSource = Me.bsKardexCamion
        Me.grdResumen.Location = New System.Drawing.Point(0, 24)
        Me.grdResumen.Name = "grdResumen"
        Me.grdResumen.Size = New System.Drawing.Size(240, 129)
        Me.grdResumen.TabIndex = 32
        Me.grdResumen.TableStyles.Add(Me.KardexCamionTableStyleDataGridTableStyle)
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 91)
        '
        'ResumenCargaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdResumen)
        Me.Controls.Add(Me.lblReventaAjenoVacio)
        Me.Controls.Add(Me.lblReventaAjenoLleno)
        Me.Controls.Add(Me.lblActivoAjenoVacio)
        Me.Controls.Add(Me.lblActivoAjenoLleno)
        Me.Controls.Add(Me.lblReventaPropios)
        Me.Controls.Add(Me.lblActivosPropio)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Menu = Me.MainMenu1
        Me.Name = "ResumenCargaForm"
        Me.Text = "Praxair"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblActivosPropio As System.Windows.Forms.Label
    Friend WithEvents lblReventaPropios As System.Windows.Forms.Label
    Friend WithEvents lblActivoAjenoLleno As System.Windows.Forms.Label
    Friend WithEvents lblActivoAjenoVacio As System.Windows.Forms.Label
    Friend WithEvents lblReventaAjenoLleno As System.Windows.Forms.Label
    Friend WithEvents lblReventaAjenoVacio As System.Windows.Forms.Label
    Friend WithEvents GestorProductos As Oxigenos.Gases.GestorProductos
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents bsKardexCamion As System.Windows.Forms.BindingSource
    Friend WithEvents KardexCamionTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents grdResumen As System.Windows.Forms.DataGrid
    Friend WithEvents SaldoPraxair As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
