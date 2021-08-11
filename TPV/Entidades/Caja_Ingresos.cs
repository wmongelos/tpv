using System;
using System.Data;

namespace TPV.Entidades
{
    class Caja_Ingresos
    {
        public Int32 Caja_Ingreso_Id { get; set; }
        public string Descripcion { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE caja_ingresos(caja_ingreso_id integer PRIMARY KEY, descripcion VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE caja_ingresos(caja_ingreso_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, descripcion VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Caja_Ingresos GetCaja_Ingresos(Int32 Id)
        {
            Caja_Ingresos oIngreso;
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT caja_ingreso_id, descripcion FROM caja_ingresos WHERE caja_ingreso_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oIngreso = new Caja_Ingresos();
                oIngreso.Caja_Ingreso_Id = Convert.ToInt32(dt.Rows[0]["caja_ingreso_id"]);
                oIngreso.Descripcion = dt.Rows[0]["descripcion"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return oIngreso;
        }

        public DataTable GetCaja_Ingresos()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM caja_ingresos WHERE Borrado = 0 ORDER BY caja_ingreso_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Caja_Ingresos oIngreso)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oIngreso.Caja_Ingreso_Id == 0)
                    db.CreateCommand("INSERT INTO caja_ingresos(descripcion) VALUES(@descrip)");
                else
                {
                    db.CreateCommand("UPDATE caja_ingresos SET descripcion = @descrip WHERE caja_ingreso_id = @id");
                    db.AsignarParametroEntero("@id", oIngreso.Caja_Ingreso_Id);
                }

                db.AsignarParametroCadena("@descrip", oIngreso.Descripcion);
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
                db.CreateCommand("UPDATE caja_ingresos SET borrado = 1 WHERE caja_ingreso_id = @id");
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
