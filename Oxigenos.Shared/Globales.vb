Imports OpenNETCF.Win32

Public Module Globales
    Public Nucleo As INucleo
    Public Programa As ProgramaBase

    Public Sub IncrementarNumeroDocumento(ByVal rowDocumento As DataRow)
        Dim sNumDocumento As String = CStr(rowDocumento("Actual"))
        Dim sFormato As String = New String("0"c, sNumDocumento.Length)
        rowDocumento("Actual") = (CInt(sNumDocumento) + 1).ToString(sFormato)
    End Sub
    Public Sub DecrementarNumeroDocumento(ByVal rowDocumento As DataRow)
        Dim sNumDocumento As String = CStr(rowDocumento("Actual"))
        Dim sFormato As String = New String("0"c, sNumDocumento.Length)
        rowDocumento("Actual") = (CInt(sNumDocumento) - 1).ToString(sFormato)
    End Sub
End Module
