Imports Oxigenos.Common

Public Class GestorPacientes

    ' Carga las autorizaciones del cliente/Entidad
    Public Sub LoadAutorizaciones(ByVal sCodCliente As String, ByVal SCodEntidad As String)
        Me.dtaDetalleAutorizaciones.Connection = Connection
        Me.dsPacientes.DetalleAutorizaciones.Rows.Clear()
        Me.dtaDetalleAutorizaciones.FillDetalleAutorizacion(Me.dsPacientes.DetalleAutorizaciones, _
        sCodCliente, SCodEntidad)
    End Sub

    ' Verifica si un Producto esta autorizado para la entidad/paciente
    Public Sub VerificarProductoAutorizado(ByVal sCodProducto As String, ByVal CantidadLeida As Short, _
    ByVal Capacidad As String, ByRef RowAutorizacion() As DataRow, ByRef CantidadContado As Short, _
    ByRef CantidadCredito As Short, ByVal sTipoProducto As String, ByVal sLastro As String)
        Dim UnidadesDisponibles As Short
        Dim UnidadesReales As Short
        CantidadCredito = 0
        CantidadContado = 0

        If sTipoProducto = TipoProducto.Producto And sLastro = Lastro.Controla Then
            UnidadesReales = CantidadLeida * CShort((CDbl(Capacidad) / 1000))
        Else
            UnidadesReales = CantidadLeida
        End If

        If Pacientes.dsPacientes.DetalleAutorizaciones.Rows.Count > 0 Then
            RowAutorizacion = Pacientes.dsPacientes.DetalleAutorizaciones.Select("CodProducto =" & sCodProducto.Trim & " AND (UNIDADES - UNIDADESUTILIZADAS) >= " & UnidadesReales)

            If RowAutorizacion Is Nothing Then
                CantidadContado = UnidadesReales
                CantidadCredito = 0
                Exit Sub
            End If

            If RowAutorizacion.Length = 0 Then
                CantidadContado = UnidadesReales
                CantidadCredito = 0
                RowAutorizacion = Nothing
                Exit Sub
            End If

            If CShortDBNull(RowAutorizacion(0)("Unidades")) - CShortDBNull(RowAutorizacion(0)("UnidadesUtilizadas")) > 0 Then
                UnidadesDisponibles = CShortDBNull(RowAutorizacion(0)("Unidades")) - CShortDBNull(RowAutorizacion(0)("UnidadesUtilizadas"))
                If UnidadesDisponibles < UnidadesReales Then
                    If sTipoProducto = TipoProducto.Producto And sLastro = Lastro.Controla Then
                        CantidadCredito = CShort(CDbl(UnidadesDisponibles) / CDbl(Capacidad) / 1000)
                        CantidadContado = CantidadLeida - CantidadCredito
                    Else
                        CantidadCredito = UnidadesReales
                        CantidadContado = CantidadLeida - CantidadCredito
                    End If
                Else
                    CantidadCredito = UnidadesReales
                    CantidadContado = 0
                End If

                ' Se modifica la cantidad utilizada en el detalle de la 
                'autorizacion
                If CantidadCredito > 0 Then
                    If RowAutorizacion(0)("UnidadesUtilizadas") Is DBNull.Value Then
                        RowAutorizacion(0)("UnidadesUtilizadas") = CantidadCredito
                    Else
                        RowAutorizacion(0)("UnidadesUtilizadas") = CShort(RowAutorizacion(0)("UnidadesUtilizadas")) + CantidadCredito
                    End If
                End If
            Else
                CantidadContado = UnidadesReales
                CantidadCredito = 0
                RowAutorizacion = Nothing
            End If
        Else
            CantidadContado = UnidadesReales
            CantidadCredito = 0
            RowAutorizacion = Nothing
        End If
    End Sub

    Public Sub GetEntidadesCliente(ByVal sCodCliente As String)
        Me.dtaEntidadCliente.Connection = Connection
        Me.dsPacientes.EntidadCliente.Rows.Clear()
        Me.dtaEntidadCliente.FillEntidadesCliente(Me.dsPacientes.EntidadCliente, sCodCliente)
    End Sub

    Public Sub LoadCopagosPorCobrar(ByVal sCodCliente As String)
        Me.dtaCopagosPorCobrar.Connection = Connection
        Me.dsPacientes.CopagosPorCobrar.Rows.Clear()
        Me.dtaCopagosPorCobrar.FillCopagosPorCobrar(Me.dsPacientes.CopagosPorCobrar, sCodCliente)
    End Sub

    Public Function GetDatosEntidad(ByVal CodEntidad As String) As PacientesDataSet.ClientesDataTable
        Me.dtaClientes.Connection = Connection
        Me.dsPacientes.Clientes.Rows.Clear()
        Return dtaClientes.GetDatosEntidad(CodEntidad)
    End Function

    Public Sub GetEntidad(ByVal CodEntidad As String)
        Me.dtaEntidades.Connection = Connection
        Me.dsPacientes.Entidades.Rows.Clear()
        Me.dtaEntidades.FillEntidad(Me.dsPacientes.Entidades, CodEntidad)
    End Sub

    Public Sub UpdateDetalleAutorizaciones()
        Me.dtaDetalleAutorizaciones.Connection = Connection
        Me.dtaDetalleAutorizaciones.Transaccion = Transaccion
        Me.dtaDetalleAutorizaciones.Update(dsPacientes.DetalleAutorizaciones)
        dsPacientes.DetalleAutorizaciones.AcceptChanges()
    End Sub

    Public Sub GetTipoAsignacion(ByVal sCodProducto As String, ByVal sCodCapacidad As String)
        Me.dtaDetallesTipoAsignacion.Connection = Connection
        Me.dsPacientes.DetallesTipoAsignacion.Rows.Clear()
        Me.dtaDetallesTipoAsignacion.FillTipoAsignacion(Me.dsPacientes.DetallesTipoAsignacion, _
        sCodProducto, sCodCapacidad)
    End Sub

    Public Sub GetAsignaciones(ByVal CodCliente As String, ByVal CodEntidad As String, ByVal TipoAsignacion As String)
        Me.dtaAsignaciones.Dispose()
        Me.dtaAsignaciones.Connection = Connection
        Me.dsPacientes.Asignaciones.Rows.Clear()
        'Me.dtaAsignaciones.FillAsignacionesPaciente(Me.dsPacientes.Asignaciones, TipoAsignacion, CodCliente, CodEntidad)
        Me.dtaAsignaciones.FillAsignacionesPaciente2(Me.dsPacientes.Asignaciones, CodCliente)
    End Sub

    Public Sub UpdateAsignacion(ByVal NoAsignacion As String, ByVal NoRecoleccion As String)
        Me.dtaAsignaciones.Connection = Connection
        Me.dtaAsignaciones.Transaccion = Transaccion
        Me.dtaAsignaciones.UpdateAsignacion(NoRecoleccion, NoAsignacion)
    End Sub

    Public Function GetDescripcionTipoAsignacion(ByVal Tipoasignacion As String) As String
        Dim dt As PacientesDataSet.TipoAsignacionesDataTable

        Me.dtaTipoAsignaciones.Connection = Connection
        dt = Me.dtaTipoAsignaciones.GetTipoAsignacion(Tipoasignacion)
        If dt.Rows.Count > 0 Then
            Return cstrDBNULL(dt.Rows(0)("Descripcion"))
        Else
            Return ""
        End If
    End Function

    Public Function GetProductoTipoAsignacion(ByVal Tipoasignacion As String) As String
        Dim dt As PacientesDataSet.DetallesTipoAsignacionDataTable

        Me.dtaDetallesTipoAsignacion.Connection = Connection
        dt = Me.dtaDetallesTipoAsignacion.GetProductoTipoAsignacion(CInt(Tipoasignacion))
        If dt.Rows.Count > 0 Then
            Return cstrDBNULL(dt.Rows(0)("CodProducto"))
        Else
            Return ""
        End If
    End Function

    Public Sub GetAlquileres(ByVal sIdAutorizacion As String)
        Me.dtaAlquileres.Connection = Connection
        Me.dsPacientes.Alquileres.Rows.Clear()
        Me.dtaAlquileres.FillAlquileres(Me.dsPacientes.Alquileres, sIdAutorizacion)
    End Sub

    Public Sub DepositosEntidad(ByVal CodEntidad As String, ByVal CodTipoAsignacion As String)
        Me.dtaDepositosEntidad.Connection = Connection
        Me.dsPacientes.DepositosEntidad.Rows.Clear()
        Me.dtaDepositosEntidad.FillDeposito(Me.dsPacientes.DepositosEntidad, _
        CodEntidad, CodTipoAsignacion)
    End Sub

    Public Sub GetDepositosTipoAsignacion(ByVal CodTipoAsignacion As String)
        Me.dtaTipoAsignaciones.Connection = Connection
        Me.dsPacientes.TipoAsignaciones.Rows.Clear()
        Me.dtaTipoAsignaciones.FillDepositoTipoAsignacion(dsPacientes.TipoAsignaciones, _
        CodTipoAsignacion)
    End Sub

    Public Function GetMontoDepositoEntidad(ByVal CodTipoAsignacion As String, ByVal CodEntidad As String) As PacientesDataSet.DepositosEntidadDataTable
        Me.dtaDepositosEntidad.Connection = Connection
        Me.dsPacientes.DepositosEntidad.Rows.Clear()
        Return dtaDepositosEntidad.GetDeposito(CodEntidad, CodTipoAsignacion)
    End Function

    Public Sub UpdateDepositosGarantia()
        Me.dtaDepositosGarantia.Connection = Connection
        Me.dtaDepositosGarantia.Transaccion = Transaccion
        Me.dtaDepositosGarantia.Update(dsPacientes.DepositosGarantia)
        dsPacientes.DepositosGarantia.AcceptChanges()
    End Sub

    Public Sub UpdateAlquileres()
        Me.dtaAlquileres.Connection = Connection
        Me.dtaAlquileres.Transaccion = Transaccion
        Me.dtaAlquileres.Update(dsPacientes.Alquileres)
        dsPacientes.Alquileres.AcceptChanges()
    End Sub

    Public Sub UpdateAlquileresPagados()
        Me.dtaAlquileresPagados.Connection = Connection
        Me.dtaAlquileresPagados.Transaccion = Transaccion
        Me.dtaAlquileresPagados.Update(dsPacientes.AlquileresPagados)
        dsPacientes.AlquileresPagados.AcceptChanges()
    End Sub

    Public Sub UpdateAlquileresPendientes()
        Me.dtaAlquileresPendientes.Connection = Connection
        Me.dtaAlquileresPendientes.Transaccion = Transaccion
        Me.dtaAlquileresPendientes.Update(dsPacientes.AlquileresPendientes)
        dsPacientes.AlquileresPendientes.AcceptChanges()
    End Sub

    Public Sub UpdateAsignaciones()
        Me.dtaAsignaciones.Connection = Connection
        Me.dtaAsignaciones.Transaccion = Transaccion
        Try
            'MsgBox("" & dsPacientes.Asignaciones.Item(0).Modificado, MsgBoxStyle.Critical)
            'MsgBox("" & dsPacientes.Asignaciones.Item(1).Modificado, MsgBoxStyle.Critical)
            Me.dtaAsignaciones.Update(dsPacientes.Asignaciones)
            dsPacientes.Asignaciones.AcceptChanges()
        Catch ex As Exception
            Me.dsPacientes.Asignaciones.WriteXml("\Asig" & Now.ToString("ddMMyyyyHHmmss") & ".xml")
            WriteLog(ex)
        End Try
    End Sub

    Public Sub UpdateAutorizacionAsignaciones()
        Me.dtaAutorizacionAsignacion.Connection = Connection
        Me.dtaAutorizacionAsignacion.Transaccion = Transaccion
        Me.dtaAutorizacionAsignacion.Update(dsPacientes.AutorizacionAsignacion)
        dsPacientes.AutorizacionAsignacion.AcceptChanges()
    End Sub

    Public Sub UpdateAutorizacionRemision()
        Me.dtaAutorizacionRemision.Connection = Connection
        Me.dtaAutorizacionRemision.Transaccion = Transaccion
        Me.dtaAutorizacionRemision.Update(dsPacientes.AutorizacionRemision)
        dsPacientes.AutorizacionRemision.AcceptChanges()
    End Sub

    Public Sub UpdateDepositoGarantia()
        Me.dtaDepositosGarantia.Connection = Connection
        Me.dtaDepositosGarantia.Transaccion = Transaccion
        Me.dtaDepositosGarantia.Update(dsPacientes.DepositosGarantia)
        dsPacientes.DepositosGarantia.AcceptChanges()
    End Sub

    Public Sub GetDeudasPendientes(ByVal CodCliente As String)
        Me.dtaAlquileresPendientes.Connection = Connection
        Me.dsPacientes.AlquileresPendientes.Rows.Clear()
        Me.dtaAlquileresPendientes.FillDeudaPendiente(dsPacientes.AlquileresPendientes, CodCliente)
    End Sub

    Public Sub UpdateDeudasPagadas()
        Me.dtaDeudasPagadas.Connection = Connection
        Me.dtaDeudasPagadas.Transaccion = Transaccion
        Me.dtaDeudasPagadas.Update(dsPacientes.DeudasPagadas)
        dsPacientes.DeudasPagadas.AcceptChanges()
    End Sub

    Public Sub UpdateMovimientoCopagos()
        Me.dtaMovimientoCopagosCuotas.Connection = Connection
        Me.dtaMovimientoCopagosCuotas.Transaccion = Transaccion
        Me.dtaMovimientoCopagosCuotas.Update(dsPacientes.MovimientoCopagosCuotas)
        dsPacientes.MovimientoCopagosCuotas.AcceptChanges()
    End Sub

    Public Sub UpdateCopagosPendientes()
        Me.dtaCopagosPorCobrar.Connection = Connection
        Me.dtaCopagosPorCobrar.Transaccion = Transaccion
        Me.dtaCopagosPorCobrar.Update(dsPacientes.CopagosPorCobrar)
        dsPacientes.CopagosPorCobrar.AcceptChanges()
    End Sub

End Class
