<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmEncuestaNiso
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
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.chkSatisfecho1 = New System.Windows.Forms.CheckBox
        Me.chkInsatisfecho1 = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkInstatisfecho2 = New System.Windows.Forms.CheckBox
        Me.chkSatisfecho2 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.MenuItem2)
        Me.MenuItem1.Text = "Menu"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Siguiente>"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 51)
        Me.Label1.Text = "Si con la atención a su requerimiento se siente satisfecho marque 1. sino marque " & _
            "2"
        '
        'chkSatisfecho1
        '
        Me.chkSatisfecho1.Location = New System.Drawing.Point(14, 67)
        Me.chkSatisfecho1.Name = "chkSatisfecho1"
        Me.chkSatisfecho1.Size = New System.Drawing.Size(100, 20)
        Me.chkSatisfecho1.TabIndex = 1
        Me.chkSatisfecho1.Text = "1 Satisfecho"
        '
        'chkInsatisfecho1
        '
        Me.chkInsatisfecho1.Location = New System.Drawing.Point(14, 93)
        Me.chkInsatisfecho1.Name = "chkInsatisfecho1"
        Me.chkInsatisfecho1.Size = New System.Drawing.Size(135, 20)
        Me.chkInsatisfecho1.TabIndex = 2
        Me.chkInsatisfecho1.Text = "2 Insatisfecho"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 51)
        Me.Label2.Text = "Si la atención prestada por nuestro personal fue buena marque 1. sino marque 2"
        '
        'chkInstatisfecho2
        '
        Me.chkInstatisfecho2.Location = New System.Drawing.Point(14, 196)
        Me.chkInstatisfecho2.Name = "chkInstatisfecho2"
        Me.chkInstatisfecho2.Size = New System.Drawing.Size(135, 20)
        Me.chkInstatisfecho2.TabIndex = 6
        Me.chkInstatisfecho2.Text = "2 Insatisfecho"
        '
        'chkSatisfecho2
        '
        Me.chkSatisfecho2.Location = New System.Drawing.Point(14, 170)
        Me.chkSatisfecho2.Name = "chkSatisfecho2"
        Me.chkSatisfecho2.Size = New System.Drawing.Size(100, 20)
        Me.chkSatisfecho2.TabIndex = 5
        Me.chkSatisfecho2.Text = "1 Satisfecho"
        '
        'FrmEncuestaNiso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.chkInstatisfecho2)
        Me.Controls.Add(Me.chkSatisfecho2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkInsatisfecho1)
        Me.Controls.Add(Me.chkSatisfecho1)
        Me.Controls.Add(Me.Label1)
        Me.Menu = Me.mainMenu1
        Me.Name = "FrmEncuestaNiso"
        Me.Text = "Encuesta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents chkSatisfecho1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkInsatisfecho1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkInstatisfecho2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSatisfecho2 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
End Class
