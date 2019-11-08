Module Globales
    Public HojasRuta As New GestorHojasRutas
    Public Productos As New GestorProductos
    Public Venta As New GestorVenta

    Public Function CStrDBNull(ByVal sValor As Object, Optional ByVal sValorDefecto As String = "") As String
        If sValor Is Nothing Then
            Return sValorDefecto
        ElseIf sValor.GetType Is Type.GetType("System.DBNull") Then
            If sValorDefecto <> "" Then
                Return sValorDefecto
            Else
                Return ""
            End If
        Else
            Return CStr(sValor)
        End If
    End Function

    Public Function CIntDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Integer = 0) As Integer
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CInt(iValor)
        End If
    End Function

    Public Function CDblDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Double = 0) As Double
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CDbl(iValor)
        End If
    End Function

    Public Function CShortDBNull(ByVal iValor As Object, Optional ByVal iValorDefecto As Short = 0) As Short
        If iValor Is Nothing Then
            Return iValorDefecto
        ElseIf iValor.GetType Is Type.GetType("System.DBNull") Then
            Return iValorDefecto
        Else
            Return CShort(iValor)
        End If
    End Function
End Module
