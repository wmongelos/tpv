using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TPV.Entidades
{
    class Personal
    {
        public Int32 Personal_Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Cuit { get; set; }
        public String Domicilio { get; set; }
        public String Telefono_1 { get; set; }
        public String Telefono_2 { get; set; }
        public String Email { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE personal(personal_id integer PRIMARY KEY, nombre VARCHAR(50), apellido VARCHAR(50), " +
                        "cuit VARCHAR(50), domicilio VARCHAR(50), telefono_1 VARCHAR(50),  " +
                        "telefono_2 VARCHAR(50), email VARCHAR(80), borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE personal(personal_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, nombre VARCHAR(50), apellido VARCHAR(50), " +
                    "cuit VARCHAR(50), domicilio VARCHAR(50), telefono_1 VARCHAR(50),  " +
                    "telefono_2 VARCHAR(50), email VARCHAR(80), borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Personal getPersonal(Int32 Id)
        {
            Personal oPer = new Personal();

            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM personal WHERE personal_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oPer.Personal_Id = Id;
                oPer.Nombre = dt.Rows[0]["nombre"].ToString();
                oPer.Apellido = dt.Rows[0]["apellido"].ToString();
                oPer.Cuit = dt.Rows[0]["cuit"].ToString();
                oPer.Domicilio = dt.Rows[0]["domicilio"].ToString();
                oPer.Telefono_1 = dt.Rows[0]["telefono_1"].ToString();
                oPer.Telefono_2 = dt.Rows[0]["telefono_2"].ToString();
                oPer.Email = dt.Rows[0]["email"].ToString();

            }
            catch (Exception)
            {

                throw;
            }

            return oPer;
        }

        public DataTable getPersonal()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT  personal_id, apellido, nombre, telefono_1, telefono_2, cuit FROM personal WHERE personal.borrado = 0 ORDER BY personal_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Personal oPer)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oPer.Personal_Id == 0)
                    db.CreateCommand("INSERT INTO personal(nombre, apellido, cuit, domicilio, telefono_1, " +
                        "telefono_2, email) VALUES(@nom, @ape, @cuit, @dom, @tel_1, " +
                        "@tel_2, @email)");
                else
                {
                    db.CreateCommand("UPDATE personal SET nombre = @nom, apellido = @ape, cuit = @cuit, domicilio = @dom, " +
                        "telefono_1 = @tel_1, telefono_2 = @tel_2, email = @email WHERE personal_id = @id");

                    db.AsignarParametroEntero("@id", oPer.Personal_Id);
                }

                db.AsignarParametroCadena("@nom", oPer.Nombre);
                db.AsignarParametroCadena("@ape", oPer.Apellido);
                db.AsignarParametroCadena("@cuit", oPer.Cuit);
                db.AsignarParametroCadena("@dom", oPer.Domicilio);
                db.AsignarParametroCadena("@tel_1", oPer.Telefono_1);
                db.AsignarParametroCadena("@tel_2", oPer.Telefono_2);
                db.AsignarParametroCadena("@email", oPer.Email);

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
                db.CreateCommand("UPDATE personal SET borrado = 1 WHERE personal_id = @id");
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
