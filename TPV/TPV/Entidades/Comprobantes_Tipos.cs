using System;

namespace TPV.Entidades
{
    class Comprobantes_Tipos
    {
        public Int32 Comprobante_Tipo_Id { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();
                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comprobantes_tipos(comprobante_tipo_id integer PRIMARY KEY, codigo VARCHAR(2) NOT NULL, descripcion VARCHAR(50) NOT NULL);");
                else
                    db.CreateCommand("CREATE TABLE comprobantes_tipos(comprobante_tipo_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, codigo VARCHAR(2) NOT NULL, descripcion VARCHAR(50) NOT NULL);");

                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('01', 'FACTURAS A')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('02', 'NOTAS DE DEBITO A')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('03', 'NOTAS DE CREDITO A')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('04', 'RECIBOS A')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('05', 'NOTAS DE VENTAS AL CONTADO A')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('06', 'FACTURAS B')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('07', 'NOTAS DE DEBITO B')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('08', 'NOTAS DE CREDITO B')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('09', 'RECIBOS B')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('10', 'NOTAS DE VENTAS AL CONTADO B')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('11', 'FACTURAS C')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('12', 'NOTAS DE DEBITO C')");
                db.ExecuteCommand();
                db.CreateCommand("INSERT INTO comprobantes_tipos(codigo, descripcion) VALUES('13', 'NOTAS DE CREDITO C')");
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
