using System;
using System.Data;

namespace TPV.Entidades
{
    public class Impresoras
    {
        public Int32 Impresora_Id { get; set; }
        public String Nombre { get; set; }
        public String Impresora { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE impresoras(impresora_id integer PRIMARY KEY, nombre VARCHAR(50) NOT NULL, impresora VARCHAR(50) NOT NULL DEFAULT '', borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE impresoras(impresora_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, nombre VARCHAR(50) NOT NULL, impresora VARCHAR(50) DEFAULT '', borrado integer DEFAULT 0);");

                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO impresoras(nombre) VALUES('NINGUNA')");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO impresoras(nombre) VALUES('PANTALLA')");
                db.ExecuteCommand();

                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Impresoras GetImpresora(Int32 Id)
        {
            Impresoras oImp = new Impresoras();
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT impresora_id, nombre, impresora FROM impresoras WHERE impresora_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                if(dt.Rows.Count > 0)
                { 
                    oImp.Nombre = dt.Rows[0]["nombre"].ToString();
                    oImp.Impresora_Id = Convert.ToInt32(dt.Rows[0]["impresora_id"]);
                    oImp.Impresora = dt.Rows[0]["impresora"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return oImp;
        }

        public DataTable GetImpresoras()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();

                db.CreateCommand("SELECT *, (SELECT COUNT(*) FROM articulos WHERE impresora_id = impresoras.impresora_id) AS total FROM impresoras WHERE Borrado = 0 ORDER BY impresora_id DESC");

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Impresoras oImpresora)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oImpresora.Impresora_Id == 0)
                    db.CreateCommand("INSERT INTO impresoras(nombre, impresora) VALUES(@nom, @impr)");
                else
                {
                    db.CreateCommand("UPDATE impresoras SET nombre = @nom, impresora = @impr WHERE impresora_id = @id");
                    db.AsignarParametroEntero("@id", oImpresora.Impresora_Id);
                }

                db.AsignarParametroCadena("@nom", oImpresora.Nombre);
                db.AsignarParametroCadena("@impr", oImpresora.Impresora);

              //  db.Begin();
                db.ExecuteCommand();
              //  db.Commit();
                db.DisConnect();

                result = true;
            }
            catch (Exception)
            {
                //db.RollBack();
                db.DisConnect();
                throw;
            }

            return result;
        }

        public void Delete(Int32 Id)
        {
            try
            {
                db.Connect();
                db.CreateCommand("UPDATE impresoras SET borrado = 1 WHERE impresora_id = @id");
                db.AsignarParametroEntero("@id", Id);
                db.ExecuteCommand();

                db.CreateCommand("UPDATE articulos SET impresora_id = 0 WHERE impresora_id = @id");
                db.AsignarParametroEntero("@id", Id);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
