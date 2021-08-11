using System;
using System.Data;
using System.Data.SQLite;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;

namespace TPV
{
    public class DbHelper
    {
        private static DbHelper oInstance = null;

        private DbConnection conexion = null;
        private DbCommand comando = null;
        private DbTransaction transaccion = null;
        private string conexionString;
        private static DbProviderFactory factory = null;

        private DbHelper()
        {
            if (this.conexion == null || this.conexion.State.Equals(ConnectionState.Closed))
                setConfiguration();
        }

        public static DbHelper getDbHelper()
        {
            if (oInstance == null)
                oInstance = new DbHelper();

            return oInstance;
        }

        private void setConfiguration()
        {
            try
            {
                if (GlobalVar.isTrial)
                {
                    this.conexionString = "Data Source = db.sqlite; Version = 3;";
                    DbHelper.factory = SQLiteFactory.Instance;
                }
                else
                {
                    string server = Properties.Settings.Default.DB_Server;
                    string user = Properties.Settings.Default.DB_User;
                    string pwd = Properties.Settings.Default.DB_Pwd;
                    string port = Properties.Settings.Default.DB_Port;

                    this.conexionString = String.Format("server={0};port={1};uid={2};pwd={3};database=db;", server, port, user, pwd);
                    DbHelper.factory = MySqlClientFactory.Instance;
                }
            }
            catch (DataException ex)
            {
                throw ex;
            }
        }

        public Boolean ExistMySqlDataBase()
        {
            try
            {
                this.setConfiguration();
                this.Connect();
                this.DisConnect();

                return true;
            }
            catch { return false; }
        }

        public Boolean Connect(string server, string user, string pwd, string port)
        {
            string stringCon = String.Format("server={0};port={1};uid={2};pwd={3};", server, port, user, pwd);

            try
            {
                MySqlConnection con = new MySqlConnection(stringCon);
                con.Open();
                con.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void CreateDataBase()
        {
            try
            {
                if(GlobalVar.isTrial)
                    SQLiteConnection.CreateFile("db.sqlite");
                else
                {
                    string server = Properties.Settings.Default.DB_Server;
                    string user = Properties.Settings.Default.DB_User;
                    string pwd = Properties.Settings.Default.DB_Pwd;
                    string port = Properties.Settings.Default.DB_Port;

                    string stringCon = String.Format("server={0};port={1};uid={2};pwd={3};", server, port, user, pwd);

                    MySqlConnection con = new MySqlConnection(stringCon);
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("CREATE DATABASE IF NOT EXISTS `db`", con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (DataException ex)
            {

                throw ex;
            }
        }

        public void Connect()
        {
            if (this.conexion != null && !this.conexion.State.Equals(ConnectionState.Closed))
                throw new Exception("La conexion se encuentra abierta");
            else
            {
                try
                {
                    if (this.conexion == null)
                    {
                        this.conexion = factory.CreateConnection();
                        this.conexion.ConnectionString = this.conexionString;
                    }

                    this.conexion.Open();
                }
                catch (DataException ex)
                {

                    throw ex;
                }
            }
        }

        public void CreateCommand(string sql)
        {
            this.comando = factory.CreateCommand();
            this.comando.Connection = this.conexion;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = sql;

            if (this.transaccion != null)
                this.comando.Transaction = this.transaccion;
        }

        private void AsignarParametro(string nombre, string separador, string valor)
        {
            int indice = this.comando.CommandText.IndexOf(nombre);
            string prefijo = this.comando.CommandText.Substring(0, indice);
            string sufijo = this.comando.CommandText.Substring(indice + nombre.Length);

            this.comando.CommandText = String.Format("{0}{1}{2}{3}{4}", prefijo, separador, valor, separador, sufijo);
        }

        public void AsignarParametroCadena(string nombre, string valor)
        {
            AsignarParametro(nombre, "'", valor.ToString().Replace("'", "''"));
        }

        public void AsignarParametroEntero(string nombre, int valor)
        {
            AsignarParametro(nombre, "", valor.ToString());
        }

        public void AsignarParametroDecimal(string nombre, decimal valor)
        {
            AsignarParametro(nombre, "", valor.ToString().Replace(",", "."));
        }

        public void AsignarParametroDouble(string nombre, double valor)
        {
            AsignarParametro(nombre, "", valor.ToString().Replace(",", "."));
        }

        public void AsignarParametroFecha(string nombre, DateTime valor)
        {
            AsignarParametro(nombre, "'", valor.ToString("yyyy-MM-dd HH:mm"));
        }

        public void AsignarParametroNulo(string nombre)
        {
            AsignarParametro(nombre, "", "NULL");
        }

        public int EjecutarScalar()
        {
            int escalar = 0;
            try
            {
                if (GlobalVar.isTrial)
                {
                    this.ExecuteCommand();
                    this.CreateCommand("select last_insert_rowid()");
                    escalar = int.Parse(this.comando.ExecuteScalar().ToString());
                }
                else
                { 
                    this.comando.CommandText = String.Format("{0} {1}", this.comando.CommandText, "SELECT @@IDENTITY");

                    escalar = int.Parse(this.comando.ExecuteScalar().ToString());
                }
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }

            return escalar;
        }

        public void ExecuteCommand()
        {
            try
            {
                this.comando.ExecuteNonQuery();
            }
            catch (DbException ex)
            {
                throw ex;
            }

        }

        public DataTable GetDataTable()
        {
            DbDataAdapter adapter = factory.CreateDataAdapter();
            DataTable dt = new DataTable();

            adapter.SelectCommand = this.comando;
            adapter.SelectCommand.CommandText = this.comando.CommandText;
            adapter.SelectCommand.Connection = this.comando.Connection;

            try
            {
                adapter.Fill(dt);
                dt.EndLoadData();
            }
            catch (DbException ex)
            {

                throw ex;
            }

            return dt;
        }

        public void DisConnect()
        {
            if (this.conexion.State.Equals(ConnectionState.Open))
                this.conexion.Close();
        }

        public void Begin()
        {
            if (this.transaccion == null)
                this.transaccion = this.conexion.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void RollBack()
        {
            if (this.transaccion != null)
            {
                CreateCommand("ROLLBACK");
                ExecuteCommand();
            }
        }

        public void Commit()
        {
            if (this.transaccion != null)
            {
                CreateCommand("COMMIT");
                ExecuteCommand();
            };
        }

        public void Backup()
        {
            string constring = this.conexionString;

            constring += "charset=utf8;convertzerodatetime=true;";

            string file =  "backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();



                        UploadFileToFTP(file);
                    }
                }
            }
        }

        private static void UploadFileToFTP(string source)
        {
            try
            {
                string filename = Path.GetFileName(source);
                string ftpfullpath = "ftp://31.170.167.34//" + source;
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(ftpfullpath);
                ftp.Credentials = new NetworkCredential("u459445069.mercado", "722633");

                ftp.KeepAlive = true;
                ftp.UseBinary = true;
                ftp.Method = WebRequestMethods.Ftp.UploadFile;

                FileStream fs = File.OpenRead(source);
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                fs.Close();

                Stream ftpstream = ftp.GetRequestStream();
                ftpstream.Write(buffer, 0, buffer.Length);
                ftpstream.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
