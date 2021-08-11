using System;
using System.Data;

namespace TPV.Entidades
{
    class Configuracion
    {
        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();
                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE configuracion(condiguracion_id integer PRIMARY KEY, variable VARCHAR(50) NOT NULL, valor_n integer DEFAULT 0, valor_c varchar(50) NOT NULL, descripcion VARCHAR(50) NOT NULL);");
                else
                    db.CreateCommand("CREATE TABLE configuracion(condiguracion_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, variable VARCHAR(50) NOT NULL, valor_n integer DEFAULT 0, valor_c varchar(50) NOT NULL, descripcion VARCHAR(50) NOT NULL);");

                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "RSocial", 0, "SBCODE Software Solutions", "Nombre del Comercio"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Direccion", 0, "Falkner 853 1er Piso", "Direccion del Comercio"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Condicion_IVA", 6, "", "Id de Condicion IVA"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Cuit", 0, "20305764044", "Cuit del Comercio"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Email", 0, "info@sbcode.com.ar", "Email del Comercio"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Telefono", 0, "+54 2257 154-11212", "Telefono del Comercio"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "Mozo", 0, "", "Solicita Personal"));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("INSERT INTO configuracion(variable, valor_n, valor_c, descripcion) VALUES('{0}', {1},'{2}', '{3}')", "AgrupaItem", 0, "", "Agrupa Items en Ticket"));
                db.ExecuteCommand();

                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public String getValue_C(string variable)
        {
            string value = "";

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT valor_c FROM configuracion WHERE variable = '{0}'", variable));

                DataTable dt = db.GetDataTable();

                db.DisConnect();

                if (dt.Rows.Count > 0)
                    value = dt.Rows[0]["valor_c"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return value;
        }

        public Int32 getValue_N(string variable)
        {
            Int32 value = 0;

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT valor_n FROM configuracion WHERE variable = '{0}'", variable));

                DataTable dt = db.GetDataTable();

                db.DisConnect();

                if (dt.Rows.Count > 0)
                    value = Convert.ToInt32(dt.Rows[0]["valor_n"].ToString());
            }
            catch (Exception)
            {

                throw;
            }

            return value;
        }

        public void setValue_C(string variable, string value)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM configuracion WHERE variable = '{0}'", variable));
                DataTable dt = db.GetDataTable();

                if (dt.Rows.Count > 0)
                    db.CreateCommand("UPDATE configuracion SET valor_c = @value WHERE variable = @variable");
                else
                    db.CreateCommand("INSERT INTO configuracion(valor_c, variable) VALUES(@value, @variable)");

                db.AsignarParametroCadena("@value", value);
                db.AsignarParametroCadena("@variable", variable);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {
                db.DisConnect();
                throw;
            }
        }

        public void setValue_N(string variable, int value)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM configuracion WHERE variable = '{0}'", variable));
                DataTable dt = db.GetDataTable();

                if (dt.Rows.Count > 0)
                    db.CreateCommand("UPDATE configuracion SET valor_n = @value WHERE variable = @variable");
                else
                    db.CreateCommand("INSERT INTO configuracion(valor_c, valor_n, variable, descripcion) VALUES('', @value, @variable, '')");

                db.AsignarParametroEntero("@value", value);
                db.AsignarParametroCadena("@variable", variable);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {
                db.DisConnect();
                throw;
            }
        }
    }
}
