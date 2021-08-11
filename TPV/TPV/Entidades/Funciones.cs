using System;
using System.Data;

namespace TPV.Entidades
{
    class Funciones
    {
        private DbHelper db = DbHelper.getDbHelper();

        public Boolean ValidarRepetido(String tabla, String campo, String valor)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM {0} WHERE Borrado = 0 AND {1} = @value", tabla, campo));
                db.AsignarParametroCadena("@value", valor);
                DataTable dt = db.GetDataTable();
                db.DisConnect();

                if (dt.Rows.Count > 0)
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public Boolean ValidarRepetido(String tabla, String condicion)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM {0} WHERE {1}", tabla, condicion));
                DataTable dt = db.GetDataTable();
                db.DisConnect();

                if (dt.Rows.Count > 0)
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }

        public void GenerarBackup()
        {
            db.Backup();
        }
    }
}
