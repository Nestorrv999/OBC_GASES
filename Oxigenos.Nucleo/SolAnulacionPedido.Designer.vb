<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SolAnulacionPedido
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
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuRegresar = New System.Windows.Forms.MenuItem
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnsolanula = New System.Windows.Forms.Button
        Me.bsMotivosAnulacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnulacionPedidos = New Oxigenos.Principal.AnulacionPedidos
        Me.cmbmotivos = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblpedido = New System.Windows.Forms.Label
        Me.lblcliente = New System.Windows.Forms.Label
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
        Me.MenuItem1.Text = "Anulación"
        '
        'mnuRegresar
        '
        Me.mnuRegresar.Text = "Regresar"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 39)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(4, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(233, 33)
        Me.Label21.Text = "Solicitud de Anulación de Pedidos"
        '
        'btnsolanula
        '
        Me.btnsolanula.Location = New System.Drawing.Point(54, 230)
        Me.btnsolanula.Name = "btnsolanula"
        Me.btnsolanula.Size = New System.Drawing.Size(131, 20)
        Me.btnsolanula.TabIndex = 1
        Me.btnsolanula.Text = "&Solicitar Anulación"
        '
        'bsMotivosAnulacion
        '
        Me.bsMotivosAnulacion.DataMember = "MotivosAnulacion"
        Me.bsMotivosAnulacion.DataSource = Me.AnulacionPedidos
        '
        'AnulacionPedidos
        '
        Me.AnulacionPedidos.DataSetName = "AnulacionPedidos"
        Me.AnulacionPedidos.Prefix = ""
        Me.AnulacionPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbmotivos
        '
        Me.cmbmotivos.DataSource = Me.bsMotivosAnulacion
        Me.cmbmotivos.DisplayMember = "Motivo"
        Me.cmbmotivos.Location = New System.Drawing.Point(4, 191)
        Me.cmbmotivos.Name = "cmbmotivos"
        Me.cmbmotivos.Size = New System.Drawing.Size(233, 22)
        Me.cmbmotivos.TabIndex = 3
        Me.cmbmotivos.ValueMember = "Codigo"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(4, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 20)
        Me.Label1.Text = "Seleccione un Motivo de Anulación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.Text = "Pedido"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.Text = "Cliente"
        '
        'lblpedido
        '
        Me.lblpedido.Location = New System.Drawing.Point(70, 46)
        Me.lblpedido.Name = "lblpedido"
        Me.lblpedido.Size = New System.Drawing.Size(167, 20)
        '
        'lblcliente
        '
        Me.lblcliente.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblcliente.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblcliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblcliente.Location = New System.Drawing.Point(0, 85)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(240, 70)
        '
        'SolAnulacionPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.lblpedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbmotivos)
        Me.Controls.Add(Me.btnsolanula)
        Me.Controls.Add(Me.Panel3)
        Me.Menu = Me.mainMenu1
        Me.Name = "SolAnulacionPedido"
        Me.Text = "Praxair"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnsolanula As System.Windows.Forms.Button
    Friend WithEvents cmbmotivos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblpedido As System.Windows.Forms.Label
    Friend WithEvents lblcliente As System.Windows.Forms.Label
    Friend WithEvents bsMotivosAnulacion As System.Windows.Forms.BindingSource
    Friend WithEvents AnulacionPedidos As Oxigenos.Principal.AnulacionPedidos
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
