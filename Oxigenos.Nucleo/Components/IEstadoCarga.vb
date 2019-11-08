Imports System.Data

' Interfaz que permite mostrar al usuario el estado de un proceso
' de comunicaciones. La clase que implemente esta interfaz debe
' Proporcionar formas visuales de mostrar los camibos en las
' propiedades o mostrar la información de nuevas actividades 
' La clase también debe implementar la propiedades que dan
' información sobre el programa y correria sobre los cuales
' aplica el proceso de comunicaciones.
Public Interface IEstadoCarga
    ' Propiedad que determina si el usuario decidio cancelar el proceso
    ReadOnly Property Cancelado() As Boolean

    ' Progeso actividad actual en porcentaje
    WriteOnly Property ProgresoTabla() As Integer

    ' Progreso total
    WriteOnly Property ProgresoTotal() As Integer

    ' Indica el inicio de proceso de una nueva tabla
    Sub IniciarTabla(ByVal sNombreTabla As String)

End Interface
