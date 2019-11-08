
'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F02
'--              se incluye la clase Comunicaciòn que ya existia en el proyecto de liquidos
'-----------------------------------------------------------------------------------------------------------------

'--MTOVAR_CO_147_ESP_REQ_GPRS_F02

Imports PraxairComunicaciones
Imports DatascanCF
Imports OpenNETCF
Imports System.Data
Imports OpenNETCF.Net

Public Class Comunicacion
    Private m_Rows() As DataRow
    Private Timeout As Integer = 100000
    Private Gprs As Boolean
    Private ListQuery As New DatascanCF.Data.DataSetSerializer.QueryList

    Public Sub New()
        If Settings.ConexionGPRS.ToString().Trim = "" Then
            Gprs = False
        Else
            Gprs = True
        End If

    End Sub
    Public Function ejecutarCarga(ByVal Coneccion As String, ByVal Mensaje As String, ByVal TipoCarga As ProcesosComunicacion) As Boolean

        Dim oParametros As Object()
        NucleoCOM.ConfigurarServicioWeb(Settings.IPServidor, Settings.PuertoServidor.ToString(), Settings.VirtualDirectory, Settings.UsuarioWebService, Settings.ClaveWebService, Timeout, Settings.IPServidorGPRS)
        Return NucleoCOM.CargarDatos(1, TipoCarga, Settings.IDTerminal, "", True, True, Gprs, True, Mensaje, Settings.ConexionGPRS, Coneccion, ListQuery, oParametros)

    End Function
    Public Function ejecutarDescarga(ByVal Coneccion As String, ByVal iTipoDescarga As String, ByVal TipoCarga As ProcesosComunicacion, ByVal sMensaje As String) As Boolean
        Try
            LoadQuerysDescarga(iTipoDescarga)

            Dim oParametros As Object()
            NucleoCOM.ConfigurarServicioWeb(Settings.IPServidor, Settings.PuertoServidor.ToString(), Settings.VirtualDirectory, Settings.UsuarioWebService, Settings.ClaveWebService, Timeout, Settings.IPServidorGPRS)
            Return NucleoCOM.DescargarDatos(1, TipoCarga, Settings.IDTerminal, "", True, True, Gprs, True, sMensaje, Settings.ConexionGPRS, Coneccion, ListQuery, oParametros)
        Catch ex As Exception
            Return False
        End Try


    End Function


    Public Function EliminacionTablas(ByVal iTipoDescarga As String) As DatascanCF.Data.DataSetSerializer.QueryList
        Try
            LoadQuerysDescarga(iTipoDescarga)
            Return ListQuery
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Sub LoadQuerysDescarga(ByVal Tipo As String)

        'DATASCAN 20171017
        'SE VERIFICA LA INTEGRIDAD DE LOS DATOS DE TALONARIOS AL DESCARGAR LOS DATOS
        'ESTO CON EL FIN QUE EN PRAX QUEDE LA INFORMACION DE MANERA CORRECTA
        Dim _ValidacionMaestroGuias As New ConexionDLL
        Dim dt As New DataTable, dt1 As New DataTable, dt2 As New DataTable
        Dim x As Integer
        Dim sSql As String
        Dim bEcontro As Boolean
        bEcontro = False
        Try            
            sSql = "SELECT MAX(NoFactura) AS MAX_NoFactura, TipoDocumento, PrefijoFactura" _
                    & " FROM MaestroGuias" _
                    & " GROUP BY TipoDocumento, PrefijoFactura"
            dt = _ValidacionMaestroGuias.SqlQuery(sSql)
            ''Logger.Write("Consulta el maximo numero de factura por documento en la tabla MaestroGuias")
            If Not dt Is Nothing Then
                For x = 0 To dt.Rows.Count - 1
                    sSql = "SELECT d.CodTipoDocumento, MAX(t.Consecutivo) AS Consecutivo,t.Actual" _
                            & " FROM Documentos d INNER JOIN Talonarios t" _
                            & " ON d.CodTipoDocumento = t.CodTipoDocumento" _
                            & " AND d.Sigla = '" & dt.Rows(x)("TipoDocumento").ToString() & "'" _
                            & " AND t.Prefijo = '" & dt.Rows(x)("PrefijoFactura").ToString() & "'" _
                            & " GROUP BY d.CodTipoDocumento, t.Actual"
                    dt1 = _ValidacionMaestroGuias.SqlQuery(sSql)
                    ''Logger.Write("Consulta el maximo numero conscutivo en la tabla talonarios")
                    If Not dt1 Is Nothing Then
                        If dt1.Rows.Count > 0 Then
                            If dt1.Rows(0)("Actual").ToString() <> dt.Rows(x)("MAX_NoFactura").ToString() Then
                                sSql = "UPDATE Talonarios" _
                                & " SET actual = '" & dt.Rows(x)("MAX_NoFactura").ToString() & "'" _
                                & " WHERE CodTipoDocumento = " & dt1.Rows(0)("CodTipoDocumento").ToString() _
                                & " AND consecutivo =" & dt1.Rows(0)("Consecutivo").ToString() _
                                & " AND Prefijo =" & dt.Rows(x)("PrefijoFactura").ToString()
                                _ValidacionMaestroGuias.SqlCommand(sSql)
                                ''Logger.Write("Actualiza la tabla talonarios por el metodo LoadQuerysDescarga: " + Chr(13) + sSql)
                            End If
                        End If
                    End If
                Next
            End If
        Catch

        End Try
        'FIN DATASCAN 20171017

        'MTOVAR_CO_147_ESP_REQ_GPRS_F08
        ListQuery.Clear()
        GestorListQueries = New GestorListaQueries()
        Dim dsqueries As New System.Data.DataSet
        If Tipo = "Parcial" Then
            dsqueries = GestorListQueries.obtenerQueries("P", CStr(ProcesosComunicacion.DescargaNovedades))
        ElseIf Tipo = "CargueCamion" Then
            dsqueries = GestorListQueries.obtenerQueries("C", CStr(ProcesosComunicacion.CargueCamion))
        Else
            dsqueries = GestorListQueries.obtenerQueries("T", CStr(ProcesosComunicacion.DescargaCompleta))
        End If


        Dim dtqueries As System.Data.DataTable
        dtqueries = dsqueries.Tables(0)


        For Each dr As DataRow In dtqueries.Select

            ListQuery.Add(dr("Tabla").ToString(), dr("Query").ToString())
        Next


        'If Tipo = "Parcial" Then
        '    ListQuery.Add("DetalleFactura", "SELECT * from DetalleFactura " & sqlFiltroEnviados())
        '    ListQuery.Add("HojasRuta", "HojasRuta")
        '    ListQuery.Add("KardexCamionLiquidos", "KardexCamion")
        '    ListQuery.Add("DetallePedidoLiquidos", "SELECT * from DetallePedido where (nopedido) in (select nopedido from MaestroFacturas " & sqlFiltroEnviados() & ")")
        '    ListQuery.Add("MaestroFacturas", "SELECT * from MaestroFacturas	 " & sqlFiltroEnviados())
        '    ListQuery.Add("Parametros_Descarga", "Parametros")
        '    ListQuery.Add("Precintos", "Precintos")
        '    ListQuery.Add("TalonariosDescarga", "Talonarios")
        '    ListQuery.Add("PedidosLiquidos", "SELECT * from Pedidos where (nopedido) in (select nopedido from MaestroFacturas " & sqlFiltroEnviados() & ")")
        '    ListQuery.Add("Guia_Documento", "SELECT * from Guia_Documento where transmitido_sn = 'N'")
        'ElseIf Tipo = "CargueCamion" Then
        '    ListQuery.Add("KardexCamion", "KardexCamion")
        '    ListQuery.Add("Carga", "Carga")
        'Else
        '    ListQuery.Add("DetalleFactura", "DetalleFactura")
        '    ListQuery.Add("HojasRuta", "HojasRuta")
        '    ListQuery.Add("KardexCamionLiquidos", "KardexCamion")
        '    ListQuery.Add("DetallePedidoLiquidos", "DetallePedido")
        '    ListQuery.Add("MaestroFacturas", "MaestroFacturas")
        '    ListQuery.Add("Parametros_Descarga", "Parametros")
        '    ListQuery.Add("Precintos", "Precintos")
        '    ListQuery.Add("TalonariosDescarga", "Talonarios")
        '    ListQuery.Add("PedidosLiquidos", "Pedidos")
        '    ListQuery.Add("Guia_Documento", "Guia_Documento")

        'End If

    End Sub
    Private Function sqlFiltroEnviados() As String
        Return " where exists (select num_documento from Guia_Documento where transmitido_sn = 'N' and nofactura = num_documento and prefijo_documento =  PREFIJO )"
    End Function
End Class

'--FIN MTOVAR_CO_147_ESP_REQ_GPRS_F02