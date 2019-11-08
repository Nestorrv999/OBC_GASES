Public Enum Programas
    Gases = 0
    Liquidos = 1
End Enum

Public Enum PrinterPortTypes
    Estandar = 0
    Bluetooth = 1
End Enum

Public Enum DeviceModels
    MC9090 = 0
    PPT8800 = 1
End Enum

Public Enum PrinterModels
    SyscanZFP3Traction
    SyscanZFP3Friction
    ZebraPortatil
End Enum

Public Class VistasRutero
    Public Const Clientes As String = "CLIENTES"
    Public Const Pedidos As String = "PEDIDOS"
End Class

Public Class ModuloMenuItem
    Inherits MenuItem
    Public InfoModulo As InfoModulo
End Class

Public Enum ProcesosComunicacion
    CargaCompleta = 1
    DescargaCompleta = 2
    CargaNovedades = 3
    DescargaNovedades = 5
    CargueCamion = 11
End Enum

