using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DatascanCF.Windows.Forms;
using System.Net;
using OpenNETCF.Net;
using OpenNETCF.WindowsCE;
using DatascanCF;
using DatascanCF.Data;
using System.Data.SqlServerCe;

namespace PraxairComunicaciones.Comunicacion
{
    internal partial class DescargarDatosForm : Form, DatascanCF.Data.DataSetSerializer.IEstadoCarga
    {
        private DataTable m_GuiaDocumentos;
        //private QuickMobile.Client.WSComunicaciones.DataAccess m_ws;
        private WSPraxair.DataAccess m_ws;
        private OpenNETCF.Threading.Thread2 m_Thread;
        private string m_sData = null;
        private bool m_bCancelado = false;
        private delegate void ActualizarMensajeHandler(string sData);
        private delegate void SetProgresoHandler(int Progreso);
        private bool m_bCerrarVentana = false;
        //APARTAR EL NUCLEO DE LA INTEGRACION        
        private ParametrosWS m_rwParametros;
      
        private string m_sConexionLocal = null;
        private DatascanCF.Data.DataSetSerializer.QueryList m_QueryList;
        //private ListQuerysDescarga m_QueryList;//nuevo

        private static ConfiguracionServidorWS m_ConfiguracionWS;

        public DescargarDatosForm()
        {
            InitializeComponent();
        }

        public static void ConfiguracionServidorWS(string pIPServidor, string pPuertoServidor, string pVirtualDirectory, string pUsuarioWebService, string pClaveWebService, int pTimeOutWebServices, string pIPServidorGPRS)
        {
            m_ConfiguracionWS = new ConfiguracionServidorWS(pIPServidor, pPuertoServidor, pVirtualDirectory, pUsuarioWebService, pClaveWebService, pTimeOutWebServices, pIPServidorGPRS );
        }

        public static bool Run(int sPrograma, int sProceso, string sIdTerminal, string sIdSistema, bool bComprimir, bool bUpdateCurrentRows, bool bUsarGPRS, bool bCerrarVentana, string sNombreProceso, string sConexionGPRS, string sConexionLocal,DatascanCF.Data.DataSetSerializer.QueryList ListQuery, params object[] rParametros)
        {
            bool result = false;
            bUsarGPRS = usarGprsf(sConexionGPRS);
            // Si asi se especifica se intenta primero establecer la conexión GPRS
            UIHandler.StartWait();
            if (bUsarGPRS)
            {
                if (!(GPRS.Conectar(sConexionGPRS)))
                {
                    UIHandler.EndWait();
                    return false;
                }
            }
            try
            {
                // Se crea la instancia de la forma y se inicia el proceso
                DescargarDatosForm frm = new DescargarDatosForm();
                frm.m_rwParametros = new ParametrosWS(sPrograma, sProceso, sIdTerminal, sIdSistema, bComprimir, false, bUsarGPRS, sNombreProceso, sConexionGPRS,  ListQuery, rParametros);
                frm.m_bCerrarVentana = bCerrarVentana;
                frm.m_sConexionLocal = sConexionLocal;
                result = (UIHandler.ShowDialog(frm) == System.Windows.Forms.DialogResult.OK);
                frm.Dispose();
                // Finalmente se cierra la conexión
                if (bUsarGPRS)
                {
                    GPRS.Desconectar();
                }
                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                UIHandler.EndWait();
            }            
        }

        public static bool usarGprsf(string sConexionGPRS)
        {
            if (sConexionGPRS == null)
                return false;

            if (sConexionGPRS.ToString().Trim().Equals(""))
                return false;
            
            WSPraxair.DataAccess m_ws;
            m_ws = new PraxairComunicaciones.WSPraxair.DataAccess();
            m_ws.Url = "http://" + m_ConfiguracionWS.IPServidor + ":" + m_ConfiguracionWS.PuertoServidor + "/" + m_ConfiguracionWS.VirtualDirectory + "/DataAccess.asmx";

            m_ws.Timeout = m_ConfiguracionWS.TimeOutWebServices;
            m_ConfiguracionWS.TimeOutWebServices = m_ws.Timeout;
            m_ws.Timeout = 10000;
            try
            {
                string fecha = m_ws.GetFechaSistema();
                return false ;
            }
            catch(Exception ex)
            {
                return true ;
            }
        }

        private void DescargarDatosForm_Load(object sender, EventArgs e)
        {
            // Se inicializan controles
            UiHandler1.Parent = this;
            pnlInfoTablas.Visible = false;
            this.lblProceso.Text = m_rwParametros.DescripcionProceso;

            // Se inicia el hilo de ejecución de la integración de datos y se habilita el timer
            // de reset de estado Idle del sistema
            timerResetIdleState.Enabled = true;
            m_Thread = new OpenNETCF.Threading.Thread2(EnviarDatosThread);
            m_Thread.Start();
            this.CargarImagenes();
            UIHandler.EndWait();
        }

        private void ConfigurarWebService()
        {
            //m_ws = new QuickMobile.Client.WSComunicaciones.DataAccess();
            m_ws = new PraxairComunicaciones.WSPraxair.DataAccess();
            if (this.m_rwParametros.UsarGPRS)
            {
                m_ws.Url = "http://" + m_ConfiguracionWS.IPServidorGprs  + ":" + m_ConfiguracionWS.PuertoServidor + "/" + m_ConfiguracionWS.VirtualDirectory + "/DataAccess.asmx";
            }
            else
            {
                m_ws.Url = "http://" + m_ConfiguracionWS.IPServidor + ":" + m_ConfiguracionWS.PuertoServidor + "/" + m_ConfiguracionWS.VirtualDirectory + "/DataAccess.asmx";
            }
            m_ws.Timeout = m_ConfiguracionWS.TimeOutWebServices;
            m_ConfiguracionWS.TimeOutWebServices = m_ws.Timeout;
            if (m_ConfiguracionWS.UsuarioWebService != "")
            {
                m_ws.Credentials = new NetworkCredential(m_ConfiguracionWS.UsuarioWebService, m_ConfiguracionWS.ClaveWebService);
            }
        }

        private void EnviarDatosThread()
        {
            string sIdComunicaciones = null;
            try
            {
                IniciarEnvioDatos("Obteniendo datos locales...");
                if (m_rwParametros.lstQuery != null)
                {
                    m_sData = null;
                    ConfigurarWebService();
                    //OBTENER LA LISTA DE SQL QUERYS A PROCESAR                    
                    
                    sIdComunicaciones = Convert.ToString(m_rwParametros.Proceso);
                    m_rwParametros.IdComunicaciones = Convert.ToString(m_rwParametros.Proceso);// sIdComunicaciones;//Igual al tipo
                    CargarGuiaDocumento();
                        DataSetSerializer dsDatos = new DataSetSerializer(new DatascanCF.Data.SqlServerCe.GestorDatosBase(m_sConexionLocal));
                        //m_sData = dsDatos.GetFromDatabase(this.m_QueryList, this);
                        m_sData = dsDatos.GetFromDatabase(m_rwParametros.lstQuery, this);
                    //}
                }
               
                IniciarEnvioDatos("Enviando datos al servidor");
                if (m_sData != null)
                {
                    if (m_rwParametros.Comprimir)
                    {
                        m_sData = ComprimirArchivos(m_sData);
                    }
                    if (sIdComunicaciones != null)
                    {
                        m_ws.SendDatos(m_rwParametros.IdTerminal,m_rwParametros.Programa,m_rwParametros.Proceso,m_sData);
                        actualizarGuiaDocumento();
                    }
                    else
                    {
                        throw new Exception("Error Obteniendo IdComunicaciones");
                    }
                    MostrarProcesoTerminado("Proceso de descarga de datos terminado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MostrarError(ex.GetType().ToString() + "\r\n" + ex.Message);
                WriteLog(ex);
                //if (sIdComunicaciones != null)
                //{
                //    try
                //    {
                //        m_ws.EnviarDescargaDatos(sIdComunicaciones, ex.Message, null);
                //    }
                //    catch (Exception ex2)
                //    {
                //        WriteLog(ex2);
                //    }
                //}
            }
        }

        private void InternalMostrarProcesoTerminado(string sMensaje)
        {
            pnlInfoTablas.Visible = false;
            pnlTerminado.Visible = true;
            pnlTerminado.BringToFront();
            lblMensajeFinal.Text = sMensaje;
            if (m_bCerrarVentana)
            {
                this.btnTerminar_Click(this, null);
            }
        }

        private void MostrarProcesoTerminado(string sMensaje)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(InternalMostrarProcesoTerminado);
            this.Invoke(funcHandler, sMensaje);
        }

        private void IniciarObtenerDatos(string sMensaje)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(InternalIniciarObtenerDatos);
            this.Invoke(funcHandler, sMensaje);
        }

        private void InternalIniciarEnvioDatos(string sMensaje)
        {
            pnlInfoTablas.Visible = false;
            pnlEnviar.Visible = true;
            AnimateCtl1.StartAnimation();
            lblFase.Text = sMensaje;
        }

        private void IniciarEnvioDatos(string sMensaje)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(InternalIniciarEnvioDatos);
            this.Invoke(funcHandler, sMensaje);
        }

        private void InternalIniciarObtenerDatos(string sMensaje)
        {
            pnlInfoTablas.Visible = true;
            lblFase.Text = sMensaje;
        }

        private void MostrarError(string sMensaje)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(InternalMostrarError);
            this.Invoke(funcHandler, sMensaje);
        }

        private void InternalMostrarError(string sMensaje)
        {
            pnlError.Visible = true;
            pnlError.BringToFront();
            lblError.Text = sMensaje;
        }

        private void timerResetIdleState_Tick(object sender, EventArgs e)
        {
            OpenNETCF.WindowsCE.PowerManagement.ResetSystemIdleTimer();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            UIHandler.StartWait();
            timerResetIdleState.Enabled = false;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            m_bCancelado = true;
            lblFase.Text = "Cancelando...";
            pnlInfoTablas.Visible = false;
            pbAvanceTotal.Visible = false;
            btnCancelar.Enabled = false;
            Application.DoEvents();
            if (m_Thread != null && m_Thread.State != OpenNETCF.Threading.ThreadState.Stopped)
            {
                if (!(m_Thread.Join(5000)))
                {
                    try
                    {
                        m_Thread.Abort();
                    }
                    catch
                    {
                    }
                }
            }
            UIHandler.StartWait();
            timerResetIdleState.Enabled = false;
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void btnCerrarByError_Click(object sender, EventArgs e)
        {
            UIHandler.StartWait();
            timerResetIdleState.Enabled = false;
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public static void WriteLog(Exception ex)
        {
            // Se guarda la información del error en el archivo
            System.IO.StreamWriter stream = new System.IO.StreamWriter("\\ErroresIntegracion.TXT", true);
            System.Text.StringBuilder bld = new System.Text.StringBuilder();
            Exception inner = ex.InnerException;

            stream.WriteLine("==============================================================================");
            stream.WriteLine(System.DateTime.Now.ToString() + "Ha ocurrido una excepción: " + ex.GetType().FullName);
            stream.WriteLine(ex.Message);
            if (inner != null)
            {
                stream.WriteLine("Inner Exception: " + inner.ToString());
            }
            if (ex.GetType() == typeof(System.Data.SqlServerCe.SqlCeException))
            {
                System.Data.SqlServerCe.SqlCeException sqlex = null;
                //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                //			System.Data.SqlServerCe.SqlCeError err = null;
                sqlex = (System.Data.SqlServerCe.SqlCeException)ex;

                // Enumerate each error to a message box.
                foreach (System.Data.SqlServerCe.SqlCeError err in sqlex.Errors)
                {
                    stream.WriteLine(" Error Code: " + err.HResult.ToString("X"));
                    stream.WriteLine(" Message   : " + err.Message);
                    stream.WriteLine(" Minor Err.: " + err.NativeError);
                    stream.WriteLine(" Source    : " + err.Source);

                    // Retrieve the error parameter numbers for each error.
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //				int numPar = 0;
                    foreach (int numPar in err.NumericErrorParameters)
                    {
                        if (0 != numPar)
                        {
                            stream.WriteLine(" Num. Par. : " + numPar);
                        }
                    }

                    // Retrieve the error parameters for each error.
                    //INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
                    //				string errPar = null;
                    foreach (string errPar in err.ErrorParameters)
                    {
                        if (string.Empty != errPar)
                        {
                            bld.Append(("\r" + " Err. Par. : " + errPar));
                        }
                    }
                }
            }
            stream.WriteLine("Stack Trace: " + ex.StackTrace.ToString());
            stream.Close();
        }

        private void CargarImagenes()
        {
            System.Reflection.Assembly _assembly = System.Reflection.Assembly.GetExecutingAssembly();
            this.AnimateCtl1.Image = new System.Drawing.Bitmap(_assembly.GetManifestResourceStream("PraxairComunicaciones.Imagenes.AnimateCtl1.Image.jpg"));
        }

        /// <summary>
        /// Actualiza los envios de doumentos
        /// </summary>
        private void actualizarGuiaDocumento()
        {
            SqlCeCommand cmdActualizar = new SqlCeCommand();
            SqlCeConnection cnConection = new SqlCeConnection(m_sConexionLocal);
            string sSql = "";
            cnConection.Open();            
            foreach (DataRow fila in m_GuiaDocumentos.Rows)
            {
                cmdActualizar = new SqlCeCommand();
                cmdActualizar.Connection = cnConection;
                cmdActualizar.CommandType = CommandType.Text;
                sSql = "UPDATE GUIA_DOCUMENTO SET TRANSMITIDO_SN = 'S', HORA_TRANSMISION = GETDATE() WHERE ";
                sSql = sSql + " NUM_GUIA = " + fila["Num_Guia"];
                sSql = sSql + " AND PREFIJO_DOCUMENTO = " + fila["Prefijo_Documento"];
                sSql = sSql + " AND NUM_DOCUMENTO = " + fila["Num_Documento"];
                cmdActualizar.CommandText = sSql;
                cmdActualizar.ExecuteNonQuery();
            }
            cnConection.Close();
        }


        private void CargarGuiaDocumento()
        {
            SqlCeCommand cmdActualizar = new SqlCeCommand();
            SqlCeDataAdapter daConsulta;
            SqlCeConnection cnConection = new SqlCeConnection(m_sConexionLocal);
            string sSql = "";
            cnConection.Open();

            cmdActualizar = new SqlCeCommand();
            cmdActualizar.Connection = cnConection;
            cmdActualizar.CommandType = CommandType.Text;
            sSql = "SELECT  * FROM GUIA_DOCUMENTO WHERE TRANSMITIDO_SN = 'N'";
            cmdActualizar.CommandText = sSql;
            m_GuiaDocumentos = new DataTable();
            daConsulta = new SqlCeDataAdapter(cmdActualizar);
            daConsulta.Fill(m_GuiaDocumentos);

            cnConection.Close();
        }

        #region Miembros de IEstadoCarga

        public bool Cancelado
        {
            get { return m_bCancelado; }
        }

        public int ProgresoTabla
        {
            set
            {
                SetProgresoHandler funcHandler = new SetProgresoHandler(this.SetProgresoTotal);
                this.Invoke(funcHandler, value);
            }
        }

        public int ProgresoTotal
        {
            set
            {
                SetProgresoHandler funcHandler = new SetProgresoHandler(this.SetProgresoTotal);
                this.Invoke(funcHandler, value);
            }
        }

        public void IniciarTabla(string sNombreTabla)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(this.InternalIniciarTabla);
            this.Invoke(funcHandler, sNombreTabla);
        }

        private void InternalIniciarTabla(string sNombreTabla)
        {
            pbAvanceTabla.Value = 0;
            lblTabla.Text = "Procesando " + sNombreTabla;
        }

        private void SetProgresosTabla(int Progreso)
        {
            pbAvanceTabla.Value = Progreso;
        }

        private void SetProgresoTotal(int Progreso)
        {
            pbAvanceTotal.Value = Progreso;
        }

        public string ComprimirArchivos(string sDato)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            System.IO.MemoryStream rwEncriptar = DatascanCF.Compression.DataCompression.Compress(sDato);
            return Convert.ToBase64String(rwEncriptar.GetBuffer(), 0, Convert.ToInt32(rwEncriptar.Length));
        }

        #endregion
    }
}