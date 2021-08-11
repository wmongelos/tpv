using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TPV.Entidades
{
    class Proveedores
    {
        public Int32 Proveedor_Id { get; set; }
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
                    db.CreateCommand("CREATE TABLE proveedores(proveedor_id integer PRIMARY KEY, rsocial VARCHAR(50) NOT NULL, tipo_responsable_id integer, " +
                        "cuit VARCHAR(50), domicilio VARCHAR(50), nombre VARCHAR(50), apellido VARCHAR(50), telefono_1 VARCHAR(50),  " +
                        "telefono_2 VARCHAR(50), email VARCHAR(80), borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE proveedores(proveedor_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, rsocial VARCHAR(50) NOT NULL, tipo_responsable_id integer, " +
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

        public Proveedores getProveedor(Int32 Id)
        {
            Proveedores oPro = new Proveedores();

            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM proveedores WHERE proveedor_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oPro.Proveedor_Id = Id;
                oPro.RSocial = dt.Rows[0]["rsocial"].ToString();
                oPro.Tipo_Responsable_Id = Convert.ToInt32(dt.Rows[0]["tipo_responsable_id"].ToString());
                oPro.Cuit = dt.Rows[0]["cuit"].ToString();
                oPro.Domicilio = dt.Rows[0]["domicilio"].ToString();
                oPro.Nombre = dt.Rows[0]["nombre"].ToString();
                oPro.Apellido = dt.Rows[0]["apellido"].ToString();
                oPro.Telefono_1 = dt.Rows[0]["telefono_1"].ToString();
                oPro.Telefono_2 = dt.Rows[0]["telefono_2"].ToString();
                oPro.Email = dt.Rows[0]["email"].ToString();

            }
            catch (Exception)
            {

                throw;
            }

            return oPro;
        }

        public DataTable getProveedores()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT proveedor_id, rsocial, telefono_1, telefono_2, cuit, apellido  FROM proveedores WHERE proveedores.borrado = 0 ORDER BY proveedor_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Proveedores oPro)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oPro.Proveedor_Id == 0)
                    db.CreateCommand("INSERT INTO proveedores(rsocial, tipo_responsable_id, cuit, domicilio, nombre, apellido, telefono_1, " +
                        "telefono_2, email) VALUES(@rsoc, @tipres, @cuit, @dom, @nom, @ape, @tel_1, " +
                        "@tel_2, @email)");
                else
                {
                    db.CreateCommand("UPDATE proveedores SET rsocial = @rsoc, tipo_responsable_id = @tipres, cuit = @cuit, domicilio = @dom, nombre = @nom, " +
                        "apellido = @ape, telefono_1 = @tel_1, telefono_2 = @tel_2, email = @email WHERE proveedor_id = @id");

                    db.AsignarParametroEntero("@id", oPro.Proveedor_Id);
                }

                db.AsignarParametroCadena("@rsoc", oPro.RSocial);
                db.AsignarParametroEntero("@tipres", oPro.Tipo_Responsable_Id);
                db.AsignarParametroCadena("@cuit", oPro.Cuit);
                db.AsignarParametroCadena("@dom", oPro.Domicilio);
                db.AsignarParametroCadena("@nom", oPro.Nombre);
                db.AsignarParametroCadena("@ape", oPro.Apellido);
                db.AsignarParametroCadena("@tel_1", oPro.Telefono_1);
                db.AsignarParametroCadena("@tel_2", oPro.Telefono_2);
                db.AsignarParametroCadena("@email", oPro.Email);

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
                db.CreateCommand("UPDATE proveedores SET borrado = 1 WHERE proveedor_id = @id");
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
