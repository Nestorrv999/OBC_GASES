<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DocumentosManualesForm
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
        Me.Label21 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.btnRegresar = New OpenNETCF.Windows.Forms.Button2
        Me.rbDepositos = New System.Windows.Forms.RadioButton
        Me.rbContratos = New System.Windows.Forms.RadioButton
        Me.rbRecolecciones = New System.Windows.Forms.RadioButton
        Me.rbVenta = New System.Windows.Forms.RadioButton
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label21.Size = New System.Drawing.Size(182, 20)
        Me.Label21.Text = "Documentos Manuales"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.Panel1.Controls.Add(Me.btnContinuar)
        Me.Panel1.Controls.Add(Me.btnRegresar)
        Me.Panel1.Controls.Add(Me.rbDepositos)
        Me.Panel1.Controls.Add(Me.rbContratos)
        Me.Panel1.Controls.Add(Me.rbRecolecciones)
        Me.Panel1.Controls.Add(Me.rbVenta)
        Me.Panel1.Controls.Add(Me.Shape1)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 239)
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(126, 204)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(81, 20)
        Me.btnContinuar.TabIndex = 21
        Me.btnContinuar.Text = "&Continuar"
        '
        'btnRegresar
        '
        Me.btnRegresar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnRegresar.ImageIndex = -1
        Me.btnRegresar.ImageList = Nothing
        Me.btnRegresar.Location = New System.Drawing.Point(32, 204)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(88, 20)
        Me.btnRegresar.TabIndex = 20
        Me.btnRegresar.Text = "Regresar"
        '
        'rbDepositos
        '
        Me.rbDepositos.BackColor = System.Drawing.Color.White
        Me.rbDepositos.Location = New System.Drawing.Point(70, 100)
        Me.rbDepositos.Name = "rbDepositos"
        Me.rbDepositos.Size = New System.Drawing.Size(115, 25)
        Me.rbDepositos.TabIndex = 18
        Me.rbDepositos.TabStop = False
        Me.rbDepositos.Text = "Depósitos"
        '
        'rbContratos
        '
        Me.rbContratos.BackColor = System.Drawing.Color.White
        Me.rbContratos.Location = New System.Drawing.Point(70, 129)
        Me.rbContratos.Name = "rbContratos"
        Me.rbContratos.Size = New System.Drawing.Size(115, 25)
        Me.rbContratos.TabIndex = 16
        Me.rbContratos.TabStop = False
        Me.rbContratos.Text = "Contratos"
        '
        'rbRecolecciones
        '
        Me.rbRecolecciones.BackColor = System.Drawing.Color.White
        Me.rbRecolecciones.Location = New System.Drawing.Point(70, 72)
        Me.rbRecolecciones.Name = "rbRecolecciones"
        Me.rbRecolecciones.Size = New System.Drawing.Size(115, 25)
        Me.rbRecolecciones.TabIndex = 15
        Me.rbRecolecciones.TabStop = False
        Me.rbRecolecciones.Text = "Recolecciones"
        '
        'rbVenta
        '
        Me.rbVenta.BackColor = System.Drawing.Color.White
        Me.rbVenta.Checked = True
        Me.rbVenta.Location = New System.Drawing.Point(70, 47)
        Me.rbVenta.Name = "rbVenta"
        Me.rbVenta.Size = New System.Drawing.Size(115, 25)
        Me.rbVenta.TabIndex = 14
        Me.rbVenta.Text = "Venta"
        '
        'Shape1
        '
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(32, 26)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(175, 174)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 19
        Me.Shape1.Text = "Shape1"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'DocumentosManualesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.MainMenu1
        Me.Name = "DocumentosManualesForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents rbDepositos As System.Windows.Forms.RadioButton
    Friend WithEvents rbContratos As System.Windows.Forms.RadioButton
    Friend WithEvents rbRecolecciones As System.Windows.Forms.RadioButton
    Friend WithEvents rbVenta As System.Windows.Forms.RadioButton
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents btnRegresar As OpenNETCF.Windows.Forms.Button2
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
End Class
