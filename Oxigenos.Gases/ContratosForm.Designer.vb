<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ContratosForm
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
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnContinuar = New System.Windows.Forms.Button
        Me.lblNoDocumento = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grdDetalle = New System.Windows.Forms.DataGrid
        Me.btnRegresar = New System.Windows.Forms.Button
        Me.Panel3.SuspendLayout()
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
        Me.Label21.Size = New System.Drawing.Size(172, 20)
        Me.Label21.Text = "Requiere Contrato"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.Text = "Se requiere registrar contrato por los activos a asignar"
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(146, 192)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(71, 20)
        Me.btnAnular.TabIndex = 12
        Me.btnAnular.Text = "&Anular"
        '
        'btnContinuar
        '
        Me.btnContinuar.Location = New System.Drawing.Point(120, 235)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(84, 20)
        Me.btnContinuar.TabIndex = 11
        Me.btnContinuar.Text = "&Continuar"
        '
        'lblNoDocumento
        '
        Me.lblNoDocumento.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNoDocumento.Location = New System.Drawing.Point(71, 192)
        Me.lblNoDocumento.Name = "lblNoDocumento"
        Me.lblNoDocumento.Size = New System.Drawing.Size(143, 20)
        Me.lblNoDocumento.Text = "xxx-xxxxxx"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.Text = "No. Doc.:"
        '
        'grdDetalle
        '
        Me.grdDetalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grdDetalle.Location = New System.Drawing.Point(3, 71)
        Me.grdDetalle.Name = "grdDetalle"
        Me.grdDetalle.Size = New System.Drawing.Size(234, 106)
        Me.grdDetalle.TabIndex = 15
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(30, 235)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(84, 20)
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "Regresar"
        '
        'ContratosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.grdDetalle)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.lblNoDocumento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "ContratosForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnContinuar As System.Windows.Forms.Button
    Friend WithEvents lblNoDocumento As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grdDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents btnRegresar As System.Windows.Forms.Button
End Class
