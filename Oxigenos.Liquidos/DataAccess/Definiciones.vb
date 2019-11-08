Public Class EstadosHojaRuta
    Public Const Creada As String = "1"
    Public Const Iniciada As String = "2"
    Public Const Cerrada As String = "3"
End Class

Public Class MetodosEntrega
    Public Const PorNiveles As String = "1"
    Public Const PorPesoCamion As String = "2"
    Public Const PorPesoTanque As String = "3"
    Public Const PorCaudalimetro As String = "4"
End Class

Public Class PrecioProducto
    Public AplicaIVA As Boolean
    Public Precio As Decimal
    Public PorcentajeIVA As Decimal
    Public PorcentajeDescuento As Single
    Public MontoDescuento As Decimal
End Class

Public Class TiposPrecinto
    Public Const Existente As String = "E"
    Public Const Coladado As String = "C"
End Class

Public Class TipoPago
    Public Const Credito As String = "02"
    Public Const Contado As String = "01"
End Class

Public Class EstadoFactura
    Public Const Entregado As String = "E"
    Public Const Anulado As String = "A"
End Class

Public Class TiposMovimiento
    Public Const Factura As String = "F"
    Public Const Remision As String = "B"
End Class

Public Class TipoDocumentos
    Public Shared Factura As String = "FAC"
    Public Shared Remision As String = "FCO"
End Class

Public Class UnidadesMedida
    Public Const Kilogramos As String = "kgs"
    Public Const MetrosCubicos As String = "m3"
End Class
