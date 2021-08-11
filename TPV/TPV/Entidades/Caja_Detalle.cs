using System;
using System.Data;

namespace TPV.Entidades
{
    class Caja_Detalle
    {
        public Int32 Caja_Detalle_Id { get; set; }
        public Int32 Usuario_Id { get; set; }
        public Int32 Comprobantes_Venta_Id { get; set; }
        public Int32 Caja_Egreso_Id { get; set; }
        public Int32 Caja_Ingreso_Id { get; set; }
        public DateTime FechaHora { get; set; }
        public String Concepto { get; set; }
        public Decimal Importe_Debe { get; set; }
        public Decimal Importe_Haber { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE caja_detalle(caja_detalle_id integer PRIMARY KEY, caja_id integer DEFAULT 0, usuario_id integer DEFAULT 0, " +
                        "comprobante_venta_id integer DEFAULT 0, caja_egreso_id integer DEFAULT 0, caja_ingreso_id integer DEFAULT 0, fechahora DATETIME, concepto varchar(50) NOT NULL," +
                        "importe_debe decimal(10,2) DEFAULT 0, importe_haber decimal(10,2) DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE caja_detalle(caja_detalle_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, caja_id integer DEFAULT 0, usuario_id integer DEFAULT 0, " +
                        "comprobante_venta_id integer DEFAULT 0, caja_egreso_id integer DEFAULT 0, caja_ingreso_id integer DEFAULT 0, fechahora DATETIME, concepto varchar(50) NOT NULL, " +
                        "importe_debe decimal(10,2) DEFAULT 0, importe_haber decimal(10,2) DEFAULT 0);");

                db.ExecuteCommand();

                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable getCajaDetalle()
        {
            DataTable dt = new DataTable();
            
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT fechahora, concepto, importe_haber, importe_debe, caja_ingreso_id, caja_egreso_id FROM caja_detalle WHERE usuario_id = {0} and caja_id = 0", GlobalVar.CurrentUser_Id));
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        public DataTable getSaldosFPagos()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("select *, IFNULL((select sum(importe_final) from comprobantes_venta " +
                    "where formas_pago_id = formas_pago.formas_pago_id and comprobante_venta_id in " +
                    "(select comprobante_venta_id from caja_detalle where usuario_id = {0} and caja_id = 0)), 0) AS total from formas_pago", GlobalVar.CurrentUser_Id));
                dt = db.GetDataTable();
                db.DisConnect();

            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        public void SetSaldoInicial(decimal importe)
        {
            try
            {
                db.Connect();
                db.CreateCommand("INSERT INTO caja_detalle(usuario_id, fechahora, concepto, importe_haber) " +
                    "VALUES(@usu, @fechor, 'SALDO INICIAL', @importe)");

                db.AsignarParametroEntero("@usu", GlobalVar.CurrentUser_Id);
                db.AsignarParametroFecha("@fechor", DateTime.Now);
                db.AsignarParametroDecimal("@importe", importe);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Decimal GetSaldoInicial()
        {
            decimal saldo = 0;
            try
            {
                db.Connect();
                db.CreateCommand("SELECT IFNULL(SUM(importe_haber), 0) as importe_haber FROM caja_detalle WHERE usuario_id = @usu AND caja_id = 0 and comprobante_venta_id = 0 " +
                    "and caja_egreso_id = 0 and caja_ingreso_id = 0");

                db.AsignarParametroEntero("@usu", GlobalVar.CurrentUser_Id);
                DataTable dt = db.GetDataTable();

                if (dt.Rows.Count > 0)
                    saldo = Convert.ToDecimal(dt.Rows[0]["importe_haber"]);

                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
            return saldo;
        }

        public Int32 GetCubiertos()
        {
            Int32 cantidad = 0;

            try
            {
                db.Connect();
                db.CreateCommand("select sum(cubiertos) as total from comprobantes_venta where comprobante_venta_id in (select comprobante_venta_id from caja_detalle where caja_id = 0)");
                DataTable dt = db.GetDataTable();
                db.DisConnect();

                cantidad = Convert.ToInt32(dt.Rows[0]["total"]);
            }
            catch (Exception)
            {

                throw;
            }

            return cantidad;
        }

        public void Save(Caja_Detalle oCajaDet)
        {
            try
            {
                db.Connect();
                db.CreateCommand("INSERT INTO caja_detalle(usuario_id, comprobante_venta_id, caja_egreso_id, " +
                    "caja_ingreso_id, fechahora, concepto, importe_debe, importe_haber) " +
                    "VALUES(@usuario, @comp, @egreso, @ingreso, @fechor, @concep, @debe, @haber)");

                db.AsignarParametroEntero("@usuario", oCajaDet.Usuario_Id);
                db.AsignarParametroEntero("@comp", oCajaDet.Comprobantes_Venta_Id);
                db.AsignarParametroEntero("@egreso", oCajaDet.Caja_Egreso_Id);
                db.AsignarParametroEntero("@ingreso", oCajaDet.Caja_Ingreso_Id);
                db.AsignarParametroFecha("@fechor", oCajaDet.FechaHora);
                db.AsignarParametroCadena("@concep", oCajaDet.Concepto);
                db.AsignarParametroDecimal("@debe", oCajaDet.Importe_Debe);
                db.AsignarParametroDecimal("@haber", oCajaDet.Importe_Haber);
                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetCaja(Int32 idCaja, Int32 idUsuario)
        {
            try
            {
                db.Connect();
                db.CreateCommand("UPDATE caja_detalle SET caja_id = @id WHERE usuario_id = @usu");
                db.AsignarParametroEntero("@id", idCaja);
                db.AsignarParametroEntero("@usu", idUsuario);
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
