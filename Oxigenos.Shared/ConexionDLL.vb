Option Explicit On
Imports System.Data.SqlServerCe

Public Class ConexionDLL
    Public sNomApp As String = String.Empty
    Dim cn As New SqlCeConnection, cmd As New SqlCeCommand

    Private Function Conectar() As Boolean
        desconectar()
        Try
            cn.ConnectionString = "Data source = \Oxigenos.SDF"
            cn.Open()
            cmd.Connection = cn
            Return True
        Catch ex As SqlCeException
            Return False
        End Try
    End Function

    Private Sub desconectar()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()                
            End If
        Catch

        End Try
    End Sub

    Public Function SqlCommand(ByVal sSql As String) As Boolean
        If Conectar() Then
            Try
                cmd.CommandType = CommandType.Text
                cmd.CommandText = sSql
                cmd.ExecuteNonQuery()
                desconectar()
                Return True
            Catch ex As Exception
                desconectar()
                Return False
            End Try
        End If
    End Function

    Public Function SqlQuery(ByVal sSql As String) As DataTable
        Dim dt As New DataTable, dr As SqlCeDataReader
        Conectar()

        cmd.CommandType = CommandType.Text
        cmd.CommandText = sSql
        Try
            dr = cmd.ExecuteReader
            dt.Load(dr)
            Return dt
            desconectar()
        Catch ex As SqlCeException
            dr = Nothing
            Return Nothing            
        End Try
    End Function
End Class