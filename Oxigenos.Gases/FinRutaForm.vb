'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F02
'-----------------------------------------------------------------------------------------------------------------

Imports Oxigenos.Common

Public Class FinRutaForm
    Implements IModuloPrograma

    Public Sub Run() Implements Common.IModuloPrograma.Run
        If Nucleo.KilometrajeInicial = " " Or Nucleo.KilometrajeInicial = "0" Then
            UIHandler.ShowError("La ruta no se ha iniciado!!")
            Exit Sub
        End If

        'If Pedidos.GetPedidosPendientes() Then
        '    UIHandler.ShowError("Existen pedidos pendientes!!," & vbCrLf & "No se puede finalizar la ruta")
        '    Exit Sub
        'End If

        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub FinRutaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                MenuRegresar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub FinRutaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me

        LoadParametros()
        If Nucleo.KiloMetrajeFinal <> " " And Nucleo.KiloMetrajeFinal <> "0" Then
            Me.txtKilometrajeInicial.Text = Nucleo.KiloMetrajeFinal
            Me.txtKilometrajeInicial.ReadOnly = True
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

    Private Sub txtKilometrajeInicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilometrajeInicial.KeyPress
        If e.KeyChar = vbCr Then
            If Me.txtKilometrajeInicial.Text = "" Then
                UIHandler.ShowError("Debe ingresar el Kilometraje Final!!")
                Me.txtKilometrajeInicial.Focus()
                Exit Sub
            End If

            If CLng(Me.txtKilometrajeInicial.Text) < CLng(Nucleo.KilometrajeInicial) Or CLng(Me.txtKilometrajeInicial.Text) > 9999999 Then
                UIHandler.ShowError("Kilometraje Incorrecto!!")
                Me.txtKilometrajeInicial.Text = ""
                Me.txtKilometrajeInicial.Focus()
                Exit Sub
            End If

            If MsgBox("Esta seguro de finalizar la ruta?, no podrá realizar más atención?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
                ' Se guarda el kilometraje final
                Nucleo.KiloMetrajeFinal = Me.txtKilometrajeInicial.Text
                Me.txtKilometrajeInicial.ReadOnly = True

                '--MTOVAR_CO_147_ESP_REQ_GPRS_F02
                ''''ACTUALIZAR LA GUIA DE CARGA
                Try

                    GuiaCarga.actualizarGuiaCarga(Nucleo.KiloMetrajeFinal, Now())

                  

                Catch ex As Exception
                    UIHandler.ShowError("No fue posible crear la guia de carga " & ex.Message)
                    GuiaCarga.WriteLog(ex)

                End Try

                ''''
                '--FIN MTOVAR_CO_147_ESP_REQ_GPRS_F02


            Else
                Me.txtKilometrajeInicial.Text = ""
                Me.txtKilometrajeInicial.Focus()
            End If
        End If
    End Sub

    Private Sub MenuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub


    Private Sub txtKilometrajeInicial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKilometrajeInicial.TextChanged

    End Sub
End Class