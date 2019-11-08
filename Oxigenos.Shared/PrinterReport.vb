Public Class PrinterReport
    Public Enum TipoAlineacion
        Izquierda
        Derecha
    End Enum

    Public Class ColumnInfo
        Public FieldName As String
        Public Caption As String
        Public MaxLength As Integer
        Public Formato As String
        Public Total As String
        Public Alineacion As TipoAlineacion
    End Class

    Public Titulo As String
    Public dtReporte As Data.DataTable
    Public Columnas As New Dictionary(Of String, ColumnInfo)

    Private Sub InitColumInfo()
        Columnas.Clear()
        If dtReporte IsNot Nothing Then
            Dim infoColum As ColumnInfo
            For Each column As DataColumn In dtReporte.Columns
                infoColum = New ColumnInfo
                infoColum.Caption = column.Caption
                infoColum.FieldName = column.ColumnName
                If column.DataType Is GetType(System.Int16) OrElse _
                      column.DataType Is GetType(System.Int32) OrElse _
                      column.DataType Is GetType(System.Int64) Then
                    infoColum.Formato = "#,##0"
                    infoColum.Alineacion = TipoAlineacion.Derecha
                    infoColum.MaxLength = 10
                ElseIf column.DataType Is GetType(System.Double) OrElse _
                      column.DataType Is GetType(System.Single) OrElse _
                      column.DataType Is GetType(System.Decimal) Then
                    infoColum.Formato = "#,##0.00"
                    infoColum.Alineacion = TipoAlineacion.Derecha
                    infoColum.MaxLength = 15
                ElseIf column.DataType Is GetType(System.DateTime) Then
                    infoColum.Alineacion = TipoAlineacion.Izquierda
                    infoColum.MaxLength = 10
                    infoColum.Formato = "dd/MM/yyyy"
                ElseIf column.DataType Is GetType(System.String) Then
                    infoColum.Alineacion = TipoAlineacion.Izquierda
                    infoColum.MaxLength = column.MaxLength
                    infoColum.Formato = ""
                End If
                Columnas.Add(column.ColumnName, infoColum)
            Next
        End If
    End Sub

    Public Sub New(ByVal Titulo As String, ByVal dt As DataTable)
        Me.Titulo = Titulo
        Me.dtReporte = dt
        InitColumInfo()
    End Sub
    


End Class


