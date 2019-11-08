'-----------------------------------------------------------------------------------------------------------------
'--Versión       Fecha           Autor               Motivo                      Indicador del cambio
'--1.5
'--1.6           11/11/2010	    MTOVAR/ASESOFTWARE  CO_147_ESP_REQ_GPRS_F02     MTOVAR_CO_147_ESP_REQ_GPRS_F08
'--              Se crea el gestor para obtener un listado de queries parametrizadas
'-----------------------------------------------------------------------------------------------------------------

'--MTOVAR_CO_147_ESP_REQ_GPRS_F08

Imports System.Data.SqlServerCe
Imports System.Data
Public Class GestorListaQueries


    ''' <summary>
    ''' Función que devuelve un dataset con las queries parametrizadas
    ''' </summary>
    ''' <param name="p_tipocarga">P de parcial y T de total</param>
    ''' <param name="p_idproceso">descarga de novedades, descarga total</param>
    ''' <returns>Dataset</returns>
    ''' <remarks></remarks>

    Public Function obtenerQueries(ByVal p_tipocarga As String, ByVal p_idproceso As String) As System.Data.DataSet

        Me.dtaParamDescarga.Connection = Me.Connection
        Me.dsListaQueries.ParamDescarga.Rows.Clear()
        Me.dtaParamDescarga.FillBy(Me.dsListaQueries.ParamDescarga, p_tipocarga, p_idproceso)

        Return Me.dsListaQueries
    End Function
End Class
