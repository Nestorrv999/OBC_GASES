<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VerAsignacionesForm
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
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblTitulo = New System.Windows.Forms.Label
        Me.bsAsignaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsPacientes = New Oxigenos.Gases.PacientesDataSet
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.lblTipoAsignacion = New System.Windows.Forms.Label
        Me.lstAsignaciones = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.btnRegresar = New System.Windows.Forms.Button
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
        Me.lblTitulo.Size = New System.Drawing.Size(155, 20)
        Me.lblTitulo.Text = "Recolecciones"
        '
        'bsAsignaciones
        '
        Me.bsAsignaciones.DataMember = "Asignaciones"
        Me.bsAsignaciones.DataSource = Me.dsPacientes
        '
        'dsPacientes
        '
        Me.dsPacientes.DataSetName = "PacientesDataSet"
        Me.dsPacientes.Prefix = ""
        Me.dsPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(129, 230)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(91, 22)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "&Aceptar"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.Text = "Tipo Asignación:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 54)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(234, 39)
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblTipoAsignacion
        '
        Me.lblTipoAsignacion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTipoAsignacion.Location = New System.Drawing.Point(115, 34)
        Me.lblTipoAsignacion.Name = "lblTipoAsignacion"
        Me.lblTipoAsignacion.Size = New System.Drawing.Size(43, 20)
        Me.lblTipoAsignacion.Text = "1"
        '
        'lstAsignaciones
        '
        Me.lstAsignaciones.CheckBoxes = True
        Me.lstAsignaciones.Columns.Add(Me.ColumnHeader1)
        Me.lstAsignaciones.Columns.Add(Me.ColumnHeader2)
        Me.lstAsignaciones.FullRowSelect = True
        Me.lstAsignaciones.Location = New System.Drawing.Point(3, 96)
        Me.lstAsignaciones.Name = "lstAsignaciones"
        Me.lstAsignaciones.Size = New System.Drawing.Size(234, 128)
        Me.lstAsignaciones.TabIndex = 5
        Me.lstAsignaciones.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. Asignación"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cod. Entidad"
        Me.ColumnHeader2.Width = 100
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(32, 230)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(91, 22)
        Me.btnRegresar.TabIndex = 10
        Me.btnRegresar.Text = "Regresar"
        '
        'VerAsignacionesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lstAsignaciones)
        Me.Controls.Add(Me.lblTipoAsignacion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "VerAsignacionesForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents bsAsignaciones As System.Windows.Forms.BindingSource
    Friend WithEvents dsPacientes As Oxigenos.Gases.PacientesDataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblTipoAsignacion As System.Windows.Forms.Label
    Friend WithEvents lstAsignaciones As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
