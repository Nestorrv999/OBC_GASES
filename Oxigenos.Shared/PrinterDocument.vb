Public Class PrinterDocument
#Region "Control envases"

    Public DetalleControlenvases As New List(Of ControlEnvases)
    Public DetalleDocumentoGenerado As New List(Of DocumentosGenerados)
    'Maestro reportes
    Public Fecha As String
    Public Sucursal As String
    Public Conductor As String
    Public Placa As String
    Public Ruta As String
    Public Tipo As TipoReporte
    Public Codigo As String

    Public Class DocumentosGenerados
        Public Tipo As String
        Public Prefijo As String
        Public Documento As String
        Public Cliente As String
        Public Nombre As String
        Public Contado As String
        Public Credito As String
        Public Estado As String
        Public Reimpresion As String
    End Class
    Public Class ControlEnvases
        Public CodProducto As String
        Public Descripcion As String
        Public Capacidad As String
        Public PE As String
        Public SalidaLLe As String
        Public SalidaVac As String
        Public Ventas As String
        Public Asignacion As String
        Public Recolecion As String
        Public VaciosEnt As String
        Public RetornoLleno As String
        Public RetornoVac As String
    End Class

    Public Sub setMaestroReportes(ByVal Fecha As String, ByVal Sucursal As String, ByVal Conductor As String, ByVal Placa As String, ByVal Ruta As String)
        Me.Fecha = Fecha
        Me.Sucursal = Sucursal
        Me.Conductor = Conductor
        Me.Placa = Placa
        Me.Ruta = Ruta
    End Sub
    Public Sub SetDetalleDocumentosGenerados(ByVal Tipo As String, ByVal Prefijo As String, ByVal Documento As String, ByVal Cliente As String, ByVal Nombre As String, ByVal Contado As String, ByVal Credito As String, ByVal Estado As String, ByVal Reimpresion As String)
        Dim Det As New DocumentosGenerados
        Det.Cliente = Cliente
        Det.Contado = Contado
        Det.Credito = Credito
        Det.Documento = Documento
        Det.Estado = Estado
        Det.Nombre = Nombre
        Det.Prefijo = Prefijo.Trim()
        Det.Tipo = Tipo
        Det.Reimpresion = Reimpresion
        DetalleDocumentoGenerado.Add(Det)
    End Sub
    Public Sub SetDetalleControlEnvases(ByVal CodProducto As String, ByVal Descripcion As String, ByVal Capacidad As String, ByVal PE As String, ByVal SalidaLLe As String, ByVal SalidaVac As String, ByVal Ventas As String, ByVal Asignacion As String, ByVal Recolecion As String, ByVal VaciosEnt As String, ByVal RetornoLleno As String, ByVal RetornoVac As String)
        Dim Det As New ControlEnvases
        Det.CodProducto = CodProducto
        Det.Descripcion = Descripcion
        Det.Capacidad = Capacidad
        Det.PE = PE
        Det.SalidaLLe = SalidaLLe
        Det.SalidaVac = SalidaVac
        Det.Ventas = Ventas
        Det.Asignacion = Asignacion
        Det.Recolecion = Recolecion
        Det.VaciosEnt = VaciosEnt
        Det.RetornoLleno = RetornoLleno
        Det.RetornoVac = RetornoVac
        DetalleControlenvases.Add(Det)
    End Sub


#End Region


    Public Class InfoCliente
        Public Codigo As String
        Public NIT As String
        Public Nombre As String
        Public Direccion As String
        Public Barrio As String
        Public Telefono As String
        Public Entidad As String
        Public SubDivision As String
        Public TipoPago As String
    End Class

    Public Class DocumentItem
        Public CodProducto As String
        Public Descripcion As String
        Public CantiUnit As Decimal
        Public Cantidad As Decimal
        Public Capacidad As String
        Public PrecioUnitario As Decimal
        Public UnidadMedida As String
        Public PrecioTotal As Decimal
        Public UsaPrecios As Boolean
        Public InfoAdicional As String
    End Class
    Public Class NoCopias
        Public orden As Integer
        Public Descripcion As String
    End Class

    Public Class InfoResolucion
        Public Numero As String
        Public RangoIni As String
        Public RangoFin As String
        Public Fecha As DateTime
        Public NoEntidad As String
        Public NoAutorizacion As String
    End Class

    Public MostarTotales As Boolean = False
    Public Consecutivo As String
    Public NumPedido As String
    Public Nombre As String
    Public TipoDocumento As String
    Public TipoPago As String
    Public FechaElaboracion As DateTime
    Public FechaVencimiento As DateTime
    Public Cliente As New InfoCliente
    Public Resolucion As InfoResolucion
    Public Entidad As InfoResolucion
    Public NoAutorizacion As InfoResolucion
    Public Items As New List(Of DocumentItem)
    Public ListNoCopias As New List(Of NoCopias)
    Public Subtotal As Decimal
    Public TotalIVA As Decimal
    Public Total As Decimal
    Public CodigoBarras As String
    Public ObservacionGeneral As String



    Public Sub SetInfoDocumento(ByVal Consecutivo As String, ByVal NumPedido As String, _
    ByVal Nombre As String, ByVal TipoDocumento As String, ByVal TipoPago As String, _
    ByVal FechaElaboracion As DateTime, ByVal FechaVencimiento As DateTime, ByVal sSucursal As String, _
    ByVal CodigoBarras As String, ByVal Codigo As String, ByVal ObservacionGeneral As String)
        Me.Consecutivo = (Convert.ToInt32(Consecutivo.Split(CChar("-"))(0).Trim())) & "-" _
                            & Convert.ToInt32((Consecutivo.Split(CChar("-"))(1).Trim()))
        Me.Nombre = Nombre
        Me.NumPedido = NumPedido
        Me.TipoDocumento = TipoDocumento
        Me.TipoPago = TipoPago
        Me.FechaElaboracion = FechaElaboracion
        Me.FechaVencimiento = FechaVencimiento
        Me.Sucursal = sSucursal
        Me.CodigoBarras = CodigoBarras
        Me.Codigo = Codigo
        Me.ObservacionGeneral = ObservacionGeneral
    End Sub

    Public Sub SetInfoResolucion(ByVal NumResolucion As String, ByVal RangoIni As String, ByVal RangoFin As String, _
    ByVal FechaResolucion As DateTime, ByVal Entidad As String, ByVal NoAsignacion As String)
        Me.Resolucion = New InfoResolucion
        Me.Resolucion.Numero = NumResolucion
        Me.Resolucion.RangoIni = RangoIni
        Me.Resolucion.RangoFin = RangoFin
        Me.Resolucion.Fecha = FechaResolucion
        Me.Resolucion.NoEntidad = Entidad
        Me.Resolucion.NoAutorizacion = NoAsignacion
    End Sub

    Public Sub SetInfoCliente(ByVal Codigo As String, ByVal NIT As String, ByVal Nombre As String, _
    ByVal Direccion As String, ByVal Barrio As String, ByVal Telefono As String, ByVal Entidad As String, ByVal Subdivision As String, ByVal TipoPago As String)
        Me.Cliente.Codigo = Codigo
        Me.Cliente.NIT = NIT
        Me.Cliente.Nombre = Nombre
        Me.Cliente.Direccion = Direccion
        Me.Cliente.Barrio = Barrio
        Me.Cliente.Telefono = Telefono
        Me.Cliente.Entidad = Entidad
        Me.Cliente.SubDivision = Subdivision
        Me.Cliente.TipoPago = TipoPago
    End Sub
    Public Sub CopiasDocumento(ByVal orden As Integer, ByVal Descripcion As String)
        Dim NoCopias As New NoCopias
        NoCopias.orden = orden
        NoCopias.Descripcion = Descripcion
        ListNoCopias.Add(NoCopias)
    End Sub
    Public Sub AddItem(ByVal CodProducto As String, ByVal Descripcion As String, _
    ByVal Cantidad As Decimal, ByVal UnidadMedida As String, ByVal InfoAdicional As String, _
                ByVal cantidadUnitaria As Decimal, ByVal capacidad As String)
        Dim item As New DocumentItem
        item.CodProducto = CodProducto
        item.Descripcion = Descripcion        
        item.Cantidad = Cantidad
        item.CantiUnit = cantidadUnitaria        
        item.Capacidad = capacidad
        item.UnidadMedida = UnidadMedida
        item.UsaPrecios = False
        item.InfoAdicional = InfoAdicional
        Items.Add(item)
    End Sub

    Public Sub AddItem(ByVal CodProducto As String, ByVal Descripcion As String, ByVal Cantidad As Decimal, _
    ByVal PrecioUnitario As Decimal, ByVal UnidadMedida As String, ByVal PrecioTotal As Decimal, _
                ByVal InfoAdicional As String, ByVal cantidadUnitaria As Decimal, ByVal capacidad As String)
        Dim item As New DocumentItem
        item.CodProducto = CodProducto
        item.Descripcion = Descripcion
        item.Cantidad = Cantidad
        item.UnidadMedida = UnidadMedida
        item.CantiUnit = cantidadUnitaria
        item.Capacidad = capacidad
        item.PrecioUnitario = PrecioUnitario
        item.PrecioTotal = PrecioTotal
        item.UsaPrecios = True
        item.InfoAdicional = InfoAdicional
        Items.Add(item)
    End Sub

    Public Sub SetInfoTotales(ByVal Subtotal As Decimal, ByVal IVA As Decimal)
        Me.Subtotal = Subtotal
        Me.TotalIVA = IVA
        Me.Total = Subtotal + IVA
        Me.MostarTotales = True
    End Sub

End Class

