using System;
using System.Data;

namespace TPV.Entidades
{
    public class Rubros
    {
        public Int32 Rubro_Id { get; set; }
        public string Rubro { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE rubros(rubro_id integer PRIMARY KEY, rubro VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE rubros(rubro_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, rubro VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Rubros GetRubro(Int32 Id)
        {
            Rubros oRub;
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT rubro_id, rubro FROM rubros WHERE rubro_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oRub = new Rubros();
                oRub.Rubro_Id = Convert.ToInt32(dt.Rows[0]["rubro_id"]);
                oRub.Rubro = dt.Rows[0]["rubro"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return oRub;
        }

        public DataTable GetRubros()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT *, (SELECT COUNT(*) FROM articulos WHERE rubro_id = rubros.rubro_id) AS total FROM rubros WHERE Borrado = 0 ORDER BY rubro_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Rubros oRubro)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oRubro.Rubro_Id == 0)
                    db.CreateCommand("INSERT INTO rubros(rubro) VALUES(@rubro)");
                else
                {
                    db.CreateCommand("UPDATE rubros SET rubro = @rubro WHERE rubro_id = @id");
                    db.AsignarParametroEntero("@id", oRubro.Rubro_Id);
                }

                db.AsignarParametroCadena("@rubro", oRubro.Rubro);
                db.ExecuteCommand();
                db.DisConnect();

                result = true;
            }
            catch (Exception)
            {
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
                db.CreateCommand("UPDATE rubros SET borrado = 1 WHERE rubro_id = @id");
                db.AsignarParametroEntero("@id", Id);
                db.ExecuteCommand();

                db.CreateCommand("UPDATE articulos SET rubro_id = 0 WHERE rubro_id = @id");
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
