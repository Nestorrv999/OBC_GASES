Imports System.Data
Public Class VentaForm
    Implements IModuloPedido

    Private m_rowCliente As Data.DataRow
    Private m_rowPedido As Data.DataRow
    Private m_Venta As GestorVenta

    Public Sub Run(ByVal rowCliente As System.Data.DataRow, ByVal rowPedido As System.Data.DataRow) Implements Common.IModuloPedido.Run
        UIHandler.StartWait()
        Me.m_rowPedido = rowPedido
        Me.m_rowCliente = rowCliente
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Private Sub VentaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                menuCancelar_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.N Then
                menuNuevaEntrega_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub VentaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadData()
        UIHandler.EndWait()
    End Sub

    Private Sub menuTerminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuTerminar.Click
        If dsVenta.DetallePedido.Count > 0 Then
            If GeneracionForm.Run(m_rowCliente, m_rowPedido) Then
                UIHandler.StartWait()
                m_rowPedido("Estado") = EstadosPedido.Atendido
                m_rowPedido("FechaAtencion") = Today()
                m_rowPedido("HoraAtencion") = Now.ToString("HH:mm")
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Else
            UIHandler.StartWait()
            DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub menuNuevaEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuNuevaEntrega.Click
        pnlVenta.Visible = True
        pnlVenta.BringToFront()
        Me.Menu = New MainMenu()
        cbTanque.Focus()
    End Sub

    Private Sub LoadData()
        Venta.dsVenta = Me.dsVenta
        Venta.LoadTanquesCliente(m_rowCliente)
    End Sub

    Private Sub btnContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinuar.Click
        If cbTanque.SelectedIndex >= 0 Then
            Dim rowTanque As VentaDataSet.TanquesClienteRow
            rowTanque = CType(GetCurrentRow(bsTanquesCliente), VentaDataSet.TanquesClienteRow)
            pnlVenta.Visible = False
            Me.Menu = mainMenu1
            If rbtnNiveles.Checked Then
                VentaPorNivelesForm.Run(m_rowCliente, m_rowPedido, rowTanque)
            ElseIf rbtnPorCaudalimetro.Checked Then
                VentaPorCaudalimetroForm.Run(m_rowCliente, m_rowPedido, rowTanque)
            ElseIf rbtnPorPesoCamion.Checked Then
                VentaPorPesadaCamionForm.Run(m_rowCliente, m_rowPedido, rowTanque)
            ElseIf rbtnPorPesoTanque.Checked Then
                VentaPorPesadaTanqueForm.Run(m_rowCliente, m_rowPedido, rowTanque)
            End If
        Else
            UIHandler.ShowError("Debe seleccionar un tanque")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        pnlVenta.Visible = False
    End Sub

    Private Sub menuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCancelar.Click
        If dsVenta.DetallePedido.Count > 0 Then
            If Not UIHandler.Confirm("La información capturada se perdera. Esta seguro?", "¿Cancelar?") Then
                Exit Sub
            End If
        End If
        UIHandler.StartWait()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub
End Class