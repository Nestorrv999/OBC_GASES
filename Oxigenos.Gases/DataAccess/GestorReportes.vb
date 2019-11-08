Public Class GestorReportes

    Public Function GetPedidosAnulados() As DataTable
        Dim dt As New ReportesDataSet.PedidosAnuladosDataTable
        Dim da As New ReportesDataSetTableAdapters.PedidosAnuladosTableAdapter
        da.Connection = Me.Connection
        da.Fill(dt)
        Return dt
    End Function

    Public Function GetDocumentosGenerados() As DataTable
        Dim dt As New ReportesDataSet.DocumentosGeneradosDataTable
        Dim da As New ReportesDatasetTableAdapters.DocumentosGeneradosTableAdapter
        da.Connection = Me.Connection
        da.Fill(dt)
        Return dt
    End Function

    Public Function GetControlEnvases() As DataTable
        Dim dt As New ReportesDataset.ControlEnvasesDataTable
        Dim da As New ReportesDatasetTableAdapters.ControlEnvasesTableAdapter
        da.Connection = Me.Connection
        da.DeleteAll()
        da.InsertData()
        da.Fill(dt)
        Return dt
    End Function
    Public Function EntidadSubdivision(ByVal Cliente As String, ByVal Entidad As String) As DataRow
        Try
            Dim dt As New ReportesDataset.EntidadSubDivisionDataTable
            Dim da As New ReportesDatasetTableAdapters.EntidadSubDivisionTableAdapter
            da.Connection = Me.Connection
            da.Fill(dt, Cliente, Entidad)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


End Class
