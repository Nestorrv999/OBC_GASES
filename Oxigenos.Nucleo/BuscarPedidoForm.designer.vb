<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BuscarPedidoForm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBusqueda = New DatascanCF.Windows.Forms.TextInputBox
        Me.cbCriterios = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MintCream
        Me.Label1.Location = New System.Drawing.Point(4, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.Text = "Buscar:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.AcceptLetters = True
        Me.txtBusqueda.AcceptNumbers = True
        Me.txtBusqueda.AcceptPunctuations = True
        Me.txtBusqueda.AcceptSpaces = True
        Me.txtBusqueda.AcceptSymbols = True
        'Me.txtBusqueda.CaseStyle = DatascanCF.Windows.Forms.CaseStyle.None
        Me.txtBusqueda.ErrorMessage = ""
        Me.txtBusqueda.HelpText = Nothing
        Me.txtBusqueda.InvalidChars = ""
        Me.txtBusqueda.Location = New System.Drawing.Point(4, 85)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Required = False
        Me.txtBusqueda.Size = New System.Drawing.Size(210, 21)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.TabOnEnter = True
        Me.txtBusqueda.ValidChars = ""
        '
        'cbCriterios
        '
        Me.cbCriterios.Items.Add("Codigo")
        Me.cbCriterios.Items.Add("Nombre")
        Me.cbCriterios.Items.Add("Direccion")
        Me.cbCriterios.Items.Add("Barrio")
        Me.cbCriterios.Location = New System.Drawing.Point(4, 47)
        Me.cbCriterios.Name = "cbCriterios"
        Me.cbCriterios.Size = New System.Drawing.Size(210, 22)
        Me.cbCriterios.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MintCream
        Me.Label2.Location = New System.Drawing.Point(4, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.Text = "Criterio:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(64, 112)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 20)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(142, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 20)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MintCream
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Buscar Pedido"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.MintCream
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(224, 145)
        'Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 9
        Me.Shape1.Text = "Shape1"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'BuscarPedidoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(225, 145)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cbCriterios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Shape1)
        Me.Name = "BuscarPedidoForm"
        Me.Text = "Buscar Pedido"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As DatascanCF.Windows.Forms.TextInputBox
    Friend WithEvents cbCriterios As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
