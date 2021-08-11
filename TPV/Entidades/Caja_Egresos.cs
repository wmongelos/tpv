using System;
using System.Data;

namespace TPV.Entidades
{
    class Caja_Egresos
    {
        public Int32 Caja_Egreso_Id { get; set; }
        public string Descripcion { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE caja_egresos(caja_egreso_id integer PRIMARY KEY, descripcion VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE caja_egresos(caja_egreso_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, descripcion VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Caja_Egresos GetCaja_Egresos(Int32 Id)
        {
            Caja_Egresos oEgreso;
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT caja_egreso_id, descripcion FROM caja_egresos WHERE caja_egreso_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oEgreso = new Caja_Egresos();
                oEgreso.Caja_Egreso_Id = Convert.ToInt32(dt.Rows[0]["caja_egreso_id"]);
                oEgreso.Descripcion = dt.Rows[0]["descripcion"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return oEgreso;
        }

        public DataTable GetCaja_Egresos()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM caja_egresos WHERE Borrado = 0 ORDER BY caja_egreso_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Caja_Egresos oEgreso)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oEgreso.Caja_Egreso_Id == 0)
                    db.CreateCommand("INSERT INTO caja_egresos(descripcion) VALUES(@descrip)");
                else
                {
                    db.CreateCommand("UPDATE caja_egresos SET descripcion = @descrip WHERE caja_egreso_id = @id");
                    db.AsignarParametroEntero("@id", oEgreso.Caja_Egreso_Id);
                }

                db.AsignarParametroCadena("@descrip", oEgreso.Descripcion);
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
                db.CreateCommand("UPDATE caja_egresos SET borrado = 1 WHERE caja_egreso_id = @id");
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
