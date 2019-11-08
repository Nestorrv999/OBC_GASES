Public Class InicioRutaForm
    Implements IModuloPrograma

    Private m_rowHojaRuta As HojasRutaDataSet.HojasRutaRow
    Private m_bUpdateNumeroMovimiento As Boolean = False

    Private Sub InicioRutaForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Not Nucleo.ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then
                menuCancelar_Click(Me, Nothing)
                If e.KeyCode = Keys.Enter And e.Shift Then
                    menuGuardar_Click(Me, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub InicioRutaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UiHandler1.Parent = Me
        LoadData()
        cbProducto.Focus()
        UIHandler.EndWait()
    End Sub

    Public Sub Run() Implements Common.IModuloPrograma.Run
        HojasRuta.LoadHojaRutaActual()
        If HojasRuta.dsHojasRuta.HojasRuta.Count > 0 Then
            If HojasRuta.dsHojasRuta.HojasRuta(0).Estado = EstadosHojaRuta.Iniciada Then
                UIHandler.ShowError("La hoja de ruta ya fue iniciada, ya no se puede modificar!")
                Exit Sub
            End If
        End If
        UIHandler.StartWait()
        UIHandler.ShowDialog(Me)
        Me.Dispose()
        UIHandler.EndWait()
    End Sub

    Public Sub LoadData()
        dsHojasRuta = HojasRuta.dsHojasRuta
        dsProductos = Productos.dsProductos
        bsChoferes.DataSource = dsHojasRuta
        bsHojasRuta.DataSource = dsHojasRuta
        bsLugaresCarga.DataSource = dsHojasRuta
        bsProductos.DataSource = dsProductos
        bsTanqueros.DataSource = dsHojasRuta
        bsTractores.DataSource = dsHojasRuta
        Productos.LoadProductos()
        HojasRuta.LoadChoferes()
        HojasRuta.LoadLugaresCarga()
        HojasRuta.LoadTractores()
        If bsHojasRuta.Count = 0 Then
            bsHojasRuta.AddNew()
            m_rowHojaRuta = CType(GetCurrentRow(bsHojasRuta), HojasRutaDataSet.HojasRutaRow)
            m_rowHojaRuta.IdHojaRuta = CInt(Nucleo.NumeroMovimiento)
            m_rowHojaRuta.LLegadaInicioRuta = Now()
            m_rowHojaRuta.SalidaInicioRuta = Now()
            m_bUpdateNumeroMovimiento = True
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

    Private Sub menuGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuGuardar.Click
        Try
            UIHandler.StartWait()
            bsHojasRuta.EndEdit()
            m_rowHojaRuta.Estado = EstadosHojaRuta.Creada
            HojasRuta.UpdateHojaRuta(m_rowHojaRuta)
            If Not IsNullOrEmpty(m_rowHojaRuta("KilometrajeIniicial")) Then
                Nucleo.KilometrajeInicial = m_rowHojaRuta.KilometrajeIniicial
            End If
            If Not IsNullOrEmpty(m_rowHojaRuta("KilometrajeFinal")) Then
                Nucleo.KiloMetrajeFinal = m_rowHojaRuta.KilometrajeFinal
            End If
            If m_bUpdateNumeroMovimiento Then
                Nucleo.NumeroMovimiento = CStr(CInt(Nucleo.NumeroMovimiento) + 1)
            End If
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            UIHandler.EndWait()
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub menuIniciarRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuIniciarRuta.Click
        Try
            UIHandler.StartWait()
            bsHojasRuta.EndEdit()
            If IsNullOrEmpty(m_rowHojaRuta("Cabezote")) Then
                Throw New Exception("Debe especificar la placa del Cabezote")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("Tanquero")) Then
                Throw New Exception("Debe especificar la placa del Tanquero")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("CodConductor")) Then
                Throw New Exception("Debe seleccionar un conductor")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("CodLugarCargue")) Then
                Throw New Exception("Debe seleccionar el lugar de cargue")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("CodProducto")) Then
                Throw New Exception("Debe seleccionar el producto")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("PesoInicial")) Then
                Throw New Exception("Debe especificar el peso inicial")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("PesoFinal")) Then
                Throw New Exception("Debe especificar el peso final")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("KilometrajeIniicial")) Then
                Throw New Exception("Debe espececificar el Kilomentra Inicial")
            End If
            If IsNullOrEmpty(m_rowHojaRuta("NumRemision")) Then
                Throw New Exception("Debe especificar el número de la remisión del lugar de cargue")
            End If
            m_rowHojaRuta.Estado = EstadosHojaRuta.Iniciada
            Try
                ' Se guarda la hoja de ruta
                HojasRuta.OpenConnection()
                HojasRuta.UpdateHojaRuta(m_rowHojaRuta)

                ' Se calcula la existencia inicial y se almacena en el kardex
                Dim nExistencias As Decimal = m_rowHojaRuta.PesoFinal - m_rowHojaRuta.PesoInicial
                Dim rowProducto As ProductosDataSet.ProductosRow
                rowProducto = dsProductos.Productos.FindByCodigo(m_rowHojaRuta.CodProducto)
                If rowProducto.UnidadMedidaVenta = UnidadesMedida.Kilogramos Then
                    nExistencias = CDec(nExistencias * rowProducto.CoeficienteProducto)
                End If
                Productos.InitKardex(m_rowHojaRuta.IdHojaRuta, m_rowHojaRuta.CodProducto, nExistencias)

                ' Se guardan los datos adicionales
                Dim rowConductor As HojasRutaDataSet.ChoferesRow
                rowConductor = CType(GetCurrentRow(bsChoferes), HojasRutaDataSet.ChoferesRow)
                Nucleo.RowParametros("CodigoChofer") = m_rowHojaRuta.CodConductor
                Nucleo.RowParametros("NombreChofer") = rowConductor.Nombre
                Nucleo.KilometrajeInicial = m_rowHojaRuta.KilometrajeIniicial
                Nucleo.KiloMetrajeFinal = m_rowHojaRuta.KilometrajeIniicial
                If m_bUpdateNumeroMovimiento Then
                    Nucleo.NumeroMovimiento = CStr(CInt(Nucleo.NumeroMovimiento) + 1)
                End If
            Finally
                HojasRuta.CloseConnection()
            End Try
            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            UIHandler.EndWait()
            UIHandler.ShowError(ex.Message)
        End Try
    End Sub

    Private Sub cbProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProducto.SelectedValueChanged
        UIHandler.StartWait()
        If cbProducto.SelectedIndex >= 0 Then
            HojasRuta.LoadTanqueros(CStr(cbProducto.SelectedValue))
        Else
            bsTanqueros.SuspendBinding()
            dsHojasRuta.Tanqueros.Rows.Clear()
            bsTanqueros.ResumeBinding()
        End If
        UIHandler.EndWait()
    End Sub
End Class