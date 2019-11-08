Imports System.Data

Public Class VentaForm
    Implements IModuloPedido

    Private ConsecutivoFactura As Short = 0
    Private ConsecutivoRemito As Short = 0
    Private ConsecutivoAsignacion As Short = 0
    Private ConsecutivoRecoleccion As Short = 0
    Private ConsecutivoDeposito As Short = 0
    Private CantidadServicio As Short = 0
    Private m_rowCliente As DataRow
    Private m_rowPedido As DataRow
    Private FilaSeleccionada As DataRow


    Public Sub Run(ByVal rowCliente As System.Data.DataRow, ByVal rowPedido As System.Data.DataRow) Implements Common.IModuloPedido.Run
        UIHandler.StartWait()
        Me.m_rowCliente = rowCliente
        Me.m_rowPedido = rowPedido
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub VentaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LimpiarControles()
        Me.dsPedidos = Pedidos.dsPedidos
        Me.bsDetallePedido.DataSource = Me.dsPedidos
        bsDetallePedido.Position = 0
        Me.dsVenta = Venta.dsVenta
        Me.dsPacientes = Pacientes.dsPacientes
        Me.lblNoPedido.Text = cstrDBNULL(m_rowPedido("NoPedido"))
        UIHandler.EndWait()
    End Sub

    Public Sub LimpiarControles()
        Me.lblDescripcionProducto.Text = ""
        Me.lblCantidadAjeno.Text = ""
        Me.lblCantidadPraxair.Text = ""
        Me.lblContado.Text = ""
        Me.lblCredito.Text = ""
    End Sub

    Private Sub grdDetallePedido_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDetallePedido.CurrentCellChanged
        Dim nIndex As Integer
        nIndex = grdDetallePedido.CurrentRowIndex
        If nIndex >= 0 Then
            FilaSeleccionada = GetCurrentRow(bsDetallePedido)
            If FilaSeleccionada IsNot Nothing Then
                If cstrDBNULL(m_rowCliente("CodTipoCliente")) <> TiposCliente.Paciente Then
                    If CStr(m_rowCliente("TipoPago")) = TipoPago.Credito Then
                        If cstrDBNULL(m_rowCliente("FrecuenciaMensual")) = DatosCliente.FrecuenciaMensual Then

                            'TODO: Un servicio siempre se paga de contado???????
                            'If cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Servicio Then
                            '    Me.lblCredito.Text = "0"
                            '    Me.lblContado.Text = cstrDBNULL(FilaSeleccionada("UnidadesReales"), "0")
                            'Else
                            Me.lblCredito.Text = cstrDBNULL(FilaSeleccionada("UnidadesReales"), "0")
                            Me.lblContado.Text = "0"
                            'End If
                        Else
                            Me.lblContado.Text = cstrDBNULL(FilaSeleccionada("UnidadesReales"), "0")
                            Me.lblCredito.Text = "0"
                        End If
                    Else
                        Me.lblContado.Text = cstrDBNULL(FilaSeleccionada("UnidadesReales"), "0")
                        Me.lblCredito.Text = "0"
                    End If
                End If

                'Se valida que las unidades capturadas sean mayor a  cero
                'Para poder recoger, modificar flete o eliminar un servicio
                If CShort(FilaSeleccionada("UnidadesReales")) > 0 Then
                    If cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Flete Then
                        btnAux.Visible = True
                        btnAux.Text = "&Modificar"
                        lblQRecoger.Visible = False
                        txtCantidadRecoger.Visible = False
                        lblQAsignar.Visible = False
                        txtQReal.Visible = False
                    ElseIf cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Producto Then
                        ' Muestra la opción de recoger cilindros solo cuando el producto requiere 
                        ' asignacion
                        If cstrDBNULL(FilaSeleccionada("RequiereAsignacion")) = Asignacion.RequiereAsignacion And (CIntDBNull(FilaSeleccionada("Asignaciones")) > 0 Or CIntDBNull(FilaSeleccionada("Recolecciones")) > 0) Then
                            Me.lblQRecoger.Visible = True
                            Me.txtCantidadRecoger.Visible = True
                            lblQAsignar.Visible = True
                            txtQReal.Visible = True
                            Me.btnAux.Visible = False
                        Else
                            Me.lblQRecoger.Visible = False
                            Me.txtCantidadRecoger.Visible = False
                            lblQAsignar.Visible = False
                            txtQReal.Visible = False
                            Me.btnAux.Visible = False
                        End If
                    ElseIf cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Servicio Then
                        btnAux.Visible = True
                        btnAux.Text = "&Eliminar"
                        lblQRecoger.Visible = False
                        txtCantidadRecoger.Visible = False
                        lblQAsignar.Visible = False
                        txtQReal.Visible = False
                    End If
                Else
                    Me.lblQRecoger.Visible = False
                    Me.txtCantidadRecoger.Visible = False
                    Me.btnAux.Visible = False
                    lblQAsignar.Visible = False
                    txtQReal.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub btnAux_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAux.Click
        If cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Flete Then
            If cstrDBNULL(m_rowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                ModificarFletePaciente()
            Else
                ModificarFlete()
            End If
        ElseIf cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Servicio Then
            If MsgBox("Esta seguro de eliminar el servicio?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                If FilaSeleccionada("IdDetalleAutorizacion") IsNot DBNull.Value Then
                    Dim Row As PacientesDataSet.DetalleAutorizacionesRow
                    Row = Pacientes.dsPacientes.DetalleAutorizaciones.FindByIdDetalleAutorizacion(cstrDBNULL(FilaSeleccionada("IdDetalleAutorizacion")))
                    If Row IsNot Nothing Then
                        Row.UnidadesUtilizadas = Row.UnidadesUtilizadas + CShortDBNull(FilaSeleccionada("UnidadesReales"))
                    End If
                End If

                FilaSeleccionada.Delete()
                Me.lblCantidadAjeno.Text = "0"
                Me.lblCantidadPraxair.Text = "0"
                Me.lblContado.Text = "0"
                Me.lblCredito.Text = "0"
                Me.btnAux.Visible = False
            End If
        End If
    End Sub

    Private Sub ModificarFlete(Optional ByVal FltMunc As Boolean = False)
        Dim CantidadFlete As Short = 0
        'Dim PrecioUnitario, PorcentajeDescuento, _
        'PorcentajeImpuesto, TotalDescuento As Double
        Dim sCodProducto As String = ""
        Dim sCapacidad As String = ""
        Dim UnidadMedida As String = ""
        Dim sActualizar As Boolean = False
        Dim RowProducto As DataRow
        Dim RowDetallePedido As PedidosDataSet.DetallePedidoRow

        If FilaSeleccionada IsNot Nothing Then
            ' Se visualiza la pantalla de selección del producto            
            If FltMunc Then
                RowProducto = BuscarProductoForm.Run(TipoProducto.FleteMunicipios, CantidadServicio, False)
            Else
                RowProducto = BuscarProductoForm.Run(TipoProducto.Flete, CantidadServicio, False)
            End If
            If RowProducto IsNot Nothing Then
                ' Se verifica que se haya seleccionado un codflete distinto 
                'al capturado
                If cstrDBNULL(FilaSeleccionada("CodProducto")) = CStr(RowProducto("Codigo")) Then
                    UIHandler.ShowError("No se modifico el flete!!")
                Else
                    If FltMunc Then
                        sActualizar = True
                    Else
                        If MsgBox("Esta seguro de modificar el flete?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                            sActualizar = True
                        Else : sActualizar = False
                        End If
                    End If

                    If sActualizar Then
                        CantidadFlete = CShortDBNull(FilaSeleccionada("UnidadesReales"))
                        sCodProducto = cstrDBNULL(FilaSeleccionada("CodFlete"))
                        sCapacidad = cstrDBNULL(FilaSeleccionada("CapacidadActivo"))

                        ' Se elimina el flete de la tabla de detalles
                        FilaSeleccionada.Delete()

                        ' se actualiza el detalle del pedido con el nuevo codigo de flete
                        RowDetallePedido = dsPedidos.DetallePedido.FindByNoPedidoCodProductoCapacidadNoAutorizacion(CStr(m_rowPedido("NoPedido")), _
                                sCodProducto, sCapacidad, cstrDBNULL(m_rowPedido("Autorizacion")))
                        If Not RowDetallePedido Is Nothing Then
                            RowDetallePedido("CodFlete") = CStr(RowProducto("Codigo"))
                        End If

                        ' Se inserta el flete
                        Pedidos.ActualizarFlete(cstrDBNULL(m_rowPedido("NoPedido")), cstrDBNULL(RowProducto("Codigo")), _
                        CantidadFlete, sCodProducto, sCapacidad, cstrDBNULL(m_rowCliente("TipoPago")), m_rowCliente, "S")
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub AgregarFleteMunicipios()
        Dim CantidadFlete As Short = 0
        Dim sCodProducto As String = ""
        Dim sCapacidad As String = ""
        Dim UnidadMedida As String = ""
        Dim IdDetalleAutorizacion As String = ""
        Dim RowAutorizacion() As DataRow = Nothing
        Dim CantidadContado As Short = 0
        Dim CantidadCredito As Short = 0

        CantidadFlete = 0
        For Index As Integer = 0 To grdDetallePedido.VisibleRowCount - 1
            grdDetallePedido.CurrentRowIndex = Index
            FilaSeleccionada = GetCurrentRow(bsDetallePedido)
            If cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Flete Then
                btnAux.Visible = True
                btnAux.Text = "&Modificar"
                If cstrDBNULL(FilaSeleccionada("TipoProducto")) = TipoProducto.Flete Then
                    If cstrDBNULL(m_rowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                        ModificarFletePaciente(True)
                    Else
                        ModificarFlete(True)
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub ModificarFletePaciente(Optional ByVal FltMunc As Boolean = False)
        Dim CantidadFlete As Short = 0
        Dim sCodProducto As String = ""
        Dim sCapacidad As String = ""
        Dim sActualizar As Boolean = False
        Dim UnidadMedida As String = ""
        Dim IdDetalleAutorizacion As String = ""
        Dim RowProducto As DataRow
        Dim RowAutorizacion() As DataRow = Nothing
        Dim CantidadContado As Short = 0
        Dim CantidadCredito As Short = 0

        If FilaSeleccionada IsNot Nothing Then
            ' Se visualiza la pantalla de selección del producto
            If FltMunc Then
                RowProducto = BuscarProductoForm.Run(TipoProducto.FleteMunicipios, CantidadServicio, False)
            Else
                RowProducto = BuscarProductoForm.Run(TipoProducto.Flete, CantidadServicio, False)
            End If
            If RowProducto IsNot Nothing Then
                ' Se verifica que se haya seleccionado un codflete distinto 
                'al capturado
                If cstrDBNULL(FilaSeleccionada("CodProducto")) = CStr(RowProducto("Codigo")) Then
                    UIHandler.ShowError("No se modifico el flete!!")
                Else
                    If FltMunc Then
                        sActualizar = True
                    Else
                        If MsgBox("Esta seguro de modificar el flete?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                            sActualizar = True
                        Else : sActualizar = False
                        End If
                    End If
                    If sActualizar Then
                        CantidadFlete = CShortDBNull(FilaSeleccionada("UnidadesReales"))
                        sCodProducto = cstrDBNULL(FilaSeleccionada("CodFlete"))
                        sCapacidad = cstrDBNULL(FilaSeleccionada("CapacidadActivo"))

                        If FilaSeleccionada("IdDetalleAutorizacion") IsNot Nothing Then
                            Dim Row As PacientesDataSet.DetalleAutorizacionesRow
                            Row = Pacientes.dsPacientes.DetalleAutorizaciones.FindByIdDetalleAutorizacion(cstrDBNULL(FilaSeleccionada("IdDetalleAutorizacion")))
                            If Row IsNot Nothing Then
                                Row.UnidadesUtilizadas = Row.UnidadesUtilizadas + CantidadFlete
                            End If
                        End If

                        ' Se elimina el flete de la tabla de detalles
                        FilaSeleccionada.Delete()

                        Pedidos.ActualizarFletePaciente(cstrDBNULL(m_rowPedido("NoPedido")), cstrDBNULL(m_rowCliente("CodTipoCliente")), _
                        cstrDBNULL(RowProducto("Codigo")), CantidadFlete, sCodProducto, sCapacidad, m_rowCliente, cstrDBNULL(m_rowPedido("CodEntidad")))
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCantidadRecoger_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadRecoger.KeyPress
        If e.KeyChar = vbCr Then
            If Me.txtCantidadRecoger.Text <> "" Then
                ' Solo si el cliente es Industrial ó Entidad se puede generar una asignación automática
                If cstrDBNULL(m_rowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                    If CLng(Me.txtCantidadRecoger.Text) > CLng(Me.txtQReal.Text) Then
                        UIHandler.ShowError("Error, Cantidad mayor a la entregada!!")
                        Me.txtCantidadRecoger.Text = "0"
                        Me.txtCantidadRecoger.Focus()
                        Exit Sub
                    End If
                End If
                If CLng(Me.txtQReal.Text) - CLng(Me.txtCantidadRecoger.Text) < 0 Then
                    Me.lblQAsignada.Text = "0"
                Else
                    Me.lblQAsignada.Text = CStr(CLng(Me.txtQReal.Text) - CLng(Me.txtCantidadRecoger.Text))
                End If
                bsDetallePedido.EndEdit()
                bsDetallePedido.ResetCurrentItem()
            End If
        End If
    End Sub

#Region "Eventos MenuPrincipal"

    Private Sub menuServicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuServicio.Click
        Dim Row As DataRow
        Dim CodProducto As String = ""
        Dim RowAutorizacion() As DataRow = Nothing
        Dim CantidadContado As Short = 0
        Dim CantidadCredito As Short = 0
        Dim Credito As String = "N"

        Row = BuscarProductoForm.Run(TipoProducto.Servicio, CantidadServicio, False)
        If Row IsNot Nothing Then
            ' Se agrega al detalle del pedido
            If cstrDBNULL(m_rowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                If bVerificarAutorizacion Then
                    Pacientes.VerificarProductoAutorizado(cstrDBNULL(Row("Codigo")), CantidadServicio, _
                    Servicio.Capacidad, RowAutorizacion, CantidadContado, CantidadCredito, _
                    cstrDBNULL(Row("CodTipoProducto")), cstrDBNULL(Row("Lastro")))
                End If
                'DATASCAN 20171025
                'ANTES:
                Pedidos.ActualizarDetallePedidoPaciente(m_rowPedido, m_rowCliente, cstrDBNULL(Row("CodFlete")), _
                Servicio.Capacidad, Pertenencia.Praxair, CType(Row, ProductosDataSet.ProductosRow), _
                CantidadServicio, RowAutorizacion, CantidadContado, CantidadCredito, bRespetaPrecio)
                'AHORA:
                If Pedidos.ActualizarDetallePedidoPaciente(m_rowPedido, m_rowCliente, cstrDBNULL(Row("CodFlete")), _
                Servicio.Capacidad, Pertenencia.Praxair, CType(Row, ProductosDataSet.ProductosRow), _
                CantidadServicio, RowAutorizacion, CantidadContado, CantidadCredito, bRespetaPrecio) = False Then
                    Exit Sub
                End If
                'FIN DATASCAN 20171025
            Else
                If CStr(m_rowCliente("TipoPago")) = TipoPago.Credito Then
                    If cstrDBNULL(m_rowCliente("FrecuenciaMensual")) = DatosCliente.FrecuenciaMensual Then
                        Credito = "S"
                    Else
                        Credito = "N"
                    End If
                Else
                    Credito = "N"
                End If
                Pedidos.ActualizarDetallePedido(m_rowPedido, m_rowCliente, "", Servicio.Capacidad, _
                Pertenencia.Praxair, CType(Row, ProductosDataSet.ProductosRow), CantidadServicio, Credito)
            End If
        End If
    End Sub

    Private Sub mnuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCancelar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub mnuLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuLectura.Click
        LecturaCilindrosVentaForm.Run(m_rowPedido, m_rowCliente)
        bsDetallePedido.DataSource = Pedidos.dsPedidos

        'Flete a Municipios
        If cstrDBNULL(m_rowCliente("Acarreo")) = "M" Then
            AgregarFleteMunicipios()
        End If

    End Sub

    Private Sub VentaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                mnuCancelar_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.S Then
                menuServicio_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.L Then
                mnuLectura_Click(Me, Nothing)
            ElseIf e.KeyCode = System.Windows.Forms.Keys.M Or e.KeyCode = System.Windows.Forms.Keys.E Then
                btnAux_Click(Me, Nothing)
            End If
        End If
    End Sub

#End Region
   
End Class