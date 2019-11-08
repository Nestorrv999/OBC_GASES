<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VentaManualForm
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
        Me.btnSalirVenta = New System.Windows.Forms.Button
        Me.btnContinuarVenta = New System.Windows.Forms.Button
        Me.rbServicio = New System.Windows.Forms.RadioButton
        Me.rbVentaProducto = New System.Windows.Forms.RadioButton
        Me.pnTipoDocumento = New System.Windows.Forms.Panel
        Me.rbRemision = New System.Windows.Forms.RadioButton
        Me.rbFactura = New System.Windows.Forms.RadioButton
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel3.SuspendLayout()
        Me.pnTipoDocumento.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(1, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 31)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 5)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(172, 20)
        Me.Label21.Text = "Venta Manual"
        '
        'btnSalirVenta
        '
        Me.btnSalirVenta.Location = New System.Drawing.Point(27, 141)
        Me.btnSalirVenta.Name = "btnSalirVenta"
        Me.btnSalirVenta.Size = New System.Drawing.Size(66, 20)
        Me.btnSalirVenta.TabIndex = 26
        Me.btnSalirVenta.Text = "Regresar"
        '
        'btnContinuarVenta
        '
        Me.btnContinuarVenta.Location = New System.Drawing.Point(99, 141)
        Me.btnContinuarVenta.Name = "btnContinuarVenta"
        Me.btnContinuarVenta.Size = New System.Drawing.Size(74, 20)
        Me.btnContinuarVenta.TabIndex = 25
        Me.btnContinuarVenta.Text = "&Continuar"
        '
        'rbServicio
        '
        Me.rbServicio.BackColor = System.Drawing.Color.MintCream
        Me.rbServicio.Location = New System.Drawing.Point(18, 62)
        Me.rbServicio.Name = "rbServicio"
        Me.rbServicio.Size = New System.Drawing.Size(138, 20)
        Me.rbServicio.TabIndex = 24
        Me.rbServicio.TabStop = False
        Me.rbServicio.Text = "Venta Servicio"
        '
        'rbVentaProducto
        '
        Me.rbVentaProducto.BackColor = System.Drawing.Color.MintCream
        Me.rbVentaProducto.Checked = True
        Me.rbVentaProducto.Location = New System.Drawing.Point(18, 40)
        Me.rbVentaProducto.Name = "rbVentaProducto"
        Me.rbVentaProducto.Size = New System.Drawing.Size(138, 20)
        Me.rbVentaProducto.TabIndex = 23
        Me.rbVentaProducto.Text = "Venta Producto"
        '
        'pnTipoDocumento
        '
        Me.pnTipoDocumento.BackColor = System.Drawing.Color.Linen
        Me.pnTipoDocumento.Controls.Add(Me.rbRemision)
        Me.pnTipoDocumento.Controls.Add(Me.rbFactura)
        Me.pnTipoDocumento.Enabled = False
        Me.pnTipoDocumento.Location = New System.Drawing.Point(27, 84)
        Me.pnTipoDocumento.Name = "pnTipoDocumento"
        Me.pnTipoDocumento.Size = New System.Drawing.Size(146, 51)
        '
        'rbRemision
        '
        Me.rbRemision.Location = New System.Drawing.Point(19, 26)
        Me.rbRemision.Name = "rbRemision"
        Me.rbRemision.Size = New System.Drawing.Size(96, 20)
        Me.rbRemision.TabIndex = 10
        Me.rbRemision.TabStop = False
        Me.rbRemision.Text = "Remisión"
        '
        'rbFactura
        '
        Me.rbFactura.Checked = True
        Me.rbFactura.Location = New System.Drawing.Point(19, 3)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(96, 20)
        Me.rbFactura.TabIndex = 9
        Me.rbFactura.Text = "Factura"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.MintCream
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(190, 185)
        Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 29
        Me.Shape1.Text = "Shape1"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'VentaManualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(190, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalirVenta)
        Me.Controls.Add(Me.btnContinuarVenta)
        Me.Controls.Add(Me.rbServicio)
        Me.Controls.Add(Me.rbVentaProducto)
        Me.Controls.Add(Me.pnTipoDocumento)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Shape1)
        Me.Name = "VentaManualForm"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.pnTipoDocumento.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnSalirVenta As System.Windows.Forms.Button
    Friend WithEvents btnContinuarVenta As System.Windows.Forms.Button
    Friend WithEvents rbServicio As System.Windows.Forms.RadioButton
    Friend WithEvents rbVentaProducto As System.Windows.Forms.RadioButton
    Friend WithEvents pnTipoDocumento As System.Windows.Forms.Panel
    Friend WithEvents rbRemision As System.Windows.Forms.RadioButton
    Friend WithEvents rbFactura As System.Windows.Forms.RadioButton
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
