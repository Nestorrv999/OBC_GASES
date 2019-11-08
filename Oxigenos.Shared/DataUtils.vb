Imports System.Data
Imports System.Windows.Forms

Public Module DataUtils
    Public Function GetCurrentRow(ByVal BindingSource As BindingSource) As System.Data.DataRow
        Dim row As DataRow = Nothing
        If BindingSource.Position >= 0 Then
            row = CType(BindingSource.Current, DataRowView).Row
        End If
        Return row
    End Function

    Public Sub SetCurrentRow(ByVal bs As BindingSource, ByVal row As DataRow)
        Dim dv As DataView = CType(bs.List, DataView)
        bs.Sort = GetPrimaryKeyColumsString(row.Table)
        bs.Position = dv.Find(GetPrimaryKeyValues(row))
    End Sub

    Public Function GetPrimaryKeyValues(ByVal row As DataRow) As Object()
        Dim KeyFieldsCount As Integer = row.Table.PrimaryKey.Length - 1
        Dim KeyValues(KeyFieldsCount) As Object
        For I As Integer = 0 To KeyFieldsCount
            KeyValues(I) = row(row.Table.PrimaryKey(I).ColumnName)
        Next
        Return KeyValues
    End Function

    Private Function GetPrimaryKeyColumsString(ByVal Table As DataTable) As String
        Dim KeyFieldsCount As Integer = Table.PrimaryKey.Length - 1
        Dim sPrimaryKeyString As String = ""
        For I As Integer = 0 To KeyFieldsCount
            If I > 0 Then
                sPrimaryKeyString += ", "
            End If
            sPrimaryKeyString += Table.PrimaryKey(I).ColumnName
        Next
        Return sPrimaryKeyString
    End Function

    Public Function IsNullOrEmpty(ByVal FieldValue As Object) As Boolean
        Dim bResult As Boolean = True
        If FieldValue IsNot Nothing Then
            If FieldValue IsNot DBNull.Value Then
                If FieldValue.GetType() Is GetType(System.String) Then
                    If FieldValue.ToString().Trim() <> "" Then
                        bResult = False
                    End If
                Else
                    bResult = False
                End If
            End If
        End If
        Return bResult
    End Function

End Module
