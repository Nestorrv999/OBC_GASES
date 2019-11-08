Imports OpenNETCF.Win32
Imports Oxigenos.Common
Imports System.Data

Public Class AsignaDocumentoManualForm
    Private NoDocumento As String = ""
    Private sTipoMovimiento As String
    Private sTipoDocumento As Integer
    Private sDescripcionProducto As String = ""
    Private sMensaje As String
    Private RowTalonario As DataRow
    Private bSinProductos As Boolean = False

    Public Shared Sub Run(ByVal sTipoMovimiento As String, ByVal sMensaje As String, _
    ByVal sTipoDocumento As Short, Optional ByVal bSinProductos As Boolean = False)
        UIHandler.StartWait()
        Dim form As New AsignaDocumentoManualForm
        Dim Row As DataRow = Nothing

        form.sTipoMovimiento = sTipoMovimiento
        form.sMensaje = sMensaje
        form.sTipoDocumento = sTipoDocumento
        form.bSinProductos = bSinProductos
        ' Se verifican si existen documentos para realizar la generación
        'Row = Nucleo.GetTalonarioActual(sTipoDocumento)
        'If Row Is Nothing Then
        '    UIHandler.ShowError("No existen Documentos disponibles para realizar la generación!!")
        'Else
        '    form.RowTalonario = Row
        '    UIHandler.ShowDialog(form)
        '    form.Dispose()
        'End If

        If ObtenerNoFactura(Row, sTipoDocumento) Then
            Nucleo.UpdateTalonario(Row)
            form.RowTalonario = Row
            UIHandler.ShowDialog(form)
            form.Dispose()
        Else
            Venta.dsVenta.RejectChanges()
        End If
        UIHandler.EndWait()
    End Sub

    Private Sub AsignaDocumentoManualForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'DATASCAN 20170914
        'ANTES:
        'Win32Window.MoveWindow(Me.Handle, CInt((240 - Shape1.Width) / 2), _
        'CInt((280 - Shape1.Height) / 2), Shape1.Width, Shape1.Height)
        'AHORA:
        Win32Window.MoveWindow(Me.Handle, 0, 70, Shape1.Width, Shape1.Height)
        'FIN DATASCAN 20170914
    End Sub

    Private Sub AsignaDocumentoManualForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = System.Windows.Forms.Keys.Escape Then
                btnCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub DocumentoManualForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Me.lblTitulo.Text = sMensaje
        Me.dsVenta = Venta.dsVenta
        ' Se muestra el No. del documento actual
        Me.lblNoDocumento.Text = CStr(RowTalonario("Prefijo")) & " - " & CStr(RowTalonario("Actual"))
        UIHandler.EndWait()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        GuardarDatos()
    End Sub

    Private Sub GuardarDatos()
        Dim RowKardex As ProductosDataSet.KardexCamionRow
        Dim Asignacion As Integer = 0

        UIHandler.StartWait()
        Select Case sTipoMovimiento
            Case TipoMovimientos.Factura
                If bSinProductos Then
                    dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Factura, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                    "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                    Venta.UpdateFacturasManuales()
                Else
                    For Each Row As VentaDataSet.CilindrosLeidosRow In Venta.dsVenta.CilindrosLeidos.Rows
                        ' Se guarda la tabla de facturas manuales
                        dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Factura, cstrDBNULL(RowTalonario("Actual")), _
                        Nucleo.CodigoSucursal, Row.CodProducto, Row.Capacidad, Row.Secuencial, Row.Pertenencia, _
                        Row.SecuencialAjeno, cstrDBNULL(RowTalonario("Prefijo")))

                        ' Se actualiza el kardex y la carga del camión
                        Productos.ActualizarCargueKardex(Row.CodProducto, Row.CodSucursal, Row.SecuencialAjeno, _
                        Row.Secuencial, Row.CodTipoProducto, Row.Pertenencia, Row.Capacidad, Row.Cantidad)

                        If Row.CantidadAsignada > 0 Then
                            Asignacion += 1
                            ' Si se genero asignacion se graba en la tabla de asignaciones/recolecciones
                            Dim RowAsigna As VentaDataSet.DetalleGuiaAsignacionesRecoleccionesRow
                            'RowAsigna = dsVenta.DetalleGuiaAsignacionesRecolecciones.FindByNoMovimientoTipoGuiaTipoMovimientoCodProductoCapacidadPertenenciaNoGuiaPrefijo(Nucleo.NumeroMovimiento, _
                            'TipoGuias.Asignacion, TipoMovimientos.AsignacionDetalleguia, Row.CodProducto, Row.Capacidad, Row.Pertenencia, _
                            '"", "")
                            If RowAsigna Is Nothing Then
                                ' se inserta el registro
                                dsVenta.DetalleGuiaAsignacionesRecolecciones.AddDetalleGuiaAsignacionesRecoleccionesRow(Nucleo.NumeroMovimiento, _
                                TipoGuias.Asignacion, TipoMovimientos.AsignacionDetalleguia, Row.CodProducto, Row.Capacidad, Row.Pertenencia, Row.CantidadAsignada, _
                                "", "", Row.UnidadMedida)
                            Else
                                'Se incrementa la cantidad
                                RowAsigna.Cantidad += Row.CantidadAsignada
                            End If
                        End If
                    Next
                    Productos.UpdateCarga()
                    Productos.UpdateKardexCamion()
                    Venta.UpdateFacturasManuales()
                    Venta.UpdateDetalleGuiaAsignacionesRecolecciones()

                    If Asignacion > 0 Then
                        AsignacionManualForm.Run()
                    End If
                End If
            Case TipoMovimientos.Remision
                If bSinProductos Then
                    dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Remision, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                    "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                    Venta.UpdateFacturasManuales()
                Else
                    For Each Row As VentaDataSet.CilindrosLeidosRow In Venta.dsVenta.CilindrosLeidos.Rows
                        ' Se guarda la tabla de facturas manuales
                        dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Remision, cstrDBNULL(RowTalonario("Actual")), _
                        Nucleo.CodigoSucursal, Row.CodProducto, Row.Capacidad, Row.Secuencial, Row.Pertenencia, _
                        Row.SecuencialAjeno, cstrDBNULL(RowTalonario("Prefijo")))

                        ' Se actualiza el kardex y la carga del camión
                        Productos.ActualizarCargueKardex(Row.CodProducto, Row.CodSucursal, Row.SecuencialAjeno, _
                        Row.Secuencial, Row.CodTipoProducto, Row.Pertenencia, Row.Capacidad, Row.Cantidad)

                        If Row.CantidadAsignada > 0 Then
                            Asignacion += 1
                            ' Si se genero asignacion se graba en la tabla de asignaciones/recolecciones
                            Dim RowAsigna As VentaDataSet.DetalleGuiaAsignacionesRecoleccionesRow
                            'RowAsigna = dsVenta.DetalleGuiaAsignacionesRecolecciones.FindByNoMovimientoTipoGuiaTipoMovimientoCodProductoCapacidadPertenenciaNoGuiaPrefijo(Nucleo.NumeroMovimiento, _
                            'TipoGuias.Asignacion, TipoMovimientos.AsignacionDetalleguia, Row.CodProducto, Row.Capacidad, Row.Pertenencia, _
                            '"", "")
                            If RowAsigna Is Nothing Then
                                ' se inserta el registro
                                dsVenta.DetalleGuiaAsignacionesRecolecciones.AddDetalleGuiaAsignacionesRecoleccionesRow(Nucleo.NumeroMovimiento, _
                                TipoGuias.Asignacion, TipoMovimientos.AsignacionDetalleguia, Row.CodProducto, Row.Capacidad, Row.Pertenencia, Row.CantidadAsignada, _
                                "", "", Row.UnidadMedida)
                            Else
                                'Se incrementa la cantidad
                                RowAsigna.Cantidad += Row.CantidadAsignada
                            End If
                        End If
                    Next
                    Productos.UpdateCarga()
                    Productos.UpdateKardexCamion()
                    Venta.UpdateFacturasManuales()
                    Venta.UpdateDetalleGuiaAsignacionesRecolecciones()
                    If Asignacion > 0 Then
                        AsignacionManualForm.Run()
                    End If
                End If
            Case TipoMovimientos.Recoleccion
                For Each RowCilindros As VentaDataSet.CilindrosLeidosRow In Venta.dsVenta.CilindrosLeidos.Rows

                    ' Se actualizan activos en el kardex camion
                    RowKardex = Productos.dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(RowCilindros.CodProducto, _
                    RowCilindros.Capacidad, TipoProducto.Activo)

                    If RowKardex IsNot Nothing Then
                        If RowCilindros.Pertenencia = Pertenencia.Cliente Then
                            RowKardex("SaldoCliente") = CShort(RowKardex("SaldoCliente")) + CShort(1)
                        Else
                            RowKardex("SaldoPraxair") = CShort(RowKardex("SaldoPraxair")) + CShort(1)
                        End If
                    Else
                        If RowCilindros.Pertenencia = Pertenencia.Cliente Then
                            Productos.dsProductos.KardexCamion.AddKardexCamionRow(RowCilindros.CodProducto, RowCilindros.Capacidad, _
                            0, 0, RowCilindros.Cantidad, RowCilindros.Cantidad, Nucleo.CodigoSucursal, TipoProducto.Activo, CInt(RowCilindros.Capacidad))
                        Else
                            Productos.dsProductos.KardexCamion.AddKardexCamionRow(RowCilindros.CodProducto, RowCilindros.Capacidad, _
                            RowCilindros.Cantidad, RowCilindros.Cantidad, 0, 0, Nucleo.CodigoSucursal, TipoProducto.Activo, CInt(RowCilindros.Capacidad))
                        End If
                    End If

                    ' Se graba el detalle de la guia de recolecciones
                    Dim row As VentaDataSet.DetalleGuiaAsignacionesRecoleccionesRow
                    row = Nothing
                    'row = dsVenta.DetalleGuiaAsignacionesRecolecciones.FindByNoMovimientoTipoGuiaTipoMovimientoCodProductoCapacidadPertenenciaNoGuiaPrefijo(Nucleo.NumeroMovimiento, TipoGuias.Recojo, _
                    '    TipoMovimientos.RecojoVacios, RowCilindros.CodProducto, RowCilindros.Capacidad, RowCilindros.Pertenencia, cstrDBNULL(RowTalonario("Actual")), cstrDBNULL(RowTalonario("Prefijo")))

                    If row IsNot Nothing Then
                        row.Cantidad += CShort(RowCilindros.Cantidad)
                    Else
                        dsVenta.DetalleGuiaAsignacionesRecolecciones.AddDetalleGuiaAsignacionesRecoleccionesRow(Nucleo.NumeroMovimiento, TipoGuias.Recojo, _
                        TipoMovimientos.RecojoVacios, RowCilindros.CodProducto, RowCilindros.Capacidad, RowCilindros.Pertenencia, CShort(RowCilindros.Cantidad), _
                        cstrDBNULL(RowTalonario("Actual")), cstrDBNULL(RowTalonario("Prefijo")), RowCilindros.UnidadMedida)
                    End If

                    If RowCilindros.Pertenencia = Pertenencia.Cliente Then
                        ' Si es Recolección Ajena se graba el detalle de recolecciones ajenas
                        dsVenta.DetalleGuiaRecoleccionesAjenos.AddDetalleGuiaRecoleccionesAjenosRow(Nucleo.NumeroMovimiento, cstrDBNULL(RowTalonario("Actual")), _
                        TipoMovimientos.RecojoVacios, RowCilindros.CodProducto, RowCilindros.Capacidad, RowCilindros.SecuencialAjeno, _
                        Nucleo.CodigoSucursal, "", cstrDBNULL(RowTalonario("Prefijo")))
                    End If
                Next

                ' Se graba en la tabla de facturas manuales
                dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Recoleccion, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                Venta.UpdateFacturasManuales()

                ' Se actualizan los datasets
                Venta.UpdateDetalleGuiaAsignacionesRecolecciones()
                Venta.UpdateDetalleGuiaRecoleccionesAjenos()
                Productos.UpdateKardexCamion()

            Case TipoMovimientos.Asignacion
                dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Asignacion, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                Venta.UpdateFacturasManuales()

            Case TipoMovimientos.Contrato
                dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Contrato, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                Venta.UpdateFacturasManuales()

            Case TipoMovimientos.Deposito
                dsVenta.FacturasManuales.AddFacturasManualesRow(TipoMovimientos.Deposito, cstrDBNULL(RowTalonario("Actual")), Nucleo.CodigoSucursal, _
                "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
                Venta.UpdateFacturasManuales()
        End Select

        ' Se incrementa el numero de documento
        'IncrementarNumeroDocumento(RowTalonario)
        Nucleo.UpdateTalonario(RowTalonario)

        ' Se incrementa el No. del movimiento
        Nucleo.NumeroMovimiento = CStr(CInt(Nucleo.NumeroMovimiento) + 1)

        Venta = New GestorVenta
        UIHandler.ShowAlert("Generación finalizada correctamente!!")
        UIHandler.EndWait()

        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DecrementarNumeroDocumento(RowTalonario)
        Venta.dsVenta.RejectChanges()

        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        If MsgBox("Esta seguro de anular el documento?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
            ' Se incrementa el documento actual

            Nucleo.UpdateTalonario(RowTalonario)
            dsVenta.FacturasManuales.AddFacturasManualesRow(LCase(sTipoMovimiento), cstrDBNULL(RowTalonario("Actual")), _
            Nucleo.CodigoSucursal, "", "", "", "", "", cstrDBNULL(RowTalonario("Prefijo")))
            Venta.UpdateFacturasManuales()
            IncrementarNumeroDocumento(RowTalonario)
            RowTalonario = Nucleo.GetTalonarioActual(CInt(sTipoDocumento))
            If RowTalonario Is Nothing Then
                UIHandler.ShowError("No existen documentos disponibles para la impresión")
                UIHandler.StartWait()
                DialogResult = System.Windows.Forms.DialogResult.Yes
            Else
                Me.lblNoDocumento.Text = CStr(RowTalonario("Prefijo")) & " - " & CStr(RowTalonario("Actual"))
            End If
        End If
    End Sub
End Class