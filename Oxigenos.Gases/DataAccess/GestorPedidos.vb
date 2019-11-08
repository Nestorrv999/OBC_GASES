Imports System.Data
Public Class GestorPedidos

    Public Function GetPedidosPendientes() As Boolean
        Dim dt As PedidosDataSet.PedidosDataTable
        Me.dtaPedidos.Connection = Connection
        dt = Me.dtaPedidos.GetPedidos()
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LoadDetallePedido(ByVal NoPedido As String)
        Me.dtaDetallePedido.Connection = Connection
        Me.dsPedidos.DetallePedido.Rows.Clear()
        Me.dtaDetallePedido.FillPedido(Me.dsPedidos.DetallePedido, NoPedido)
    End Sub

    Public Sub UpdatePedido(ByVal dt As DataRow)
        Me.dtaPedidos.Connection = Connection
        Me.dtaPedidos.Transaccion = Transaccion
        Me.dtaPedidos.Update(dt)
        dsPedidos.Pedidos.AcceptChanges()
    End Sub

    Public Sub UpdateDetallePedido(ByVal dt As PedidosDataSet.DetallePedidoDataTable)
        Me.dtaDetallePedido.Connection = Connection
        Me.dtaDetallePedido.Transaccion = Transaccion
        Me.dtaDetallePedido.Update(dt)
        dsPedidos.DetallePedido.AcceptChanges()
    End Sub

    Public Sub ActualizarDetallePedido(ByVal RowPedido As DataRow, ByVal RowCliente As DataRow, ByVal sCodFlete As String, _
    ByVal sCapacidad As String, ByVal sPertenencia As String, ByVal Row As ProductosDataSet.ProductosRow, _
    ByVal Cantidad As Short, ByVal Credito As String)
        Dim PrecioUnitario As Double
        Dim PorcentajeDescuento As Double
        Dim PorcentajeIva As Double
        Dim TotalDescuento As Double
        Dim Iva As Double
        Dim MontoTotal As Double
        Dim UnidadMedida As String = String.Empty
        Dim CantidadReal As Short
        Dim SubTotal As Double
        Dim RowDetalle As PedidosDataSet.DetallePedidoRow

        ' Se consulta si el detalle del pedido existe
        UnidadMedida = Row.UnidadMedida
        PorcentajeIva = Row.Iva

        RowDetalle = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(cstrDBNULL(RowPedido("NoPedido")), Row.Codigo, sCapacidad, "")

        If RowDetalle IsNot Nothing Then
            'Se toma el codigo del flete si ya lo tiene asignado
            If RowDetalle("CodFlete") IsNot DBNull.Value Then
                If RowDetalle.CodFlete <> "" And RowDetalle.CodFlete <> " " Then
                    sCodFlete = RowDetalle.CodFlete
                End If
            End If

            'Se inicializan las variables
            If RowDetalle("PrecioContado") Is DBNull.Value Then
                ' Se inicializan los campos
                RowDetalle.UnidadesVendidasContado = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.PrecioContado = 0
            ElseIf RowDetalle.PrecioContado = 0 Then
                RowDetalle.UnidadesVendidasContado = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.PrecioContado = 0
            End If

            If RowDetalle("PrecioCredito") Is DBNull.Value Then
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0

            ElseIf RowDetalle.PrecioCredito = 0 Then
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0
            End If

            CantidadReal = RowDetalle.UnidadesReales + Cantidad

            ' Se consultan los precios para el cliente
            Venta.ObtenerPrecio(RowCliente, "", False, False, Row.Codigo, PrecioUnitario, _
            PorcentajeDescuento, TotalDescuento, Row)

            ' Se calculan los totales
            SubTotal = PrecioUnitario * CDbl(sCapacidad) / 1000 * CantidadReal
            Iva = SubTotal * (PorcentajeIva / 100)
            MontoTotal = SubTotal + Iva

            ' Se actualiza el detalle del pedido
            If sPertenencia = Pertenencia.Cliente Then
                RowDetalle.UnidadesVendidasCliente = CantidadReal
            Else
                RowDetalle.UnidadesVendidasPraxair = CantidadReal
            End If
            RowDetalle.CodFlete = sCodFlete
            RowDetalle.Lastro = Row.Lastro
            RowDetalle.UnidadesReales = CantidadReal

            If Row.RequiereAsignacion = Asignacion.RequiereAsignacion And sPertenencia = Pertenencia.Praxair Then
                If RowDetalle("Asignaciones") Is DBNull.Value Then
                    RowDetalle.Asignaciones = Cantidad
                Else
                    RowDetalle.Asignaciones += Cantidad
                End If
            Else
                RowDetalle.Asignaciones = 0
            End If

            'If cstrDBNULL(RowCliente("TipoPago")) = TipoPago.Credito Then
            If Credito = "S" Then
                RowDetalle.PrecioCredito = Math.Round(CDec(PrecioUnitario))
                RowDetalle.TotalDescuentoCredito = Math.Round(CDec(TotalDescuento))
                RowDetalle.TotalIvaCredito = Math.Round(CDec(Iva))
                RowDetalle.SubTotalCredito = Math.Round(CDec(SubTotal))
                RowDetalle.MontoTotalCredito = Math.Round(CDec(MontoTotal))
                RowDetalle.UnidadesVendidasCredito = CantidadReal

                RowDetalle.PrecioContado = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.UnidadesVendidasContado = 0
            Else
                RowDetalle.PrecioContado = Math.Round(CDec(PrecioUnitario))
                RowDetalle.TotalDescuentoContado = Math.Round(CDec(TotalDescuento))
                RowDetalle.TotalIvaContado = Math.Round(CDec(Iva))
                RowDetalle.SubTotalContado = Math.Round(CDec(SubTotal))
                RowDetalle.MontoTotalContado = Math.Round(CDec(MontoTotal))
                RowDetalle.UnidadesVendidasContado = CantidadReal

                RowDetalle.PrecioCredito = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0
            End If

            ' Si las cantidades son todas cero se debe borrar la fila
            If RowDetalle.Asignaciones = 0 And RowDetalle.Recolecciones = 0 And _
            RowDetalle.UnidadesReales = 0 And RowDetalle.UnidadesPedidas = 0 Then
                RowDetalle.Delete()
            End If

            ' Se actualiza el flete si es necesario
            ActualizarFlete(cstrDBNULL(RowPedido("NoPedido")), sCodFlete, Cantidad, Row.Codigo, _
            sCapacidad, cstrDBNULL(RowCliente("TipoPago")), RowCliente, Credito)
        Else
            If Cantidad > 0 Then
                UnidadMedida = Row.UnidadMedida
                PorcentajeIva = Row.Iva

                ' Se consultan los precios para el cliente
                Venta.ObtenerPrecio(RowCliente, "", False, False, Row.Codigo, PrecioUnitario, _
                PorcentajeDescuento, TotalDescuento, Row)

                ' Se calculan los totales
                CantidadReal = Cantidad
                SubTotal = PrecioUnitario * CDbl(sCapacidad) / 1000 * Cantidad
                Iva = SubTotal * (PorcentajeIva / 100)
                MontoTotal = SubTotal + Iva

                RowDetalle = dsPedidos.DetallePedido.NewDetallePedidoRow

                RowDetalle.NoPedido = cstrDBNULL(RowPedido("NoPedido"))
                RowDetalle.NoAutorizacion = ""
                RowDetalle.CodProducto = Row.Codigo
                RowDetalle.Capacidad = sCapacidad
                If sPertenencia = Pertenencia.Cliente Then
                    RowDetalle.UnidadesVendidasCliente = CantidadReal
                    RowDetalle.UnidadesVendidasPraxair = 0
                Else
                    RowDetalle.UnidadesVendidasCliente = 0
                    RowDetalle.UnidadesVendidasPraxair = CantidadReal
                End If
                RowDetalle.UnidadesPedidas = 0
                RowDetalle.UnidadesReales = CantidadReal

                ' Se valida si el producto requiere asignacion
                If Row.RequiereAsignacion = Asignacion.RequiereAsignacion And sPertenencia = Pertenencia.Praxair Then
                    RowDetalle.Asignaciones = CantidadReal
                    RowDetalle.RequiereAsignacion = Row.RequiereAsignacion
                Else
                    RowDetalle.RequiereAsignacion = Asignacion.NoRequiereAsignacion
                    RowDetalle.Asignaciones = 0
                End If

                RowDetalle.Recolecciones = 0
                RowDetalle.Nuevo = "1"
                RowDetalle.UnidadMedidaVenta = UnidadMedida
                RowDetalle.DescripcionProducto = Row.Descripcion
                RowDetalle.TipoProducto = Row.CodTipoProducto
                RowDetalle.RequiereFlete = Row.RequiereFlete
                RowDetalle.CodFlete = sCodFlete
                RowDetalle.PorcentajeDescuento = Math.Round(CDec(PorcentajeDescuento))
                RowDetalle.PorcentajeImpuesto = Math.Round(CDec(PorcentajeIva))
                RowDetalle.CapacidadActivo = sCapacidad

                'If cstrDBNULL(RowCliente("TipoPago")) = TipoPago.Credito Then
                If Credito = "S" Then
                    RowDetalle.PrecioCredito = Math.Round(CDec(PrecioUnitario))
                    RowDetalle.TotalDescuentoCredito = Math.Round(CDec(TotalDescuento))
                    RowDetalle.TotalIvaCredito = Math.Round(CDec(Iva))
                    RowDetalle.SubTotalCredito = Math.Round(CDec(SubTotal))
                    RowDetalle.MontoTotalCredito = Math.Round(CDec(MontoTotal))
                    RowDetalle.UnidadesVendidasCredito = CantidadReal

                    RowDetalle.PrecioContado = 0
                    RowDetalle.UnidadesVendidasContado = 0
                    RowDetalle.TotalDescuentoContado = 0
                    RowDetalle.TotalIvaContado = 0
                    RowDetalle.SubTotalContado = 0
                    RowDetalle.MontoTotalContado = 0
                Else
                    RowDetalle.PrecioContado = Math.Round(CDec(PrecioUnitario))
                    RowDetalle.TotalDescuentoContado = CDec(TotalDescuento)
                    RowDetalle.TotalIvaContado = Math.Round(CDec(Iva))
                    RowDetalle.SubTotalContado = Math.Round(CDec(SubTotal))
                    RowDetalle.MontoTotalContado = Math.Round(CDec(MontoTotal))
                    RowDetalle.UnidadesVendidasContado = CantidadReal

                    RowDetalle.PrecioCredito = 0
                    RowDetalle.UnidadesVendidasCredito = 0
                    RowDetalle.TotalDescuentoCredito = 0
                    RowDetalle.TotalIvaCredito = 0
                    RowDetalle.SubTotalCredito = 0
                    RowDetalle.MontoTotalCredito = 0
                End If
                RowDetalle.Lastro = Row.Lastro

                dsPedidos.DetallePedido.AddDetallePedidoRow(RowDetalle)
                ' se actualiza el flete si es necesario
                ActualizarFlete(cstrDBNULL(RowPedido("NoPedido")), sCodFlete, Cantidad, Row.Codigo, sCapacidad, cstrDBNULL(RowCliente("TipoPago")), RowCliente, Credito)
            End If
        End If
    End Sub

    Public Function ActualizarDetallePedidoPaciente(ByVal RowPedido As DataRow, ByVal RowCliente As DataRow, ByVal sCodFlete As String, _
    ByVal sCapacidad As String, ByVal sPertenencia As String, ByVal Row As ProductosDataSet.ProductosRow, ByVal Cantidad As Short, _
    ByVal RowAutorizacion() As DataRow, ByVal CantidadContado As Short, ByVal CantidadCredito As Short, ByVal RespetaPrecio As Boolean) As Boolean

        Dim RowDetalle As PedidosDataSet.DetallePedidoRow
        Dim PrecioUnitario As Double
        Dim PorcentajeDescuento As Double
        Dim PorcentajeIva As Double
        Dim TotalDescuento As Double
        Dim UnidadMedida As String = String.Empty
        Dim Autorizado As Boolean = False
        Dim MontoCopago As Double = 0

        If RowAutorizacion IsNot Nothing Then
            If RowAutorizacion.Length > 0 Then
                Autorizado = True
            End If
        End If

        UnidadMedida = Row.UnidadMedida
        PorcentajeIva = Row.Iva

        ' Se consulta si el detalle del pedido existe
        If RowAutorizacion IsNot Nothing Then
            RowDetalle = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(cstrDBNULL(RowPedido("NoPedido")), Row.Codigo, sCapacidad, cstrDBNULL(RowAutorizacion(0)("NoAutorizacion")))
        Else
            RowDetalle = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(cstrDBNULL(RowPedido("NoPedido")), Row.Codigo, sCapacidad, "")
        End If

        If RowDetalle IsNot Nothing Then
            'Se toma el codigo del flete si ya lo tiene asignado
            If RowDetalle("CodFlete") IsNot DBNull.Value Then
                If RowDetalle.CodFlete <> "" And RowDetalle.CodFlete <> " " Then
                    sCodFlete = RowDetalle.CodFlete
                End If
            End If

            'Se inicializan las variables
            If RowDetalle("PrecioContado") Is DBNull.Value Then
                ' Se inicializan los campos
                RowDetalle.UnidadesVendidasContado = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.PrecioContado = 0
            ElseIf RowDetalle.PrecioContado = 0 And Row.CodTipoProducto <> TipoProducto.Activo Then
                RowDetalle.UnidadesVendidasContado = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.PrecioContado = 0
            End If

            If RowDetalle("PrecioCredito") Is DBNull.Value Then
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0
                RowDetalle.PrecioContado = 0
                RowDetalle.MontoTotalCopago = 0
            ElseIf RowDetalle.PrecioCredito = 0 And Row.CodTipoProducto <> TipoProducto.Activo Then
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0
                RowDetalle.PrecioContado = 0
                RowDetalle.MontoTotalCopago = 0
            End If

            RowDetalle.CodFlete = sCodFlete
            RowDetalle.CapacidadActivo = sCapacidad

            ' El producto no esta autorizado, se graba de contado
            If Not Autorizado Then
                GrabarProductoContado(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                Row, RowDetalle, Cantidad, sCapacidad, PorcentajeIva)
            Else
                If CantidadContado > 0 Then
                    GrabarProductoContado(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                    bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                    Row, RowDetalle, Cantidad, sCapacidad, PorcentajeIva)
                End If

                If CantidadCredito > 0 Then
                    GrabarProductoCredito(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                    bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                    Row, RowDetalle, Cantidad, RowAutorizacion, sCapacidad, PorcentajeIva, True)
                End If
            End If

            If sPertenencia = Pertenencia.Cliente Then
                RowDetalle.UnidadesVendidasCliente += Cantidad
            Else
                RowDetalle.UnidadesVendidasPraxair += Cantidad
            End If

            RowDetalle.UnidadesReales += Cantidad

            If Row.RequiereAsignacion = Asignacion.RequiereAsignacion And sPertenencia = Pertenencia.Praxair Then
                If RowDetalle("Asignaciones") Is DBNull.Value Then
                    RowDetalle.Asignaciones = Cantidad
                Else
                    RowDetalle.Asignaciones += Cantidad
                End If
            End If

            ' Se actualiza el flete si es necesario
            ActualizarFletePaciente(cstrDBNULL(RowPedido("NoPedido")), cstrDBNULL(RowCliente("CodTipoCliente")), _
            sCodFlete, Cantidad, Row.Codigo, sCapacidad, RowCliente, cstrDBNULL(RowPedido("CodEntidad")))
        Else
            If Cantidad > 0 Then
                RowDetalle = dsPedidos.DetallePedido.NewDetallePedidoRow

                ' Se inicializan los campos
                RowDetalle.UnidadesVendidasContado = 0
                RowDetalle.NoAutorizacion = ""
                RowDetalle.UnidadesVendidasCredito = 0
                RowDetalle.TotalIvaContado = 0
                RowDetalle.TotalIvaCredito = 0
                RowDetalle.TotalDescuentoContado = 0
                RowDetalle.TotalDescuentoCredito = 0
                RowDetalle.SubTotalContado = 0
                RowDetalle.SubTotalCredito = 0
                RowDetalle.MontoTotalContado = 0
                RowDetalle.MontoTotalCredito = 0
                RowDetalle.PrecioContado = 0
                RowDetalle.PrecioCredito = 0
                RowDetalle.PorcentajeImpuesto = 0
                RowDetalle.PorcentajeDescuento = 0
                RowDetalle.UnidadesVendidasPraxair = 0
                RowDetalle.UnidadesVendidasCliente = 0
                RowDetalle.UnidadesPedidas = 0
                RowDetalle.Asignaciones = 0
                RowDetalle.Recolecciones = 0
                RowDetalle.MontoTotalCuota = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.UnidadesReales = 0
                RowDetalle.Nuevo = "1"

                RowDetalle.NoPedido = cstrDBNULL(RowPedido("NoPedido"))
                RowDetalle.CodProducto = Row.Codigo
                RowDetalle.Capacidad = sCapacidad
                If sPertenencia = Pertenencia.Cliente Then
                    RowDetalle.UnidadesVendidasCliente = Cantidad
                Else
                    RowDetalle.UnidadesVendidasPraxair = Cantidad
                End If
                RowDetalle.UnidadesReales = Cantidad

                ' Se valida si el producto requiere asignacion
                If Row.RequiereAsignacion = Asignacion.RequiereAsignacion And sPertenencia = Pertenencia.Praxair Then
                    RowDetalle.Asignaciones = Cantidad
                    RowDetalle.RequiereAsignacion = Row.RequiereAsignacion
                Else
                    RowDetalle.Asignaciones = 0
                    RowDetalle.RequiereAsignacion = Asignacion.NoRequiereAsignacion
                End If

                RowDetalle.UnidadMedidaVenta = UnidadMedida
                RowDetalle.DescripcionProducto = Row.Descripcion
                RowDetalle.TipoProducto = Row.CodTipoProducto
                RowDetalle.RequiereFlete = Row.RequiereFlete
                RowDetalle.Lastro = Row.Lastro
                RowDetalle.CodFlete = sCodFlete
                RowDetalle.CapacidadActivo = sCapacidad

                If Not Autorizado Then
                    GrabarProductoContado(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                    bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                    Row, RowDetalle, Cantidad, sCapacidad, PorcentajeIva)
                Else
                    If CantidadContado > 0 Then
                        GrabarProductoContado(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                        bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                        Row, RowDetalle, Cantidad, sCapacidad, PorcentajeIva)
                    End If
                    If CantidadCredito > 0 Then
                        GrabarProductoCredito(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), _
                        bRespetaPrecio, PrecioUnitario, PorcentajeDescuento, TotalDescuento, _
                        Row, RowDetalle, Cantidad, RowAutorizacion, sCapacidad, PorcentajeIva, True)
                    End If
                End If

                ''DATASCAN 20171025
                ''CONSULTA LA TABLA DETALLEPEDIDOS Y SE VERIFICA SI EXISTE EL PEDIDO SIN "NRO. AUTORIZACION"
                'Dim RowDetalleAUX As PedidosDataSet.DetallePedidoRow
                'RowDetalleAUX = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(cstrDBNULL(RowDetalle.NoPedido), _
                '            RowDetalle.CodProducto, RowDetalle.Capacidad, "")
                'If RowDetalleAUX IsNot Nothing Then
                '    MessageBox.Show("El pedido no presenta autorización vigente, por favor genere un nuevo pedido.")
                '    Return False
                'End If
                ''FIN DATASCAN 20171025

                dsPedidos.DetallePedido.AddDetallePedidoRow(RowDetalle)
                ' se actualiza el flete si es necesario
                ActualizarFletePaciente(cstrDBNULL(RowPedido("NoPedido")), cstrDBNULL(RowCliente("CodTipoCliente")), _
                sCodFlete, Cantidad, Row.Codigo, sCapacidad, RowCliente, cstrDBNULL(RowPedido("CodEntidad")))
            End If
        End If
        Return True 'DATASCAN 20171025
    End Function

    Public Sub BorrarDetallePedidoPaciente(ByVal RowPedido As DataRow, ByVal RowCliente As DataRow, ByVal sCodFlete As String, _
    ByVal sCapacidad As String, ByVal sPertenencia As String, ByVal Row As ProductosDataSet.ProductosRow, ByVal Cantidad As Short, _
    ByVal RespetaPrecio As Boolean, ByVal CodProducto As String)

        Dim RowDetalle As PedidosDataSet.DetallePedidoRow
        Dim PrecioUnitario As Double
        Dim PorcentajeDescuento As Double
        Dim TotalDescuento As Double
        Dim Iva, SubTotal, MontoTotal As Double
        Dim UnidadMedida As String = String.Empty
        Dim MontoCopago As Double = 0
        Dim NoAutorizacion As String = String.Empty

        Dim fila As PedidosDataSet.DetallePedidoRow
        For Each fila In dsPedidos.DetallePedido.Rows
            If Not cstrDBNULL(fila.NoAutorizacion).Trim.Equals("") And fila.CodProducto = CodProducto And fila.Capacidad = sCapacidad Then
                NoAutorizacion = fila.NoAutorizacion
                Exit For
            End If
        Next

        ' Se consulta si el detalle del pedido existe
        RowDetalle = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(cstrDBNULL(RowPedido("NoPedido")), CodProducto, sCapacidad, NoAutorizacion)

        If RowDetalle IsNot Nothing Then

            If sPertenencia = Pertenencia.Praxair Then
                RowDetalle.UnidadesVendidasPraxair -= Cantidad
            Else
                RowDetalle.UnidadesVendidasCliente -= Cantidad
            End If
            RowDetalle.UnidadesReales -= Cantidad

            If RowDetalle.RequiereAsignacion = Asignacion.RequiereAsignacion And sPertenencia = Pertenencia.Praxair Then
                If CShortDBNull(RowDetalle.Asignaciones) < CShortDBNull(RowDetalle.Recolecciones) Then
                    RowDetalle.Recolecciones -= Cantidad
                End If

                RowDetalle.Asignaciones -= Cantidad
            End If

            If CIntDBNull(RowDetalle.UnidadesVendidasContado) > 0 Then
                ' Se consulta el precio del producto
                Venta.ObtenerPrecio(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), False, _
                RespetaPrecio, CodProducto, PrecioUnitario, PorcentajeDescuento, TotalDescuento, Row)

                ' Se calculan los totales
                SubTotal = RowDetalle.PrecioContado * CDbl(RowDetalle.Capacidad) / 1000 * Cantidad
                Iva = SubTotal * (RowDetalle.PorcentajeImpuesto / 100)
                MontoTotal = SubTotal + Iva

                RowDetalle.UnidadesVendidasContado -= Cantidad

                If CDblDBNull(RowDetalle.TotalDescuentoContado) > 0 Then
                    RowDetalle.TotalDescuentoContado -= Math.Round(CDec(TotalDescuento))
                End If
                If CDblDBNull(RowDetalle.TotalIvaContado) > 0 Then
                    RowDetalle.TotalIvaContado -= Math.Round(CDec(Iva))
                End If
                If CDblDBNull(RowDetalle.SubTotalContado) > 0 Then
                    RowDetalle.SubTotalContado -= Math.Round(CDec(SubTotal))
                End If
                If CDblDBNull(RowDetalle.MontoTotalContado) > 0 Then
                    RowDetalle.MontoTotalContado -= Math.Round(CDec(MontoTotal))
                End If
            Else
                ' Se consulta el precio del producto
                Venta.ObtenerPrecio(RowCliente, cstrDBNULL(RowPedido("CodEntidad")), True, _
                RespetaPrecio, CodProducto, PrecioUnitario, PorcentajeDescuento, TotalDescuento, Row)

                ' Se calculan los totales
                SubTotal = RowDetalle.PrecioCredito * CDbl(RowDetalle.Capacidad) / 1000 * Cantidad
                Iva = SubTotal * (RowDetalle.PorcentajeImpuesto / 100)
                MontoTotal = SubTotal + Iva
                RowDetalle.UnidadesVendidasCredito -= Cantidad

                If CDblDBNull(RowDetalle.TotalDescuentoCredito) > 0 Then
                    RowDetalle.TotalDescuentoCredito -= Math.Round(CDec(TotalDescuento))
                End If
                If CDblDBNull(RowDetalle.TotalIvaCredito) > 0 Then
                    RowDetalle.TotalIvaCredito -= Math.Round(CDec(Iva))
                End If
                If CDblDBNull(RowDetalle.SubTotalCredito) > 0 Then
                    RowDetalle.SubTotalCredito -= Math.Round(CDec(SubTotal))
                End If
                If CDblDBNull(RowDetalle.MontoTotalCredito) > 0 Then
                    RowDetalle.MontoTotalCredito -= Math.Round(CDec(MontoTotal))
                End If

                ' Restar los copagos
                If RowDetalle("TipoPago") IsNot DBNull.Value Then
                    If cstrDBNULL(RowDetalle.TipoPago) = Autorizaciones.Copago Then
                        MontoCopago = SubTotal * (CDbl(RowDetalle.Monto) / 100)
                        RowDetalle.MontoTotalCopago -= Math.Round(CDec(MontoCopago))
                    End If
                End If

                If RowDetalle("IdDetalleAutorizacion") IsNot DBNull.Value Then
                    ' Restar la cantidad de unidades autorizadas
                    Dim RowAutorizacion As PacientesDataSet.DetalleAutorizacionesRow
                    Dim UnidadesReales As Short

                    RowAutorizacion = Pacientes.dsPacientes.DetalleAutorizaciones.FindByIdDetalleAutorizacion(RowDetalle.IdDetalleAutorizacion)
                    If RowAutorizacion IsNot Nothing Then
                        If RowDetalle.TipoProducto = TipoProducto.Producto And RowDetalle.Lastro = Lastro.Controla Then
                            UnidadesReales = Cantidad * CShort((CDbl(RowDetalle.Capacidad) / 1000))
                        Else
                            UnidadesReales = Cantidad
                        End If
                        RowAutorizacion.UnidadesUtilizadas -= UnidadesReales
                    End If
                End If
            End If
        End If
        If cstrDBNULL(RowDetalle.CodFlete) <> "" And sCodFlete <> CodProducto Then
            Pedidos.BorrarDetallePedidoPaciente(RowPedido, RowCliente, Row.CodFlete, _
            Servicio.Capacidad, sPertenencia, Row, Cantidad, bRespetaPrecio, Row.CodFlete)
        End If
    End Sub

    Public Sub ActualizarFletePaciente(ByVal sNoPedido As String, ByVal sTipoCliente As String, ByVal sCodFlete As String, _
    ByVal Cantidad As Short, ByVal sCodProducto As String, ByVal sCapacidadActivo As String, ByVal RowCliente As DataRow, _
    ByVal CodEntidad As String)
        Dim RowDetalle As PedidosDataSet.DetallePedidoRow
        Dim RowAutorizacion() As DataRow = Nothing
        Dim PrecioFlete As Double
        Dim Autorizado As Boolean = False
        Dim UnidadMedida As String = String.Empty
        Dim CantidadCredito As Short = 0
        Dim CantidadContado As Short = 0
        Dim RowFlete As ProductosDataSet.ProductosRow
        Dim PorcentajeIva, PorcentajeDescuento, TotalDescuento As Double


        If sCodFlete <> "" Then
            If RowAutorizacion IsNot Nothing Then
                If RowAutorizacion.Length > 0 Then
                    Autorizado = True
                End If
            End If

            ' Se Revisa si el cliente tiene autorizado el flete
            Pacientes.VerificarProductoAutorizado(sCodFlete, Cantidad, Flete.Capacidad, RowAutorizacion, _
            CantidadContado, CantidadCredito, TipoProducto.Flete, Lastro.NoControla)

            RowFlete = Productos.GetProducto(sCodFlete)
            If RowFlete IsNot Nothing Then
                PorcentajeIva = RowFlete.Iva
                UnidadMedida = RowFlete.UnidadMedida
            Else
                ' No se cobra el flete
                Exit Sub
            End If

            If RowAutorizacion IsNot Nothing Then
                RowDetalle = Me.dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(sNoPedido, sCodFlete, Flete.Capacidad, cstrDBNULL(RowAutorizacion(0)("NoAutorizacion")))
            Else
                RowDetalle = Me.dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(sNoPedido, sCodFlete, Flete.Capacidad, "")
            End If

            If RowDetalle IsNot Nothing Then
                If RowDetalle("PrecioContado") Is DBNull.Value Then
                    ' Se inicializan los campos
                    RowDetalle.UnidadesVendidasContado = 0
                    RowDetalle.TotalIvaContado = 0
                    RowDetalle.TotalDescuentoContado = 0
                    RowDetalle.SubTotalContado = 0
                    RowDetalle.MontoTotalContado = 0
                    RowDetalle.PrecioContado = 0
                ElseIf RowDetalle.PrecioContado = 0 Then
                    RowDetalle.UnidadesVendidasContado = 0
                    RowDetalle.TotalIvaContado = 0
                    RowDetalle.TotalDescuentoContado = 0
                    RowDetalle.SubTotalContado = 0
                    RowDetalle.MontoTotalContado = 0
                    RowDetalle.PrecioContado = 0
                End If

                If RowDetalle("PrecioCredito") Is DBNull.Value Then
                    RowDetalle.UnidadesVendidasCredito = 0
                    RowDetalle.TotalIvaCredito = 0
                    RowDetalle.TotalDescuentoCredito = 0
                    RowDetalle.SubTotalCredito = 0
                    RowDetalle.MontoTotalCredito = 0
                    RowDetalle.PrecioCredito = 0
                    RowDetalle.MontoTotalCopago = 0
                ElseIf RowDetalle.PrecioCredito = 0 Then
                    RowDetalle.UnidadesVendidasCredito = 0
                    RowDetalle.TotalIvaCredito = 0
                    RowDetalle.TotalDescuentoCredito = 0
                    RowDetalle.SubTotalCredito = 0
                    RowDetalle.MontoTotalCredito = 0
                    RowDetalle.PrecioCredito = 0
                    RowDetalle.MontoTotalCopago = 0
                End If

                RowDetalle.Lastro = Lastro.NoControla
                RowDetalle.Asignaciones = 0
                RowDetalle.Recolecciones = 0

                ' Se actualiza
                RowDetalle.CapacidadActivo = sCapacidadActivo
                RowDetalle.CodFlete = sCodProducto
                RowDetalle.UnidadesReales += Cantidad
                RowDetalle.UnidadesVendidasPraxair += Cantidad

                If Autorizado Then
                    GrabarProductoContado(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                    PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, Servicio.Capacidad, _
                    PorcentajeIva)
                Else
                    If CantidadContado > 0 Then
                        GrabarProductoContado(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                        PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, Servicio.Capacidad, _
                        PorcentajeIva)
                    End If
                    If CantidadCredito > 0 Then
                        GrabarProductoCredito(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                        PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, _
                        RowAutorizacion, Servicio.Capacidad, PorcentajeIva, True)
                    End If
                End If
            Else
                If Cantidad > 0 Then
                    ' Se inserta   
                    RowDetalle = dsPedidos.DetallePedido.NewDetallePedidoRow
                    RowDetalle.NoPedido = sNoPedido
                    RowDetalle.NoAutorizacion = ""
                    RowDetalle.CodProducto = sCodFlete
                    RowDetalle.Capacidad = Flete.Capacidad
                    RowDetalle.CapacidadActivo = sCapacidadActivo
                    RowDetalle.UnidadesVendidasPraxair = Cantidad
                    RowDetalle.UnidadesVendidasCliente = 0
                    RowDetalle.UnidadesPedidas = 0
                    RowDetalle.Asignaciones = 0
                    RowDetalle.Recolecciones = 0
                    RowDetalle.RequiereAsignacion = "0"
                    RowDetalle.Nuevo = "1"
                    RowDetalle.UnidadesReales = Cantidad
                    RowDetalle.UnidadMedidaVenta = UnidadMedida
                    RowDetalle.DescripcionProducto = Productos.NombreProducto(sCodFlete)
                    RowDetalle.TipoProducto = TipoProducto.Flete
                    RowDetalle.RequiereFlete = Flete.NoRequiereFlete
                    RowDetalle.CodFlete = sCodProducto
                    RowDetalle.Lastro = Lastro.NoControla

                    RowDetalle.UnidadesVendidasCredito = 0
                    RowDetalle.UnidadesVendidasContado = 0
                    RowDetalle.SubTotalCredito = 0
                    RowDetalle.SubTotalContado = 0
                    RowDetalle.MontoTotalCredito = 0
                    RowDetalle.MontoTotalContado = 0
                    RowDetalle.TotalDescuentoCredito = 0
                    RowDetalle.TotalDescuentoContado = 0
                    RowDetalle.TotalIvaCredito = 0
                    RowDetalle.TotalIvaContado = 0
                    RowDetalle.PrecioContado = 0
                    RowDetalle.PrecioCredito = 0
                    RowDetalle.MontoTotalCopago = 0
                    RowDetalle.PorcentajeDescuento = 0
                    RowDetalle.PorcentajeImpuesto = 0

                    If Autorizado Then
                        GrabarProductoContado(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                        PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, Servicio.Capacidad, _
                        PorcentajeIva)
                    Else
                        If CantidadContado > 0 Then
                            GrabarProductoContado(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                        PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, Servicio.Capacidad, _
                        PorcentajeIva)
                        End If

                        If CantidadCredito > 0 Then
                            GrabarProductoCredito(RowCliente, CodEntidad, bRespetaPrecio, PrecioFlete, _
                            PorcentajeDescuento, TotalDescuento, RowFlete, RowDetalle, Cantidad, _
                            RowAutorizacion, Servicio.Capacidad, PorcentajeIva, True)
                        End If
                    End If
                    dsPedidos.DetallePedido.AddDetallePedidoRow(RowDetalle)
                End If
            End If
        End If
    End Sub

    Public Sub ActualizarFlete(ByVal sNoPedido As String, ByVal sCodFlete As String, _
    ByVal Cantidad As Short, ByVal sCodProducto As String, ByVal sCapacidadActivo As String, _
    ByVal sTipoPago As String, ByVal RowCliente As DataRow, ByVal Credito As String)

        'Dim Row As DataRow
        Dim RowDetalle As PedidosDataSet.DetallePedidoRow
        Dim CantidadReal As Short = 0
        Dim PrecioFlete, PorcentajeIva, _
            PorcentajeDescuento, Iva, TotalDescuento, _
            SubTotal, MontoTotal As Double
        Dim UnidadMedida As String = String.Empty
        Dim RowFlete As ProductosDataSet.ProductosRow

        If sCodFlete <> "" Then
            RowFlete = Productos.GetProducto(sCodFlete)
            If RowFlete IsNot Nothing Then
                PorcentajeIva = RowFlete.Iva
                UnidadMedida = RowFlete.UnidadMedida
                Venta.ObtenerPrecio(RowCliente, "", False, bRespetaPrecio, sCodFlete, PrecioFlete, _
                PorcentajeDescuento, TotalDescuento, RowFlete)
                If PrecioFlete = 0 Then
                    Exit Sub
                End If
            Else
                Exit Sub
            End If

            RowDetalle = Me.dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(sNoPedido, sCodFlete, Flete.Capacidad, "")

            If RowDetalle IsNot Nothing Then

                CantidadReal = RowDetalle.UnidadesReales + Cantidad

                ' Se calculan los totales
                SubTotal = PrecioFlete * CantidadReal
                Iva = SubTotal * (PorcentajeIva / 100)
                MontoTotal = SubTotal + Iva

                ' Se actualiza
                RowDetalle.CapacidadActivo = sCapacidadActivo
                RowDetalle.CodFlete = sCodProducto
                RowDetalle.UnidadesReales = CantidadReal
                RowDetalle.UnidadesVendidasPraxair = CantidadReal
                RowDetalle.Lastro = Lastro.NoControla
                RowDetalle.Asignaciones = 0

                'If sTipoPago = TipoPago.Credito Then
                If Credito = "S" And sTipoPago = TipoPago.Credito Then
                    RowDetalle.PrecioCredito = Math.Round(CDec(PrecioFlete))
                    RowDetalle.SubTotalCredito = Math.Round(CDec(SubTotal))
                    RowDetalle.MontoTotalCredito = Math.Round(CDec(MontoTotal))
                    RowDetalle.UnidadesVendidasCredito = CantidadReal
                    RowDetalle.TotalIvaCredito = Math.Round(CDec(Iva))
                    RowDetalle.TotalDescuentoCredito = Math.Round(CDec(TotalDescuento))

                    RowDetalle.PrecioContado = 0
                    RowDetalle.SubTotalContado = 0
                    RowDetalle.MontoTotalContado = 0
                    RowDetalle.UnidadesVendidasContado = 0
                    RowDetalle.TotalIvaContado = 0
                    RowDetalle.TotalDescuentoContado = 0
                Else
                    RowDetalle.PrecioContado = Math.Round(CDec(PrecioFlete))
                    RowDetalle.SubTotalContado = Math.Round(CDec(SubTotal))
                    RowDetalle.MontoTotalContado = Math.Round(CDec(MontoTotal))
                    RowDetalle.UnidadesVendidasContado = CantidadReal
                    RowDetalle.TotalIvaContado = Math.Round(CDec(Iva))
                    RowDetalle.TotalDescuentoContado = Math.Round(CDec(TotalDescuento))

                    RowDetalle.PrecioCredito = 0
                    RowDetalle.SubTotalCredito = 0
                    RowDetalle.MontoTotalCredito = 0
                    RowDetalle.UnidadesVendidasCredito = 0
                    RowDetalle.TotalIvaCredito = 0
                    RowDetalle.TotalDescuentoCredito = 0
                End If

                ' Si las cantidades son todas cero se debe borrar la fila
                If RowDetalle.Asignaciones = 0 And RowDetalle.Recolecciones = 0 And _
                    RowDetalle.UnidadesReales = 0 And RowDetalle.UnidadesPedidas = 0 Then
                    RowDetalle.Delete()
                End If
            Else
                If Cantidad > 0 Then
                    CantidadReal = Cantidad

                    ' Se calculan los totales
                    SubTotal = PrecioFlete * CantidadReal
                    Iva = SubTotal * (PorcentajeIva / 100)
                    MontoTotal = SubTotal + Iva

                    ' Se inserta el registro
                    RowDetalle = dsPedidos.DetallePedido.NewDetallePedidoRow
                    RowDetalle.NoPedido = sNoPedido
                    RowDetalle.NoAutorizacion = ""
                    RowDetalle.CodProducto = sCodFlete
                    RowDetalle.Capacidad = Flete.Capacidad
                    RowDetalle.CapacidadActivo = sCapacidadActivo
                    RowDetalle.UnidadesVendidasPraxair = CantidadReal
                    RowDetalle.UnidadesVendidasCliente = 0
                    RowDetalle.UnidadesPedidas = 0
                    RowDetalle.UnidadesReales = CantidadReal
                    RowDetalle.Asignaciones = 0
                    RowDetalle.Recolecciones = 0
                    RowDetalle.Nuevo = "1"
                    RowDetalle.UnidadMedidaVenta = UnidadMedida
                    RowDetalle.DescripcionProducto = Productos.NombreProducto(sCodFlete)
                    RowDetalle.TipoProducto = TipoProducto.Flete
                    RowDetalle.RequiereAsignacion = Asignacion.NoRequiereAsignacion
                    RowDetalle.RequiereFlete = Flete.NoRequiereFlete
                    RowDetalle.CodFlete = sCodProducto
                    RowDetalle.PorcentajeDescuento = Math.Round(CDec(PorcentajeDescuento))
                    RowDetalle.PorcentajeImpuesto = Math.Round(CDec(PorcentajeIva))

                    If Credito = "S" And sTipoPago = TipoPago.Credito Then
                        'If sTipoPago = TipoPago.Credito Then
                        RowDetalle.PrecioCredito = Math.Round(CDec(PrecioFlete))
                        RowDetalle.SubTotalCredito = Math.Round(CDec(SubTotal))
                        RowDetalle.MontoTotalCredito = Math.Round(CDec(MontoTotal))
                        RowDetalle.UnidadesVendidasCredito = CantidadReal
                        RowDetalle.TotalDescuentoCredito = Math.Round(CDec(TotalDescuento))
                        RowDetalle.TotalIvaCredito = Math.Round(CDec(Iva))

                        RowDetalle.PrecioContado = 0
                        RowDetalle.SubTotalContado = 0
                        RowDetalle.MontoTotalContado = 0
                        RowDetalle.UnidadesVendidasContado = 0
                        RowDetalle.TotalDescuentoContado = 0
                        RowDetalle.TotalIvaContado = 0
                    Else
                        RowDetalle.PrecioContado = Math.Round(CDec(PrecioFlete))
                        RowDetalle.SubTotalContado = Math.Round(CDec(SubTotal))
                        RowDetalle.MontoTotalContado = Math.Round(CDec(MontoTotal))
                        RowDetalle.UnidadesVendidasContado = CantidadReal
                        RowDetalle.TotalDescuentoContado = Math.Round(CDec(TotalDescuento))
                        RowDetalle.TotalIvaContado = Math.Round(CDec(Iva))

                        RowDetalle.PrecioCredito = 0
                        RowDetalle.SubTotalCredito = 0
                        RowDetalle.MontoTotalCredito = 0
                        RowDetalle.UnidadesVendidasCredito = 0
                        RowDetalle.TotalDescuentoCredito = 0
                        RowDetalle.TotalIvaCredito = 0
                    End If
                    RowDetalle.Lastro = Lastro.NoControla
                    dsPedidos.DetallePedido.AddDetallePedidoRow(RowDetalle)
                End If
            End If
        End If
    End Sub

    Public Sub GrabarProductoContado(ByVal RowCliente As DataRow, ByVal CodEntidad As String, _
    ByVal bRespetaPrecio As Boolean, ByVal PrecioProducto As Double, _
    ByVal PorcentajeDescuento As Double, ByVal TotalDescuento As Double, _
    ByVal RowProducto As ProductosDataSet.ProductosRow, _
    ByRef RowDetalle As PedidosDataSet.DetallePedidoRow, _
    ByVal Cantidad As Short, ByVal Capacidad As String, ByVal PorcentajeIva As Double)
        Dim SubTotal, Iva, MontoTotal As Double

        Venta.ObtenerPrecio(RowCliente, CodEntidad, False, bRespetaPrecio, RowProducto.Codigo, PrecioProducto, _
        PorcentajeDescuento, TotalDescuento, RowProducto)

        If PrecioProducto = 0 And RowProducto.CodTipoProducto = TipoProducto.Flete Then
            Exit Sub
        End If

        If PrecioProducto = 0 And RowProducto.CodTipoProducto = TipoProducto.Activo Then
            GrabarProductoCredito(RowCliente, CodEntidad, bRespetaPrecio, PrecioProducto, _
            PorcentajeDescuento, TotalDescuento, RowProducto, RowDetalle, Cantidad, Nothing, _
            Capacidad, PorcentajeIva, False)
            Exit Sub
        ElseIf PrecioProducto = 0 Then
            GrabarProductoCredito(RowCliente, CodEntidad, bRespetaPrecio, PrecioProducto, _
                        PorcentajeDescuento, TotalDescuento, RowProducto, RowDetalle, Cantidad, Nothing, _
                        Capacidad, PorcentajeIva, False)
            Exit Sub
        End If

        SubTotal = PrecioProducto * (CDbl(Capacidad) / 1000) * Cantidad
        Iva = SubTotal * (PorcentajeIva / 100)
        MontoTotal = SubTotal + Iva

        RowDetalle.UnidadesVendidasContado += Cantidad
        RowDetalle.SubTotalContado += Math.Round(CDec(SubTotal))
        RowDetalle.MontoTotalContado += Math.Round(CDec(MontoTotal))
        RowDetalle.TotalDescuentoContado += Math.Round(CDec(TotalDescuento))
        RowDetalle.TotalIvaContado += Math.Round(CDec(Iva))
        RowDetalle.PrecioContado = Math.Round(CDec(PrecioProducto))
        RowDetalle.PorcentajeImpuesto = Math.Round(CDec(PorcentajeIva))
        RowDetalle.PorcentajeDescuento = Math.Round(CDec(PorcentajeDescuento))
    End Sub

    Public Sub GrabarProductoCredito(ByVal RowCliente As DataRow, ByVal CodEntidad As String, _
    ByVal bRespetaPrecio As Boolean, ByVal PrecioProducto As Double, _
    ByVal PorcentajeDescuento As Double, ByVal TotalDescuento As Double, _
    ByVal RowProducto As ProductosDataSet.ProductosRow, ByRef RowDetalle As PedidosDataSet.DetallePedidoRow, _
    ByVal Cantidad As Short, ByVal RowAutorizacion() As DataRow, ByVal Capacidad As String, ByVal PorcentajeIva As Double, _
    ByVal CalculaPrecio As Boolean)
        Dim SubTotal, Iva, MontoTotal, MontoCopago As Double
        If CalculaPrecio Then
            Venta.ObtenerPrecio(RowCliente, CodEntidad, True, bRespetaPrecio, RowProducto.Codigo, PrecioProducto, _
            PorcentajeDescuento, TotalDescuento, RowProducto)

            If PrecioProducto = 0 And RowProducto.CodTipoProducto = TipoProducto.Flete Then
                Exit Sub
            End If

            ' Se calculan los totales
            SubTotal = PrecioProducto * CDbl(Capacidad) / 1000 * Cantidad
            Iva = SubTotal * (PorcentajeIva / 100)
            MontoTotal = SubTotal + Iva

            RowDetalle.UnidadesVendidasCredito += Cantidad
            RowDetalle.SubTotalCredito += Math.Round(CDec(PrecioProducto * Cantidad))
            RowDetalle.MontoTotalCredito += Math.Round(CDec(PrecioProducto * Cantidad))
            RowDetalle.MontoTotalCopago += Math.Round((CDec(PrecioProducto * Cantidad)) * (CDec(RowAutorizacion(0)("Monto")) / 100))
            RowDetalle.TotalDescuentoCredito += Math.Round(CDec(TotalDescuento))
            RowDetalle.TotalIvaCredito += Math.Round(CDec(Iva))
            RowDetalle.PrecioCredito = Math.Round(CDec(PrecioProducto))
            RowDetalle.PorcentajeDescuento = Math.Round(CDec(PorcentajeDescuento))
            RowDetalle.PorcentajeImpuesto = Math.Round(CDec(PorcentajeIva))

            If RowProducto.CodTipoProducto <> TipoProducto.Flete Then
                If cstrDBNULL(RowAutorizacion(0)("TipoPago")) = Autorizaciones.Copago Then
                    MontoCopago = SubTotal * (CDbl(RowAutorizacion(0)("Monto")) / 100)
                    RowDetalle.MontoTotalCopago = Math.Round(CDec(MontoCopago))
                    RowDetalle.MontoTotalCuota = 0
                End If
            End If

            ' Se guardan los detalles de la autorizacion
            RowDetalle.NoAutorizacion = cstrDBNULL(RowAutorizacion(0)("NoAutorizacion"))
            RowDetalle.IdDetalleAutorizacion = cstrDBNULL(RowAutorizacion(0)("IdDetalleAutorizacion"))
            RowDetalle.UnidadesAutorizadas = CShortDBNull(RowAutorizacion(0)("Unidades"))
            RowDetalle.TipoPago = cstrDBNULL(RowAutorizacion(0)("TipoPago"))
            RowDetalle.Monto = Math.Round(CDec(RowAutorizacion(0)("Monto")))
        Else
            RowDetalle.UnidadesVendidasCredito += Cantidad
            RowDetalle.SubTotalCredito += 0
            RowDetalle.MontoTotalCredito += 0
            RowDetalle.MontoTotalCopago += 0
            RowDetalle.TotalDescuentoCredito += 0
            RowDetalle.TotalIvaCredito += 0
            RowDetalle.PrecioCredito = 0
            RowDetalle.PorcentajeDescuento = 0
            RowDetalle.PorcentajeImpuesto = 0

            If RowProducto.CodTipoProducto <> TipoProducto.Flete Then
                MontoCopago = 0
                RowDetalle.MontoTotalCopago = 0
                RowDetalle.MontoTotalCuota = 0
            End If

            ' Se guardan los detalles de la autorizacion
            RowDetalle.NoAutorizacion = ""
            RowDetalle.IdDetalleAutorizacion = ""
            RowDetalle.UnidadesAutorizadas = 0
            RowDetalle.TipoPago = "0"
            RowDetalle.Monto = 0
        End If
    End Sub

End Class


