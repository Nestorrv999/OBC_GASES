using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace PraxairComunicaciones
{
    public class ParametrosWS
    {
        public ParametrosWS(int pPrograma, int pProceso, string pIdTerminal, string pIdSistema, bool pComprimir, bool pUpdateCurrentRows, bool pUsarGPRS, string pDescripcionProceso, string sConexionGprs, DatascanCF.Data.DataSetSerializer.QueryList listQuery, params object[] pParametros)
        {
            this.Programa = pPrograma;
            this.Proceso = pProceso;
            this.IdTerminal = pIdTerminal;
            this.IdSistema = pIdSistema;
            this.Comprimir = pComprimir;
            this.Parametros = pParametros;
            this.UpdateCurrentRows = pUpdateCurrentRows;
            this.UsarGPRS = pUsarGPRS;
            this.DescripcionProceso = pDescripcionProceso;
            this.lstQuery = listQuery;
            this.ConexionGPRS = sConexionGPRS;
        }

        private DatascanCF.Data.DataSetSerializer.QueryList m_QueryList;
        public DatascanCF.Data.DataSetSerializer.QueryList lstQuery
        {
            get { return m_QueryList; }
            set { m_QueryList = value; }
        }
        private int sPrograma;

        public int Programa
        {
            get { return sPrograma; }
            set { sPrograma = value; }
        }
        private int sProceso;

        public int Proceso
        {
            get { return sProceso; }
            set { sProceso = value; }
        }
        private string sIdTerminal;

        public string IdTerminal
        {
            get { return sIdTerminal; }
            set { sIdTerminal = value; }
        }
        private string sIdSistema;

        public string IdSistema
        {
            get { return sIdSistema; }
            set { sIdSistema = value; }
        }
        private string sIdComunicaciones;

        public string IdComunicaciones
        {
            get { return sIdComunicaciones; }
            set { sIdComunicaciones = value; }
        }
        private object[] rParametros;

        public object[] Parametros
        {
            get { return rParametros; }
            set { rParametros = value; }
        }

        private bool bComprimir;

        public bool Comprimir
        {
            get { return bComprimir; }
            set { bComprimir = value; }
        }

        private bool bUpdateCurrentRows = false;

        public bool UpdateCurrentRows
        {
            get { return bUpdateCurrentRows; }
            set { bUpdateCurrentRows = value; }
        }

        private bool bUsarGPRS = false;

        public bool UsarGPRS
        {
            get { return bUsarGPRS; }
            set { bUsarGPRS = value; }
        }


        private string sConexionGPRS;

        public string ConexionGPRS
        {
            get { return sConexionGPRS; }
            set { sConexionGPRS = value; }
        }

        private string sDescripcionProceso;

        public string DescripcionProceso
        {
            get { return sDescripcionProceso; }
            set { sDescripcionProceso = value; }
        }
        private DataRow[] m_rows;
        /// <summary>
        /// Operaciones cuando se hacen con datos de memoria
        /// </summary>
        public DataRow[] Rows
        {
            get { return Rows; }
            set { Rows = value; }
        }
    }
}
