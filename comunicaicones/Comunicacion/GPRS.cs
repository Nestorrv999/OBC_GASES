using OpenNETCF.Net;
using DatascanCF.Windows.Forms;
using System;

namespace PraxairComunicaciones
{
    internal class GPRS
    {
        public  static ConnectionManager m_cm;

        public static bool Conectar(string sConexionGPRS)
        {
            OpenNETCF.Net.DestinationInfoCollection diList;
            m_cm = new ConnectionManager();            
            try
            {
                
                diList = m_cm.EnumDestinations();
                foreach(DestinationInfo di in diList)
                {
                    if (di.Description == sConexionGPRS)
                    {                        
                        m_cm.Connect(di.Guid, false, ConnectionMode.Synchronous);
                        return true;
                    }
                }
                UIHandler.ShowError("La conexión a GPRS, no esta configurada");
                return false;
            }
            catch (Exception ex)
            {
                UIHandler.ShowError(ex.Message, "Error estableciendo conexión");
                Desconectar();
                return false;
            }
        }

        public static void Desconectar()
        {
            if (m_cm != null & m_cm.Status == ConnectionStatus.Connected)
            {
                m_cm.RequestDisconnect();
                m_cm = null;
            }
        }
    }
}
