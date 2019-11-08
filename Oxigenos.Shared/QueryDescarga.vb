Public Class QueryDescarga
    Public m_TableName As String
    Public m_Query As String

    Public Sub New(ByVal TableName As String, ByVal Query As String)
        m_TableName = TableName
        m_Query = Query
    End Sub

    Public ReadOnly Property TableName() As String
        Get
            Return m_TableName
        End Get
    End Property

    Public ReadOnly Property Query() As String
        Get
            Return m_Query
        End Get
    End Property

End Class

Public Class ListQuerysDescarga
    Inherits List(Of QueryDescarga)
    Public Overloads Sub Add(ByVal TableName As String, ByVal Query As String)
        Dim q As New QueryDescarga(TableName, Query)
        Me.Add(q)
    End Sub
End Class
