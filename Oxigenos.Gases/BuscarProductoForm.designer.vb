<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BuscarProductoForm
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
        Dim Codigo As System.Windows.Forms.DataGridTextBoxColumn
        Dim Descripcion As System.Windows.Forms.DataGridTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsProductos = New Oxigenos.Gases.ProductosDataSet
        Me.grdProductos = New System.Windows.Forms.DataGrid
        Me.ProductosTableStyleDataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblCantidad = New System.Windows.Forms.Label
        Me.txtCantidad = New DatascanCF.Windows.Forms.NumericInputBox
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Codigo = New System.Windows.Forms.DataGridTextBoxColumn
        Descripcion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Codigo
        '
        Codigo.Format = ""
        Codigo.FormatInfo = Nothing
        Codigo.HeaderText = "Codigo"
        Codigo.MappingName = "Codigo"
        Codigo.NullText = ""
        Codigo.Width = 65
        '
        'Descripcion
        '
        Descripcion.Format = ""
        Descripcion.FormatInfo = Nothing
        Descripcion.HeaderText = "Descripcion"
        Descripcion.MappingName = "Descripcion"
        Descripcion.NullText = ""
        Descripcion.Width = 150
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(123, 237)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 20)
        Me.btnAceptar.TabIndex = 60
        Me.btnAceptar.Text = "&Aceptar"
        '
        'bsProductos
        '
        Me.bsProductos.DataMember = "Productos"
        Me.bsProductos.DataSource = Me.dsProductos
        '
        'dsProductos
        '
        Me.dsProductos.DataSetName = "ProductosDataSet"
        Me.dsProductos.Prefix = ""
        Me.dsProductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grdProductos
        '
        Me.grdProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdProductos.DataSource = Me.bsProductos
        Me.grdProductos.Location = New System.Drawing.Point(0, 28)
        Me.grdProductos.Name = "grdProductos"
        Me.grdProductos.Size = New System.Drawing.Size(240, 170)
        Me.grdProductos.TabIndex = 61
        Me.grdProductos.TableStyles.Add(Me.ProductosTableStyleDataGridTableStyle)
        '
        'ProductosTableStyleDataGridTableStyle
        '
        Me.ProductosTableStyleDataGridTableStyle.GridColumnStyles.Add(Codigo)
        Me.ProductosTableStyleDataGridTableStyle.GridColumnStyles.Add(Descripcion)
        Me.ProductosTableStyleDataGridTableStyle.MappingName = "Productos"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(32, 237)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 20)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "&Cancelar"
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
        Me.Label21.Text = "Seleccionar Producto"
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(6, 205)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(66, 20)
        Me.lblCantidad.Text = "Cantidad:"
        Me.lblCantidad.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.AcceptZero = False
        Me.txtCantidad.AllowNegative = False
        Me.txtCantidad.Decimals = 0
        Me.txtCantidad.ErrorMessage = ""
        Me.txtCantidad.Format = ""
        Me.txtCantidad.HelpText = Nothing
        Me.txtCantidad.Location = New System.Drawing.Point(69, 204)
        Me.txtCantidad.MaxLength = 4
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Required = False
        Me.txtCantidad.Size = New System.Drawing.Size(34, 21)
        Me.txtCantidad.TabIndex = 64
        Me.txtCantidad.TabOnEnter = True
        Me.txtCantidad.Visible = False
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'BuscarProductoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grdProductos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Menu = Me.MainMenu1
        Me.Name = "BuscarProductoForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GestorProductos As Oxigenos.Gases.GestorProductos
    Friend WithEvents dsProductos As Oxigenos.Gases.ProductosDataSet
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents grdProductos As System.Windows.Forms.DataGrid
    Friend WithEvents ProductosTableStyleDataGridTableStyle As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
End Class
