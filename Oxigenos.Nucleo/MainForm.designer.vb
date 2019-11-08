<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lstModulos = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.menuCargarDatos = New System.Windows.Forms.MenuItem
        Me.menuDescargarDatos = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.menuConfiguracion = New System.Windows.Forms.MenuItem
        Me.menuSalir = New System.Windows.Forms.MenuItem
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.lblPrograma = New System.Windows.Forms.Label
        Me.lblIDTerminal = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblRutaPrincipal = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlIniciando = New System.Windows.Forms.Panel
        Me.AnimateCtl1 = New OpenNETCF.Windows.Forms.AnimateCtl
        Me.lblMensajeProceso = New System.Windows.Forms.Label
        Me.Shape1 = New DatascanCF.Windows.Forms.Shape
        Me.pnlIniciando.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 33)
        '
        'lstModulos
        '
        Me.lstModulos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstModulos.FullRowSelect = True
        Me.lstModulos.LargeImageList = Me.ImageList1
        Me.lstModulos.Location = New System.Drawing.Point(0, 73)
        Me.lstModulos.Name = "lstModulos"
        Me.lstModulos.Size = New System.Drawing.Size(242, 221)
        Me.lstModulos.SmallImageList = Me.ImageList1
        Me.lstModulos.TabIndex = 9
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.Images.Clear()
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource3"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource4"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource5"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource6"), System.Drawing.Image))
        Me.ImageList1.Images.Add(CType(resources.GetObject("resource7"), System.Drawing.Image))
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.Add(Me.MenuItem5)
        '
        'MenuItem5
        '
        Me.MenuItem5.MenuItems.Add(Me.menuCargarDatos)
        Me.MenuItem5.MenuItems.Add(Me.menuDescargarDatos)
        Me.MenuItem5.MenuItems.Add(Me.MenuItem1)
        Me.MenuItem5.MenuItems.Add(Me.menuConfiguracion)
        Me.MenuItem5.MenuItems.Add(Me.menuSalir)
        Me.MenuItem5.Text = "Archivo"
        '
        'menuCargarDatos
        '
        Me.menuCargarDatos.Text = "Cargar Datos..."
        '
        'menuDescargarDatos
        '
        Me.menuDescargarDatos.Text = "Descargar Datos..."
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "-"
        '
        'menuConfiguracion
        '
        Me.menuConfiguracion.Text = "Configuración..."
        '
        'menuSalir
        '
        Me.menuSalir.Text = "Salir"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'lblPrograma
        '
        Me.lblPrograma.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrograma.ForeColor = System.Drawing.Color.Green
        Me.lblPrograma.Location = New System.Drawing.Point(3, 36)
        Me.lblPrograma.Name = "lblPrograma"
        Me.lblPrograma.Size = New System.Drawing.Size(234, 19)
        '
        'lblIDTerminal
        '
        Me.lblIDTerminal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblIDTerminal.ForeColor = System.Drawing.Color.Red
        Me.lblIDTerminal.Location = New System.Drawing.Point(65, 57)
        Me.lblIDTerminal.Name = "lblIDTerminal"
        Me.lblIDTerminal.Size = New System.Drawing.Size(70, 16)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(4, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.Text = "ID Terminal:"
        '
        'lblRutaPrincipal
        '
        Me.lblRutaPrincipal.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblRutaPrincipal.ForeColor = System.Drawing.Color.Red
        Me.lblRutaPrincipal.Location = New System.Drawing.Point(179, 57)
        Me.lblRutaPrincipal.Name = "lblRutaPrincipal"
        Me.lblRutaPrincipal.Size = New System.Drawing.Size(60, 15)
        Me.lblRutaPrincipal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(142, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 20)
        Me.Label5.Text = "Ruta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnlIniciando
        '
        Me.pnlIniciando.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlIniciando.Controls.Add(Me.AnimateCtl1)
        Me.pnlIniciando.Controls.Add(Me.lblMensajeProceso)
        Me.pnlIniciando.Controls.Add(Me.Shape1)
        Me.pnlIniciando.Location = New System.Drawing.Point(25, 121)
        Me.pnlIniciando.Name = "pnlIniciando"
        Me.pnlIniciando.Size = New System.Drawing.Size(190, 62)
        '
        'AnimateCtl1
        '
        Me.AnimateCtl1.DelayInterval = 200
        'Me.AnimateCtl1.DrawDirection = OpenNETCF.Windows.Forms.DrawDirection.Vertical
        Me.AnimateCtl1.FrameHeight = 11
        Me.AnimateCtl1.FrameWidth = 45
        Me.AnimateCtl1.Height = 11
        Me.AnimateCtl1.Image = CType(resources.GetObject("AnimateCtl1.Image"), System.Drawing.Image)
        Me.AnimateCtl1.Location = New System.Drawing.Point(73, 36)
        Me.AnimateCtl1.LoopCount = 0
        Me.AnimateCtl1.Name = "AnimateCtl1"
        Me.AnimateCtl1.Size = New System.Drawing.Size(45, 11)
        Me.AnimateCtl1.TabIndex = 2
        Me.AnimateCtl1.Width = 45
        '
        'lblMensajeProceso
        '
        Me.lblMensajeProceso.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblMensajeProceso.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMensajeProceso.Location = New System.Drawing.Point(14, 13)
        Me.lblMensajeProceso.Name = "lblMensajeProceso"
        Me.lblMensajeProceso.Size = New System.Drawing.Size(162, 20)
        Me.lblMensajeProceso.Text = "Iniciando Aplicación..."
        Me.lblMensajeProceso.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Shape1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Shape1.Enabled = False
        Me.Shape1.Location = New System.Drawing.Point(0, 0)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(190, 62)
        'Me.Shape1.Style = DatascanCF.Windows.Forms.Shape.ShapeStyle.Rectangle
        Me.Shape1.TabIndex = 1
        Me.Shape1.Text = "Shape1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlIniciando)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lstModulos)
        Me.Controls.Add(Me.lblRutaPrincipal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblIDTerminal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPrograma)
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.Text = "Praxair - Ver. 1.50.14"
        Me.pnlIniciando.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lstModulos As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents lblPrograma As System.Windows.Forms.Label
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents menuConfiguracion As System.Windows.Forms.MenuItem
    Friend WithEvents menuSalir As System.Windows.Forms.MenuItem
    Friend WithEvents lblIDTerminal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRutaPrincipal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents menuCargarDatos As System.Windows.Forms.MenuItem
    Friend WithEvents menuDescargarDatos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents pnlIniciando As System.Windows.Forms.Panel
    Friend WithEvents lblMensajeProceso As System.Windows.Forms.Label
    Friend WithEvents Shape1 As DatascanCF.Windows.Forms.Shape
    Friend WithEvents AnimateCtl1 As OpenNETCF.Windows.Forms.AnimateCtl

End Class
