Public Class PrecintosForm

    Private m_sCodPedido As String
    Private m_sCodTanque As String
    
    Public Shared Sub Run(ByVal CodPedido As String, ByVal CodTanque As String)
        UIHandler.StartWait()
        Dim frm As New PrecintosForm
        frm.m_sCodPedido = CodPedido
        frm.m_sCodTanque = CodTanque
        UIHandler.ShowDialog(frm)
        frm.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub PrecintosForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                btnCancelar_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub PrecintosForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        Venta.dsVenta.Precintos.Rows.Clear()
        txtPrecintoExist1.Focus()
        MostrarPrecintos()
        UIHandler.EndWait()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click, menuGuardar.Click
        UIHandler.StartWait()
        GuardarPrecintos()
        DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub GuardarPrecintos()
        Dim I As Integer

        Dim ctlsExistentes() As TextInputBox = {txtPrecintoExist1, txtPrecintoExist2, _
        txtPrecintoExist3, txtPrecintoExist4}
        Dim ctlsColocados() As TextInputBox = {txtPrecintoCol1, txtPrecintoCol2, _
            txtPrecintoCol3, txtPrecintoCol4}


        ' Se borran los precintos almacenados en memoria
        Dim rows() As Data.DataRow
        rows = Venta.dsVenta.Precintos.Select("CodTanque = '" & m_sCodTanque & "'")
        For I = 0 To rows.Length - 1
            Venta.dsVenta.Precintos.Rows.Remove(rows(I))
        Next

        ' Se insertan los registros de los nuevos precintos capturados
        For I = 0 To ctlsColocados.Length - 1
            If ctlsColocados(I).Text.Trim() <> "" Then
                Venta.dsVenta.Precintos.AddPrecintosRow(m_sCodPedido, _
                    m_sCodTanque, ctlsColocados(I).Text, TiposPrecinto.Coladado)
            End If
            If ctlsExistentes(I).Text.Trim() <> "" Then
                Venta.dsVenta.Precintos.AddPrecintosRow(m_sCodPedido, _
                    m_sCodTanque, ctlsExistentes(I).Text, TiposPrecinto.Existente)
            End If
        Next

    End Sub

    Private Sub MostrarPrecintos()
        Dim rows() As Data.DataRow
        Dim rowPrecinto As VentaDataSet.PrecintosRow
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim ctlsExistentes() As TextInputBox = {txtPrecintoExist1, txtPrecintoExist2, _
              txtPrecintoExist3, txtPrecintoExist4}
        Dim ctlsColocados() As TextInputBox = {txtPrecintoCol1, txtPrecintoCol2, _
            txtPrecintoCol3, txtPrecintoCol4}

        rows = Venta.dsVenta.Precintos.Select("CodTanque = '" & m_sCodTanque & "'")
        For Each row As Data.DataRow In rows
            rowPrecinto = DirectCast(row, VentaDataSet.PrecintosRow)
            If rowPrecinto.Tipo = TiposPrecinto.Coladado Then
                ctlsColocados(I).Text = rowPrecinto.Precinto
            Else
                ctlsExistentes(I).Text = rowPrecinto.Precinto
            End If
        Next
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, menuCancelar.Click
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class