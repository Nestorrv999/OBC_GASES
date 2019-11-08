<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ReportesForm
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
        Me.menuRegresar = New System.Windows.Forms.MenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnPedidosAnulados = New System.Windows.Forms.Button
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.btnDocumentosGenerados = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        '
        'MenuItem1
        '
        Me.MenuItem1.MenuItems.Add(Me.menuRegresar)
        Me.MenuItem1.Text = "Reportes"
        '
        'menuRegresar
        '
        Me.menuRegresar.Text = "Regresar"
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
        Me.Label11.Text = "Reportes"
        '
        'btnPedidosAnulados
        '
        Me.btnPedidosAnulados.Location = New System.Drawing.Point(24, 43)
        Me.btnPedidosAnulados.Name = "btnPedidosAnulados"
        Me.btnPedidosAnulados.Size = New System.Drawing.Size(190, 31)
        Me.btnPedidosAnulados.TabIndex = 2
        Me.btnPedidosAnulados.Text = "Pedidos Anulados"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'btnDocumentosGenerados
        '
        Me.btnDocumentosGenerados.Location = New System.Drawing.Point(24, 80)
        Me.btnDocumentosGenerados.Name = "btnDocumentosGenerados"
        Me.btnDocumentosGenerados.Size = New System.Drawing.Size(190, 31)
        Me.btnDocumentosGenerados.TabIndex = 4
        Me.btnDocumentosGenerados.Text = "Documentos Generados"
        '
        'ReportesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDocumentosGenerados)
        Me.Controls.Add(Me.btnPedidosAnulados)
        Me.Controls.Add(Me.Panel2)
        Me.Menu = Me.mainMenu1
        Me.Name = "ReportesForm"
        Me.Text = "Praxair"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents menuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents btnPedidosAnulados As System.Windows.Forms.Button
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents btnDocumentosGenerados As System.Windows.Forms.Button
End Class
