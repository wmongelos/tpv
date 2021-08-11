using System;
using System.Data;

namespace TPV.Entidades
{
    class Plano
    {
        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE plano(plano_id integer PRIMARY KEY, tipo VARCHAR(50), nombre VARCHAR(50), top integer DEFAULT 0, " +
                            "_left integer DEFAULT 0, height integer DEFAULT 0, width integer DEFAULT 0, location_x integer DEFAULT 0, location_y integer DEFAULT 0, plano_estado_id integer DEFAULT 0, rotacion integer DEFAULT 1);");
                else
                    db.CreateCommand("CREATE TABLE plano(plano_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, tipo VARCHAR(50), nombre VARCHAR(50), top integer DEFAULT 0, " +
                            "_left integer DEFAULT 0, height integer DEFAULT 0, width integer DEFAULT 0, location_x integer DEFAULT 0, location_y integer DEFAULT 0, plano_estado_id integer DEFAULT 0, rotacion integer DEFAULT 1);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getPlano()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();

                db.CreateCommand("SELECT * FROM plano");

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public void Save(DataTable dt)
        {
            try
            {
                db.Connect();
                db.CreateCommand("DELETE FROM plano");
                db.ExecuteCommand();

                foreach (DataRow dr in dt.Rows)
                {
                    db.CreateCommand("INSERT INTO plano(tipo, nombre, top, _left, height, width, location_x, location_y, plano_estado_id, rotacion) VALUES(@tip, @nom, @t, @l, @h, @w, @x, @y, 1, @ro)");

                    db.AsignarParametroCadena("@tip", dr["tipo"].ToString());
                    db.AsignarParametroCadena("@nom", dr["nombre"].ToString());
                    db.AsignarParametroEntero("@t", Convert.ToInt32(dr["top"]));
                    db.AsignarParametroEntero("@l", Convert.ToInt32(dr["_left"]));
                    db.AsignarParametroEntero("@h", Convert.ToInt32(dr["height"]));
                    db.AsignarParametroEntero("@w", Convert.ToInt32(dr["width"]));
                    db.AsignarParametroEntero("@x", Convert.ToInt32(dr["location_x"]));
                    db.AsignarParametroEntero("@y", Convert.ToInt32(dr["location_y"]));
                    db.AsignarParametroEntero("@ro", Convert.ToInt32(dr["rotacion"]));
                    db.ExecuteCommand();
                }

                db.DisConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getMesas_Disponibles()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();

                db.CreateCommand("SELECT nombre, plano_id FROM plano where plano_estado_id = 1 and nombre <> '' order by nombre");

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }
    }
}
