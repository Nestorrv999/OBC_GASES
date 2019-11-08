Imports OpenNETCF.Net

Public Class GPRS

    Private Shared m_cm As ConnectionManager

    Public Shared Function Conectar() As Boolean
        Dim diList As OpenNETCF.Net.DestinationInfoCollection
        m_cm = New ConnectionManager
        Dim di As DestinationInfo
        Try
            diList = m_cm.EnumDestinations()
            For Each di In diList
                If di.Description = Settings.ConexionGPRS Then
                    m_cm.Connect(di.Guid, False, ConnectionMode.Synchronous)
                    Return True
                End If
            Next
            UIHandler.ShowError("La conexión a GPRS, no esta configurada")
        Catch ex As Exception
            UIHandler.ShowError(ex.Message, "Error estableciendo conexión")
            Desconectar()
            Return False
        End Try
    End Function

    Public Shared Sub Desconectar()
        If m_cm IsNot Nothing AndAlso m_cm.Status = ConnectionStatus.Connected Then
            m_cm.RequestDisconnect()
            m_cm = Nothing
        End If
    End Sub
End Class
