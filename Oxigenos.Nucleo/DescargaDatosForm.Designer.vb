<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class DescargaDatosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DescargaDatosForm))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.pnlAvance = New System.Windows.Forms.Panel
        Me.btnCancelar = New OpenNETCF.Windows.Forms.Button2
        Me.lblFase = New System.Windows.Forms.Label
        Me.pnlInfoTablas = New System.Windows.Forms.Panel
        Me.lblTabla = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pbAvanceTabla = New System.Windows.Forms.ProgressBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.pbAvanceTotal = New OpenNETCF.Windows.Forms.ProgressBar2
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblProceso = New System.Windows.Forms.Label
        Me.pnlError = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCerrarByError = New System.Windows.Forms.Button
        Me.lblError = New System.Windows.Forms.Label
        Me.pnlTerminado = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnTerminar = New System.Windows.Forms.Button
        Me.lblMensajeFinal = New System.Windows.Forms.Label
        Me.timerResetIdleState = New System.Windows.Forms.Timer
        Me.pnlEnviar = New System.Windows.Forms.Panel
        Me.AnimateCtl1 = New OpenNETCF.Windows.Forms.AnimateCtl
        Me.pnlAvance.SuspendLayout()
        Me.pnlInfoTablas.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlError.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlTerminado.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.pnlEnviar.SuspendLayout()
        Me.SuspendLayout()
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'pnlAvance
        '
        Me.pnlAvance.Controls.Add(Me.btnCancelar)
        Me.pnlAvance.Controls.Add(Me.lblFase)
        Me.pnlAvance.Controls.Add(Me.pnlInfoTablas)
        Me.pnlAvance.Controls.Add(Me.pnlEnviar)
        Me.pnlAvance.Location = New System.Drawing.Point(0, 23)
        Me.pnlAvance.Name = "pnlAvance"
        Me.pnlAvance.Size = New System.Drawing.Size(240, 245)
        '
        'btnCancelar
        '
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.ImageIndex = -1
        Me.btnCancelar.ImageList = Nothing
        Me.btnCancelar.Location = New System.Drawing.Point(78, 200)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 21)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'lblFase
        '
        Me.lblFase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFase.Location = New System.Drawing.Point(8, 18)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(217, 20)
        Me.lblFase.Text = "Fase"
        '
        'pnlInfoTablas
        '
        Me.pnlInfoTablas.Controls.Add(Me.lblTabla)
        Me.pnlInfoTablas.Controls.Add(Me.Label2)
        Me.pnlInfoTablas.Controls.Add(Me.pbAvanceTabla)
        Me.pnlInfoTablas.Controls.Add(Me.Label3)
        Me.pnlInfoTablas.Controls.Add(Me.pbAvanceTotal)
        Me.pnlInfoTablas.Location = New System.Drawing.Point(0, 45)
        Me.pnlInfoTablas.Name = "pnlInfoTablas"
        Me.pnlInfoTablas.Size = New System.Drawing.Size(239, 132)
        Me.pnlInfoTablas.Visible = False
        '
        'lblTabla
        '
        Me.lblTabla.Location = New System.Drawing.Point(8, 6)
        Me.lblTabla.Name = "lblTabla"
        Me.lblTabla.Size = New System.Drawing.Size(219, 36)
        Me.lblTabla.Text = "Procesando tabla CLIENTES"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 20)
        Me.Label2.Text = "Progreso Total:"
        '
        'pbAvanceTabla
        '
        Me.pbAvanceTabla.Location = New System.Drawing.Point(101, 48)
        Me.pbAvanceTabla.Name = "pbAvanceTabla"
        Me.pbAvanceTabla.Size = New System.Drawing.Size(124, 12)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.Text = "Progreso Tabla:"
        '
        'pbAvanceTotal
        '
        Me.pbAvanceTotal.BarColor = System.Drawing.SystemColors.Highlight
        Me.pbAvanceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAvanceTotal.Location = New System.Drawing.Point(8, 105)
        Me.pbAvanceTotal.Maximum = 100
        Me.pbAvanceTotal.Name = "pbAvanceTotal"
        Me.pbAvanceTotal.ShowPercentValueText = True
        Me.pbAvanceTotal.Size = New System.Drawing.Size(217, 17)
        Me.pbAvanceTotal.Step = 0
        Me.pbAvanceTotal.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.lblProceso)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 26)
        '
        'lblProceso
        '
        Me.lblProceso.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblProceso.ForeColor = System.Drawing.Color.White
        Me.lblProceso.Location = New System.Drawing.Point(3, 2)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(232, 20)
        Me.lblProceso.Text = "Descarga datos"
        '
        'pnlError
        '
        Me.pnlError.BackColor = System.Drawing.Color.Firebrick
        Me.pnlError.Controls.Add(Me.Label1)
        Me.pnlError.Controls.Add(Me.Panel1)
        Me.pnlError.Location = New System.Drawing.Point(0, 90)
        Me.pnlError.Name = "pnlError"
        Me.pnlError.Size = New System.Drawing.Size(240, 178)
        Me.pnlError.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 17)
        Me.Label1.Text = "Error realizando carga"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Panel1.Controls.Add(Me.btnCerrarByError)
        Me.Panel1.Controls.Add(Me.lblError)
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 155)
        '
        'btnCerrarByError
        '
        Me.btnCerrarByError.Location = New System.Drawing.Point(78, 132)
        Me.btnCerrarByError.Name = "btnCerrarByError"
        Me.btnCerrarByError.Size = New System.Drawing.Size(72, 20)
        Me.btnCerrarByError.TabIndex = 1
        Me.btnCerrarByError.Text = "Cerrar"
        '
        'lblError
        '
        Me.lblError.Location = New System.Drawing.Point(10, 9)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(215, 120)
        '
        'pnlTerminado
        '
        Me.pnlTerminado.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTerminado.Controls.Add(Me.Label4)
        Me.pnlTerminado.Controls.Add(Me.Panel4)
        Me.pnlTerminado.Location = New System.Drawing.Point(0, 90)
        Me.pnlTerminado.Name = "pnlTerminado"
        Me.pnlTerminado.Size = New System.Drawing.Size(240, 178)
        Me.pnlTerminado.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 21)
        Me.Label4.Text = "Terminado!"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.Controls.Add(Me.btnTerminar)
        Me.Panel4.Controls.Add(Me.lblMensajeFinal)
        Me.Panel4.Location = New System.Drawing.Point(0, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 155)
        '
        'btnTerminar
        '
        Me.btnTerminar.Location = New System.Drawing.Point(78, 132)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(72, 20)
        Me.btnTerminar.TabIndex = 1
        Me.btnTerminar.Text = "Cerrar"
        '
        'lblMensajeFinal
        '
        Me.lblMensajeFinal.Location = New System.Drawing.Point(10, 9)
        Me.lblMensajeFinal.Name = "lblMensajeFinal"
        Me.lblMensajeFinal.Size = New System.Drawing.Size(215, 120)
        Me.lblMensajeFinal.Text = "Proceso terminado"
        '
        'timerResetIdleState
        '
        Me.timerResetIdleState.Interval = 5000
        '
        'pnlEnviar
        '
        Me.pnlEnviar.Controls.Add(Me.AnimateCtl1)
        Me.pnlEnviar.Location = New System.Drawing.Point(0, 45)
        Me.pnlEnviar.Name = "pnlEnviar"
        Me.pnlEnviar.Size = New System.Drawing.Size(239, 132)
        Me.pnlEnviar.Visible = False
        '
        'AnimateCtl1
        '
        Me.AnimateCtl1.DelayInterval = 300
        'Me.AnimateCtl1.DrawDirection = OpenNETCF.Windows.Forms.DrawDirection.Horizontal
        Me.AnimateCtl1.FrameHeight = 60
        Me.AnimateCtl1.FrameWidth = 218
        Me.AnimateCtl1.Height = 60
        Me.AnimateCtl1.Image = CType(resources.GetObject("AnimateCtl1.Image"), System.Drawing.Image)
        Me.AnimateCtl1.Location = New System.Drawing.Point(10, 24)
        Me.AnimateCtl1.LoopCount = 0
        Me.AnimateCtl1.Name = "AnimateCtl1"
        Me.AnimateCtl1.Size = New System.Drawing.Size(218, 60)
        Me.AnimateCtl1.TabIndex = 0
        Me.AnimateCtl1.Width = 218
        '
        'DescargaDatosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlAvance)
        Me.Controls.Add(Me.pnlTerminado)
        Me.Controls.Add(Me.pnlError)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "DescargaDatosForm"
        Me.Text = "Comunicaciones"
        Me.pnlAvance.ResumeLayout(False)
        Me.pnlInfoTablas.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlError.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlTerminado.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.pnlEnviar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents pnlAvance As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As OpenNETCF.Windows.Forms.Button2
    Friend WithEvents lblTabla As System.Windows.Forms.Label
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents pbAvanceTotal As OpenNETCF.Windows.Forms.ProgressBar2
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblProceso As System.Windows.Forms.Label
    Friend WithEvents pnlError As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrarByError As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents pbAvanceTabla As System.Windows.Forms.ProgressBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlInfoTablas As System.Windows.Forms.Panel
    Friend WithEvents pnlTerminado As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnTerminar As System.Windows.Forms.Button
    Friend WithEvents lblMensajeFinal As System.Windows.Forms.Label
    Friend WithEvents timerResetIdleState As System.Windows.Forms.Timer
    Friend WithEvents pnlEnviar As System.Windows.Forms.Panel
    Friend WithEvents AnimateCtl1 As OpenNETCF.Windows.Forms.AnimateCtl
End Class
