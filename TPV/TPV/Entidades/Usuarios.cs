using System;
using System.Data;

namespace TPV.Entidades
{
    public class Usuarios
    {
        public Int32 Usuario_Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public Int32 Usuario_Rol_Id { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE usuarios(usuario_id integer PRIMARY KEY, usuario_rol_id integer DEFAULT 0, usuario VARCHAR(50) NOT NULL, clave VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE usuarios(usuario_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, usuario_rol_id integer DEFAULT 0, usuario VARCHAR(50) NOT NULL, clave VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO usuarios(usuario_rol_id, usuario, clave) VALUES(1, 'ADMIN', 'ADMIN');");
                db.ExecuteCommand();
                db.DisConnect();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Boolean ValidAccess(string usuario, string clave)
        {
            DataTable dt = new DataTable();
            bool result = false;

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM usuarios WHERE usuario = @usu AND clave = @cla AND Borrado = 0");
                db.AsignarParametroCadena("@usu", usuario.ToUpper());
                db.AsignarParametroCadena("@cla", clave.ToUpper());
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

            if (dt.Rows.Count == 0)
                result = false;
            else
            {
                GlobalVar.CurrentUser_Id = Convert.ToInt32(dt.Rows[0]["usuario_id"]);
                GlobalVar.CurrentUser_Rol_Id = Convert.ToInt32(dt.Rows[0]["usuario_rol_id"]);
                GlobalVar.CurrentUser_Name = dt.Rows[0]["usuario"].ToString();

                result = true;
            }

            return result;
        }

        public Usuarios GetUsuario(Int32 Id)
        {
            Usuarios oUsu;
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM usuarios WHERE usuario_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oUsu = new Usuarios();
                oUsu.Usuario_Id = Convert.ToInt32(dt.Rows[0]["usuario_id"]);
                oUsu.Usuario = dt.Rows[0]["usuario"].ToString();
                oUsu.Clave = dt.Rows[0]["clave"].ToString();
                oUsu.Usuario_Rol_Id = Convert.ToInt32(dt.Rows[0]["usuario_rol_id"]);
            }
            catch (Exception)
            {

                throw;
            }

            return oUsu;
        }

        public DataTable GetUsuarios()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("select *,(select rol from usuarios_roles where usuario_rol_id = usuarios.usuario_rol_id) as rol from usuarios WHERE Borrado = 0 ORDER BY usuario");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Usuarios oUsuario)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oUsuario.Usuario_Id == 0)
                    db.CreateCommand("INSERT INTO usuarios(usuario, clave, usuario_rol_id) VALUES(@usuario, @clave, @rol)");
                else
                {
                    db.CreateCommand("UPDATE usuarios SET usuario = @usuario, clave = @clave, usuario_rol_id = @rol WHERE usuario_id = @id");
                    db.AsignarParametroEntero("@id", oUsuario.Usuario_Id);
                }

                db.AsignarParametroCadena("@usuario", oUsuario.Usuario);
                db.AsignarParametroCadena("@clave", oUsuario.Clave);
                db.AsignarParametroEntero("@rol", oUsuario.Usuario_Rol_Id);
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
                db.CreateCommand("UPDATE usuarios SET borrado = 1 WHERE usuario_id = @id");
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
