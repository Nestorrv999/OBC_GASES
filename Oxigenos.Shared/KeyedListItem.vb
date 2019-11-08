Public Class KeyedListItem
    Public m_KeyValue As String
    Public m_DisplayValue As String

    Public Sub New(ByVal KeyValue As String, ByVal DisplayValue As String)
        m_KeyValue = KeyValue
        m_DisplayValue = DisplayValue
    End Sub

    Public ReadOnly Property KeyValue() As String
        Get
            Return m_KeyValue
        End Get
    End Property

    Public ReadOnly Property DisplayValue() As String
        Get
            Return m_DisplayValue
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return DisplayValue
    End Function

    Public Shared Function NewItem(ByVal KeyValue As String, ByVal DisplayValue As String) As KeyedListItem
        Dim klItem As New KeyedListItem(KeyValue, DisplayValue)
        Return klItem
    End Function

    Public Shared Function GetKeyValue(ByVal Item As Object) As String
        Dim klItem As KeyedListItem = DirectCast(Item, KeyedListItem)
        Return klItem.KeyValue
    End Function

End Class
