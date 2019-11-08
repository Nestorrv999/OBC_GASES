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
        Dim da As New ReportesDataSetTableAdapters.DocumentosGeneradosTableAdapter
        da.Connection = Me.Connection
        da.Fill(dt)
        Return dt
    End Function


End Class
