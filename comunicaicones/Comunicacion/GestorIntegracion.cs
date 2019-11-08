using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using DatascanCF.Data.SqlServerCe;
using System;

namespace QuickMobile.Client.Comunicacion
{
    public class GestorIntegracion : DatascanCF.Data.SqlServerCe.GestorDatosBase
    {

        #region  Funciones utilizadas para la integración de datos

        public GestorIntegracion(string sConexion)
            : base()
        {
            this.ConnectionString = sConexion;            
        }

        // Permite realizar la integración de datos de a partir de un dataset serializado
        // El dataset debe contener tablas con nombres y campos iguales a los creados en la base de
        // datos
        public bool IntegrarDatos(string sSerializedData, bool bUpdateCurrentRows, IEstadoCarga Estado)
        {
            StringReader sr = new StringReader(sSerializedData);
            string sLine = null;
            string[] sFields = null;
            string[] sFieldsTypes = null;
            string[] sValues = null;
            SqlCeResultSet rs = null;
            SqlCeUpdatableRecord record = null;
            int I = 0;
            int J = 0;
            int nIndex = 0;
            int nTableCount = 0;
            int nRowCount = 0;
            int nTotalRowCount = 0;
            int nTables = 0;
            int nRows = 0;
            int nTotalRows = 0;
            int nProgresoTabla = 0;
            int nProgresoTotal = 0;
            DataTable dtNucleo = null;
            DataRow row = null;
            object FieldValue = null;
            try
            {
                // Se lee la liena con el número de tablas serializadas y el numero total de filas a procesar
                sLine = sr.ReadLine();
                nTableCount = System.Convert.ToInt32(sLine.Substring(12));
                sLine = sr.ReadLine();
                nTotalRowCount = System.Convert.ToInt32(sLine.Substring(15));
                nProgresoTotal = 0;
                nTables = 0;
                nTotalRows = 0;

                this.OpenConnection();

                while (!Estado.Cancelado)
                {
                    // Se obtiene el nombre y cantidad de registros de cada tabla serializada
                    string sTableName = null;
                    sLine = sr.ReadLine();
                    if (sLine == null)
                    {
                        break;
                    }
                    sTableName = sLine.Substring(7);
                    sLine = sr.ReadLine();
                    nRowCount = System.Convert.ToInt32(sLine.Substring(10));
                    if (nRowCount > 0)
                    {

                        nProgresoTabla = 0;
                        nRows = 0;

                        Estado.IniciarTabla(sTableName);

                        // Se revisa si es una tabla del nucleo y se actualiza
                        // Revisar esto
                        dtNucleo = null;
                        

                        if (bUpdateCurrentRows)
                        {
                            // Se filtra la información del indice de llave primario, para la busqueda de
                            // de las filas actuales
                            m_dvPK.RowFilter = "TABLE_NAME = '" + sTableName + "'";
                        }
                        else
                        {
                            // Si es una tabla del nucleo si eliminan las filas actuales
                            if (dtNucleo != null)
                            {
                                dtNucleo.Rows.Clear();
                            }
                        }


                        // Se obtiene el objeto ResultSet por medio del cual se hará la actualización
                        // especificando el indice de llave primaria de la tabla
                        SqlCeCommand cmd = new SqlCeCommand();
                        cmd.Connection = (SqlCeConnection)this.Connection;
                        cmd.CommandType = CommandType.TableDirect;
                        cmd.CommandText = sTableName;
                        if (bUpdateCurrentRows)
                        {
                            cmd.IndexName = System.Convert.ToString(m_dvPK[0]["CONSTRAINT_NAME"]);
                            rs = cmd.ExecuteResultSet(ResultSetOptions.Updatable | ResultSetOptions.Sensitive | ResultSetOptions.Scrollable);
                        }
                        else
                        {
                            rs = cmd.ExecuteResultSet(ResultSetOptions.Updatable);
                        }

                        // se obtienen los nombres de los campos
                        sLine = sr.ReadLine();
                        sFields = sLine.Split('|');

                        // se obtienen los tipos de datos de las columnas
                        sLine = sr.ReadLine();
                        sFieldsTypes = sLine.Split('|');

                        // Se procesa cada fila que venga serializada en la cadena
                        sLine = sr.ReadLine();

                        bool bInsertRecord = false;

                        while ((sLine != null) & (!Estado.Cancelado))
                        {
                            if (sLine.Trim() == string.Empty)
                            {
                                break;
                            }

                            // Se obtienen los valores que vienen en el registro
                            sValues = sLine.Split('|');

                            // Se obtienen los valores de llave primaria del registro
                            // Se crea la matriz de objetos para guardar los valores de la llave primaria de cada registro
                            bInsertRecord = true;
                            if (bUpdateCurrentRows)
                            {

                                // Se obtiene la llave primaria del registro
                                object[] RecordKey = new object[m_dvPK.Count];
                                for (I = 0; I < m_dvPK.Count; I++)
                                {
                                    for (J = 0; J < sFields.GetUpperBound(0); J++)
                                    {
                                        if (System.Convert.ToString(m_dvPK[I]["COLUMN_NAME"]).ToUpper() == sFields[J])
                                        {
                                            RecordKey[I] = GetColumnValue(sFieldsTypes[J], sValues[J]);
                                        }
                                    }
                                }

                                // se busca el registro actual y luego se actualizan los datos
                                // si no se encuentra se inserta un nuevo registro
                                if (rs.Seek(DbSeekOptions.FirstEqual, RecordKey))
                                {
                                    bInsertRecord = false;

                                    // Se obtiene la fila a modificar
                                    rs.Read();
                                    if (dtNucleo != null)
                                    {
                                        row = dtNucleo.Rows.Find(RecordKey);
                                    }

                                    // Se actualizan los valores de cada columna en el registro en la base de datos y si
                                    // se esta procesando una tabla del nucleo tambien se actualiza en memoria
                                    if (dtNucleo != null && row != null)
                                    {
                                        for (I = 0; I < sFields.GetUpperBound(0); I++)
                                        {
                                            try
                                            {
                                                nIndex = rs.GetOrdinal(sFields[I]);
                                                FieldValue = GetColumnValue(rs.GetFieldType(nIndex).ToString(), sValues[I]);
                                                rs.SetValue(nIndex, FieldValue);
                                                nIndex = row.Table.Columns.IndexOf(sFields[I]);
                                                if (nIndex >= 0)
                                                {
                                                    row[nIndex] = FieldValue;
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                throw new InvalidOperationException("Field: " + sFields[I] + "\r\n" + "Type: " + rs.GetFieldType(nIndex).ToString() + "\r\n" + "Value: " + sValues[I] + "\r\n" + ex.Message);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (I = 0; I < sFields.GetUpperBound(0); I++)
                                        {
                                            try
                                            {
                                                nIndex = rs.GetOrdinal(sFields[I]);
                                                FieldValue = GetColumnValue(rs.GetFieldType(nIndex).ToString(), sValues[I]);
                                                rs.SetValue(nIndex, FieldValue);
                                            }
                                            catch (Exception ex)
                                            {
                                                throw new InvalidOperationException("Field: " + sFields[I] + "\r\n" + "Type: " + rs.GetFieldType(nIndex).ToString() + "\r\n" + "Value: " + sValues[I] + "\r\n" + ex.Message);
                                            }
                                        }
                                    }
                                    rs.Update();
                                }
                            }
                            if (bInsertRecord)
                            {
                                // Se crea el nuevo registro
                                record = rs.CreateRecord();
                                if (dtNucleo != null)
                                {
                                    row = dtNucleo.NewRow();
                                }
                                else
                                {
                                    row = null;
                                }

                                // Se actualizan los valores de cada columna en el registro
                                if (dtNucleo != null && row != null)
                                {
                                    for (I = 0; I < sFields.GetUpperBound(0); I++)
                                    {
                                        try
                                        {
                                            nIndex = rs.GetOrdinal(sFields[I]);
                                            FieldValue = GetColumnValue(rs.GetFieldType(nIndex).ToString(), sValues[I]);
                                            record.SetValue(nIndex, FieldValue);
                                            nIndex = row.Table.Columns.IndexOf(sFields[I]);
                                            if (nIndex >= 0)
                                            {
                                                row[nIndex] = FieldValue;
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new InvalidOperationException("Field: " + sFields[I] + "\r\n" + "Type: " + rs.GetFieldType(nIndex).ToString() + "\r\n" + "Value: " + sValues[I] + "\r\n" + ex.Message);
                                        }
                                    }
                                }
                                else
                                {
                                    for (I = 0; I < sFields.GetUpperBound(0); I++)
                                    {
                                        try
                                        {
                                            nIndex = rs.GetOrdinal(sFields[I]);
                                            FieldValue = GetColumnValue(rs.GetFieldType(nIndex).ToString(), sValues[I]);
                                            record.SetValue(nIndex, FieldValue);
                                        }
                                        catch (Exception ex)
                                        {
                                            throw new InvalidOperationException("Field: " + sFields[I] + "\r\n" + "Type: " + rs.GetFieldType(nIndex).ToString() + "\r\n" + "Value: " + sValues[I] + "\r\n" + ex.Message);
                                        }
                                    }
                                }

                                // Se almacena el nuevo registro
                                try
                                {
                                    rs.Insert(record, DbInsertOptions.KeepCurrentPosition);
                                    if (dtNucleo != null && row != null)
                                    {
                                        dtNucleo.Rows.Add(row);
                                        row.AcceptChanges();
                                    }
                                }
                                catch (Exception ex)
                                {
                                    object[] values = new object[rs.FieldCount + 1];
                                    record.GetValues(values);
                                    throw ex;
                                }

                            }


                            // Se registra el avance de la tabla
                            nRows += 1;
                            nTotalRows += 1;
                            if ((nRows % 100) == 0 || nRows == nRowCount)
                            {
                                Estado.ProgresoTabla = System.Convert.ToInt32((nRows * 100 / nRowCount));
                                Estado.ProgresoTotal = System.Convert.ToInt32(nTotalRows * 100 / nTotalRowCount);
                            }

                            // Se se lee el siguiente registro
                            sLine = sr.ReadLine();
                        }
                        rs.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;                
            }
            finally
            {
                if (rs != null)
                {
                    if (!rs.IsClosed)
                    {
                        rs.Close();
                        rs = null;
                    }
                }
                this.CloseConnection();
                sr.Close();
            }
            return true;
        }

        public string GetSerializedData(ListQuerysDescarga QueryList, IEstadoCarga Estado)
        {
            StringBuilder sb = new StringBuilder();
            SqlCeDataReader dr = null;
            SqlCeCommand cmd = new SqlCeCommand();
            int I = 0;
            int J = 0;
            int nIndexRowCountReplace = 0;
            int nTableCount = 0;
            int nRowCount = 0;
            int nTotalRowsCount = 0;

            // Se adicionan las 2 primeras lineas con tags para poder remplazarlos al final
            sb.Append("TABLECOUNT: <<TABLECOUNT>>" + "\r\n");
            sb.Append("TOTALROWCOUNT: <<TOTALROWCOUNT>>" + "\r\n");
            nTableCount = 0;
            nTotalRowsCount = 0;
            try
            {
                this.OpenConnection();
                for (I = 0; I < QueryList.Count; I++)
                {
                    if (Estado.Cancelado)
                    {
                        break;
                    }
                    Estado.IniciarTabla(QueryList[I].TableName.ToUpper());
                    cmd.Connection = (SqlCeConnection)this.Connection;
                    cmd.CommandText = QueryList[I].Query;
                    if (cmd.CommandText.StartsWith("SELECT", StringComparison.CurrentCultureIgnoreCase))
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.TableDirect;
                    }
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        nTableCount += 1;
                        sb.Append("TABLE: " + QueryList[I].TableName + "\r\n");
                        nIndexRowCountReplace = sb.Length;
                        sb.Append("ROWCOUNT: <<ROWCOUNT>> " + "\r\n");

                        // Se agrega una primer linea con los nombres de los campos
                        for (J = 0; J < dr.FieldCount; J++)
                        {
                            sb.Append(dr.GetName(J) + "|");
                        }
                        sb.Append("\r\n");

                        // Se agrega una segunda linea con los tipos de datos
                        for (J = 0; J < dr.FieldCount; J++)
                        {
                            sb.Append(dr.GetFieldType(J).ToString() + "|");
                        }
                        sb.Append("\r\n");

                        // Se agregan lineas con los datos de todos los registros
                        nRowCount = 0;
                        do
                        {
                            if (Estado.Cancelado)
                            {
                                break;
                            }
                            for (J = 0; J < dr.FieldCount; J++)
                            {
                                if (dr.IsDBNull(J))
                                {
                                    sb.Append("(null)|");
                                }
                                else
                                {
                                    if (dr.GetFieldType(J) == typeof(System.DateTime))
                                    {
                                        sb.Append(dr.GetDateTime(J).ToString("yyyy/MM/dd HH:mm:ss") + "|");
                                    }
                                    else
                                    {
                                        sb.Append(System.Convert.ToString(dr.GetValue(J)) + "|");
                                    }
                                }
                            }
                            sb.Append("\r\n");
                            nRowCount += 1;
                            nTotalRowsCount += 1;
                        } while (dr.Read());
                        dr.Close();
                        sb.Replace("<<ROWCOUNT>>", nRowCount.ToString(), nIndexRowCountReplace, 40);
                        sb.Append("\r\n"); // Se agrega una linea adicional para delimitar los datos de la tabla
                    }
                }
                sb.Replace("<<TABLECOUNT>>", nTableCount.ToString(), 0, 40);
                if (sb.Length < 60)
                {
                    sb.Replace("<<TOTALROWCOUNT>>", nTotalRowsCount.ToString(), 0, sb.Length);
                }
                else
                {
                    sb.Replace("<<TOTALROWCOUNT>>", nTotalRowsCount.ToString(), 0, 60);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open)
                {
                    this.CloseConnection();
                }                
            }
            return sb.ToString();
        }

        private object GetColumnValue(string sFieldType, string sValue)
        {
            if (sValue == "(null)")
            {
                return DBNull.Value;
            }
            else
            {
                switch (sFieldType)
                {
                    case "System.DateTime":
                        return DateTime.ParseExact(sValue, "yyyy/MM/dd HH:mm:ss", null);
                    case "System.Int32":
                        return Int32.Parse(sValue);
                    case "System.Int16":
                        return Int16.Parse(sValue);
                    default:
                        return sValue;
                }
            }
        }

        // Function utilitaria utilizada por la función de integración para llenar los parametros
        // de un objeto SqlCommand obtenido de un datadapter
        protected static void FillParameters(SqlCeCommand cmd, DataRow row)
        {
            int I = 0;
            for (I = 0; I < cmd.Parameters.Count; I++)
            {
                cmd.Parameters[I].Value = row[cmd.Parameters[I].SourceColumn];
            }
        }

        public bool EliminarDatosDescarga(ListQuerysDescarga QueryList)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            int I = 0;
            try
            {
                this.OpenConnection();
                for (I = 0; I < QueryList.Count; I++)
                {
                    cmd.Connection = (SqlCeConnection)this.Connection;
                    cmd.CommandText = QueryList[I].Query;
                    if (cmd.CommandText.StartsWith("DELETE", StringComparison.CurrentCultureIgnoreCase))
                    {
                        cmd.CommandType = CommandType.Text;
                    }
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (this.Connection.State == ConnectionState.Open)
                {
                    this.CloseConnection();
                }
            }            
        }
        #endregion

        #region "Codigo Del gestor Base"
        internal DataTable m_dtPK = null;
        internal DataView m_dvPK = null;

        public void LoadPrimaryKeysInfo()
        {
            // Se obtiene la información de los indices de llave primaria de las tablas en 
            // la base de datos
            OpenConnection();
            SqlCeDataAdapter daIndices = new SqlCeDataAdapter();
            m_dtPK = new DataTable();
            daIndices.SelectCommand = new SqlCeCommand();
            daIndices.SelectCommand.Connection = (SqlCeConnection)this.Connection;
            daIndices.SelectCommand.CommandType = CommandType.Text;
            daIndices.SelectCommand.CommandText = " SELECT TABLE_NAME, CONSTRAINT_NAME, COLUMN_NAME, ORDINAL_POSITION " + " FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE " + " WHERE CONSTRAINT_NAME LIKE 'PK%' ORDER BY TABLE_NAME, ORDINAL_POSITION";
            daIndices.Fill(m_dtPK);
            m_dtPK.TableName = "Indices";
            m_dvPK = new DataView(m_dtPK);
            CloseConnection();
        }

        public string GetPrimaryKey(string sTableName)
        {
            m_dvPK.RowFilter = "TABLE_NAME = '" + sTableName + "'";
            return System.Convert.ToString(m_dvPK[0]["CONSTRAINT_NAME"]);
        }
        #endregion
    }
}