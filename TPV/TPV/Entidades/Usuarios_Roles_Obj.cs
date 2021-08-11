using System;
using System.Data;

namespace TPV.Entidades
{
    class Usuarios_Roles_Obj
    {
        public Int32 Usuarios_Roles_Obj_Id { get; set; }
        public Int32 Usuario_Rol_Id { get; set; }
        public Int32 Objeto_Id { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE usuarios_roles_obj(id integer PRIMARY KEY, usuario_rol_id integer DEFAULT 0, objeto_id integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE Usuarios_Roles_Obj(id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, usuario_rol_id integer DEFAULT 0, objeto_id integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setPermisos(Int32 IdRol, DataTable dt) {
            try
            {
                db.Connect();

                db.CreateCommand(String.Format("DELETE FROM usuarios_roles_obj WHERE usuario_rol_id = {0}", IdRol));
                db.ExecuteCommand();

                foreach (DataRow dr in dt.Rows)
                {
                    db.CreateCommand("INSERT INTO usuarios_roles_obj(usuario_rol_id, objeto_id) VALUES(@idrol, @obj);");
                    db.AsignarParametroEntero("@idrol", IdRol);
                    db.AsignarParametroEntero("@obj", Convert.ToInt32(dr["objeto_id"]));
                    db.ExecuteCommand();
                }
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable getPermisos(Int32 IdRol)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM usuarios_roles_obj WHERE usuario_rol_id = @id");
                db.AsignarParametroEntero("@id", IdRol);

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
