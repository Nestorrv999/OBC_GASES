
Public Class EstadosCilindro
    Public Shared Entregado As String = "E"
    Public Shared NoEntregado As String = ""
End Class

Public Class EstadoCilindroCliente
    Public Shared Cargado As String = "C"
    Public Shared NoCargado As String = " "
    Public Shared Entregado As String = "E"
End Class

Public Class Pertenencia
    Public Shared Praxair As String = "1"
    Public Shared Cliente As String = "2"
End Class

Public Class TipoProducto
    Public Shared Producto As String = "1"
    Public Shared Servicio As String = "2"
    Public Shared Alquiler As String = "3"
    Public Shared Flete As String = "4"
    Public Shared Activo As String = "5"
    Public Shared FleteMunicipios As String = "6"
End Class

Public Class TipoMoneda
    Public Shared Nacional As String = "01"
    Public Shared Dolares As String = "02"
End Class

Public Class TipoMovimientos
    Public Shared Factura As String = "F"
    Public Shared Remision As String = "B"
    Public Shared Recoleccion As String = "R"
    Public Shared Asignacion As String = "A"
    Public Shared Anulada As String = "G"
    Public Shared Contrato As String = "C"
    Public Shared Deposito As String = "D"
    Public Shared RecojoVacios As String = "102"
    Public Shared RecojoLlenos As String = "111"
    Public Shared FacturaDetalleGuia As String = "901"
    Public Shared RemisionDetalleGuia As String = "902"
    Public Shared AsignacionDetalleguia As String = "101"
    Public Shared CopagoAsignacion As String = "AUD"
    Public Shared CopagoRemision As String = "REM"
End Class

Public Class TipoGuias
    Public Shared Recojo As String = "R"
    Public Shared Asignacion As String = "A"
End Class

Public Class Pedido
    Public Shared PedidoNuevo As String = "1"
    Public Shared PedidoDetalleNuevo As String = "1"
End Class

Public Class GeneraDocumento
    Public Shared Asignacion As Boolean = False
    Public Shared Recoleccion As Boolean = False
    Public Shared Devolucion As Boolean = False
    Public Shared DeudaPendiente As Boolean = False
    Public Shared Factura As Boolean = False
    Public Shared Remision As Boolean = False
End Class

Public Class Flete
    Public Shared RequiereFlete As String = "1"
    Public Shared NoRequiereFlete As String = "0"
    Public Shared Capacidad As String = "1000"
End Class

Public Class Servicio
    Public Shared Capacidad As String = "1000"
End Class

Public Class Asignacion
    Public Shared RequiereAsignacion As String = "1"
    Public Shared NoRequiereAsignacion As String = "0"
    Public Shared AsignacionContado As String = "1"
    Public Shared AsignacionCredito As String = "0"
    Public Shared AsignadoNormal As String = "1"
    Public Shared AsignadoComoSustituto As String = "0"
End Class

Public Class TipoPago
    Public Shared Credito As String = "02"
    Public Shared Contado As String = "01"
End Class

Public Class DatosCliente
    Public Shared FrecuenciaMensual As String = "1"
End Class

Public Class EstadoFactura
    Public Shared Entregado As String = "E"
    Public Shared Anulado As String = "A"
End Class

Public Class Lastro
    Public Shared Controla As String = "1"
    Public Shared NoControla As String = "0"
End Class

Public Class EstadosEntidad
    Public Shared Bloqueada As String = "1"
    Public Shared Normal As String = "0"
End Class

Public Class RespetaPrecio
    Public Shared Respeta As String = "1"
    Public Shared NoRespeta As String = "0"
End Class

Public Class RemisionValorizada
    Public Shared Incluye As String = "1"
    Public Shared Noincluye As String = "0"
End Class

Public Class Depositos
    Public Shared PagaDeposito As String = "1"
    Public Shared NoPagaDeposito As String = "0"
End Class

Public Class TipoDocumentos
    Public Shared Factura As String = "FAC"
    Public Shared Remision As String = "FCO"
End Class

Public Class Autorizaciones
    Public Shared Copago As String = "1"
    Public Shared Cuota As String = "2"
End Class

Public Enum Asignaciones
    NoRequiereAsignacion = 0
    RequiereAsignacion = 1
End Enum

Public Enum Fletes
    NoRequiereFlete = 0
    RequiereFlete = 1
End Enum

Public Enum Movimientos
    GeneraMovimiento = 0
    NoGeneraMovimiento = 1
End Enum

Public Enum ProcesosComunicacion
    EnvioCargueCamion = 11
End Enum

