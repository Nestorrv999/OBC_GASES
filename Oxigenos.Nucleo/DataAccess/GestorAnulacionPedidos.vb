'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F08
'--              Se crea el gestor para motivos de anulación
'-----------------------------------------------------------------------------------------------------------------

'--MTOVAR_CO_147_ESP_REQ_GPRS_F08
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlServerCe
Imports DatascanCF.Data
Public Class GestorAnulacionPedidos

    Public Function obtenerMotivos() As System.Data.DataSet



        Me.dtaMotivosAnulacion.Connection = Connection
        Me.dsAnulacionPedidos.MotivosAnulacion.Rows.Clear()
        Me.dtaMotivosAnulacion.Fill(Me.dsAnulacionPedidos.MotivosAnulacion)

        Return dsAnulacionPedidos


    End Function


    Public Function existeSolicitud(ByVal p_nopedido As String) As Boolean


        If Me.dtaSolicitud_Anula_Pedido.existeSolicitud(p_nopedido).Value < 1 Then
            Return False
        Else
            Return True
        End If
        'Dim sqlcmd As New SqlCeCommand

        'sqlcmd.CommandType = CommandType.Text
        'sqlcmd.Connection = Me.Connection
        'Dim idcarga As String = String.Empty
        'Dim existe As Integer = 0
        'Dim sqldr As SqlCeDataReader
        'Try
        '    'If Me.Connection.State <> ConnectionState.Open Then
        '    '    Me.Connection.Open()
        '    'End If

        '    sqlcmd.CommandText = "select MensajeChofer from parametros"
        '    sqldr = sqlcmd.ExecuteReader
        '    While (sqldr.Read)
        '        idcarga = CStr(sqldr("MensajeChofer"))
        '    End While

        '    sqldr.Close()

        '    sqlcmd.CommandText = "select count(*) cant from  solicitud_anula_pedido " & _
        '        "where nopedido='" & p_nopedido & "' " & _
        '        "and idcarga ='" & idcarga & "'"
        '    sqldr = sqlcmd.ExecuteReader
        '    While (sqldr.Read)
        '        existe = CInt(sqldr("cant"))
        '    End While

        '    sqldr.Close()

        '    If existe > 0 Then
        '        Return True
        '    Else
        '        Return False
        '    End If
        'Catch ex As Exception
        '    Return True
        '    'Finally
        '    '    Me.Connection.Close()
        'End Try


    End Function


    Public Function crearSolicitudDeAnulacion(ByVal p_nopedido As String, ByVal p_motivo As String) As Boolean



        'Dim sqlcmd As New SqlCeCommand
        'sqlcmd.CommandType = CommandType.Text
        'sqlcmd.Connection = Me.Connection
        '
        'Dim existe As Integer = 0
        'Dim sqldr As SqlCeDataReader
        'Try
        '    'If Me.Connection.State <> ConnectionState.Open Then
        '    '    Me.Connection.Open()
        '    'End If

        '    sqlcmd.CommandText = "select MensajeChofer from parametros"
        '    sqldr = sqlcmd.ExecuteReader
        '    While (sqldr.Read)
        '        idcarga = CStr(sqldr("MensajeChofer"))
        '    End While

        '    sqldr.Close()

        '    sqlcmd.CommandText = "select count(*) cant from  solicitud_anula_pedido " & _
        '        "where nopedido='" & p_nopedido & "' " & _
        '        "and idcarga ='" & idcarga & "'"
        '    sqldr = sqlcmd.ExecuteReader
        '    While (sqldr.Read)
        '        existe = CInt(sqldr("cant"))
        '    End While

        '    sqldr.Close()

        Try

            Me.dtaParametros.Connection = Connection
            Me.dsAnulacionPedidos.Parametros.Rows.Clear()

            Me.dtaParametros.Fill(Me.dsAnulacionPedidos.Parametros)
            Dim dr As DataRow = Me.dsAnulacionPedidos.Parametros.Rows(0) ''es la primera y unica fila
           

            Dim idcarga As String = dr("MensajeChofer").ToString


            Dim existe As Nullable(Of Integer) = Me.dtaSolicitud_Anula_Pedido.existeSolicitud(p_nopedido)


            Me.dtaSolicitud_Anula_Pedido.Connection = Me.Connection
            If existe.Value < 1 Then

                Me.dtaSolicitud_Anula_Pedido.crearSolicituddeAnulacion(idcarga, p_nopedido, p_motivo, Now(), "0")
                Me.dtaSolicitud_Anula_Pedido.Update(Me.dsAnulacionPedidos)
                Me.dsAnulacionPedidos.AcceptChanges()
            Else
                Me.dtaSolicitud_Anula_Pedido.ActualizarParaEnviarNuevamente(idcarga, p_nopedido)
                Me.dtaSolicitud_Anula_Pedido.Update(Me.dsAnulacionPedidos)
                Me.dsAnulacionPedidos.AcceptChanges()
            End If

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

End Class
