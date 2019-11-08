'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           29/01/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F08
'--              Se crea gestor de carga
'-----------------------------------------------------------------------------------------------------------------

'--MTOVAR_CO_147_ESP_REQ_GPRS_F08

Public Class GestorCarga


    Public Sub ActualizaSolAnulacion()

        Try
            Me.dtaPedidos.Connection = Me.Connection
            Me.dtaPedidos.AnularPedido(EstadosPedido.Confirmadoanulado, EstadosPedido.Anulado)
            Me.dtaPedidos.Update(Me.dsCargaDataset.Pedidos)

            Me.dtaSolicitud_Anula_Pedido.Connection = Me.Connection
            Me.dtaSolicitud_Anula_Pedido.eliminarSolicitudesConfirmadas(EstadosPedido.Anulado, EstadosPedido.Normal)
            Me.dtaSolicitud_Anula_Pedido.Update(Me.dsCargaDataset.Solicitud_Anula_Pedido)

            Me.dtaConfirmacionAnulacionPedido.Connection = Me.Connection
            Me.dtaConfirmacionAnulacionPedido.limpiarConfirmaciones()
            Me.dtaConfirmacionAnulacionPedido.Update(Me.dsCargaDataset.ConfirmacionAnulacionPedido)

            'ACEPTAR CAMBIOS

            Me.dsCargaDataset.AcceptChanges()

            
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub ActualizaPedidosReasignados()


        Try

            Me.dtaPedidos.Connection = Me.Connection
            Me.dtaPedidos.registrarReasignacion(EstadosPedido.Reasignado)
            Me.dtaPedidos.Update(Me.dsCargaDataset.Pedidos)

            Me.dtaPedidosReasignados.Connection = Me.Connection
            Me.dtaPedidosReasignados.limpiarPedidosReasignados()
            Me.dtaPedidosReasignados.Update(Me.dsCargaDataset.PedidosReasignados)

            Me.dsCargaDataset.AcceptChanges()
        Catch ex As Exception
            Throw ex
        End Try



    End Sub


    Public Sub limpiarSolAnulaciones()
        Try
            Me.dtaSolicitud_Anula_Pedido.Connection = Me.Connection
            Me.dtaSolicitud_Anula_Pedido.actualizarSolicitudesTransmitidas("1", "0")
            Me.dtaSolicitud_Anula_Pedido.Update(Me.dsCargaDataset.Solicitud_Anula_Pedido)
            Me.dsCargaDataset.AcceptChanges()
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

End Class
