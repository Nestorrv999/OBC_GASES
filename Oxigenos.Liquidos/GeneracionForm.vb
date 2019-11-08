Public Class GeneracionForm
    Private m_DetallePedido As VentaDataSet.DetallePedidoDataTable
    Private GeneroDocumentos As Boolean = False
    Private m_RowCliente As DataRow
    Private m_RowPedido As DataRow
    Private m_RowFactura() As DataRow
    Private m_rowTalonario As DataRow = Nothing
    Private m_sTipoMovimiento As String
    Private doc As PrinterDocument ' Obejto para crear el documento impreso

    Public Shared Function Run(ByVal rowCliente As System.Data.DataRow, ByRef rowPedido As System.Data.DataRow) As Boolean
        UIHandler.StartWait()
        Dim form As New GeneracionForm
        form.m_RowCliente = rowCliente
        form.m_RowPedido = rowPedido
        Dim bRes As Boolean = UIHandler.ShowDialog(form) = System.Windows.Forms.DialogResult.OK
        form.Dispose()
        UIHandler.EndWait()
        Return bRes
    End Function

    Private Sub GeneracionForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                menuCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub GeneracionForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UiHandler1.Parent = Me

        Me.dsVenta = Venta.dsVenta
        Me.bsDetalleFactura.DataSource = Me.dsVenta
        Me.bsFactura.DataSource = Me.dsVenta

        ' Se valida si se debe pedir al usuario el tipo de documento
        If CStr(m_RowCliente("TipoPago")) = TipoPago.Contado Then
            UIHandler.ShowAlert("Cliente solo permite pago CONTADO!, se generara FACTURA")
            m_sTipoMovimiento = TiposMovimiento.Factura
            ObtenerTalonario()
            existeDocumento()
            GenerarDocumento()
        Else
            PedirTipoDocumento()
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub PedirTipoDocumento()
        ' Se ocultan los paneles
        pnTipoDocumento.Visible = True
        pnDetalleDocumento.Visible = False
        Me.Menu = New MainMenu()
    End Sub

    Private Sub ObtenerTalonario()
        If m_sTipoMovimiento = TiposMovimiento.Factura Then
            m_rowTalonario = Nucleo.GetTalonarioActual(TiposDocumento.FacturaAutomatica)
        Else
            m_rowTalonario = Nucleo.GetTalonarioActual(TiposDocumento.RemitoAutomatico)
        End If
    End Sub
    Private Function ObtenerInformacionSucursal() As String
        Return CStrDBNull(Nucleo.RowParametros("NombreSucursal")) + " TELEFONO: " + CStrDBNull(Nucleo.RowParametros("TelefonoTransportador")) + " " + CStrDBNull(Nucleo.RowParametros("NitTrasportadora"))
    End Function
    Private Sub GenerarDocumento()
        Dim sTitulo As String
        Dim nMontoTotal As Decimal
        Dim nSubTotal As Decimal
        Dim nTotalIVA As Decimal
        Dim nTotalDescuento As Decimal
        Dim sTipoDocumento As String
        Dim sTipoPago As String
        Dim dtFechaVencimiento As DateTime

        doc = New PrinterDocument

        ' Se ajusta el titulo de la ventana y se pide el talonario para el tipo de documento
        If m_sTipoMovimiento = TiposMovimiento.Factura Then
            lblTitulo.Text = "Generar Factura"
            sTitulo = "FACTURA DE VENTA"
            sTipoDocumento = TipoDocumentos.Factura
            dtFechaVencimiento = DateAdd(DateInterval.Day, CInt(m_RowCliente("DiasCredito")), Today())
        Else
            lblTitulo.Text = "Generar Remisión"
            sTitulo = "REMISION"
            sTipoDocumento = TipoDocumentos.Remision
            dtFechaVencimiento = Today()
        End If
        pnTipoDocumento.Visible = False
        pnDetalleDocumento.Visible = True
        Me.Menu = mainMenu1

        ' Se calcula los montos totales de la factura
        nSubTotal = CDec(dsVenta.DetallePedido.Compute("SUM(PrecioTotal)", ""))
        nTotalIVA = CDec(dsVenta.DetallePedido.Compute("SUM(MontoImpuesto)", ""))
        nTotalDescuento = CDec(dsVenta.DetallePedido.Compute("SUM(MontoDescuento)", ""))
        nMontoTotal = nSubTotal + nTotalIVA
        lblSubTotal.Text = nSubTotal.ToString("#,##0.00")

        ' Se crean el encabezado del documento
        Venta.dsVenta.MaestroFacturas.AddMaestroFacturasRow(m_sTipoMovimiento, _
            CStrDBNull(m_rowTalonario("Actual")), CStrDBNull(m_rowTalonario("Prefijo")), _
            CStrDBNull(m_RowCliente("CodSucursal")), CStrDBNull(m_RowCliente("Codigo")), _
            Today(), "", "", Nucleo.RutaPrincipal, "", HojasRuta.HojaActual.CodConductor, _
            HojasRuta.HojaActual.Cabezote, CStr(HojasRuta.HojaActual.IdHojaRuta), TipoPago.Credito, _
            CShortDBNull(m_RowCliente("DiasCredito")), "", nMontoTotal, 0, _
            nTotalDescuento, nTotalIVA, "", CStrDBNull(m_RowPedido("NoPedido")), EstadoFactura.Entregado)

        If sTipoDocumento = TipoDocumentos.Factura Then
            sTipoPago = "CREDITO"
            doc.SetInfoDocumento(CStrDBNull(m_rowTalonario("Prefijo")) & "-" & CStrDBNull(m_rowTalonario("Actual")), _
                CStrDBNull(m_RowPedido("NoPedido")), sTitulo, sTipoDocumento, sTipoPago, Today(), dtFechaVencimiento, ObtenerInformacionSucursal(), "0" & CStrDBNull(m_rowTalonario("Prefijo")) & CStrDBNull(m_rowTalonario("Actual")), CStrDBNull(m_rowTalonario("Actual")), "")
            doc.SetInfoCliente(CStrDBNull(("Codigo")), CStrDBNull(m_RowCliente("Nit")), _
                CStrDBNull(m_RowCliente("Nombre")), CStrDBNull(m_RowPedido("Direccion")), _
                CStrDBNull(m_RowPedido("Barrio")), CStrDBNull(m_RowCliente("Telefono")), "", "", sTipoPago)
        Else
            sTipoPago = "CREDITO"
            doc.SetInfoDocumento(CStrDBNull(m_rowTalonario("Prefijo")) & "-" & CStrDBNull(m_rowTalonario("Actual")), _
               CStrDBNull(m_RowPedido("NoPedido")), sTitulo, sTipoDocumento, sTipoPago, Today(), dtFechaVencimiento, ObtenerInformacionSucursal(), "1" & CStrDBNull(m_rowTalonario("Prefijo")) & CStrDBNull(m_rowTalonario("Actual")), CStrDBNull(m_rowTalonario("Actual")), "")
            doc.SetInfoCliente(CStrDBNull(("Codigo")), CStrDBNull(m_RowCliente("Nit")), _
                CStrDBNull(m_RowCliente("Nombre")), CStrDBNull(m_RowPedido("Direccion")), _
                CStrDBNull(m_RowPedido("Barrio")), CStrDBNull(m_RowCliente("Telefono")), "", "", sTipoPago)
        End If
        If m_sTipoMovimiento = TiposMovimiento.Factura Then
            doc.SetInfoResolucion(CStrDBNull(m_rowTalonario("NumeroResolucion")), CStrDBNull(m_rowTalonario("ResolucionDesde")), _
                CStrDBNull(m_rowTalonario("ResolucionHasta")), CDate(m_rowTalonario("FechaInicioResolucion")), "", "")
        End If

        ' Se crea el único item que lleva el documento
        Dim nCantidad As Decimal = CDec(dsVenta.DetallePedido.Compute("SUM(Cantidad)", ""))
        Venta.dsVenta.DetalleFactura.AddDetalleFacturaRow(m_sTipoMovimiento, CStrDBNull(m_rowTalonario("Actual")), _
        CStrDBNull(m_rowTalonario("Prefijo")), Productos.ProductoActual.Codigo, "", "", "", _
        Productos.ProductoActual.UnidadMedidaVenta, nCantidad, Venta.dsVenta.DetallePedido(0).PrecioUnitario, _
        0, nTotalDescuento, nTotalIVA, nSubTotal, Productos.ProductoActual.Descripcion)
        doc.AddItem(Productos.ProductoActual.Codigo, Productos.ProductoActual.Descripcion, nCantidad, _
        CDec(Productos.ProductoActual.Precio), Productos.ProductoActual.UnidadMedidaVenta, nSubTotal, "", nCantidad, "1")
        doc.SetInfoTotales(nSubTotal, nTotalIVA)

        ' Se ajustan los data bindings para la presentación en pantalla
        bsFactura.Position = dsVenta.MaestroFacturas.Count - 1
        bsFactura.ResetCurrentItem()
        bsDetalleFactura.Position = 1
        bsDetalleFactura.ResetCurrentItem()
    End Sub

    ''' <summary>
    ''' valida si existe el documento y si existe lo incrementa
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub existeDocumento()
        'valida si el documento ya existe para correrlo de nuevo
        Dim row_MaestroFacturas As VentaDataSet.MaestroFacturasRow
        row_MaestroFacturas = dsVenta.MaestroFacturas.FindByTipoFacturaNoFacturaPrefijo(m_sTipoMovimiento, CStr(m_rowTalonario("Actual")), CStr(m_rowTalonario("PREFIJO")))
        While Not row_MaestroFacturas Is Nothing
            IncrementarNumeroDocumento(m_rowTalonario)
        End While
    End Sub

    Private Sub menuGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGrabar.Click
        ' Se imprime y se guarda la información
        IncrementarNumeroDocumento(m_rowTalonario)
        'While Not Nucleo.Imprimir(doc)
        While Nucleo.Imprimir(doc) < 0
            ' Se anula el documento y se vuelve a generar
            dsVenta.MaestroFacturas(dsVenta.MaestroFacturas.Count - 1).EstadoFactura = EstadoFactura.Anulado
            dsVenta.DetalleFactura.Rows.Clear()
            GenerarDocumento()
            IncrementarNumeroDocumento(m_rowTalonario)
        End While
        UIHandler.StartWait()

        Try
            Venta.OpenConnection()
            Venta.CrearTransaccion()
            Venta.SaveVenta()
            Nucleo.UpdateTalonario(m_rowTalonario)
            Productos.UpdateKardex()
            Venta.RealizarCommit()
        Catch ex As Exception
            Venta.CloseConnection()
        Finally
            Venta.RealizarRollback()

        End Try
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub menuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCancelar.Click, btnCancelarTipoDoc.Click
        UIHandler.StartWait()
        Venta.dsVenta.MaestroFacturas.Rows.Clear()
        Venta.dsVenta.DetalleFactura.Rows.Clear()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rbFactura.Checked Then
            m_sTipoMovimiento = TiposMovimiento.Factura
        Else
            m_sTipoMovimiento = TiposMovimiento.Remision
        End If
        ObtenerTalonario()
        GenerarDocumento()
    End Sub
End Class