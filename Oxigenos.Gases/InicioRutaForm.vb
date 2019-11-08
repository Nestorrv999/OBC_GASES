'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F02
'-----------------------------------------------------------------------------------------------------------------



Imports Oxigenos.Common

Public Class InicioRutaForm
    Implements IModuloPrograma

    Public Sub Run() Implements Common.IModuloPrograma.Run
        Dim dr As DataRow
        dr = Nucleo.RowParametros
        If dr IsNot Nothing Then
            If dr("DescargaRealizada") IsNot DBNull.Value Then
                If CBool(dr("DescargaRealizada")) = True Then
                    UIHandler.ShowError("Debe realizar la carga de datos!!")
                    Exit Sub
                End If
            End If
        End If

        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub InicioRutaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                mnuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub frmInicioRuta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me

        LoadParametros()

        If Nucleo.KilometrajeInicial <> " " And Nucleo.KilometrajeInicial <> "0" Then
            Me.txtKilometrajeInicial.Text = Nucleo.KilometrajeInicial
            Me.txtKilometrajeInicial.Enabled = False
        Else
            Me.txtKilometrajeInicial.Focus()
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub LoadParametros()
        lblCodConductor.Text = Nucleo.CodigoChofer
        lblDescripcionSucursal.Text = cstrDBNULL(Nucleo.RowParametros("NombreSucursal"))
        lblDireccion.Text = cstrDBNULL(Nucleo.RowParametros("DireccionTrasportadora"))
        lblFecha.Text = Today.ToString("dd/MM/yyyy")
        lblNitTransp.Text = cstrDBNULL(Nucleo.RowParametros("NitTrasportadora"))
        lblPlacaCamion.Text = cstrDBNULL(Nucleo.RowParametros("CodigoVehiculo"))
        lblRuta.Text = Nucleo.RutaPrincipal
        lblSucursal.Text = Nucleo.CodigoSucursal
        lblTelefono.Text = cstrDBNULL(Nucleo.RowParametros("TelefonoTransportador"))
    End Sub

    Private Sub mnuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub txtKilometrajeInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilometrajeInicial.KeyPress
        If e.KeyChar = vbCr Then
            If Me.txtKilometrajeInicial.Text = "" Then
                UIHandler.ShowError("Debe ingresar el Kilometraje Inicial!!")
                Me.txtKilometrajeInicial.Focus()
                Exit Sub
            End If

            If CLng(Me.txtKilometrajeInicial.Text) < 1 Or CLng(Me.txtKilometrajeInicial.Text) > 9999999 Then
                UIHandler.ShowError("Kilometraje Incorrecto!!")
                Me.txtKilometrajeInicial.Text = ""
                Me.txtKilometrajeInicial.Focus()
                Exit Sub
            End If

            If MsgBox("Esta seguro de iniciar la ruta?, no podrá realizar más carga", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
                ' Se guarda el kilometraje inicial
                Nucleo.KilometrajeInicial = Me.txtKilometrajeInicial.Text
                Me.txtKilometrajeInicial.Enabled = False


                '--MTOVAR_CO_147_ESP_REQ_GPRS_F02
                ''''ALMACENAR LA GUIA DE CARGA
                Try
                    GuiaCarga.OpenConnection()
                    GuiaCarga.crearGuiaCarga(GuiaCarga.obtenerMensajeChofer(), Now(), Nucleo.KilometrajeInicial)
                Catch ex As Exception
                    UIHandler.ShowError("No fue posible crear la guia de carga")
                    GuiaCarga.WriteLog(ex)
                Finally
                    'GuiaCarga.CloseConnection()
                End Try

                ''''
                '--FIN MTOVAR_CO_147_ESP_REQ_GPRS_F02
            Else
                Me.txtKilometrajeInicial.Text = ""
                Me.txtKilometrajeInicial.Focus()
            End If
        End If
    End Sub

    Private Sub txtKilometrajeInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKilometrajeInicial.TextChanged

    End Sub
End Class