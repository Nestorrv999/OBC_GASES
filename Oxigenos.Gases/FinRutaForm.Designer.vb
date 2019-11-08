<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FinRutaForm
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
        Me.lblNitTransp = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblNombreTransp = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblTelefono = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.lblDireccion = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtKilometrajeInicial = New DatascanCF.Windows.Forms.NumericInputBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.UiHandler1 = New DatascanCF.Windows.Forms.UIHandler
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.lblRuta = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lblPlacaCamion = New System.Windows.Forms.Label
        Me.lblNombreConductor = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblCodConductor = New System.Windows.Forms.Label
        Me.lblDescripcionSucursal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSucursal = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.MenuRegresar = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNitTransp
        '
        Me.lblNitTransp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNitTransp.Location = New System.Drawing.Point(40, 13)
        Me.lblNitTransp.Name = "lblNitTransp"
        Me.lblNitTransp.Size = New System.Drawing.Size(162, 20)
        Me.lblNitTransp.Text = "805016737-1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblNitTransp)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.lblNombreTransp)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.lblTelefono)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.lblDireccion)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(232, 212)
        Me.TabPage2.Text = "Inf. Transportadora"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(7, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 20)
        Me.Label12.Text = "Nit:"
        '
        'lblNombreTransp
        '
        Me.lblNombreTransp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreTransp.Location = New System.Drawing.Point(7, 51)
        Me.lblNombreTransp.Name = "lblNombreTransp"
        Me.lblNombreTransp.Size = New System.Drawing.Size(226, 36)
        Me.lblNombreTransp.Text = "CCM INGENIERIA"
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(7, 36)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 20)
        Me.Label24.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTelefono.Location = New System.Drawing.Point(61, 138)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(72, 20)
        Me.lblTelefono.Text = "2 36 59 86"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(7, 138)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(58, 20)
        Me.Label28.Text = "Telefono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDireccion.Location = New System.Drawing.Point(7, 104)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(226, 34)
        Me.lblDireccion.Text = "CALLE 16 No. 20-10  "
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(7, 90)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 20)
        Me.Label27.Text = "Dirección:"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(10, 129)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(109, 20)
        Me.Label34.Text = "Placa Cisterna:"
        '
        'txtKilometrajeInicial
        '
        Me.txtKilometrajeInicial.AcceptZero = False
        Me.txtKilometrajeInicial.AllowNegative = False
        Me.txtKilometrajeInicial.Decimals = 0
        Me.txtKilometrajeInicial.ErrorMessage = ""
        Me.txtKilometrajeInicial.Format = ""
        Me.txtKilometrajeInicial.HelpText = Nothing
        Me.txtKilometrajeInicial.Location = New System.Drawing.Point(125, 180)
        Me.txtKilometrajeInicial.MaxLength = 7
        Me.txtKilometrajeInicial.Name = "txtKilometrajeInicial"
        Me.txtKilometrajeInicial.Required = False
        Me.txtKilometrajeInicial.Size = New System.Drawing.Size(91, 21)
        Me.txtKilometrajeInicial.TabIndex = 86
        Me.txtKilometrajeInicial.TabOnEnter = True
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(10, 179)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 20)
        Me.Label16.Text = "Kilometraje Final:"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFecha.Location = New System.Drawing.Point(100, 153)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(87, 20)
        Me.lblFecha.Text = "21/07/2007"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(10, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.Text = "Fecha Doc.:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(240, 32)
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(5, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(186, 20)
        Me.Label21.Text = "Fin de Ruta"
        '
        'UiHandler1
        '
        Me.UiHandler1.HelpControl = Nothing
        Me.UiHandler1.Parent = Nothing
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(100, 129)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 20)
        Me.Label15.Text = "XXXXX"
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(9, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.Text = "Placa Camión:"
        '
        'lblRuta
        '
        Me.lblRuta.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRuta.Location = New System.Drawing.Point(100, 40)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(101, 20)
        Me.lblRuta.Text = "HC10"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(10, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.Text = "Ruta:"
        '
        'lblPlacaCamion
        '
        Me.lblPlacaCamion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPlacaCamion.Location = New System.Drawing.Point(100, 99)
        Me.lblPlacaCamion.Name = "lblPlacaCamion"
        Me.lblPlacaCamion.Size = New System.Drawing.Size(101, 20)
        Me.lblPlacaCamion.Text = "VLG700"
        '
        'lblNombreConductor
        '
        Me.lblNombreConductor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNombreConductor.Location = New System.Drawing.Point(100, 77)
        Me.lblNombreConductor.Name = "lblNombreConductor"
        Me.lblNombreConductor.Size = New System.Drawing.Size(124, 20)
        Me.lblNombreConductor.Text = "PINZON ROJAS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 238)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblPlacaCamion)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.lblRuta)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.lblNombreConductor)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.lblCodConductor)
        Me.TabPage1.Controls.Add(Me.lblDescripcionSucursal)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.lblSucursal)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Controls.Add(Me.txtKilometrajeInicial)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.lblFecha)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 215)
        Me.TabPage1.Text = "Inf. Ruta"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(9, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.Text = "Conductor:"
        '
        'lblCodConductor
        '
        Me.lblCodConductor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCodConductor.Location = New System.Drawing.Point(100, 63)
        Me.lblCodConductor.Name = "lblCodConductor"
        Me.lblCodConductor.Size = New System.Drawing.Size(101, 20)
        Me.lblCodConductor.Text = "0374512"
        '
        'lblDescripcionSucursal
        '
        Me.lblDescripcionSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDescripcionSucursal.Location = New System.Drawing.Point(100, 18)
        Me.lblDescripcionSucursal.Name = "lblDescripcionSucursal"
        Me.lblDescripcionSucursal.Size = New System.Drawing.Size(112, 20)
        Me.lblDescripcionSucursal.Text = "BOGOTA"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.Text = "Sucursal:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(89, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 20)
        Me.Label4.Text = "-"
        '
        'lblSucursal
        '
        Me.lblSucursal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSucursal.Location = New System.Drawing.Point(69, 18)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(22, 20)
        Me.lblSucursal.Text = "01"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 238)
        '
        'MenuRegresar
        '
        Me.MenuRegresar.Text = "Regresar"
        '
        'MenuItem2
        '
        Me.MenuItem2.MenuItems.Add(Me.MenuRegresar)
        Me.MenuItem2.Text = "Opciones"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'FinRutaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.mainMenu1
        Me.MinimizeBox = False
        Me.Name = "FinRutaForm"
        Me.Text = "Praxair"
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNitTransp As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNombreTransp As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtKilometrajeInicial As DatascanCF.Windows.Forms.NumericInputBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UiHandler1 As DatascanCF.Windows.Forms.UIHandler
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblRuta As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblPlacaCamion As System.Windows.Forms.Label
    Friend WithEvents lblNombreConductor As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCodConductor As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionSucursal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuRegresar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents mainMenu1 As System.Windows.Forms.MainMenu
End Class
