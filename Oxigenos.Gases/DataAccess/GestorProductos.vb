Imports System.Data
Public Class GestorProductos

#Region "Funciones Kardex de Camión"
    Public Sub LoadKardexCamion()
        Me.dtaKardexCamion.Connection = Connection
        Me.dsProductos.KardexCamion.Rows.Clear()
        Me.dtaKardexCamion.FillKardex(Me.dsProductos.KardexCamion)
    End Sub

    Public Sub UpdateKardexCamion()
        Me.dtaKardexCamion.Connection = Connection
        'Me.dtaKardexCamion.Transaccion = Transaccion
        Me.dtaKardexCamion.Update(dsProductos.KardexCamion)
        dsProductos.KardexCamion.AcceptChanges()
    End Sub

    Public Sub ActualizarDataTableKardexCamion(ByVal Row As ProductosDataSet.KardexCamionRow, _
    ByVal sCodProducto As String, ByVal sCapacidad As String, ByVal sCodTipoProducto As String, _
    ByVal sSucursal As String, ByVal sPertenencia As String, ByVal Cantidad As Short, ByVal Carga As Boolean)
        Dim iSaldoCliente As Short
        Dim iSaldoPraxair As Short
        Dim iCantidadCliente As Short
        Dim iCantidadPraxair As Short

        If Row IsNot Nothing Then
            ' Se actualiza el registro
            If sPertenencia = Pertenencia.Cliente Then
                iSaldoCliente = Row.SaldoCliente + Cantidad
                iCantidadCliente = Row.SaldoCliente + Cantidad
                iSaldoPraxair = Row.SaldoPraxair
                iCantidadPraxair = Row.CantidadPraxair
            Else
                iSaldoCliente = Row.SaldoCliente
                iCantidadCliente = Row.SaldoCliente
                iSaldoPraxair = Row.SaldoPraxair + Cantidad
                iCantidadPraxair = Row.CantidadPraxair + Cantidad
            End If

            If Carga Then
                Row.CantidadPraxair = iCantidadPraxair
                Row.CantidadCliente = iCantidadCliente
            End If
            Row.SaldoPraxair = iSaldoPraxair
            Row.SaldoCliente = iSaldoCliente
        Else
            ' se inserta el registro
            Row = dsProductos.KardexCamion.NewKardexCamionRow
            Row.CodProducto = sCodProducto
            Row.Capacidad = sCapacidad
            Row.CodTipoProducto = sCodTipoProducto
            If sPertenencia = Pertenencia.Cliente Then
                Row.CantidadPraxair = 0
                Row.SaldoPraxair = 0
                Row.CantidadCliente = Cantidad
                Row.SaldoCliente = Cantidad
            Else
                Row.CantidadPraxair = Cantidad
                Row.SaldoPraxair = Cantidad
                Row.CantidadCliente = 0
                Row.SaldoCliente = 0
            End If
            Row.CodSucursal = sSucursal
            dsProductos.KardexCamion.AddKardexCamionRow(Row)
        End If
    End Sub
#End Region

#Region "Funciones Carga de Camión"
    ' Se obtienen todos los registros de la tabla
    Public Sub LoadCarga()
        Me.dtaCarga.Connection = Connection
        Me.dsProductos.Carga.Rows.Clear()
        Me.dtaCarga.Fill(Me.dsProductos.Carga)
    End Sub

    Public Sub UpdateCarga()
        Me.dtaCarga.Connection = Connection
        'Me.dtaCarga.Transaccion = Transaccion
        Me.dtaCarga.Update(dsProductos.Carga)
        dsProductos.Carga.AcceptChanges()
    End Sub

    Public Function GetSecuencial(ByVal Secuencial As String) As Boolean
        Dim dt As ProductosDataSet.CargaDataTable
        Me.dtaCarga.Connection = Connection
        dt = dtaCarga.GetSecuencial(Secuencial)
        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

#End Region

#Region "Funciones Productos"
    Public Function GetProducto(ByVal Codigo As String) As ProductosDataSet.ProductosRow
        Dim dt As ProductosDataSet.ProductosDataTable
        Me.dtaProductos.Connection = Connection
        dt = dtaProductos.GetByCodigo(Codigo)
        'dt = dtaProductos.GetDataByCodigo2(Codigo)
        If dt.Rows.Count > 0 Then
            Return dt(0)
        Else
            Return Nothing
        End If
    End Function

    Public Sub LoadProducto(ByVal CodProducto As String)
        Me.dtaProductos.Connection = Connection
        Me.dsProductos.Productos.Rows.Clear()
        Me.dtaProductos.FillByCodigo(Me.dsProductos.Productos, CodProducto)
    End Sub

    Public Sub LoadTipoProductos()
        Me.dtaTipoProductos.Connection = Connection
        Me.dsProductos.TipoProductos.Rows.Clear()
        Me.dtaTipoProductos.FillByTipoProducto(Me.dsProductos.TipoProductos)
    End Sub

    Public Sub LoadByTipoProducto(ByVal TipoProducto As String)
        Me.dtaProductos.Connection = Connection
        Me.dsProductos.Productos.Rows.Clear()
        Me.dtaProductos.FillByTipoProducto(Me.dsProductos.Productos, TipoProducto)
    End Sub

    Public Sub LoadByRequiereAsignacion()
        Me.dtaProductos.Connection = Connection
        Me.dsProductos.Productos.Rows.Clear()
        Me.dtaProductos.FillProductosRecolecciones(Me.dsProductos.Productos)
    End Sub

    ' Se busca el codigo producto y capacidad en la tabla de activos productos
    Public Function ObtenerActivoProducto(ByVal CodProducto As String, ByVal CapacidadProducto As String, _
    ByRef CodActivo As String, ByRef CapacidadActivo As String) As Boolean
        Me.dtaActivoProducto.Connection = Connection
        Me.dsProductos.ActivoProducto.Rows.Clear()
        Me.dtaActivoProducto.FillByActivo(dsProductos.ActivoProducto, CodProducto, CapacidadProducto)
        If Me.dsProductos.ActivoProducto.Rows.Count > 0 Then
            CodActivo = dsProductos.ActivoProducto(0).CodActivo
            CapacidadActivo = dsProductos.ActivoProducto(0).Capacidad
            Return True
        Else
            CodActivo = ""
            CapacidadActivo = ""
            Return False
        End If
    End Function

    Public Function NombreProducto(ByVal sCodProducto As String) As String
        Dim Row As ProductosDataSet.ProductosRow
        Row = Productos.GetProducto(sCodProducto)
        If Row IsNot Nothing Then
            Return Row.Descripcion
        Else
            Return ""
        End If
    End Function

    Public Sub GetDatosProducto(ByVal sCodProducto As String, ByRef Descripcion As String, _
    ByRef TipoProducto As String, ByRef RequiereAsignacion As String)
        Dim Row As ProductosDataSet.ProductosRow
        Row = Productos.GetProducto(sCodProducto)
        If Row IsNot Nothing Then
            Descripcion = Row.Descripcion
            TipoProducto = Row.CodTipoProducto
            RequiereAsignacion = Row.RequiereAsignacion
        Else
            Descripcion = ""
            TipoProducto = ""
            RequiereAsignacion = ""
        End If
    End Sub

#End Region

#Region "Funciones Pertenencia del cilindro"

    Public Sub LoadPertenencias()
        Me.dtaPertenencia.Connection = Connection
        Me.dsProductos.Pertenencia.Rows.Clear()
        Me.dtaPertenencia.FillByCodigo(dsProductos.Pertenencia)
    End Sub

    Public Function GetPertenencia(ByVal Codigo As String) As String
        Dim Row As DataRow
        Dim Key(0) As Object
        Key(0) = Codigo
        Row = Me.dsProductos.Pertenencia.Rows.Find(Key)
        If Not Row Is Nothing Then
            Return CStr(Row("Descripcion"))
        Else
            Return ""
        End If
    End Function
#End Region

#Region "Cilindros del Cliente"
    ' Verifica que el cilindro ajeno se encuentre en plataforma
    ' es decir el secuencial exista en la tabla CilindrosCliente
    Public Function GetSecuencialAjenoVacio(ByVal Secuencial As String) As DataRow
        Dim dt As DataTable
        Me.dtaCilindrosCliente.Connection = Connection
        Me.dsProductos.CilindrosCliente.Rows.Clear()
        dt = Me.dtaCilindrosCliente.GetBySecuencialAjeno(Secuencial)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function GetSecuencialAjenoCilindro(ByVal Serial As String) As DataRow
        Dim dt As DataTable
        Me.dtaCilindrosCliente.Connection = Connection
        Me.dsProductos.CilindrosCliente.Rows.Clear()
        dt = Me.dtaCilindrosCliente.GetBySecuencialAjenoCilindro(Serial)
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function GetSerialAjeno(ByVal Secuencial As String) As String
        Dim dt As DataTable
        Me.dtaCilindrosCliente.Connection = Connection
        Me.dsProductos.CilindrosCliente.Rows.Clear()
        dt = Me.dtaCilindrosCliente.GetBySecuencialAjeno(Secuencial.TrimEnd)
        If dt.Rows.Count > 0 Then
            Return cstrDBNULL(dt.Rows(0)("Serie"))
        Else
            Return "N.E"
        End If
    End Function

    'Legion Jul 08 2019
    Public Function GetSerialAjenoPorCilindro(ByVal Cilindro As String) As ProductosDataSet.CilindrosClienteDataTable
        Dim dt As DataTable
        Me.dtaCilindrosCliente.Connection = Connection
        Me.dsProductos.CilindrosCliente.Rows.Clear()
        Return Me.dtaCilindrosCliente.GetBySecuencialAjenoCilindro(Cilindro.Trim)
        'If dt.Rows.Count > 0 Then
        '    Return cstrDBNULL(dt.Rows(0)("Secuencia"))
        'Else
        '    Return "N.E"
        'End If
    End Function

    Public Sub UpdateCilindroCliente(ByVal Row As DataRow)
        Me.dtaCilindrosCliente.Connection = Connection

        Try
            If Row Is Nothing Then Return
            Row.AcceptChanges()
            Me.dtaCilindrosCliente.Update(Row)
        Catch ex As Exception
            Throw New ArgumentException("ERROR AL ACTUALIZAR EL CILINDRO." & ex.Message, ex)
        Finally
            dsProductos.CilindrosCliente.AcceptChanges()
        End Try


    End Sub

    ' Verifica que el cilindro ajeno se encuentre en plataforma
    ' es decir el secuencial exista en la tabla CilindrosCliente
    Public Function GetCilindroCliente(ByVal Secuencial As String) As ProductosDataSet.CilindrosClienteRow
        Me.dtaCilindrosCliente.Connection = Connection
        Me.dsProductos.CilindrosCliente.Rows.Clear()
        Me.dtaCilindrosCliente.FillBySecuencialAjeno(Me.dsProductos.CilindrosCliente, Secuencial)
        If Me.dsProductos.CilindrosCliente.Rows.Count > 0 Then
            Return Me.dsProductos.CilindrosCliente(0)
        Else
            Return Nothing
        End If
    End Function

#End Region

    Public Sub ActualizarCargueKardex(ByVal CodProducto As String, ByVal CodSucursal As String, _
    ByVal SecuencialAjeno As String, ByVal Secuencial As String, ByVal CodTipoProducto As String, ByVal sPertenencia As String, _
    ByVal Capacidad As String, ByVal Cantidad As Short)
        Dim RowCarga As ProductosDataSet.CargaRow
        Dim RowCargaActivo As ProductosDataSet.CargaRow
        Dim RowKardex As ProductosDataSet.KardexCamionRow
        Dim CodActivo As String = ""
        Dim CapacidadActivo As String = ""

        RowCarga = Me.dsProductos.Carga.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(CodSucursal, _
        CodProducto, Capacidad, Secuencial, sPertenencia, CodTipoProducto, SecuencialAjeno)

        If RowCarga IsNot Nothing Then
            RowCarga.EstadoEntrega = EstadosCilindro.Entregado
        End If

        ' Se actualiza el kardex de camión
        RowKardex = dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(CodProducto, Capacidad, CodTipoProducto)
        If RowKardex IsNot Nothing Then
            Productos.ActualizarDataTableKardexCamion(RowKardex, CodProducto, Capacidad, CodTipoProducto, _
            CodSucursal, sPertenencia, Cantidad * CShort(-1), False)
        End If

        ' se actualizan los activos
        If CodTipoProducto = TipoProducto.Producto Then
            If Productos.ObtenerActivoProducto(CodProducto, Capacidad, CodActivo, CapacidadActivo) Then
                ' Se actualizan activos
                RowCargaActivo = Me.dsProductos.Carga.FindByCodSucursalCodProductoCapacidadSecuencialPertenenciaCodTipoProductoSecuencialAjeno(CodSucursal, _
                CodProducto, Capacidad, Secuencial, sPertenencia, TipoProducto.Activo, SecuencialAjeno)
                If RowCargaActivo IsNot Nothing Then
                    RowCargaActivo.EstadoEntrega = EstadosCilindro.Entregado
                End If

                ' Se actualizan activos en el kardex camion
                RowKardex = dsProductos.KardexCamion.FindByCodProductoCapacidadCodTipoProducto(CodProducto, Capacidad, TipoProducto.Activo)
                If RowKardex IsNot Nothing Then
                    Productos.ActualizarDataTableKardexCamion(RowKardex, CodProducto, Capacidad, TipoProducto.Activo, CodSucursal, sPertenencia, _
                    -1, False)
                End If
            End If
        End If
    End Sub

End Class
