Public Class FinRutaForm
    Implements IModuloPrograma

    Private m_rowHojaRuta As HojasRutaDataSet.HojasRutaRow

    Private Sub InicioRutaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                menuCancelar_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.Enter And e.Shift Then
                menuCerrarRuta_Click(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub InicioRutaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadData()
        cbLugarDescarga.Focus()
        UIHandler.EndWait()
    End Sub

    Public Sub Run() Implements Common.IModuloPrograma.Run
        HojasRuta.LoadHojaRutaActual()
        If HojasRuta.dsHojasRuta.HojasRuta.Count > 0 Then
            If HojasRuta.dsHojasRuta.HojasRuta(0).Estado <> EstadosHojaRuta.Iniciada Then
                UIHandler.ShowError("La hoja de ruta no ha sido iniciada, no se puede realizar el cierre!")
                Exit Sub
            End If
        Else
            UIHandler.ShowError("La hoja de ruta no ha sido iniciada, no se puede realizar el cierre!")
            Exit Sub
        End If
        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Public Sub LoadData()
        dsHojasRuta = HojasRuta.dsHojasRuta
        bsHojasRuta.DataSource = dsHojasRuta
        bsLugaresCarga.DataSource = dsHojasRuta
        HojasRuta.LoadLugaresCarga()
        If bsHojasRuta.Count = 0 Then
            bsHojasRuta.AddNew()
            m_rowHojaRuta = CType(GetCurrentRow(bsHojasRuta), HojasRutaDataSet.HojasRutaRow)
            m_rowHojaRuta.IdHojaRuta = CInt(Nucleo.NumeroMovimiento)
            m_rowHojaRuta.LLegadaInicioRuta = Now()
            m_rowHojaRuta.SalidaInicioRuta = Now()
        Else
            bsHojasRuta.MoveFirst()
            m_rowHojaRuta = CType(GetCurrentRow(bsHojasRuta), HojasRutaDataSet.HojasRutaRow)
        End If

    End Sub

    Private Sub menuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuCancelar.Click
        UIHandler.StartWait()
        bsHojasRuta.CancelEdit()
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub menuCerrarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGuardar.Click
        Try
            UIHandler.StartWait()
            bsHojasRuta.EndEdit()
            If IsNullOrEmpty(m_rowHojaRuta("CodLugarDescargue")) Then
                Throw New Exception("Debe seleccionar el lugar de cargue")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("PesoCierre")) Then
                Throw New Exception("Debe especificar el peso de cierre de la ruta")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("KilometrajeFinal")) Then
                Throw New Exception("Debe espececificar el Kilometraje Final")
            End If
            If CInt(m_rowHojaRuta.KilometrajeFinal) <= CInt(Nucleo.KiloMetrajeFinal) Then
                Throw New Exception("El kilometraje final debe ser mayor al último kilometraje registrado")
            End If
            If m_rowHojaRuta.PesoCierre > m_rowHojaRuta.PesoFinal Then
                Throw New Exception("El peso de cierre no puede ser mayor al peso final del inicio de la ruta")
            End If
            m_rowHojaRuta.FechaCierre = Now()
            m_rowHojaRuta.Estado = EstadosHojaRuta.Cerrada
            HojasRuta.UpdateHojaRuta(m_rowHojaRuta)
            Nucleo.KilometrajeInicial = m_rowHojaRuta.KilometrajeIniicial
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            UIHandler.EndWait()
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

End Class