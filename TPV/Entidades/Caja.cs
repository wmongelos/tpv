using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TPV.Entidades
{
    class Caja
    {
        public Int32 Caja_Id { get; set; }
        public Int32 Usuario_Id { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Importe_Saldo_Inicial { get; set; }
        public Decimal Importe_Total_Efe { get; set; }
        public Decimal Importe_Total_Cred { get; set; }
        public Decimal Importe_Total_Deb { get; set; }
        public Decimal Importe_Total_Egr { get; set; }
        public Decimal Importe_Total_Ing { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE caja(caja_id integer PRIMARY KEY, usuario_id integer DEFAULT 0, fechahora DATETIME, importe_saldo_inicial decimal(10,2) DEFAULT 0, " +
                        "importe_total_efe decimal(10,2) DEFAULT 0, importe_total_cred decimal(10,2) DEFAULT 0, importe_total_deb decimal(10,2) DEFAULT 0, " +
                        "importe_total_egr decimal(10,2) DEFAULT 0, importe_total_ing decimal(10,2) DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE caja(caja_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, usuario_id integer DEFAULT 0, fechahora DATETIME, importe_saldo_inicial decimal(10,2) DEFAULT 0, " +
                       "importe_total_efe decimal(10,2) DEFAULT 0, importe_total_cred decimal(10,2) DEFAULT 0, importe_total_deb decimal(10,2) DEFAULT 0, " +
                       "importe_total_egr decimal(10,2) DEFAULT 0, importe_total_ing decimal(10,2) DEFAULT 0);");

                db.ExecuteCommand();

                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Save(Caja oCaja)
        {
            try
            {
                db.Connect();
                db.CreateCommand("INSERT INTO caja(usuario_id, fechahora, importe_saldo_inicial, importe_total_efe, importe_total_cred, importe_total_deb, importe_total_egr, importe_total_ing) " +
                    "VALUES(@usu, @fechor, @inicial, @efe, @cred, @deb, @egr, @ing);");
                db.AsignarParametroEntero("@usu", oCaja.Usuario_Id);
                db.AsignarParametroFecha("@fechor", oCaja.Fecha);
                db.AsignarParametroDecimal("@inicial", oCaja.Importe_Saldo_Inicial);
                db.AsignarParametroDecimal("@efe", oCaja.Importe_Total_Efe);
                db.AsignarParametroDecimal("@cred", oCaja.Importe_Total_Cred);
                db.AsignarParametroDecimal("@deb", oCaja.Importe_Total_Deb);
                db.AsignarParametroDecimal("@egr", oCaja.Importe_Total_Egr);
                db.AsignarParametroDecimal("@ing", oCaja.Importe_Total_Ing);

                int id = db.EjecutarScalar();

                db.CreateCommand("UPDATE caja_detalle SET caja_id = @id WHERE caja_id = 0 and usuario_id = @usu");
                db.AsignarParametroEntero("@id", id);
                db.AsignarParametroEntero("@usu", oCaja.Usuario_Id);
                db.ExecuteCommand();

                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetCajas(DateTime desde, DateTime hasta)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT *,(select usuario from usuarios where usuario_id = caja.usuario_id) as usuario, " +
                    "(select sum(cubiertos) from comprobantes_venta where comprobante_venta_id in (select comprobante_venta_id from caja_detalle where caja_detalle.caja_id = caja.caja_id)) as cubiertos " + 
                    "FROM caja where date(fechahora) >= @desde and date(fechahora) <= @hasta");
                db.AsignarParametroFecha("@desde", desde.Date);
                db.AsignarParametroFecha("@hasta", hasta.Date);
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }
    }
}
