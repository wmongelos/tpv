using System;
using System.Data;

namespace TPV.Entidades
{
    class Comandas_Det
    {
        public Int32 Comanda_Det_Id { get; set; }
        public Int32 Articulo_Id { get; set; }
        public Int32 Cantidad { get; set; }
        public Decimal Importe_Unitario { get; set; }
        public Decimal Importe_Total { get; set; }

        public enum Estados
        {
            PREPARACION = 1,
            COCINANDO = 2,
            DESPACHADA = 3,
            IMPRESA = 4,
            CONFIRMADA = 5,
            ANULADA = 6
        }

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comandas_det(comanda_det_id integer PRIMARY KEY, comanda_id integer DEFAULT 0, articulo_id integer DEFAULT 0," +
                        "cantidad integer DEFAULT 0, importe_unitario decimal(10,2) DEFAULT 0, importe_total decimal(10,2) DEFAULT 0, comandas_det_estados_id integer DEFAULT 0)");
                else
                    db.CreateCommand("CREATE TABLE comandas_det(comanda_det_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, comanda_id integer DEFAULT 0, articulo_id integer DEFAULT 0," +
                        "cantidad integer DEFAULT 0, importe_unitario decimal(10,2) DEFAULT 0, importe_total decimal(10,2) DEFAULT 0, comandas_det_estados_id integer DEFAULT 0)");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateTableEstados()
        {
            try
            { 
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comandas_det_estados(id integer PRIMARY KEY, estado VARCHAR(50))");
                else
                    db.CreateCommand("CREATE TABLE comandas_det_estados(id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, estado VARCHAR(50))");

                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('PREPARACION');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('COCINANDO');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('DESPACHADA');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('IMPRESA');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('CONFIRMADA');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_det_estados(estado) VALUES('ANULADA');");
                db.ExecuteCommand();


                db.DisConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getComandaDetalleGrupo(Int32 comanda_id)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT comanda_id, articulos.descripcion, comandas_det.articulo_id, SUM(cantidad) AS cantidad, importe_unitario, comandas_det_estados_id FROM comandas_det " +
                    "LEFT JOIN articulos on articulos.articulo_id = comandas_det.articulo_id WHERE comanda_id = {0} GROUP BY 1, 2", comanda_id));

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable getComandaDetalle(Int32 comanda_id)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT comandas_det.articulo_id, articulos.descripcion, comandas_det.cantidad, " +
                    "comandas_det.importe_unitario, comandas_det.importe_total, comandas_det.comandas_det_estados_id " +
                    "FROM comandas_det " +
                    "LEFT JOIN articulos on articulos.articulo_id = comandas_det.articulo_id WHERE comanda_id = {0}", comanda_id));
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(DataTable dtComanda, Int32 comanda_id)
        {
            bool result = false;


            try
            {
                db.Connect();

                foreach (DataRow dr in dtComanda.Rows)
                {
                    db.CreateCommand("INSERT INTO comandas_det(comanda_id, articulo_id, cantidad, importe_unitario, importe_total, comandas_det_estados_id) " +
                    "VALUES(@id, @articulo, @cant, @unit, @total, @estado)");

                    db.AsignarParametroEntero("@id", comanda_id);
                    db.AsignarParametroEntero("@articulo", Convert.ToInt32(dr["articulo_id"]));
                    db.AsignarParametroEntero("@cant", Convert.ToInt32(dr["cantidad"]));
                    db.AsignarParametroDecimal("@unit", Convert.ToDecimal(dr["importe"]));
                    db.AsignarParametroDecimal("@total", Convert.ToDecimal(dr["final"]));
                    db.AsignarParametroEntero("@estado", Convert.ToInt32(dr["IdEstado"]));
                    db.ExecuteCommand();
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

        public void Delete(Int32 comanda_id)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("DELETE FROM comandas_det WHERE comanda_id = {0}", comanda_id));
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable getComanasCocina()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("select descripcion, cantidad, estado,comanda_det_id,  comandas_det.comanda_id, comandas.hora, " +
                    "(select nombre from plano where plano.plano_id = comandas.plano_id) as mesa, " +
                    "(select concat_ws(',', personal.nombre, personal.apellido) from personal where " +
                    "personal.personal_id = comandas.personal_id) as personal " +
                    "from comandas_det " +
                    "left join articulos on articulos.articulo_id = comandas_det.articulo_id " +
                    "left join comandas on comandas.comanda_id = comandas_det.comanda_id " +
                    "where comandas.confirmada = 0 and (estado = ' ' or estado = 'P') " +
                    "and articulos.salida = 2 ORDER by hora");

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public void Preparando(Int32 IdComanda_Det)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("UPDATE comandas_det SET estado = 'P' where comanda_det_id = {0}", IdComanda_Det));
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Despachar(Int32 IdComanda_Det)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("UPDATE comandas_det SET estado = 'D' where comanda_det_id = {0}", IdComanda_Det));
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
