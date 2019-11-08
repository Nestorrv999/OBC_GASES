<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DireccionesClienteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DireccionesClienteForm))
        Me.dsNucleo = New Oxigenos.Principal.NucleoDataSet
        Me.bsClientes = New System.Windows.Forms.BindingSource(Me.components)
        Me.NombreLabel1 = New System.Windows.Forms.Label
        Me.bsDirecciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.DireccionLabel1 = New System.Windows.Forms.Label
        Me.BarrioLabel1 = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAceptar = New OpenNETCF.Windows.Forms.Button2
        Me.btnAnterior = New OpenNETCF.Windows.Forms.PictureBox2
        Me.btnSiguiente = New OpenNETCF.Windows.Forms.PictureBox2
        Me.lblPosicion = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dsNucleo
        '
        Me.dsNucleo.DataSetName = "dsNucleo"
        Me.dsNucleo.Prefix = ""
        Me.dsNucleo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsClientes
        '
        Me.bsClientes.DataMember = "Clientes"
        Me.bsClientes.DataSource = Me.dsNucleo
        '
        'NombreLabel1
        '
        Me.NombreLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsClientes, "Nombre", True))
        Me.NombreLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NombreLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.NombreLabel1.Location = New System.Drawing.Point(3, 19)
        Me.NombreLabel1.Name = "NombreLabel1"
        Me.NombreLabel1.Size = New System.Drawing.Size(214, 15)
        Me.NombreLabel1.Text = "Nombre"
        '
        'bsDirecciones
        '
        Me.bsDirecciones.DataMember = "DireccionesCliente"
        Me.bsDirecciones.DataSource = Me.dsNucleo
        '
        'DireccionLabel1
        '
        Me.DireccionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDirecciones, "Direccion", True))
        Me.DireccionLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DireccionLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DireccionLabel1.Location = New System.Drawing.Point(3, 45)
        Me.DireccionLabel1.Name = "DireccionLabel1"
        Me.DireccionLabel1.Size = New System.Drawing.Size(216, 42)
        Me.DireccionLabel1.Text = "Direccion"
        '
        'BarrioLabel1
        '
        Me.BarrioLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsDirecciones, "Barrio", True))
        Me.BarrioLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BarrioLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BarrioLabel1.Location = New System.Drawing.Point(2, 87)
        Me.BarrioLabel1.Name = "BarrioLabel1"
        Me.BarrioLabel1.Size = New System.Drawing.Size(220, 20)
        Me.BarrioLabel1.Text = "Barrio"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(225, 140)
        'Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 8
        Me.Shape1.Text = "Shape1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.NavajoWhite
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.NombreLabel1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 40)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 14)
        Me.Label1.Text = "Direcciones Cliente"
        '
        'btnAceptar
        '
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.ImageIndex = -1
        Me.btnAceptar.ImageList = Nothing
        Me.btnAceptar.Location = New System.Drawing.Point(155, 110)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(64, 20)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Cerrar"
        '
        'btnAnterior
        '
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.Location = New System.Drawing.Point(57, 112)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(22, 20)
        Me.btnAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Image = CType(resources.GetObject("btnSiguiente.Image"), System.Drawing.Image)
        Me.btnSiguiente.Location = New System.Drawing.Point(80, 112)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(24, 20)
        Me.btnSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        '
        'lblPosicion
        '
        Me.lblPosicion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPosicion.ForeColor = System.Drawing.Color.Blue
        Me.lblPosicion.Location = New System.Drawing.Point(3, 115)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(51, 15)
        Me.lblPosicion.Text = "1 de 5"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'DireccionesClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(225, 141)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPosicion)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BarrioLabel1)
        Me.Controls.Add(Me.DireccionLabel1)
        Me.Controls.Add(Me.Shape1)
        Me.Name = "DireccionesClienteForm"
        Me.Text = "Direcciones Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dsNucleo As Oxigenos.Principal.NucleoDataSet
    Friend WithEvents bsClientes As System.Windows.Forms.BindingSource
    Friend WithEvents NombreLabel1 As System.Windows.Forms.Label
    Friend WithEvents bsDirecciones As System.Windows.Forms.BindingSource
    Friend WithEvents DireccionLabel1 As System.Windows.Forms.Label
    Friend WithEvents BarrioLabel1 As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As OpenNETCF.Windows.Forms.Button2
    Friend WithEvents btnAnterior As OpenNETCF.Windows.Forms.PictureBox2
    Friend WithEvents btnSiguiente As OpenNETCF.Windows.Forms.PictureBox2
    Friend WithEvents lblPosicion As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
End Class
