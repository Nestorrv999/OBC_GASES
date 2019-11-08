Imports System.Windows.Forms

Public Class InfoModulo
    Public Tipo As TiposModulo
    Public Nombre As String = ""
    Public IconIndex As Integer = -1
    Public Image As System.Drawing.Image
    Public ClassType As Type
    Public HotKey As Keys

End Class

Public Class ListInfoModulos
    Inherits List(Of InfoModulo)

    Public Sub AddModuloPrograma(ByVal Nombre As String, ByVal Icono As IconosModulos, ByVal FormClass As Type, ByVal HotKey As Keys)
        Dim modInfo As New InfoModulo
        modInfo.Tipo = TiposModulo.Programa
        modInfo.Nombre = Nombre
        modInfo.IconIndex = Icono
        modInfo.ClassType = FormClass
        modInfo.HotKey = HotKey
        Me.Add(modInfo)
    End Sub

    Public Sub AddModuloPrograma(ByVal Nombre As String, ByVal FormClass As Type, ByVal HotKey As Keys)
        Dim modInfo As New InfoModulo
        modInfo.Tipo = TiposModulo.Programa
        modInfo.Nombre = Nombre
        modInfo.IconIndex = -1
        modInfo.ClassType = FormClass
        modInfo.HotKey = HotKey
        Me.Add(modInfo)
    End Sub

    Public Sub AddModuloNucleo(ByVal Modulo As ModulosNucleo, ByVal Nombre As String, ByVal HotKey As Keys)
        Dim modInfo As InfoModulo
        modInfo = Nucleo.GetInfoModulo(Modulo)
        modInfo.Tipo = TiposModulo.Nucleo
        modInfo.Nombre = Nombre
        modInfo.HotKey = HotKey
        Me.Add(modInfo)
    End Sub
End Class
