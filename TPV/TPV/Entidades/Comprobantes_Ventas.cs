using System;
using System.Data;

namespace TPV.Entidades
{
    class Comprobantes_Venta
    {
        public Int32 Comprobante_Venta_Id { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 Cliente_Id { get; set; }
        public Int32 Comprobante_Tipo_Id { get; set; }
        public Int32 Formas_Pago_Id { get; set; }
        public Int32 Numero { get; set; }
        public Int32 Cubiertos { get; set; }
        public Decimal Importe_Bruto { get; set; }
        public Decimal Importe_Desc { get; set; }
        public Decimal Importe_Final { get; set; }
        public Int32 Usuario_Id { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comprobantes_venta( " +
                        "comprobante_venta_id INTEGER PRIMARY KEY, " +
                        "fecha DATETIME, " +
                        "cliente_id INTEGER DEFAULT '0' NOT NULL, " +
                        "comprobante_tipo_id INTEGER DEFAULT '0' NOT NULL, " +
                        "formas_pago_id INTEGER DEFAULT '0' NOT NULL, " +
                        "numero INTEGER DEFAULT '0' NOT NULL, " +
                        "importe_bruto DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "importe_desc DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "importe_final DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "usuario_id INTEGER DEFAULT '0' NOT NULL)");
                else
                    db.CreateCommand("CREATE TABLE comprobantes_venta( " +
                        "comprobante_venta_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                        "fecha DATETIME, " +
                        "cliente_id INTEGER DEFAULT '0' NOT NULL, " +
                        "comprobante_tipo_id INTEGER DEFAULT '0' NOT NULL, " +
                        "formas_pago_id INTEGER DEFAULT '0' NOT NULL, " +
                        "numero INTEGER DEFAULT '0' NOT NULL, " +
                        "importe_bruto DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "importe_desc DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "importe_final DECIMAL(10, 2) DEFAULT '0' NOT NULL, " +
                        "usuario_id INTEGER DEFAULT '0' NOT NULL)");


                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Int32 Save(Comprobantes_Venta oComp, DataTable dt)
        {
            int id = 0;
            try
            {
                db.Connect();
                db.CreateCommand("INSERT INTO comprobantes_venta(fecha, cliente_id, comprobante_tipo_id, formas_pago_id, numero, cubiertos, importe_bruto, importe_desc, importe_final) " +
                "VALUES(@fec, @client_id, @tipo_id, @fpago, @num, @cub, @bruto, @desc, @final);");

                db.AsignarParametroFecha("@fec", DateTime.Now);
                db.AsignarParametroEntero("@client_id", oComp.Cliente_Id);
                db.AsignarParametroEntero("@tipo_id", oComp.Comprobante_Tipo_Id);
                db.AsignarParametroEntero("@fpago", oComp.Formas_Pago_Id);
                db.AsignarParametroEntero("@num", oComp.Numero);
                db.AsignarParametroEntero("@cub", oComp.Cubiertos);
                db.AsignarParametroDecimal("@bruto", oComp.Importe_Bruto);
                db.AsignarParametroDecimal("@desc", oComp.Importe_Desc);
                db.AsignarParametroDecimal("@final", oComp.Importe_Final);

                id = db.EjecutarScalar();

                if (id > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        Comprobantes_Venta_Det oDet = new Comprobantes_Venta_Det();
                        oDet.Comprobante_Venta_Id = id;
                        oDet.Articulo_Id = Convert.ToInt32(dr["Articulo_Id"]);
                        oDet.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                        oDet.Importe_Unitario = Convert.ToDecimal(dr["Importe_Unitario"]);
                        oDet.Save(oDet);
                    }
                }

                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }
    }
}
