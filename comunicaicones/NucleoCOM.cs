using System;
using System.Collections.Generic;
using System.Text;

namespace PraxairComunicaciones
{
    public class NucleoCOM
    {
        public static void ConfigurarServicioWeb(string sIp, string sPuertoTCP, string sCarpetaVirtual, string sUsuarioWS, string sContrasenaWS, int iTimeOut, string sIpGPRS)
        {
            Comunicacion.CargaDatosForm.ConfiguracionServidorWS(sIp,sPuertoTCP,sCarpetaVirtual,sUsuarioWS,sContrasenaWS,iTimeOut, sIpGPRS );
            Comunicacion.DescargarDatosForm.ConfiguracionServidorWS(sIp, sPuertoTCP, sCarpetaVirtual, sUsuarioWS, sContrasenaWS, iTimeOut, sIpGPRS);
        }

        public static bool CargarDatos (int sCodPrograma, int sCodProceso, string sIdTerminal, string sDeviceId, bool bComprimir, bool bActualizarRegistros,
            bool bUsarGPRS, bool bCerrarVentana, string sNombreProceso, string sConexionGPRS, string sDataSource,DatascanCF.Data.DataSetSerializer.QueryList ListQuery, object[] prParametros)
        {
            return Comunicacion.CargaDatosForm.Run(sCodPrograma, sCodProceso, sIdTerminal, sDeviceId, bComprimir, bActualizarRegistros, bUsarGPRS, bCerrarVentana, sNombreProceso, sConexionGPRS, sDataSource, ListQuery,prParametros);
        }

        public static bool DescargarDatos(int sCodPrograma, int sCodProceso, string sIdTerminal, string sDeviceId, bool bComprimir, bool bActualizarRegistros,
            bool bUsarGPRS, bool bCerrarVentana, string sNombreProceso, string sConexionGPRS, string sDataSource, DatascanCF.Data.DataSetSerializer.QueryList ListQuery , object[] prParametros)
        {
            return Comunicacion.DescargarDatosForm.Run(sCodPrograma, sCodProceso, sIdTerminal, sDeviceId, bComprimir, bActualizarRegistros, bUsarGPRS, bCerrarVentana, sNombreProceso, sConexionGPRS, sDataSource,ListQuery, prParametros);
        }
            
    }
}
