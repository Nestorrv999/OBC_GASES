<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FinRutaForm
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
        Me.menuGuardar = New System.Windows.Forms.MenuItem
        Me.menuCancelar = New System.Windows.Forms.MenuItem
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.bsHojasRuta = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsHojasRuta = New Oxigenos.Liquidos.HojasRutaDataSet
        Me.bsLugaresCarga = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbLugarDescarga = New OpenNETCF.Windows.Forms.ComboBox2(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.NumericInputBox1 = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.NumericInputBox2 = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.HojasRutaTableAdapter = New Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.HojasRutaTableAdapter
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.menuGuardar)
        Me.mainMenu1.MenuItems.Add(Me.menuCancelar)
        '
        'menuGuardar
        '
        Me.menuGuardar.Text = "Guardar"
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
        Me.Label11.Text = "Fin de Ruta"
        '
        'bsHojasRuta
        '
        Me.bsHojasRuta.DataMember = "HojasRuta"
        Me.bsHojasRuta.DataSource = Me.dsHojasRuta
        '
        'dsHojasRuta
        '
        Me.dsHojasRuta.DataSetName = "HojasRutaDataSet"
        Me.dsHojasRuta.Prefix = ""
        Me.dsHojasRuta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsLugaresCarga
        '
        Me.bsLugaresCarga.DataMember = "LugaresCarga"
        Me.bsLugaresCarga.DataSource = Me.dsHojasRuta
        '
        'cbLugarDescarga
        '
        Me.cbLugarDescarga.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsHojasRuta, "CodLugarDescargue", True))
        Me.cbLugarDescarga.DataSource = Me.bsLugaresCarga
        Me.cbLugarDescarga.DisplayMember = "Descripcion"
        Me.cbLugarDescarga.Location = New System.Drawing.Point(3, 118)
        Me.cbLugarDescarga.Name = "cbLugarDescarga"
        Me.cbLugarDescarga.Size = New System.Drawing.Size(225, 22)
        Me.cbLugarDescarga.TabIndex = 0
        Me.cbLugarDescarga.ValueMember = "Codigo"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Tanquero:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.Text = "Cabezote:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.Text = "Lugar de descargue:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(3, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 20)
        Me.Label8.Text = "KM Inicial:"
        '
        'NumericInputBox1
        '
        Me.NumericInputBox1.AcceptZero = False
        Me.NumericInputBox1.AllowNegative = False
        Me.NumericInputBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "PesoCierre", True))
        Me.NumericInputBox1.Decimals = 0
        Me.NumericInputBox1.ErrorMessage = ""
        Me.NumericInputBox1.Format = ""
        Me.NumericInputBox1.HelpText = Nothing
        Me.NumericInputBox1.Location = New System.Drawing.Point(74, 175)
        Me.NumericInputBox1.MaxLength = 8
        Me.NumericInputBox1.Name = "NumericInputBox1"
        Me.NumericInputBox1.Required = False
        Me.NumericInputBox1.Size = New System.Drawing.Size(100, 21)
        Me.NumericInputBox1.TabIndex = 2
        Me.NumericInputBox1.TabOnEnter = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(3, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 20)
        Me.Label9.Text = "Peso Cierre"
        '
        'NumericInputBox2
        '
        Me.NumericInputBox2.AcceptZero = False
        Me.NumericInputBox2.AllowNegative = False
        Me.NumericInputBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "KilometrajeFinal", True))
        Me.NumericInputBox2.Decimals = 0
        Me.NumericInputBox2.ErrorMessage = ""
        Me.NumericInputBox2.Format = ""
        Me.NumericInputBox2.HelpText = Nothing
        Me.NumericInputBox2.Location = New System.Drawing.Point(75, 146)
        Me.NumericInputBox2.MaxLength = 8
        Me.NumericInputBox2.Name = "NumericInputBox2"
        Me.NumericInputBox2.Required = False
        Me.NumericInputBox2.Size = New System.Drawing.Size(100, 21)
        Me.NumericInputBox2.TabIndex = 1
        Me.NumericInputBox2.TabOnEnter = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.Text = "KM Final:"
        '
        'Label4
        '
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "Tanquero", True))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(74, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        '
        'Label6
        '
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "Cabezote", True))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(74, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsHojasRuta, "KilometrajeIniicial", True))
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(74, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        '
        'HojasRutaTableAdapter
        '
        Me.HojasRutaTableAdapter.ClearBeforeFill = True
        '
        'FinRutaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericInputBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericInputBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbLugarDescarga)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "FinRutaForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents menuGuardar As System.Windows.Forms.MenuItem
    Friend WithEvents cbLugarDescarga As OpenNETCF.Windows.Forms.ComboBox2
    Friend WithEvents dsHojasRuta As Oxigenos.Liquidos.HojasRutaDataSet
    Friend WithEvents bsHojasRuta As System.Windows.Forms.BindingSource
    Friend WithEvents bsLugaresCarga As System.Windows.Forms.BindingSource
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumericInputBox1 As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents menuCancelar As System.Windows.Forms.MenuItem
    Friend WithEvents NumericInputBox2 As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HojasRutaTableAdapter As Oxigenos.Liquidos.HojasRutaDataSetTableAdapters.HojasRutaTableAdapter
End Class
