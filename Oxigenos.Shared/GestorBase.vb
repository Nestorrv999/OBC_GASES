Imports System.Data.SqlServerCe
Imports DatascanCF.Data.SqlServerCe

Public Class GestorBase

    ' Private Shared m_Helper As SqlCeHelper
    Private Shared m_Connection As System.Data.SqlServerCe.SqlCeConnection
    Private Shared m_nOpenCount As Integer = 0
    Private Shared m_DatabaseFile As String = String.Empty
    Private Shared m_Transaccion As System.Data.SqlServerCe.SqlCeTransaction
    
    Protected ReadOnly Property Connection() As SqlCeConnection
        Get
            If m_Connection Is Nothing Then
                m_Connection = New SqlCeConnection("Data source = '" & m_DatabaseFile & "'")
            End If
            Return m_Connection
        End Get
    End Property

    Protected ReadOnly Property Transaccion() As SqlCeTransaction
        Get
            Return m_Transaccion
        End Get
    End Property

    'Protected ReadOnly Property Helper() As SqlCeHelper
    '    Get
    '        If m_Helper Is Nothing Then
    '            m_Helper = New SqlCeHelper(Connection)
    '        End If
    '        Return m_Helper
    '    End Get
    'End Property

    Friend Shared Sub SetDatabaseFile(ByVal sDatabaseFile As String)
        m_DatabaseFile = sDatabaseFile
    End Sub

    Public Sub OpenConnection()
        If m_nOpenCount = 0 Then
            Connection.Open()
        End If
        m_nOpenCount += 1
    End Sub

    Public Sub CloseConnection()
        m_nOpenCount -= 1
        If m_nOpenCount = 0 Then
            Connection.Close()
        End If
    End Sub

    Public Sub RealizarCommit()
        If Not Transaccion Is Nothing Then
            Transaccion.Commit()
            m_Transaccion = Nothing
        End If
    End Sub

    Public Sub RealizarRollback()
        Transaccion.Rollback()
        m_Transaccion = Nothing
    End Sub
    Public Sub CrearTransaccion()
        m_Transaccion = Connection.BeginTransaction
    End Sub

End Class
