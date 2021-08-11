using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TPV.Entidades
{
    class Clientes
    {
        public Int32 Cliente_Id { get; set; }
        public String RSocial { get; set; }
        public Int32 Tipo_Responsable_Id { get; set; }
        public String Cuit { get; set; }
        public String Domicilio { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
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
                    db.CreateCommand("CREATE TABLE clientes(cliente_id integer PRIMARY KEY, rsocial VARCHAR(50) NOT NULL, tipo_responsable_id integer, " +
                        "cuit VARCHAR(50), domicilio VARCHAR(50), nombre VARCHAR(50), apellido VARCHAR(50), telefono_1 VARCHAR(50),  " +
                        "telefono_2 VARCHAR(50), email VARCHAR(80), borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE clientes(cliente_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, rsocial VARCHAR(50) NOT NULL, tipo_responsable_id integer, " +
                        "cuit VARCHAR(50), domicilio VARCHAR(50), nombre VARCHAR(50), apellido VARCHAR(50), telefono_1 VARCHAR(50),  " +
                        "telefono_2 VARCHAR(50), email VARCHAR(80), borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Clientes getCliente(Int32 Id)
        {
            Clientes oCli = new Clientes();

            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM clientes WHERE cliente_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oCli.Cliente_Id = Id;
                oCli.RSocial = dt.Rows[0]["rsocial"].ToString();
                oCli.Tipo_Responsable_Id = Convert.ToInt32(dt.Rows[0]["tipo_responsable_id"].ToString());
                oCli.Cuit = dt.Rows[0]["cuit"].ToString();
                oCli.Domicilio = dt.Rows[0]["domicilio"].ToString();
                oCli.Nombre = dt.Rows[0]["nombre"].ToString();
                oCli.Apellido = dt.Rows[0]["apellido"].ToString();
                oCli.Telefono_1 = dt.Rows[0]["telefono_1"].ToString();
                oCli.Telefono_2 = dt.Rows[0]["telefono_2"].ToString();
                oCli.Email = dt.Rows[0]["email"].ToString();

            }
            catch (Exception)
            {

                throw;
            }

            return oCli;
        }

        public DataTable getClientes()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT cliente_id, rsocial, telefono_1, telefono_2, cuit FROM clientes WHERE clientes.borrado = 0 ORDER BY cliente_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Clientes oCli)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oCli.Cliente_Id == 0)
                    db.CreateCommand("INSERT INTO clientes(rsocial, tipo_responsable_id, cuit, domicilio, nombre, apellido, telefono_1, " +
                        "telefono_2, email) VALUES(@rsoc, @tipres, @cuit, @dom, @nom, @ape, @tel_1, " +
                        "@tel_2, @email)");
                else
                {
                    db.CreateCommand("UPDATE clientes SET rsocial = @rsoc, tipo_responsable_id = @tipres, cuit = @cuit, domicilio = @dom, nombre = @nom, " +
                        "apellido = @ape, telefono_1 = @tel_1, telefono_2 = @tel_2, email = @email WHERE cliente_id = @id");

                    db.AsignarParametroEntero("@id", oCli.Cliente_Id);
                }

                db.AsignarParametroCadena("@rsoc", oCli.RSocial);
                db.AsignarParametroEntero("@tipres", oCli.Tipo_Responsable_Id);
                db.AsignarParametroCadena("@cuit", oCli.Cuit);
                db.AsignarParametroCadena("@dom", oCli.Domicilio);
                db.AsignarParametroCadena("@nom", oCli.Nombre);
                db.AsignarParametroCadena("@ape", oCli.Apellido);
                db.AsignarParametroCadena("@tel_1", oCli.Telefono_1);
                db.AsignarParametroCadena("@tel_2", oCli.Telefono_2);
                db.AsignarParametroCadena("@email", oCli.Email);

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
                db.CreateCommand("UPDATE clientes SET borrado = 1 WHERE cliente_id = @id");
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
