using System;
using System.Data;

namespace TPV.Entidades
{
    class Usuarios_Roles
    {
        public Int32 Usuario_Rol_Id { get; set; }
        public string Rol { get; set; }
        public Int32 Borrado { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE usuarios_roles(usuario_rol_id integer PRIMARY KEY, rol VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE usuarios_roles(usuario_rol_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, rol VARCHAR(50) NOT NULL, borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO usuarios_roles(rol) VALUES('ADMINISTRADOR');");
                db.ExecuteCommand();
                db.DisConnect(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Usuarios_Roles GetUsuarios_Rol(Int32 Id)
        {
            Usuarios_Roles oUsuRol;
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT usuario_rol_id, rol FROM usuarios_roles WHERE usuario_rol_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oUsuRol = new Usuarios_Roles();
                oUsuRol.Usuario_Rol_Id = Convert.ToInt32(dt.Rows[0]["usuario_rol_id"]);
                oUsuRol.Rol = dt.Rows[0]["rol"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return oUsuRol;
        }

        public DataTable GetRoles()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT *, (SELECT COUNT(*) FROM usuarios WHERE usuario_rol_id = usuarios_roles.usuario_rol_id) AS total FROM usuarios_roles WHERE Borrado = 0 ORDER BY usuario_rol_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Usuarios_Roles oUsuRol, DataTable dt)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oUsuRol.Usuario_Rol_Id == 0)
                    db.CreateCommand("INSERT INTO usuarios_roles(rol) VALUES(@rol);");
                else
                {
                    db.CreateCommand("UPDATE usuarios_roles SET rol = @rol WHERE usuario_rol_id = @id");
                    db.AsignarParametroEntero("@id", oUsuRol.Usuario_Rol_Id);
                }

                db.AsignarParametroCadena("@rol", oUsuRol.Rol);

                if (oUsuRol.Usuario_Rol_Id == 0)
                    oUsuRol.Usuario_Rol_Id = db.EjecutarScalar();
                else
                    db.ExecuteCommand();

                if (oUsuRol.Usuario_Rol_Id > 0)
                { 
                    db.CreateCommand("DELETE FROM usuarios_roles_obj WHERE usuario_rol_id = @id");
                    db.AsignarParametroEntero("@id", oUsuRol.Usuario_Rol_Id);
                    db.ExecuteCommand();

                    foreach (DataRow dr in dt.Rows)
                    {
                        db.CreateCommand("INSERT INTO usuarios_roles_obj(usuario_rol_id, objeto_id) VALUES(@idrol, @obj);");
                        db.AsignarParametroEntero("@idrol", oUsuRol.Usuario_Rol_Id);
                        db.AsignarParametroEntero("@obj", Convert.ToInt32(dr["objeto_id"]));
                        db.ExecuteCommand();
                    }
                }
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
                db.CreateCommand("UPDATE usuarios_roles SET borrado = 1 WHERE usuario_rol_id = @id");
                db.AsignarParametroEntero("@id", Id);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Boolean ValidarPermiso(Int32 Rol_id, Int32 Objeto_id)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT count(*) AS Total FROM usuarios_roles_obj WHERE usuario_rol_id = {0} and objeto_id = {1}", Rol_id, Objeto_id));
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return Convert.ToInt32(dt.Rows[0]["Total"]) == 1 ? true : false;
        }
    }
}
