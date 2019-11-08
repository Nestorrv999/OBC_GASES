Imports System.Text
Imports System.Data
Imports System.IO
Imports System.Data.SqlServerCe

Public Class TextSerializer

    Public Shared Function Serialize(ByVal ds As DataSet) As String
        Dim sb As New StringBuilder
        Dim dt As DataTable
        Dim I, nTableCount, nTotalRowsCount As Integer

        For I = 0 To ds.Tables.Count - 1
            If ds.Tables(I).Rows.Count > 0 Then
                nTableCount += 1
                nTotalRowsCount += ds.Tables(I).Rows.Count
            End If
        Next

        sb.Append("TABLECOUNT: " & nTableCount.ToString() & vbCrLf)
        sb.Append("TOTALROWCOUNT: " & nTotalRowsCount.ToString() & vbCrLf)

        For I = 0 To ds.Tables.Count - 1
            dt = ds.Tables(I)
            If dt.Rows.Count > 0 Then
                sb.Append("TABLE: " & dt.TableName & vbCrLf)
                sb.Append("ROWCOUNT: " & dt.Rows.Count.ToString() & vbCrLf)

                ' Se agrega una primer linea con los nombres de los campos
                For Each col As DataColumn In dt.Columns
                    sb.Append(col.ColumnName & "|")
                Next
                sb.Append(vbCrLf)

                ' Se agrega una segunda linea con los tipos de datos
                For Each col As DataColumn In dt.Columns
                    sb.Append(col.DataType.ToString() & "|")
                Next
                sb.Append(vbCrLf)

                ' Se agregan lineas con los datos de todos los registros
                For Each row As DataRow In dt.Rows
                    For J As Integer = 0 To dt.Columns.Count - 1
                        If row.IsNull(J) Then
                            sb.Append("(null)|")
                        Else
                            If dt.Columns(J).DataType Is GetType(System.DateTime) Then
                                sb.Append(CDate(row(J)).ToString("yyyy/MM/dd HH:mm:ss") & "|")
                            Else
                                sb.Append(CStr(row(J)) & "|")
                            End If
                        End If
                    Next
                    sb.Append(vbCrLf)
                Next
                sb.Append(vbCrLf) ' Se agrega una linea adicional para delimitar los datos de la tabla
            End If
        Next
        Return sb.ToString()
    End Function


    Public Shared Function Serialize(ByVal rows() As DataRow, ByVal sFieldNames As String, ByVal sTableName As String) As String
        Dim sb As New StringBuilder
        Dim dt As DataTable
        Dim I, J As Integer
        Dim FieldNames() As String

        sb.Append("TABLECOUNT: 1" & vbCrLf)
        sb.Append("TOTALROWCOUNT: " & rows.Length.ToString() & vbCrLf)
        FieldNames = sFieldNames.Split("|,;".ToCharArray())
        If rows.Length > 0 Then
            dt = rows(0).Table
            sb.Append("TABLE: " & sTableName & vbCrLf)
            sb.Append("ROWCOUNT: " & rows.Length.ToString() & vbCrLf)

            ' Se agrega una primer linea con los nombres de los campos
            ' Se agrega una segunda linea con los tipos de datos
            For J = 0 To FieldNames.Length - 1
                sb.Append(FieldNames(J).ToUpper() & "|")
            Next
            sb.Append(vbCrLf)

            ' Se agrega una segunda linea con los tipos de datos
            For J = 0 To FieldNames.Length - 1
                sb.Append(rows(0).Table.Columns(FieldNames(J)).DataType.ToString() & "|")
            Next
            sb.Append(vbCrLf)

            ' Se agregan lineas con los datos de todos los registros
            For I = 0 To rows.Length - 1
                For J = 0 To FieldNames.Length - 1
                    If rows(I).IsNull(FieldNames(J)) Then
                        sb.Append("(null)|")
                    Else
                        If dt.Columns(FieldNames(J)).DataType Is GetType(System.DateTime) Then
                            sb.Append(CDate(rows(I)(FieldNames(J))).ToString("yyyy/MM/dd HH:mm:ss") & "|")
                        Else
                            sb.Append(CStr(rows(I)(FieldNames(J))) & "|")
                        End If
                    End If
                Next
                sb.Append(vbCrLf)
            Next
            sb.Append(vbCrLf) ' Se agrega una linea adicional para delimitar los datos de la tabla
        End If
        Return sb.ToString()
    End Function

    Public Shared Function GetDataSet(ByVal sSerializedData As String) As DataSet
        Dim sr As New StringReader(sSerializedData)
        Dim sLine As String
        Dim sFields(), sFieldsTypes(), sValues() As String
        Dim sTableName As String
        Dim nTableCount, nTotalRowCount, nRowCount As Integer

        Dim ds As New DataSet
        Dim row As DataRow
        Dim I As Integer
        Try
            ' Se lee la liena con el número de tablas serializadas
            sLine = sr.ReadLine()
            nTableCount = CInt(sLine.Substring(12))
            sLine = sr.ReadLine()
            nTotalRowCount = CInt(sLine.Substring(15))

            Do
                ' Se obtiene el nombre de cada tabla serializada y el número de registros de cada una
                sLine = sr.ReadLine()
                If sLine Is Nothing Then
                    Exit Do
                End If
                sTableName = sLine.Substring(7)
                sLine = sr.ReadLine()
                nRowCount = CInt(sLine.Substring(10))

                Dim dt As New DataTable
                dt.TableName = sTableName

                ' se obtienen los nombres de los campos
                sLine = sr.ReadLine()
                sFields = sLine.Split("|"c)

                ' se obtienen los tipos de datos
                sLine = sr.ReadLine()
                sFieldsTypes = sLine.Split("|"c)

                ' Se configuran los campos del datatable
                For I = 0 To UBound(sFields) - 1
                    dt.Columns.Add(sFields(I), Type.GetType(sFieldsTypes(I)))
                Next

                ' Se obtienen las datos de las filas y se agregan
                sLine = sr.ReadLine()
                While Not sLine Is Nothing
                    If sLine.Trim() = String.Empty Then
                        Exit While
                    End If
                    sValues = sLine.Split("|"c)
                    row = dt.NewRow()
                    For I = 0 To UBound(sFields) - 1
                        If sValues(I) <> "(null)" Then
                            If sFieldsTypes(I) = "System.DateTime" Then
                                row(sFields(I)) = DateTime.ParseExact(sValues(I), "yyyy/MM/dd HH:mm:ss", Nothing)
                            Else
                                row(sFields(I)) = sValues(I)
                            End If
                        End If
                    Next
                    dt.Rows.Add(row)
                    sLine = sr.ReadLine()
                End While
                dt.AcceptChanges()
                ds.Tables.Add(dt)
            Loop
        Finally
            sr.Close()
        End Try
        Return ds
    End Function

    
End Class
