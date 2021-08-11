using System;
using System.Data;

namespace TPV.Entidades
{
    class Tipos_Responsables
    {
        public Int32 Tipo_Responsable_Id { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE tipos_responsables(tipo_responsable_id integer PRIMARY KEY, codigo VARCHAR(2) NOT NULL, descripcion VARCHAR(50) NOT NULL);");
                else
                    db.CreateCommand("CREATE TABLE tipos_responsables(tipo_responsable_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, codigo VARCHAR(2) NOT NULL, descripcion VARCHAR(50) NOT NULL);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('01', 'IVA RESPONSABLE INSCRIPTO')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('02', 'IVA RESPONSABLE NO INSCRIPTO')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('03', 'IVA NO RESPONSABLE')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('04', 'IVA SUJETO EXENTO')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('05', 'CONSUMIDOR FINAL')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO tipos_responsables(codigo, descripcion) VALUES('06', 'RESPONSABLE MONOTRIBUTO')");
                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable GetTipoResponsables()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM tipos_responsables ORDER BY descripcion");
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
