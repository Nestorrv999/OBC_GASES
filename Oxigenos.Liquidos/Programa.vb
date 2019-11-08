Imports System.Data.SqlServerCe
Imports System.IO
Imports OpenNETCF.Windows.Forms

Public Class Programa
    Inherits ProgramaBase

    Public Overrides ReadOnly Property Codigo() As Integer
        Get
            Return 2
        End Get
    End Property

    Public Overrides ReadOnly Property Nombre() As String
        Get
            Return "Liquidos"
        End Get
    End Property

    Protected Overrides ReadOnly Property DatabaseFile() As String
        Get
            Return "\Liquidos.SDF"
        End Get
    End Property

    Public Overrides Sub CreateDatabase()
        File.Copy(Path.Combine(Application2.StartupPath, "Liquidos.SDF"), DatabaseFile, True)
    End Sub

    Protected Overrides Sub InternalCheckDatabase()
        ' TODO: Implementar validaciones adicionales en la base de datos
    End Sub
    Public Overrides Sub LoadInfoModulosCliente(ByVal rowCliente As System.Data.DataRow)

    End Sub

    Public Overrides Sub LoadInfoModulosPrograma()
        m_lstModulosPrograma.AddModuloPrograma("Inicio Ruta", IconosModulos.InicioRuta, GetType(InicioRutaForm), Nothing)
        m_lstModulosPrograma.AddModuloNucleo(ModulosNucleo.Rutero, "Rutero", Nothing)
        m_lstModulosPrograma.AddModuloPrograma("Reportes", IconosModulos.Impresora, GetType(ReportesForm), Nothing)
        m_lstModulosPrograma.AddModuloPrograma("Fin de Ruta", IconosModulos.FinRuta, GetType(FinRutaForm), Nothing)

        ' TODO: Agregar otros módulos que se muestran después del rutero
    End Sub

    

    Public Overrides Sub LoadInfoModulosRutero()
        'm_lstModulosRutero.AddModuloPrograma("Documentos Manuales", GetType(DocumentosManualesForm), System.Windows.Forms.Keys.D)
    End Sub


    Public Overloads Sub LoadInfoModulosPedidos(ByVal rowCliente As System.Data.DataRow)
        m_lstModulosPedido.AddModuloPrograma("&Venta", GetType(VentaForm), System.Windows.Forms.Keys.V)
    End Sub

    Public Overrides ReadOnly Property UseQueryFilterInRutero() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overrides ReadOnly Property FilterQueryClientes() As String
        Get
            Return String.Format("WHERE EXISTS ( SELECT CodigoCliente FROM ClienteTanque " & _
                "WHERE ClienteTanque.ProductoTanque = '{0}' AND ClienteTanque.CodigoCliente = Clientes.Codigo )", _
                 HojasRuta.HojaActual.CodProducto)
        End Get
    End Property

    Public Overrides Sub LoadQuerysDescarga(ByVal lstQuerys As Common.ListQuerysDescarga)
        lstQuerys.Add("DetalleFactura", "DetalleFactura")
        lstQuerys.Add("HojasRuta", "HojasRuta")
        lstQuerys.Add("KardexCamionLiquidos", "KardexCamion")
        lstQuerys.Add("DetallePedidoLiquidos", "DetallePedido")
        lstQuerys.Add("MaestroFacturas", "MaestroFacturas")
        lstQuerys.Add("Parametros_Descarga", "Parametros")
        lstQuerys.Add("Precintos", "Precintos")
        lstQuerys.Add("TalonariosDescarga", "Talonarios")
    End Sub

    Public Overrides Function ValidarInicioRutero(ByRef sMensaje As String) As Boolean
        ' Se realizan las validaciones necesarias
        HojasRuta.LoadHojaRutaActual()
        If HojasRuta.dsHojasRuta.HojasRuta.Count > 0 Then
            If HojasRuta.dsHojasRuta.HojasRuta(0).Estado = EstadosHojaRuta.Creada Then
                sMensaje = "La hoja de ruta no ha sido iniciada, no se puede iniciar el rutero!"
                Return False
            End If
        Else
            sMensaje = "No se ha creado la hoja de ruta, no se puede iniciar el rutero"
            Return False
        End If

        ' Se carga la información compartida que será utilizada
        Productos.LoadProducto(HojasRuta.dsHojasRuta.HojasRuta(0).CodProducto)
        Productos.LoadExistencias(HojasRuta.dsHojasRuta.HojasRuta(0).IdHojaRuta, _
            HojasRuta.dsHojasRuta.HojasRuta(0).CodProducto)
        Return True
    End Function

    Public Overrides Function CerrarAtencionPedido(ByVal RowCliente As System.Data.DataRow, ByVal RowPedido As System.Data.DataRow) As Boolean
        Return True
    End Function

    Public Overrides Sub InicioAtencionPedido(ByVal RowCliente As System.Data.DataRow, ByVal RowPedido As System.Data.DataRow)

    End Sub

    Public Overrides Function ValidarFindeRuta(ByRef sMensaje As String) As Boolean

    End Function
End Class
