Public Class GestorGuia_Documento


    Public Function insertarGuiaDocumento(ByVal pguia As Integer, ByVal pprefijo As Integer, ByVal pdocumento As Integer, ByVal phora As Date, ByVal ptipodoc As String) As Boolean
        Dim sqlcmd As New SqlCeCommand
        Dim cantidad As Integer

        sqlcmd.CommandType = CommandType.Text
        sqlcmd.Connection = Me.Connection
        'Dim sqldr As SqlCeDataReader

        Try
            Me.dtaGuia_Documento.Connection = Me.Connection
            ''If Me.Connection.State <> ConnectionState.Open Then
            ''    Try
            ''        Me.Connection.Open()
            ''    Catch ex As Exception
            ''    End Try
            ''End If



            'sqlcmd.CommandText = "select count(*) cant from Guia_Documento where Num_Guia=" & pguia & " and " & _
            '"Prefijo_Documento=" & pprefijo & " and " & _
            '"Num_Documento= " & pdocumento & " and " & _
            '"Tipo_Documento ='" & ptipodoc & "'"
            'sqldr = sqlcmd.ExecuteReader
            'While (sqldr.Read)
            '    cantidad = CInt(sqldr("cant").ToString)
            'End While

            'sqldr.Close()

            cantidad = Me.dtaGuia_Documento.cantguia(pguia, pprefijo, pdocumento, ptipodoc).Value

            If cantidad < 1 Then

                Me.dtaGuia_Documento.Insert(pguia, pprefijo, pdocumento, "N", phora, ptipodoc)
                Me.dtaGuia_Documento.Update(Me.dsGuiaDocumento.Guia_Documento)
                Me.dsGuiaDocumento.AcceptChanges()
            End If
        Catch ex As Exception
            Return False
      

        End Try
        

        Return True
    End Function
End Class
