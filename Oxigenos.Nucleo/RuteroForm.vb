Imports Oxigenos.Common
Imports System.Data.SqlServerCe
Imports OpenNETCF.Threading

Public Class RuteroForm
    Implements IModuloNucleo
    Private m_sVistaActual As String = VistasRutero.Clientes
    Private m_InitDataThread As Thread2
    Private m_bProcesarNovedadesPendiente As Boolean = False
    Private m_dtUltimoProcesoNovedades As DateTime

    Public Sub Run() Implements Common.IModuloNucleo.Run
        Dim sMensaje As String = ""
        If Programa.ValidarInicioRutero(sMensaje) Then
            UIHandler.StartWait()
            UIHandler.ShowDialog(Me)
            UIHandler.EndWait()
            Me.Dispose()
        Else
            UIHandler.ShowError(sMensaje)
        End If
    End Sub

    Private Sub RuteroForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If m_bProcesarNovedadesPendiente Then
            m_bProcesarNovedadesPendiente = False
            ProcesarNovedades()
        End If
    End Sub

    Private Sub RuteroForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Se configuran los controles
        Me.SuspendLayout()
        UiHandler1.Parent = Me
        m_sVistaActual = GestorNucleo.dsNucleo.Parametros(0).VistaRutero.ToUpper()
        If Not Programa.UseQueryFilterInRutero Then
            dsNucleo = GestorNucleo.dsNucleo
            m_dtUltimoProcesoNovedades = Now()
            If dsNucleo.Parametros(0).IntervaloNovedades > 0 Then
                timerNovedades.Enabled = True
            Else
                timerNovedades.Enabled = False
            End If
            bsClientes.DataSource = dsNucleo
            bsPedidos.DataSource = dsNucleo
            MostrarVistaRutero()
            ConfigurarMenusModulos()
        Else
            Me.Menu = New MainMenu
            pnlVistaClientes.Visible = False
            pnlVistaPedidos.Visible = False
            LoadDataRutero()
        End If
        Me.ResumeLayout()
        UIHandler.EndWait()

    End Sub

    Private m_InitAppThread As Thread2
    Private m_bInitApplication As Boolean = True

    Private Sub InitLoadDataRutero()
        Try
            ' Se cargan los datos que se requieren
            GestorNucleo.LoadClientes()
            GestorNucleo.LoadPedidos()
            Me.Invoke(New EventHandler(AddressOf EndLoadDataApplication))
        Catch ex As Exception
            WriteLog(ex)
            Me.Invoke(New EventHandler(AddressOf ErrorLoadDataApplication))
        End Try
    End Sub

    Private Sub ErrorLoadDataApplication(ByVal sender As Object, ByVal e As EventArgs)
        UIHandler.ShowError("Ha ocurrido un error no controlado iniciando la aplicación. Por favor revise el Log de errores")
        UIHandler.StartWait()
        m_InitAppThread = Nothing
        DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub EndLoadDataApplication(ByVal sender As Object, ByVal e As EventArgs)
        AnimateCtl1.StopAnimation()
        pnlIniciando.Visible = False
        dsNucleo = GestorNucleo.dsNucleo
        m_dtUltimoProcesoNovedades = Now()
        If dsNucleo.Parametros(0).IntervaloNovedades > 0 Then
            timerNovedades.Enabled = True
        Else
            timerNovedades.Enabled = False
        End If
        bsClientes.DataSource = dsNucleo
        bsPedidos.DataSource = dsNucleo
        MostrarVistaRutero()
        ConfigurarMenusModulos()
        m_InitAppThread = Nothing
    End Sub

    Private Sub LoadDataRutero(Optional ByVal bCargaInicial As Boolean = True)
        pnlIniciando.Visible = True
        AnimateCtl1.StartAnimation()
        m_InitAppThread = New Thread2(AddressOf InitLoadDataRutero)
        m_InitAppThread.Start()
    End Sub

    Private Sub RuteroForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If m_InitAppThread IsNot Nothing Then
            Exit Sub
        End If
        If Not ProcessHotKeys(Me, e) Then
            If e.KeyCode = Keys.Escape Then ' Salir sin guardar
                menuRegresar_Click(Me, Nothing)
            ElseIf e.KeyCode = Keys.Enter Then ' Acción predeterminada para la vista actual
                If pnlVistaClientes.Visible Then
                    menuPedidosCliente_Click(Me, Nothing)
                Else
                    menuAtencionPedido_Click(Me, Nothing)
                End If
            ElseIf e.KeyCode = Keys.B Then ' Buscar
                If pnlVistaClientes.Visible Then
                    menuBuscarCliente_Click(Me, Nothing)
                Else
                    menuBuscarPedido_Click(Me, Nothing)
                End If
            ElseIf e.KeyCode = Keys.D Then ' Direcciones Cliente
                If pnlVistaClientes.Visible Then
                    menuDireccionesEntrega_Click(Me, Nothing)
                Else
                    menuDireccionesEntrega2_Click(Me, Nothing)
                End If
            ElseIf e.KeyCode = Keys.I Then ' Información Cliente
                If pnlVistaClientes.Visible Then
                    menuInformacionCliente_Click(Me, Nothing)
                Else
                    menuInformacionCliente2_Click(Me, Nothing)
                End If
            ElseIf e.KeyCode = Keys.P Then ' Pedidos Cliente
                If pnlVistaClientes.Visible Then
                    menuPedidosCliente_Click(Me, Nothing)
                End If
            ElseIf e.KeyCode = Keys.A Then ' Atencion Pedido
                If pnlVistaPedidos.Visible Then
                    menuAtencionPedido_Click(Me, Nothing)
                End If
            Else
                ' Se procesan los menús adicionales del rutero
                Dim menu, mainMenu As MenuItem
                Dim modMenu As ModuloMenuItem
                If pnlVistaClientes.Visible Then
                    mainMenu = menuRutero
                Else
                    mainMenu = menuRutero2
                End If
                For Each menu In mainMenu.MenuItems
                    If TypeOf menu Is ModuloMenuItem Then
                        modMenu = DirectCast(menu, ModuloMenuItem)
                        If modMenu.InfoModulo.HotKey = e.KeyCode Then
                            EjecutarModuloRutero(modMenu.InfoModulo)
                            Exit For
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub MostrarVistaRutero()
        If m_sVistaActual = VistasRutero.Clientes Then
            Me.Menu = menuRuteroClientes
            pnlVistaPedidos.Visible = False
            pnlVistaClientes.Visible = True
            If bsClientes.Count > 0 Then
                bsClientes.MoveFirst()
            End If
        Else
            Me.Menu = menuRuteroPedidos
            pnlVistaClientes.Visible = False
            pnlVistaPedidos.Visible = True
            If bsPedidos.Count > 0 Then
                bsPedidos.MoveFirst()
            End If
        End If
    End Sub

    Private Sub ConfigurarMenusModulos()
        Programa.ModulosRutero.Clear()
        Programa.LoadInfoModulosRutero()
        CombinarMenusModulos(menuRutero, Programa.ModulosRutero, AddressOf menuModulosRutero_Click)
        CombinarMenusModulos(menuRutero2, Programa.ModulosRutero, AddressOf menuModulosRutero_Click)
    End Sub

    ' Maneja el evento click en los menús de los modulos personalizados de la aplicación y ejecuta
    ' el módulo correspondiente
    Private Sub menuModulosRutero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Menu As ModuloMenuItem = CType(sender, ModuloMenuItem)
        EjecutarModuloRutero(Menu.InfoModulo)
    End Sub

    Private Sub menuRegresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuRegresar.Click, menuRegresar2.Click
        Salir()
    End Sub

    Public Sub Salir()
        If UIHandler.Confirm("Esta seguro de salir del rutero?") Then
            UIHandler.StartWait()
            timerNovedades.Enabled = False
            DialogResult = System.Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub menuPedidosCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuPedidosCliente.Click
        If bsClientes.Count > 0 Then
            Dim row As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsClientes), NucleoDataSet.ClientesRow)
            PedidosClienteForm.Run(row)
        End If
    End Sub

    Private Sub menuInformacionCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInformacionCliente.Click
        If bsClientes.Count > 0 Then
            Dim row As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsClientes), NucleoDataSet.ClientesRow)
            InformacionClienteForm.Run(row)
        End If
    End Sub

    Private Sub menuBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBuscarCliente.Click
        Dim sFiltro As String = BuscarClienteForm.Run()
        BuscarClienteForm.Top = 100
        BuscarClienteForm.Left = 0
        bsClientes.Filter = sFiltro
        btnQuitarFiltroCliente.Visible = bsClientes.Filter <> ""
    End Sub

    Private Sub btnQuitarFiltroCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarFiltroCliente.Click
        bsClientes.Filter = ""
        btnQuitarFiltroCliente.Visible = False
    End Sub

    Private Sub menuDireccionesEntrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDireccionesCliente.Click
        If bsClientes.Count > 0 Then
            Dim row As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsClientes), NucleoDataSet.ClientesRow)
            DireccionesClienteForm.Run(row)
        End If
    End Sub

    Private Sub btnVistaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaClientes.Click
        menuVista.Show(btnVistaClientes, New Point(0, btnVistaClientes.Height))
    End Sub

    Private Sub btnVistaPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVistaPedidos.Click
        menuVista.Show(btnVistaPedidos, New Point(0, btnVistaPedidos.Height))
    End Sub

    Private Sub menuBuscarPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuBuscarPedido.Click
        bsPedidos.Filter = BuscarPedidoForm.Run()
        BuscarPedidoForm.Top = 100
        BuscarPedidoForm.Left = 0
        btnQuitarFiltroPedidos.Visible = bsPedidos.Filter <> ""
    End Sub

    Private Sub menuVistaClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuVistaClientes.Click
        m_sVistaActual = VistasRutero.Clientes
        MostrarVistaRutero()
    End Sub

    Private Sub menuVistaPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuVistaPedidos.Click
        m_sVistaActual = VistasRutero.Pedidos
        MostrarVistaRutero()
    End Sub

    Private Sub menuDireccionesEntrega2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuDireccionesEntrega2.Click
        If bsPedidos.Count > 0 Then
            Dim row As NucleoDataSet.PedidosRow
            Dim rowCliente As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsPedidos), NucleoDataSet.PedidosRow)
            rowCliente = dsNucleo.Clientes.FindByCodigo(row.CodCliente)
            DireccionesClienteForm.Run(rowCliente)
        Else
            UIHandler.ShowError("No hay pedidos!")
        End If
    End Sub

    Private Sub menuInformacionCliente2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuInformacionCliente2.Click
        If bsPedidos.Count > 0 Then
            Dim row As NucleoDataSet.PedidosRow
            Dim rowCliente As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsPedidos), NucleoDataSet.PedidosRow)
            rowCliente = dsNucleo.Clientes.FindByCodigo(row.CodCliente)
            InformacionClienteForm.Run(rowCliente)
        Else
            UIHandler.ShowError("No hay pedidos!")
        End If
    End Sub

    Private Sub menuAtencionPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAtencionPedido.Click
        If bsPedidos.Count > 0 Then
            Dim row As NucleoDataSet.PedidosRow
            Dim rowCliente As NucleoDataSet.ClientesRow
            row = CType(GetCurrentRow(bsPedidos), NucleoDataSet.PedidosRow)
            rowCliente = dsNucleo.Clientes.FindByCodigo(row.CodCliente)
            AtencionPedidoForm.Run(rowCliente, row)
        Else
            UIHandler.ShowError("No hay pedidos!")
        End If
    End Sub

    Private Sub btnQuitarFiltroPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarFiltroPedidos.Click
        bsPedidos.Filter = ""
        btnQuitarFiltroCliente.Visible = False
    End Sub

    Private Sub menuCargarNovedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ProcesarNovedades()
    End Sub

    Private Sub ProcesarNovedades()

        '--MTOVAR_CO_147_ESP_REQ_GPRS_F08
        Dim Comunicaciones As New Comunicacion
        '--FIN MTOVAR_CO_147_ESP_REQ_GPRS_F08
        timerNovedades.Enabled = False
        bsClientes.SuspendBinding()
        bsPedidos.SuspendBinding()
        '--MTOVAR_CO_147_ESP_REQ_GPRS_F08
        If Comunicaciones.ejecutarDescarga(GestorNucleo.CadenaConexion.ToString, "Parcial", ProcesosComunicacion.DescargaNovedades, "Descarga") Then
            If Comunicaciones.ejecutarCarga(GestorNucleo.CadenaConexion.ToString, "Carga Novedades", ProcesosComunicacion.CargaNovedades) Then
                AfectacionPostCarga()
                GestorNucleo.LoadPedidos()
            End If
            bsClientes.ResumeBinding()
            bsPedidos.ResumeBinding()
            bsClientes.ResetBindings(False)
            bsPedidos.ResetBindings(False)
        End If
        '--FIN MTOVAR_CO_147_ESP_REQ_GPRS_F08
        m_dtUltimoProcesoNovedades = Now()
        If dsNucleo.Parametros(0).IntervaloNovedades > 0 Then
            timerNovedades.Enabled = True
        End If
    End Sub

    Private Sub AfectacionPostCarga()
        GestorCargas = New GestorCarga()
        GestorCargas.ActualizaSolAnulacion()
        GestorCargas.ActualizaPedidosReasignados()
        GestorCargas.limpiarSolAnulaciones()
    End Sub


    Private Sub timerNovedades_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerNovedades.Tick
        If DateDiff(DateInterval.Minute, m_dtUltimoProcesoNovedades, Now()) >= dsNucleo.Parametros(0).IntervaloNovedades Then
            timerNovedades.Enabled = False
            If Me.Enabled Then
                ProcesarNovedades()
            Else
                m_bProcesarNovedadesPendiente = True
            End If
        End If
    End Sub

    Private Sub RuteroForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        timerNovedades.Enabled = False
    End Sub

    Public Shared Sub WriteLog(ByVal ex As Exception)
        ' Se guarda la información del error en el archivo
        Dim stream As New System.IO.StreamWriter("\ErrorLoadDataRutero.TXT", True)
        Dim bld As New System.Text.StringBuilder()
        Dim inner As Exception = ex.InnerException

        stream.WriteLine("==============================================================================")
        stream.WriteLine(Now.ToString() & "Ha ocurrido una excepción: " & ex.GetType().FullName)
        stream.WriteLine(ex.Message)
        If Not inner Is Nothing Then
            stream.WriteLine("Inner Exception: " & inner.ToString())
        End If
        If ex.GetType() Is GetType(System.Data.SqlServerCe.SqlCeException) Then
            Dim sqlex As System.Data.SqlServerCe.SqlCeException
            Dim err As System.Data.SqlServerCe.SqlCeError
            sqlex = DirectCast(ex, System.Data.SqlServerCe.SqlCeException)

            ' Enumerate each error to a message box.
            For Each err In sqlex.Errors
                stream.WriteLine(" Error Code: " & err.HResult.ToString("X"))
                stream.WriteLine(" Message   : " & err.Message)
                stream.WriteLine(" Minor Err.: " & err.NativeError)
                stream.WriteLine(" Source    : " & err.Source)

                ' Retrieve the error parameter numbers for each error.
                Dim numPar As Integer
                For Each numPar In err.NumericErrorParameters
                    If 0 <> numPar Then
                        stream.WriteLine(" Num. Par. : " & numPar)
                    End If
                Next numPar

                ' Retrieve the error parameters for each error.
                Dim errPar As String
                For Each errPar In err.ErrorParameters
                    If String.Empty <> errPar Then
                        bld.Append((ControlChars.Cr & " Err. Par. : " & errPar))
                    End If
                Next errPar
            Next err
        End If
        stream.WriteLine("Stack Trace: " & ex.StackTrace.ToString())
        stream.Close()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        ProcesarNovedades()
    End Sub
End Class