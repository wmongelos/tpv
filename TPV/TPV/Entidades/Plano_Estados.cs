using System;
using System.Data;

namespace TPV.Entidades
{
    class Plano_Estados
    {
        private DbHelper db = DbHelper.getDbHelper();

        public enum Estados
        {
            DISPONIBLE = 1,
            OCUPADA = 2, 
            PENDIENTE_DE_COBRO = 3
        }

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE plano_estados(plano_estado_id integer PRIMARY KEY, estado VARCHAR(50));");
                else
                    db.CreateCommand("CREATE TABLE plano_estados(plano_estado_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, estado VARCHAR(50));");

                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO plano_estados(estado) VALUES('DISPONIBLE');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO plano_estados(estado) VALUES('OCUPADA');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO plano_estados(estado) VALUES('PENDIENTE DE COBRO');");
                db.ExecuteCommand();

                db.DisConnect();

            }
            catch (Exception ex)
            {
                throw ex;
                
            }
        }

        public void SetEstado(Int32 plano_id, Estados est)
        {
            try
            {
                db.Connect();
                db.CreateCommand("UPDATE Plano SET plano_estado_id = @est WHERE plano_id = @id");
                db.AsignarParametroEntero("@est", Convert.ToInt32(est));
                db.AsignarParametroEntero("@id", plano_id);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetEstados()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("select *, (SELECT count(*) from plano where plano.plano_estado_id = plano_estados.plano_estado_id) as total from plano_estados");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }
    }
}
