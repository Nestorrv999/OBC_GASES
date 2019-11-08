Public Class GestorAtencionPedidos

    Public Function verificarSiEsEntregaTotal(ByVal p_nopedido As String) As Boolean
        Dim rta As Boolean = True
        'Me.dtaDetallePedido.Connection = Me.Connection
        'Me.dtaDetalleGuiaAsignacionesRecolecciones.Connection = Me.Connection 'recolecciones
        'Me.dtaDetalleGuiaFacturasRemisiones.Connection = Me.Connection 'entregas
        'Dim capacidadatenci As Decimal = 0
        'Dim capacidadregped As Decimal = 0
        'Try
        '    Dim dta As New Oxigenos.Gases.AtencionPedidos.DetallePedidoDataTable
        '    dta = Me.dtaDetallePedido.GetDataBy(p_nopedido)
        '    For Each dr As DataRow In dta.Select
        '        capacidadatenci = 0
        '        capacidadregped = CDec(dr("capacidad"))
        '        'comparar contra lo entregado
        '        If CInt(dr("UnidadesPedidas")) > 0 Then
        '            ' es entrega
        '            capacidadatenci = Me.dtaDetalleGuiaFacturasRemisiones.obtenerCantidadProductoAtencion(dr("CodProducto").ToString, p_nopedido).Value
        '            If capacidadregped > capacidadatenci Then
        '                rta = False
        '            End If
        '        Else
        '            'es recolección
        '            capacidadatenci = Me.dtaDetalleGuiaAsignacionesRecolecciones.obtenerCantidadProductoAtencion(dr("CodProducto").ToString, p_nopedido).Value
        '            If capacidadregped > capacidadatenci Then
        '                rta = False
        '            End If
        '        End If
        '    Next
        'Catch ex As Exception
        '    Throw ex
        'End Try

        Return rta
    End Function
End Class
