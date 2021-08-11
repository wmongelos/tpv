using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPV.Entidades
{
    class Formas_Pago
    {
        public enum Estados
        {
            EFECTIVO = 1,
            TARJETA_CREDITO = 2,
            TARJETA_DEBITO = 3
        }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE formas_pago(formas_pago_id integer PRIMARY KEY, descripcion VARCHAR(50) NOT NULL);");
                else
                    db.CreateCommand("CREATE TABLE formas_pago(formas_pago_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, descripcion VARCHAR(50) NOT NULL);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO formas_pago(descripcion) VALUES('EFECTIVO')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO formas_pago(descripcion) VALUES('TARJETA DE CREDITO')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO formas_pago(descripcion) VALUES('TARJETA DE DEBITO')");
                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
