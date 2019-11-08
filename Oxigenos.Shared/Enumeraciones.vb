' Modulos implementados en el nucleo y que pueden ser opcionalmente utilizados
' por el programa 
Public Enum ModulosNucleo
    Rutero = 1
    CargaDatos = 2
    DescargaDatos = 3
End Enum

' Tipos de modulos que pueden ser ejecutados desde el formulario principal
Public Enum TiposModulo
    Nucleo = 1
    Programa = 2
End Enum
Public Enum TipoReporte
    ControlEnvases = 1
    DocumentosGenerados = 2
    PedidosAnulados = 3
End Enum


Public Enum IconosModulos
    Camion = 0
    InicioRuta = 1
    FinRuta = 2
    Clientes = 3
    Consultas = 4
    Impresora = 5
    CargaDatos = 6
    DescargaDatos = 7
    Ayuda = 8
End Enum

Public Enum TiposDocumento As Short
    FacturaManual = 1
    RemisionManual = 2
    AsignacionManual = 3
    RecoleccionManual = 4
    FormatoUnico = 5
    DepositoManual = 6
    FacturaAutomatica = 7
    RemitoAutomatico = 8
    AsignacionAutomatica = 9
    RecoleccionAutomatico = 10
    DepositoAutomatico = 11
End Enum

Public Class TiposCliente
    Public Const Industrial As String = "1"
    Public Const Paciente As String = "2"
    Public Const Entidad As String = "3"
End Class

Public Class EstadosPedido
    Public Const Normal As String = "0"
    Public Const Anulado As String = "1"
    Public Const AnuladoEnTerminal As String = "2"
    Public Const Atendido As String = "3"
    Public Const Enviado As String = "4"
    Public Const Confirmadoanulado As String = "5"
    Public Const Reasignado As String = "6"
    Public Const AtendidoParcial As String = "7"


End Class

Public Class TiposPago
    Public Const Contado As String = "01"
    Public Const Credito As String = "02"
End Class

Public Enum PrinterModels
    SyscanZFP3Traction
    SyscanZFP3Friction
    ZebraPortatil
End Enum



