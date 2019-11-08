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
using DatascanCF.Data;
using DatascanCF.Compression;


namespace PraxairComunicaciones.Comunicacion
{
    internal partial class CargaDatosForm : Form, DatascanCF.Data.DataSetSerializer.IEstadoCarga
    {
        //private QuickMobile.Client.WSComunicaciones.DataAccess m_ws;
        private WSPraxair.DataAccess m_ws;
        private OpenNETCF.Threading.Thread2 m_Thread;
        private string m_sData = null;
        private bool m_bCancelado = false;
        private delegate void ActualizarMensajeHandler(string sData);
        private delegate void SetProgresoHandler(int Progreso);
        private bool m_bCerrarVentana = false;        
        private ParametrosWS m_rwParametros;
        private static ConfiguracionServidorWS m_ConfiguracionWS;
        private string m_sConexionLocal = null;

        public CargaDatosForm()
        {
            InitializeComponent();
        }

        public static void ConfiguracionServidorWS(string pIPServidor, string pPuertoServidor, string pVirtualDirectory, string pUsuarioWebService, string pClaveWebService, int pTimeOutWebServices, string pIPServidorGPRS)
        {
            m_ConfiguracionWS = new ConfiguracionServidorWS(pIPServidor, pPuertoServidor, pVirtualDirectory, pUsuarioWebService, pClaveWebService, pTimeOutWebServices,pIPServidorGPRS );
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
            
            // Controlar las Excepciones
            try
            {
                
                // Se crea la instancia de la forma y se inicia el proceso
                CargaDatosForm frm = new CargaDatosForm();
                frm.m_rwParametros = new ParametrosWS(sPrograma, sProceso, sIdTerminal, sIdSistema, bComprimir, bUpdateCurrentRows, bUsarGPRS, sNombreProceso, sConexionGPRS, ListQuery, rParametros);
                frm.m_bCerrarVentana = bCerrarVentana;
                frm.m_sConexionLocal = sConexionLocal;
                result = (UIHandler.ShowDialog(frm) == System.Windows.Forms.DialogResult.OK);
                //result = (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK);
                frm.Dispose();
                // Finalmente se cierra la conexión
                if (bUsarGPRS)
                {
                    GPRS.Desconectar();
                }
                return result;
            }
            catch
            {
                return false;
            }
            finally
            {
                UIHandler.EndWait();
            }
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
                SetProgresoHandler funcHandler = new SetProgresoHandler(this.SetProgresosTabla);
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

        #endregion

        public static  bool usarGprsf( string sConexionGPRS)
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
                return false;
            }
            catch(Exception ex)
            {                
                return true;
            }
        }

        private void CargaDatosForm_Load(object sender, EventArgs e)
        {
            // Se inicializan controles
            UiHandler1.Parent = this;
            pnlInfoTablas.Visible = false;
            this.lblProceso.Text = this.m_rwParametros.DescripcionProceso;

            // Se inicia el hilo de ejecución de la integración de datos y se habilita el timer
            // de reset de estado Idle del sistema
            timerResetIdleState.Enabled = true;
            m_Thread = new OpenNETCF.Threading.Thread2(IntegrarDatosThread);
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
                
                m_ws.ConnectionGroupName = this.m_rwParametros.ConexionGPRS  ;

                //int index = 0;
                //index = m_ConfiguracionWS.IPServidorGprs.IndexOf("http");
                //if (index < 0)
                    m_ws.Url = "http://" + m_ConfiguracionWS.IPServidorGprs   + ":" + m_ConfiguracionWS.PuertoServidor + "/" + m_ConfiguracionWS.VirtualDirectory + "/DataAccess.asmx";
                //else
                //    m_ws.Url = m_ConfiguracionWS.IPServidorGprs + ":" + m_ConfiguracionWS.PuertoServidor + "/" + m_ConfiguracionWS.VirtualDirectory + "/DataAccess.asmx";
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

        private void IntegrarDatosThread()
        {
            string sFecha = null;
            try
            {
                IniciarObtenerDatos("Obteniendo datos del servidor...");
                ConfigurarWebService();                
                // Se sincroniza la hora del sistema con la hora del servidor
                m_ws.Timeout = 10000;
                sFecha = m_ws.GetFechaSistema();
                DateTimeHelper.LocalTime = DateTime.ParseExact(sFecha, "dd/MM/yyyy HH:mm:ss", null);
                m_ws.Timeout = m_ConfiguracionWS.TimeOutWebServices;
                m_ConfiguracionWS.TimeOutWebServices = m_ws.Timeout;
                string sIdComunicaciones = "";
                //m_sData = m_ws.CargarDatos(m_rwParametros.Programa, m_rwParametros.Proceso, m_rwParametros.IdTerminal, m_rwParametros.IdSistema, m_rwParametros.Comprimir, ref sIdComunicaciones, m_rwParametros.Parametros);
                m_sData = m_ws.GetDatosCarga(m_rwParametros.IdTerminal, m_rwParametros.Proceso, m_rwParametros.Programa);
                m_rwParametros.IdComunicaciones = sIdComunicaciones;
                
                IniciarIntegracionDatos("Integrando datos...");
                if (!this.Cancelado)
                {
                    //m_GestorIntegracion.LoadPrimaryKeysInfo();
                    DataSetSerializer dsDatos = new DataSetSerializer(new DatascanCF.Data.SqlServerCe.GestorDatosBase(m_sConexionLocal));                    
                     
                    if (m_rwParametros.Comprimir)
                    {
                        string datos;
                        //datos = DatascanCF.Compression.DataCompression.UnCompress(Convert.FromBase64String(m_sData), Convert.FromBase64String(m_sData).Length);
                        //DateTime.ParseExact("2010/06/16 00:00:00", "yyyy/MM/dd hh:mm:ss", null);
                       
                        dsDatos.SaveCompressToDatabase(this.m_sData, m_rwParametros.UpdateCurrentRows, this, null);
                    }
                    else
                    {
                        dsDatos.SaveToDatabase(this.m_sData, m_rwParametros.UpdateCurrentRows, this, null);                    
                    }                                        
                }
                m_ws.ConfirmarCarga(m_rwParametros.IdTerminal, m_rwParametros.Proceso, m_rwParametros.Programa);
                MostrarProcesoTerminado("Proceso de carga de datos terminado exitosamente");
            }
            catch (Exception ex)
            {
                if (m_rwParametros.IdComunicaciones != null)
                {
                    //CONTROLAR POR QUE EL CATCH PUEDE SER POR COMUNICACION Y SE BLOQUEA
                    try
                    {
                        m_ws.ConfirmarCarga(m_rwParametros.IdTerminal, m_rwParametros.Proceso, m_rwParametros.Programa);
                    }
                    catch (Exception ex2)
                    {
                        WriteLog(ex2);
                    }
                }
                MostrarError(ex.GetType().ToString() + "\r\n" + ex.Message);
                WriteLog(ex);
            }
        }

        private void InternalMostrarProcesoTerminado(string sMensaje)
        {
            pnlInfoTablas.Visible = false;
            pnlTerminado.Visible = true;
            pnlTerminado.BringToFront();
            lblMensajeFinal.Text = sMensaje;
            btnTerminar.Focus();
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

        private void IniciarIntegracionDatos(string sMensaje)
        {
            ActualizarMensajeHandler funcHandler = new ActualizarMensajeHandler(InternalIniciarIntegracionDatos);
            this.Invoke(funcHandler, sMensaje);
        }

        private void InternalIniciarObtenerDatos(string sMensaje)
        {
            lblFase.Text = sMensaje;
            pnlInfoTablas.Visible = false;
            pnlObtenerDatos.Visible = true;
            AnimateCtl1.StartAnimation();
        }

        private void InternalIniciarIntegracionDatos(string sMensaje)
        {
            lblFase.Text = sMensaje;
            AnimateCtl1.StopAnimation();
            pnlObtenerDatos.Visible = false;
            pnlInfoTablas.Visible = true;
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
            btnCerrarByError.Focus();
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

    }
}