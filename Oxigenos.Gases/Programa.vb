Imports System.Data.SqlServerCe
Imports System.IO
Imports OpenNETCF.Windows.Forms

Public Class Programa
    Inherits ProgramaBase

    Public Overrides ReadOnly Property Codigo() As Integer
        Get
            Return 1
        End Get
    End Property

    Public Overrides ReadOnly Property Nombre() As String
        Get
            Return "Industrial/HomeCare"
        End Get
    End Property

    Protected Overrides ReadOnly Property DatabaseFile() As String
        Get
            Return "\Oxigenos.SDF"
        End Get
    End Property


    Public Overrides Sub CreateDatabase()
        File.Copy(Path.Combine(Application2.StartupPath, "Oxigenos.SDF"), DatabaseFile, True)
    End Sub

    Protected Overrides Sub InternalCheckDatabase()
        ' TODO: Implementar validaciones adicionales en la base de datos
    End Sub

    Public Overrides Sub LoadInfoModulosCliente(ByVal rowCliente As System.Data.DataRow)

    End Sub
    Public Overrides Sub LoadInfoModulosPrograma()
        m_lstModulosPrograma.AddModuloPrograma("Cargue Camion", IconosModulos.Camion, GetType(CargueCamionForm), Nothing)
        m_lstModulosPrograma.AddModuloPrograma("Inicio Ruta", IconosModulos.InicioRuta, GetType(InicioRutaForm), Nothing)
        m_lstModulosPrograma.AddModuloNucleo(ModulosNucleo.Rutero, "Rutero", Nothing)
        m_lstModulosPrograma.AddModuloPrograma("Fin Ruta", IconosModulos.FinRuta, GetType(FinRutaForm), Nothing)
        m_lstModulosPrograma.AddModuloPrograma("Reportes", IconosModulos.Impresora, GetType(ReportesForm), Nothing)
    End Sub

    Public Overrides Sub LoadInfoModulosRutero()
        m_lstModulosRutero.AddModuloPrograma("Documentos &Manuales", GetType(DocumentosManualesForm), System.Windows.Forms.Keys.M)
    End Sub



    Public Overrides Sub LoadInfoModulosPedidos(ByVal rowCliente As System.Data.DataRow)
        m_lstModulosPedido.AddModuloPrograma("&Venta", GetType(VentaForm), System.Windows.Forms.Keys.V)
        m_lstModulosPedido.AddModuloPrograma("&Recoleccion", GetType(RecoleccionesForm), System.Windows.Forms.Keys.R)
        m_lstModulosPedido.AddModuloPrograma("&Deudas Pendientes", GetType(DeudasForm), System.Windows.Forms.Keys.D)
        m_lstModulosPedido.AddModuloPrograma("&Generar", GetType(ResumenDetalleGenerar), System.Windows.Forms.Keys.G)
    End Sub

    Public Overrides Sub LoadQuerysDescarga(ByVal lstQuerys As Common.ListQuerysDescarga)
        lstQuerys.Add("ALQUILERES", "ALQUILERES")
        lstQuerys.Add("ALQUILERESPAGADOS", "ALQUILERESPAGADOS")
        lstQuerys.Add("ASIGNACIONES", "ASIGNACIONES")
        lstQuerys.Add("AUTORIZACIONASIGNACION", "AUTORIZACIONASIGNACION")
        lstQuerys.Add("AUTORIZACIONREMISION", "AUTORIZACIONREMISION")
        lstQuerys.Add("DEPOSITOSGARANTIA", "DEPOSITOSGARANTIA")
        lstQuerys.Add("DETALLEAUTORIZACION", "DETALLEAUTORIZACIONES")
        lstQuerys.Add("DETALLEFACTURA", "DETALLEFACTURA")
        lstQuerys.Add("DETALLEGUIAASIGREC", "DETALLEGUIAASIGNACIONESRECOLECCIONES")
        lstQuerys.Add("DETALLEGUIAFACTREM", "DETALLEGUIAFACTURASREMISIONES")
        lstQuerys.Add("DETALLEGUIARECAJE", "DETALLEGUIARECOLECCIONESAJENOS")
        lstQuerys.Add("FACTURASMANUALES", "FACTURASMANUALES")
        lstQuerys.Add("MAESTROFACTURAS", "MAESTROFACTURAS")
        lstQuerys.Add("MAESTROGUIAS", "MAESTROGUIAS")
        lstQuerys.Add("MOVIMIENTOCOPAGOSCUOTAS", "MOVIMIENTOCOPAGOSCUOTAS")
        lstQuerys.Add("PARAMETROS_DESCARGA", "PARAMETROS")
        lstQuerys.Add("TALONARIOSDESCARGA", "TALONARIOS")
        lstQuerys.Add("COPAGOSPORCOBRAR", "COPAGOSPORCOBRAR")
    End Sub

    Public Overrides Function ValidarInicioRutero(ByRef sMensaje As String) As Boolean
        If Today() = Nucleo.FechaCarga Then
            If Nucleo.KilometrajeInicial = " " Or Nucleo.KilometrajeInicial = "0" Then
                sMensaje = "No se ha iniciado la ruta!!"
                UIHandler.EndWait()
                Return False
            Else
                Return True
            End If
        Else
            sMensaje = "La fecha de la terminal es inferior a la fecha de carga!!" & vbCrLf & "Fecha de la terminal: " & Today() & vbCrLf & "Fecha de Carga: " & Nucleo.FechaCarga
            UIHandler.EndWait()
            Return False
        End If
    End Function

    Public Overrides Sub InicioAtencionPedido(ByVal RowCliente As System.Data.DataRow, ByVal RowPedido As System.Data.DataRow)
        Dim Row As DataRow
        Venta = New GestorVenta
        Pacientes = New GestorPacientes

        If Nucleo.KiloMetrajeFinal <> " " And Nucleo.KiloMetrajeFinal <> "0" Then
            UIHandler.ShowError("La ruta ya se finalizo!!")
            Exit Sub
        End If

        Try
            Productos.OpenConnection()

            'S E  C A R G A   E L  D E T A L L E   D E L  P E D I D O

            Pedidos.LoadDetallePedido(cstrDBNULL(RowPedido("NoPedido")))
            If cstrDBNULL(RowCliente("CodTipoCliente")) = TiposCliente.Paciente Then
                If IsNullOrEmpty(RowPedido("CodEntidad")) Then
                    Row = CapturaEntidadForm.Run(cstrDBNULL(RowCliente("Codigo")))
                    If Row IsNot Nothing Then
                        RowPedido("CodEntidad") = Row("CodEntidad")
                    End If
                End If

                If Not IsNullOrEmpty(RowPedido("CodEntidad")) Then
                    'S E  C A R G A N   L A S   A U T O R I Z A C I O N E S  D E  L  C L I E N T E 

                    Pacientes.LoadAutorizaciones(cstrDBNULL(RowPedido("CodCliente")), cstrDBNULL(RowPedido("CodEntidad")))
                    If Pacientes.dsPacientes.DetalleAutorizaciones.Rows.Count > 0 Then

                        'S E  C A R G A N  L O S  A L Q U I L E R E S  D I S P O N I B L E S
                        Pacientes.GetAlquileres(cstrDBNULL(Pacientes.dsPacientes.DetalleAutorizaciones.Rows(0)("NoAutorizacion")))
                    End If


                    Dim dt As PacientesDataSet.ClientesDataTable
                    dt = Pacientes.GetDatosEntidad(CStr(RowPedido("CodEntidad")))
                    If dt.Rows.Count > 0 Then
                        bPagoDeposito = CBool(dt(0).PagaDeposito)
                    Else
                        dt = Pacientes.GetDatosEntidad(CStr(RowPedido("CodCliente")))
                        If dt.Rows.Count > 0 Then
                            bPagoDeposito = CBool(dt(0).PagaDeposito)
                        Else
                            bPagoDeposito = True
                        End If
                    End If

                    Pacientes.GetEntidad(CStr(RowPedido("CodEntidad")))

                    If Pacientes.dsPacientes.EntidadCliente.Rows.Count > 0 Then
                        bEntidadBloqueada = CBool(Pacientes.dsPacientes.EntidadCliente.Rows(0)("Estado"))
                        bRespetaPrecio = CBool(Pacientes.dsPacientes.EntidadCliente.Rows(0)("RespetaPrecio"))
                        bRemisionValorizada = CBool(Pacientes.dsPacientes.EntidadCliente.Rows(0)("IncluyeRemisionValorizada"))
                    Else
                        bRespetaPrecio = False
                        bEntidadBloqueada = True
                        bRemisionValorizada = False
                    End If
                    bVerificarAutorizacion = True
                Else
                    bRemisionValorizada = False
                    bVerificarAutorizacion = False

                    Dim dt As PacientesDataSet.ClientesDataTable
                    dt = Pacientes.GetDatosEntidad(CStr(RowPedido("CodCliente")))
                    If dt.Rows.Count > 0 Then
                        bPagoDeposito = CBool(dt(0).PagaDeposito)
                    Else
                        bPagoDeposito = True
                    End If
                End If

                ' Se cargan los copagos por cobrar del cliente
                Pacientes.LoadCopagosPorCobrar(CStr(RowPedido("Codcliente")))
                If Pacientes.dsPacientes.CopagosPorCobrar.Rows.Count > 0 Then
                    Dim Valor As Double
                    Valor = CDblDBNull(Pacientes.dsPacientes.CopagosPorCobrar.Compute("SUM(Valor)", ""), 0)
                    UIHandler.ShowAlert("Se va a generar factura de CUOTA/COPAGO por un valor de $" & CStr(Valor), "Atención")
                End If
            Else
                bRemisionValorizada = False
                bRespetaPrecio = False
            End If
        Finally
            Productos.CloseConnection()
        End Try
    End Sub

    Public Overrides Function CerrarAtencionPedido(ByVal RowCliente As System.Data.DataRow, ByVal RowPedido As System.Data.DataRow) As Boolean
        Dim Result As Boolean = False
        If Venta.dsVenta.CilindrosLeidos.Rows.Count > 0 Then
            If MsgBox("Esta seguro de salir?" & vbCr & "Se perderan los datos capturados!!", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                Result = True
            End If
        Else
            Result = True
        End If
        Return Result
    End Function

    Public Overrides Function ValidarFindeRuta(ByRef sMensaje As String) As Boolean
        If Nucleo.KiloMetrajeFinal = " " Or Nucleo.KiloMetrajeFinal = "0" Then
            sMensaje = "No se ha finalizado la ruta!!"
            UIHandler.EndWait()
            Return False
        Else
            Return True
        End If
    End Function
End Class
