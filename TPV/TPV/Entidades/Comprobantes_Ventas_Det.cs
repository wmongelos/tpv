using System;

namespace TPV.Entidades
{
    class Comprobantes_Venta_Det
    {
        public Int32 Comprobante_Venta_Det_Id { get; set; }
        public Int32 Comprobante_Venta_Id { get; set; }
        public Int32 Articulo_Id { get; set; }
        public Int32 Cantidad { get; set; }
        public Decimal Importe_Unitario { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comprobantes_venta_det( " +
                        "comprobante_venta_det_id INTEGER PRIMARY KEY, " +
                        "comprobante_venta_id INTEGER DEFAULT '0' NOT NULL, " +
                        "articulo_id INTEGER DEFAULT '0' NOT NULL, " +
                        "cantidad INTEGER DEFAULT '0' NOT NULL, " +
                        "importe_unitario DECIMAL(10,2) DEFAULT '0' NOT NULL)");
                else
                    db.CreateCommand("CREATE TABLE comprobantes_venta_det( " +
                       "comprobante_venta_det_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, " +
                       "comprobante_venta_id INTEGER DEFAULT '0' NOT NULL, " +
                       "articulo_id INTEGER DEFAULT '0' NOT NULL, " +
                       "cantidad INTEGER DEFAULT '0' NOT NULL, " +
                       "importe_unitario DECIMAL(10,2) DEFAULT '0' NOT NULL)");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Comprobantes_Venta_Det oDet)
        {
            try
            {
                db.CreateCommand("INSERT INTO comprobantes_venta_det(comprobante_venta_id, articulo_id, cantidad, importe_unitario) " + 
                "VALUES(@id, @art_id, @cant, @imp)");

                db.AsignarParametroEntero("@id", oDet.Comprobante_Venta_Id);
                db.AsignarParametroEntero("@art_id", oDet.Articulo_Id);
                db.AsignarParametroEntero("@cant", oDet.Cantidad);
                db.AsignarParametroDecimal("@imp", oDet.Importe_Unitario);

                db.ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
