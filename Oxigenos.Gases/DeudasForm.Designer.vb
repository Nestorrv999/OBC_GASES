<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DeudasForm
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
        Me.bsDeudas = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.txtPagar = New DatascanCF.Windows.Forms.NumericInputBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblAlquiler = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblFechaFinal = New System.Windows.Forms.Label
        Me.lblFechaInicial = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.grdDeudas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.btnGuardar = New System.Windows.Forms.Button
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
        Me.mnuRegresar.Text = "&Regresar"
        '
        'bsDeudas
        '
        Me.bsDeudas.DataMember = "AlquileresPendientes"
        Me.bsDeudas.DataSource = Me.dsPacientes
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPagar
        '
        Me.txtPagar.AcceptZero = False
        Me.txtPagar.AllowNegative = False
        Me.txtPagar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDeudas, "Pagar", True))
        Me.txtPagar.Decimals = 0
        Me.txtPagar.ErrorMessage = ""
        Me.txtPagar.Format = ""
        Me.txtPagar.HelpText = Nothing
        Me.txtPagar.Location = New System.Drawing.Point(79, 194)
        Me.txtPagar.MaxLength = 4
        Me.txtPagar.Name = "txtPagar"
        Me.txtPagar.Required = False
        Me.txtPagar.Size = New System.Drawing.Size(58, 21)
        Me.txtPagar.TabIndex = 36
        Me.txtPagar.TabOnEnter = True
        Me.txtPagar.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(79, 238)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(85, 20)
        Me.lblTotal.Text = "0"
        '
        'lblAlquiler
        '
        Me.lblAlquiler.Location = New System.Drawing.Point(78, 220)
        Me.lblAlquiler.Name = "lblAlquiler"
        Me.lblAlquiler.Size = New System.Drawing.Size(159, 20)
        Me.lblAlquiler.Text = "0+0=0"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.Text = "Total Selec.:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.Text = "Alq ="
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.Text = "A Pagar:"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDeudas, "FechaFin", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.lblFechaFinal.Location = New System.Drawing.Point(159, 173)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(74, 20)
        Me.lblFechaFinal.Text = "12/12/2007"
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDeudas, "FechaInicio", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.lblFechaInicial.Location = New System.Drawing.Point(40, 173)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(72, 20)
        Me.lblFechaInicial.Text = "12/12/2007"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(119, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.Text = "F.Fin:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.Text = "F.Ini:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(0, 141)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(240, 32)
        Me.lblDescripcion.Text = "Descripción Producto"
        '
        'grdDeudas
        '
        Me.grdDeudas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdDeudas.DataSource = Me.bsDeudas
        Me.grdDeudas.Location = New System.Drawing.Point(0, 27)
        Me.grdDeudas.Name = "grdDeudas"
        Me.grdDeudas.Size = New System.Drawing.Size(240, 111)
        Me.grdDeudas.TabIndex = 35
        Me.grdDeudas.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn3)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn1)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn2)
        Me.DataGridTableStyle1.MappingName = "AlquileresPendientes"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "No. Asignacion"
        Me.DataGridTextBoxColumn3.MappingName = "NoAsignacion"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn1.MappingName = "Dias"
        Me.DataGridTextBoxColumn1.NullText = "0"
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Pagar"
        Me.DataGridTextBoxColumn2.MappingName = "Pagar"
        Me.DataGridTextBoxColumn2.NullText = "0"
        Me.DataGridTextBoxColumn2.Width = 60
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 31)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(0, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(182, 20)
        Me.Label21.Text = "Deudas Pendientes"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(165, 238)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 20)
        Me.btnGuardar.TabIndex = 48
        Me.btnGuardar.Text = "&Aceptar"
        '
        'DeudasForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtPagar)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblAlquiler)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblFechaInicial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.grdDeudas)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "DeudasForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPagar As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblAlquiler As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFechaFinal As System.Windows.Forms.Label
    Friend WithEvents lblFechaInicial As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents grdDeudas As System.Windows.Forms.DataGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents bsDeudas As System.Windows.Forms.BindingSource
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
