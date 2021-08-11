using System;
using System.Data;

namespace TPV.Entidades
{
    class Objetos
    {
        public Int32 Objeto_Id { get; set; }
        public string Objeto { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();
                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE objetos(objeto_id integer PRIMARY KEY, objeto VARCHAR(50) NOT NULL);");
                else
                    db.CreateCommand("CREATE TABLE objetos(objeto_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, objeto VARCHAR(50) NOT NULL);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('OPCIONES');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE PERSONAL');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('DISEÑO DE PLANO');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('ROLES DE USUARIO');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE USUARIOS');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE PROVEEDORES');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('FACTURA COMPRAS');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('PAGO A PROVEEDORES');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('CUENTA CORRIENTE DE PROVEEDORES');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('FACTURACION');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE RUBROS DE PRODUCTOS');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE PRODUCTOS');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('GESTION DE CLIENTES');");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO objetos(objeto) VALUES('APLICAR DESCUENTO');");
                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getObjetos()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT * FROM objetos ORDER BY objeto_id ASC");
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
