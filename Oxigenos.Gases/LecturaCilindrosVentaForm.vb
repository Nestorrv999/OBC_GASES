Imports DatascanCF.Symbol
Imports System.Data
Imports DatascanCF.Windows.Forms
Imports System.IO
Imports System.Data.SqlServerCe
Imports Oxigenos.Common

Public Class LecturaCilindrosVentaForm
    Private WithEvents m_BarcodeReader As BarcodeReader
    Private RowCargaProducto As ProductosDataSet.CargaRow
    Private RowCargaActivo As ProductosDataSet.CargaRow
    Private RowPrecioCliente As VentaDataSet.PreciosRow
    Private RowCilindroCliente As DataRow
    Private RowAutorizacion() As DataRow = Nothing
    Private m_RowPedido As DataRow
    Private m_RowCliente As DataRow
    Private bVentaAutomatica As Boolean = False
    Private RequiereFlete As Boolean = False
    Private ControlaLastro As Boolean = False
    Private RequiereAlquiler As Boolean = False
    Private Credito As Boolean = False
    Private SecuencialAjeno As String = ""

    Public Shared Sub Run(ByVal RowPedido As DataRow, ByVal RowCliente As DataRow)
        UIHandler.StartWait()
        Dim form As New LecturaCilindrosVentaForm
        form.m_RowPedido = RowPedido
        form.m_RowCliente = RowCliente
        If form.m_RowPedido IsNot Nothing And form.m_RowPedido IsNot Nothing Then
            form.bVentaAutomatica = True
        End If
        UIHandler.ShowDialog(form)
        form.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub LecturaCilindrosVentaForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        m_BarcodeReader.StopRead()
    End Sub

    Private Sub LecturaCilindrosVentaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.G Then
                btnGrabar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub LecturaCilindrosVentaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LimpiarControles()
        m_BarcodeReader = New BarcodeReader
        m_BarcodeReader.StartRead(Me)
        Barcode.LoadData()

        ' Se asignan los dataset locales
        Me.dsProductos = Productos.dsProductos
        Me.dsVenta = Venta.dsVenta
        Me.dsPedidos = Pedidos.dsPedidos
        Me.dsPacientes = Pacientes.dsPacientes

        Try
            Productos.OpenConnection()
            If Not (Me.dsProductos.Carga.Rows.Count > 0 And Me.dsProductos.KardexCamion.Rows.Count > 0) Then
                Productos.LoadCarga()
                Productos.LoadKardexCamion()
            End If

            Productos.LoadTipoProductos()
            Productos.LoadPertenencias()
        Finally
            Productos.CloseConnection()
        End Try

        bsDetallePedido.DataSource = Pedidos.dsPedidos
        bsDetallePedido.Position = 0

        If bVentaAutomatica Then
            btnRegresar.Visible = True
            btnGrabar.Visible = False
        Else
            btnRegresar.Visible = True
            btnGrabar.Visible = True
            If tcLectura.TabPages.Contains(tpResumen) Then
                tcLectura.TabPages.RemoveAt(tcLectura.TabPages.IndexOf(tpResumen))
            End If
        End If

        Me.lblNolecturas.Text = "0"
        UIHandler.EndWait()
    End Sub

    Private Sub LimpiarControles()
        Me.pnCargue.Visible = True
        Me.pnLecturaAjenos.Visible = False
        Me.pnTipoDocumento.Visible = False
        Me.pnCargue.BringToFront()

        Me.txtBarras.Text = ""
        Me.lblCapacidad.Text = ""
        Me.lblDescripcionProducto.Text = ""
        Me.lblDescripcionTipoPertenencia.Text = ""
        Me.lblDescripcionTipoProducto.Text = ""
        Me.lblProducto.Text = ""
        Me.lblSecuencial.Text = ""
        Me.lblSucursal.Text = ""
        Me.lblTipoPertenencia.Text = ""
        Me.lblTipoProducto.Text = ""
        lblSep1.Visible = False
        lblSep2.Visible = False
        Me.txtBarras.Focus()
    End Sub

    Private Sub m_BarcodeReader_ScanComplete(ByVal e As DatascanCF.Symbol.ScanCompleteArgs) Handles m_BarcodeReader.ScanComplete
        Try
            Barcode.Parse(e.Text, e.Type)
            If Not Barcode.NoDefinido Is Nothing Then
                UIHandler.ShowAlert("Código no Definido!!")
            ElseIf Not Barcode.CodigoProducto Is Nothing Then
                If pnLecturaAjenos.Visible Then
                    UIHandler.ShowError("Código no válido!!")
                    Exit Sub
                End If
                MostrarInformacionCilindrosLlenos(Barcode.CodigoProducto)
            ElseIf Not Barcode.Serial Is Nothing Then
                ' Lectura de serial de un ajeno
                If pnLecturaAjenos.Visible Then
                    Me.txtSerial.Text = Barcode.Serial
                    SecuencialAjeno = Me.txtSerial.Text
                    ValidarDatosLeidos()
                    pnLecturaAjenos.Visible = False
                    pnCargue.Enabled = True
                Else
                    Me.txtBarras.Text = Barcode.Serial
                    SecuencialAjeno = Me.txtBarras.Text
                    MostrarDatosAjenoVacio()
                End If
            End If
        Catch ex As Exception
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub MostrarDatosAjenoVacio()
        RowCilindroCliente = Productos.GetSecuencialAjenoVacio(SecuencialAjeno)
        If RowCilindroCliente Is Nothing Then
            UIHandler.ShowError("Secuencial no esta registrado!!")
            Me.txtBarras.Text = ""
            Me.txtSerial.Text = ""
            Exit Sub
        End If

        If cstrDBNULL(RowCilindroCliente("Seleccionado")) = EstadoCilindroCliente.Entregado Then
            UIHandler.ShowError("Cilindro ya entregado!!")
            Me.txtBarras.Text = ""
            Me.txtSerial.Text = ""
            Exit Sub
        End If

        Productos.LoadProducto(CStr(RowCilindroCliente("CodProducto")))

        If dsProductos.Productos.Rows.Count > 0 Then
            ' Se muestran los datos del código
            Me.lblTipoProducto.Text = TipoProducto.Activo
            Me.lblDescripcionTipoProducto.Text = "Activo"
            Me.lblProducto.Text = CStr(RowCilindroCliente("CodProducto"))
            Me.lblSucursal.Text = CStr(RowCilindroCliente("Sucursal"))
            Me.lblCapacidad.Text = Format(CLng(RowCilindroCliente("Capacidad")), "###,##0")
            Me.lblSecuencial.Text = ""
            Me.lblTipoPertenencia.Text = Pertenencia.Cliente
            Me.lblDescripcionTipoPertenencia.Text = Productos.GetPertenencia(Me.lblTipoPertenencia.Text)
            Me.lblDescripcionProducto.Text = cstrDBNULL(dsProductos.Productos.Rows(0)("Descripcion"))
            ValidarDatosLeidos()
        Else
            UIHandler.ShowError("Producto no existe!!")
            Me.txtBarras.Text = ""
            Me.txtSerial.Text = ""
        End If
    End Sub

    ' Se muestra la información del código leído
    Private Sub MostrarInformacionCilindrosLlenos(ByVal Codigo As String)
        If Codigo <> "" Then
            If Codigo.Length > 8 Then
                UIHandler.ShowAlert("Código Inválido!!")
                LimpiarControles()
                Exit Sub
            End If

            Productos.LoadProducto(Codigo)
            If Me.dsProductos.Productos.Count = 0 Then
                UIHandler.ShowAlert("Producto no existe!!")
                LimpiarControles()
                Exit Sub
            End If

            ' Se muestra la informacion del producto
            bsProductos.DataSource = Productos.dsProductos
            bsProductos.Position = 0

            ' Se muestran los datos del codigo de barras
            lblSecuencial.Text = Barcode.Secuencial
            lblProducto.Text = Barcode.CodigoProducto
            lblCapacidad.Text = Barcode.CapacidadWithFormat
            lblTipoPertenencia.Text = Barcode.Pertenencia
            lblSucursal.Text = Barcode.CodigoSucursal
            lblDescripcionTipoPertenencia.Text = Productos.GetPertenencia(Barcode.Pertenencia)
            lblSep1.Visible = True
            lblSep2.Visible = True

            ' Se valida el tipo de producto
            If Not lblTipoProducto.Text = TipoProducto.Producto And _
            Not lblTipoProducto.Text = TipoProducto.Activo Then
                UIHandler.ShowError("Tipo de Producto no es el Correcto!!")
                LimpiarControles()
                Exit Sub
            End If

            If lblTipoPertenencia.Text = Pertenencia.Cliente Then
                ' NJPL: Se obtiene el secuencial ajeno de la tabla de carga
                SecuencialAjeno = GetSecuencialAjeno()
            Else
                SecuencialAjeno = ""
            End If
            ValidarDatosLeidos()
            pnLecturaAjenos.Visible = False
            pnCargue.Enabled = True
            Me.txtBarras.Text = ""
            Me.txtBarras.Focus()
        End If
    End Sub

    Private Function GetSecuencialAjeno() As String
        Dim rows() As DataRow
        rows = Productos.dsProductos.Carga.Select(String.Format( _
            "CodSucursal = '{0}' AND CodProducto='{1}' AND Capacidad='{2}' AND Secuencial='{3}' AND Pertenencia = '{4}' AND CodTipoProducto = '{5}'", _
            Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text))
        If rows.Length > 0 Then
            Return cstrDBNULL(rows(0)("SecuencialAjeno"))
        Else
            Return ""
        End If
    End Function

    Public Sub ValidarDatosLeidos()
        Dim Cantidad As Short
        Dim CantidadContado As Short = 0
        Dim CantidadCredito As Short = 0
        Dim SerialAsociado As String = ""
        Dim RowLeidos As DataRow
        Dim sCodFlete As String = ""

        ' Se busca si el código existe en la tabla de carga
        RowCargaProducto = Me.dsProductos.Carga.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(Me.lblSucursal.Text, _
        Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno)
        If RowCargaProducto IsNot Nothing Then

            ' Se valida que en los ajenos los secuenciales 
            ' coincidan con el serial que se leyó en el cargue
            If SecuencialAjeno <> "" Then
                If SecuencialAjeno <> RowCargaProducto.SecuencialAjeno Then
                    UIHandler.ShowError("El serial leído no corresponde!!")
                    LimpiarControles()
                    Exit Sub
                End If
            End If
            If RowCargaProducto.EstadoEntrega = EstadosCilindro.Entregado Then
                UIHandler.ShowError("Producto ya fué Entregado!!")
                LimpiarControles()
                Exit Sub
            End If

            ' Si es un ajeno debe pertenecer al cliente actual
            If lblTipoPertenencia.Text = Pertenencia.Cliente Then
                Dim rowCilindroCliente As ProductosDataSet.CilindrosClienteRow
                rowCilindroCliente = Productos.GetCilindroCliente(SecuencialAjeno)
                If rowCilindroCliente IsNot Nothing Then
                    If rowCilindroCliente.CodCliente <> CStr(Me.m_RowCliente("Codigo")) Then
                        UIHandler.ShowError("Producto no pertenece al cliente")
                        LimpiarControles()
                        Exit Sub
                    End If
                Else
                    UIHandler.ShowError("Producto no fue cargado")
                    LimpiarControles()
                    Exit Sub
                End If
            End If
        Else
            UIHandler.ShowError("Producto no fué cargado!!")
            LimpiarControles()
            Exit Sub
        End If

        ' Se valida si ya fue leído
        RowLeidos = dsVenta.CilindrosLeidos.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(Me.lblSucursal.Text, _
        Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno)

        If RowLeidos IsNot Nothing Then            
            If MsgBox("Código ya leído, desea eliminarlo?", MsgBoxStyle.YesNo, "Atención") = MsgBoxResult.Yes Then
                Cantidad = -1
            Else
                Exit Sub
            End If
        Else
            Cantidad = 1
        End If

        'se elimina el regsitro
        If Cantidad < 0 Then
            Pedidos.BorrarDetallePedidoPaciente(m_RowPedido, m_RowCliente, cstrDBNULL(Me.dsProductos.Productos.Rows(0)("CodFlete")), _
                                QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoPertenencia.Text, CType(dsProductos.Productos.Rows(0), ProductosDataSet.ProductosRow), _
                                1, bRespetaPrecio, Me.lblProducto.Text)
            RowLeidos.Delete()
        End If

        ' Venta automatica
        If bVentaAutomatica And Cantidad > 0 Then
            Dim Credito As String = ""

            If cstrDBNULL(m_RowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                If Cantidad > 0 Then
                    If bVerificarAutorizacion Then
                        Pacientes.VerificarProductoAutorizado(Me.lblProducto.Text, Cantidad, QuitarFormato(Me.lblCapacidad.Text), RowAutorizacion, _
                        CantidadContado, CantidadCredito, Me.lblTipoProducto.Text, cstrDBNULL(dsProductos.Productos.Rows(0)("Lastro")))
                        If RowAutorizacion Is Nothing Then
                            CantidadContado = Cantidad
                        End If
                    Else
                        CantidadContado = Cantidad
                    End If
                    If lblSecuencial.Text <> "" Then
                        'DATASCAN 20171025
                        'ANTES:
                        'Pedidos.ActualizarDetallePedidoPaciente(m_RowPedido, m_RowCliente, cstrDBNULL(Me.dsProductos.Productos.Rows(0)("CodFlete")), _
                        'QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoPertenencia.Text, CType(dsProductos.Productos.Rows(0), ProductosDataSet.ProductosRow), _
                        'Cantidad, RowAutorizacion, CantidadContado, CantidadCredito, bRespetaPrecio)
                        'AHORA:
                        If Pedidos.ActualizarDetallePedidoPaciente(m_RowPedido, m_RowCliente, cstrDBNULL(Me.dsProductos.Productos.Rows(0)("CodFlete")), _
                        QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoPertenencia.Text, CType(dsProductos.Productos.Rows(0), ProductosDataSet.ProductosRow), _
                        Cantidad, RowAutorizacion, CantidadContado, CantidadCredito, bRespetaPrecio) = False Then
                            LimpiarControles()
                            Exit Sub
                        End If
                        'FIN DATASCAN 20171025
                    End If

                    If CantidadContado > 0 Then
                        Credito = "N"
                    Else
                        Credito = "S"
                    End If

                    dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
                    Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno, Cantidad, _
                    cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), Credito, 0)
                Else
                    Pedidos.BorrarDetallePedidoPaciente(m_RowPedido, m_RowCliente, cstrDBNULL(Me.dsProductos.Productos.Rows(0)("CodFlete")), _
                    QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoPertenencia.Text, CType(dsProductos.Productos.Rows(0), ProductosDataSet.ProductosRow), _
                    1, bRespetaPrecio, Me.lblProducto.Text)
                    RowLeidos.Delete()
                End If
            Else

                If Cantidad > 0 Then
                    If CStr(m_RowCliente("TipoPago")) = TipoPago.Credito Then
                        If cstrDBNULL(m_RowCliente("FrecuenciaMensual")) = DatosCliente.FrecuenciaMensual Then
                            Credito = "S"
                        Else
                            Credito = "N"
                        End If
                    Else
                        Credito = "N"
                    End If
                    If Me.lblSecuencial.Text.Equals("") Then
                        Credito = "S"
                    End If

                    'Juan                 If Me.lblSecuencial.Text <> "" Then
                    ' Se actualiza el detalle del pedido
                    Pedidos.ActualizarDetallePedido(m_RowPedido, m_RowCliente, cstrDBNULL(Me.dsProductos.Productos.Rows(0)("CodFlete")), _
                    QuitarFormato(Me.lblCapacidad.Text), Me.lblTipoPertenencia.Text, CType(dsProductos.Productos.Rows(0), _
                    ProductosDataSet.ProductosRow), Cantidad, Credito)
                    'End If
                    'Juan  End If

                    dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
                    Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno, Cantidad, _
                    cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), Credito, 0)
                Else
                    RowLeidos.Delete()
                End If
            End If

        Else
            'Venta Manual
            If Cantidad > 0 Then
                If lblTipoPertenencia.Text = Pertenencia.Praxair Then
                    If MsgBox("Es libre cambio?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                        dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
                        Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno, Cantidad, _
                        cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), "N", 0)
                    Else
                        dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
                        Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno, Cantidad, _
                        cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), "N", Cantidad)
                    End If
                Else
                    dsVenta.CilindrosLeidos.AddCilindrosLeidosRow(Me.lblSucursal.Text, Me.lblProducto.Text, QuitarFormato(Me.lblCapacidad.Text), _
                    Me.lblSecuencial.Text, Me.lblTipoPertenencia.Text, Me.lblTipoProducto.Text, SecuencialAjeno, Cantidad, _
                    cstrDBNULL(Me.dsProductos.Productos.Rows(0)("UnidadMedida")), "N", 0)
                End If
            Else
                RowLeidos.Delete()

            End If
        End If

        ' Se actualiza en pantalla el No de lecturas
        If CInt(lblNolecturas.Text) + Cantidad >= 0 Then
            lblNolecturas.Text = CStr(CInt(lblNolecturas.Text) + Cantidad)
        End If
    End Sub

    Private Sub btnRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegresar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.txtBarras.Text <> "" Then
            If Me.txtBarras.Text.Length = 24 Then
                Barcode.Parse(Me.txtBarras.Text, DatascanCF.Symbol.BarcodeType.EAN128)
                MostrarInformacionCilindrosLlenos(Barcode.CodigoProducto)
            ElseIf Me.txtBarras.Text.Length = 7 Then
                ' Vacio Ajeno
                SecuencialAjeno = Me.txtBarras.Text
                MostrarDatosAjenoVacio()
            Else
                UIHandler.ShowError("Código Inválido!!")
                Me.txtBarras.Text = ""
                Me.txtBarras.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        pnCargue.Enabled = True
        pnLecturaAjenos.Visible = False
        pnCargue.BringToFront()
        LimpiarControles()
    End Sub

#Region "Eventos Venta manual unicamente"
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rbFactura.Checked Then
            ' Se llama la forma de control de documentos
            AsignaDocumentoManualForm.Run(TipoMovimientos.Factura, "Factura Manual", TiposDocumento.FacturaManual)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.OK
        ElseIf rbRemision.Checked Then
            AsignaDocumentoManualForm.Run(TipoMovimientos.Remision, "Remisión Manual", TiposDocumento.RemisionManual)
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.OK
        Else
            UIHandler.ShowError("Seleccione el tipo de documento!!")
        End If
    End Sub

    Private Sub btnCancelarTipoDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTipoDoc.Click
        ' Cancelar la seleccion del tipo de documento y
        ' volver a la lectura
        pnTipoDocumento.Visible = False
        pnLecturaAjenos.Visible = False
        pnCargue.Enabled = True
        Me.txtBarras.Text = ""
        Me.txtBarras.Focus()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        ' Utilizado para grabar la venta manual
        If dsVenta.CilindrosLeidos.Rows.Count > 0 Then
            ' Se pide el tipo de documento
            Me.pnTipoDocumento.Visible = True
            Me.pnLecturaAjenos.Visible = False
            Me.pnCargue.Enabled = False
            Me.pnTipoDocumento.BringToFront()
        Else
            UIHandler.ShowError("No hay datos para grabar!!")
        End If
    End Sub
#End Region

    Private Sub txtBarras_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarras.TextChanged

    End Sub
End Class
