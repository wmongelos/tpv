using System;
using System.Data;

namespace TPV.Entidades
{
    class Comandas
    {
        public Int32 Comanda_Id { get; set; }
        public Int32 Plano_Id { get; set; }
        public Int32 Personal_Id { get; set; }
        public Int32 Cliente_Id { get; set; }
        public Int32 Usuario_Id { get; set; }
        public DateTime Fecha { get; set; }
        public String Hora { get; set; }
        public Int32 Cubiertos { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal Importe_Desc { get; set; }
        public Decimal Importe_Final { get; set; }
        public Int32 Confirmada { get; set; }

        private DbHelper db = DbHelper.getDbHelper();

        public enum Estados
        {
            ANULADA = 1,
            CONFIRMADA = 2
        }

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if (GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE comandas(comanda_id integer PRIMARY KEY, plano_id integer DEFAULT 0, personal_id integer DEFAULT 0," +
                        "cliente_id integer DEFAULT 0, usuario_id integer DEFAULT 0, fecha DATETIME, hora varchar(12), " +
                        "subtotal decimal(10,2) DEFAULT 0, descuento decimal(10,2) DEFAULT 0, importe_desc decimal(10,2) DEFAULT 0, importe_final decimal(10,2) DEFAULT 0, comanda_estado_id integer DEFAULT 0)");
                else
                    db.CreateCommand("CREATE TABLE comandas(comanda_id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY, plano_id integer DEFAULT 0, personal_id integer DEFAULT 0," +
                        "cliente_id integer DEFAULT 0, usuario_id integer DEFAULT 0, fecha DATETIME, hora varchar(12), " +
                        "subtotal decimal(10,2) DEFAULT 0, descuento decimal(10,2) DEFAULT 0, importe_desc decimal(10,2) DEFAULT 0, importe_final decimal(10,2) DEFAULT 0, comanda_estado_id integer DEFAULT 0)");

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
                    db.CreateCommand("CREATE TABLE comandas_estados(id integer PRIMARY KEY, estado VARCHAR(50))");
                else
                    db.CreateCommand("CREATE TABLE comandas_estados(id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, estado VARCHAR(50))");

                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_estados(estado) VALUES('ANULADA');");
                db.ExecuteCommand();

                db.CreateCommand("INSERT INTO comandas_estados(estado) VALUES('CONFIRMADA');");
                db.ExecuteCommand();

                db.DisConnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Int32 getId(Int32 plano_id)
        {
            int id = 0;
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT comanda_id FROM comandas WHERE plano_id = {0} and confirmada = 0", plano_id));

                DataTable dt = db.GetDataTable();

                if(dt.Rows.Count > 0)
                    id = Convert.ToInt32(dt.Rows[0]["comanda_id"]);

                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }

            return id;
        }

        public DataTable getDataTableComanda(Int32 comanda_id)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM Comandas WHERE comanda_id = {0}", comanda_id));
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Comandas getComanda(Int32 comanda_id)
        {
            Comandas oComanda = new Comandas();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT * FROM Comandas WHERE comanda_id = {0}", comanda_id));
                DataTable dt = db.GetDataTable();
                db.DisConnect();

                oComanda.Comanda_Id = Convert.ToInt32(dt.Rows[0]["comanda_id"]);
                oComanda.Plano_Id = Convert.ToInt32(dt.Rows[0]["plano_id"]);
                oComanda.Personal_Id = Convert.ToInt32(dt.Rows[0]["personal_id"]);
                oComanda.Cliente_Id = Convert.ToInt32(dt.Rows[0]["cliente_id"]);
                oComanda.Usuario_Id = Convert.ToInt32(dt.Rows[0]["usuario_id"]);
                oComanda.Fecha = Convert.ToDateTime(dt.Rows[0]["fecha"]);
                oComanda.Hora = dt.Rows[0]["hora"].ToString();
                oComanda.Cubiertos = Convert.ToInt32(dt.Rows[0]["cubiertos"].ToString());
                oComanda.SubTotal = Convert.ToDecimal(dt.Rows[0]["subtotal"]);
                oComanda.Descuento = Convert.ToDecimal(dt.Rows[0]["descuento"]);
                oComanda.Importe_Desc = Convert.ToDecimal(dt.Rows[0]["importe_desc"]);
                oComanda.Importe_Final = Convert.ToDecimal(dt.Rows[0]["importe_final"]);
                oComanda.Confirmada = Convert.ToInt32(dt.Rows[0]["confirmada"]);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return oComanda;
        }

        public Int32 Save(Comandas oComanda)
        {
            int result = 0;

            try
            {
                
                db.Connect();

                db.CreateCommand("INSERT INTO comandas(plano_id, personal_id, cliente_id, usuario_id, fecha, hora, cubiertos, subtotal, descuento, importe_desc, importe_final) " +
                    "VALUES(@plano, @personal, @cliente, @usuario, @fec, @hor, @cub, @subt, @desc, @impor_desc, @impor_final);");

                db.AsignarParametroEntero("@plano", oComanda.Plano_Id);
                db.AsignarParametroEntero("@personal", oComanda.Personal_Id);
                db.AsignarParametroEntero("@cliente", oComanda.Cliente_Id);
                db.AsignarParametroEntero("@usuario", GlobalVar.CurrentUser_Id);
                db.AsignarParametroFecha("@fec", oComanda.Fecha);
                db.AsignarParametroCadena("@hor", oComanda.Hora);
                db.AsignarParametroEntero("@cub", oComanda.Cubiertos);
                db.AsignarParametroDecimal("@subt", oComanda.SubTotal);
                db.AsignarParametroDecimal("@desc", oComanda.Descuento);
                db.AsignarParametroDecimal("@impor_desc", oComanda.Importe_Desc);
                db.AsignarParametroDecimal("@impor_final", oComanda.Importe_Final);

                result = db.EjecutarScalar();

                db.DisConnect();
            }
            catch (Exception)
            {
                db.DisConnect();
                throw;
            }

            return result;
        }

        public void Update(Comandas oComanda)
        {
            try
            {
                db.Connect();
                db.CreateCommand("UPDATE comandas SET cliente_id = @cli, subtotal = @sub, descuento = @desc, importe_desc = @imp_desc, importe_final = @imp_fin WHERE comanda_id = @id");
                db.AsignarParametroEntero("@id", oComanda.Comanda_Id);
                db.AsignarParametroEntero("@cli", oComanda.Cliente_Id);
                db.AsignarParametroDecimal("@sub", oComanda.SubTotal);
                db.AsignarParametroDecimal("@desc", oComanda.Descuento);
                db.AsignarParametroDecimal("@imp_desc", oComanda.Importe_Desc);
                db.AsignarParametroDecimal("@imp_fin", oComanda.Importe_Final);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Confirmar(Int32 comanda_id)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("UPDATE comandas SET Confirmada = 1 WHERE comanda_id = {0}", comanda_id));
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CambioMesa(Int32 comanda_id, Int32 plano_id_old, Int32 plano_id_new)
        {
            try
            {
                db.Connect();
                db.CreateCommand(String.Format("UPDATE comandas SET plano_id = {0} WHERE plano_id = {1} and comanda_id = {2}", plano_id_new, plano_id_old, comanda_id));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("UPDATE plano SET plano_estado_id = 1 WHERE plano_id = {0}", plano_id_old));
                db.ExecuteCommand();

                db.CreateCommand(String.Format("UPDATE plano SET plano_estado_id = 2 WHERE plano_id = {0}", plano_id_new));
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
