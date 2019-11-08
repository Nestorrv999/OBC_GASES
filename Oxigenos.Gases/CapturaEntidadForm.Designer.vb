<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CapturaEntidadForm
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.bsEntidades = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdEntidades = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(1, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(237, 31)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(172, 20)
        Me.Label21.Text = "Entidades"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(148, 177)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 20)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "&Aceptar"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(41, 177)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(98, 20)
        Me.btnRegresar.TabIndex = 6
        Me.btnRegresar.Text = "&Sin Entidad"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 30)
        Me.Label1.Text = "Seleccione la entidad por la cuál va ser atendido el Paciente ..."
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsEntidades
        '
        Me.bsEntidades.DataMember = "EntidadCliente"
        Me.bsEntidades.DataSource = Me.dsPacientes
        '
        'grdEntidades
        '
        Me.grdEntidades.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdEntidades.DataSource = Me.bsEntidades
        Me.grdEntidades.Location = New System.Drawing.Point(3, 68)
        Me.grdEntidades.Name = "grdEntidades"
        Me.grdEntidades.Size = New System.Drawing.Size(231, 103)
        Me.grdEntidades.TabIndex = 12
        Me.grdEntidades.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn1)
        Me.DataGridTableStyle1.GridColumnStyles.Add(Me.DataGridTextBoxColumn2)
        Me.DataGridTableStyle1.MappingName = "EntidadCliente"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod.Entidad"
        Me.DataGridTextBoxColumn1.MappingName = "CodEntidad"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn2.MappingName = "Nombre"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 130
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(238, 206)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 15
        Me.Shape1.Text = "Shape1"
        '
        'CapturaEntidadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(238, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.grdEntidades)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Shape1)
        Me.Name = "CapturaEntidadForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents bsEntidades As System.Windows.Forms.BindingSource
    Friend WithEvents grdEntidades As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
End Class
