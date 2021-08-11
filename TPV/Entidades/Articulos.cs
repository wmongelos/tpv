using System;
using System.Data;

namespace TPV.Entidades
{
    class Articulos
    {
        public Int32 Articulo_Id;
        public String Codigo;
        public String Descripcion;
        public Int32 Rubro_Id;
        public Int32 Salida;
        public Int32 Impresora_Id;
        public String Barcode;
        public Decimal Importe_Costo;
        public Decimal Margen;
        public Decimal Importe_Margen;
        public Decimal Importe_Neto;
        public Decimal Iva;
        public Decimal Importe_Venta;
        public String Imagen;
        public Decimal Stock;
        public Decimal Stock_Minimo;
        public String Impresora;

        private DbHelper db = DbHelper.getDbHelper();

        public void CreateTable()
        {
            try
            {
                db.Connect();

                if(GlobalVar.isTrial)
                    db.CreateCommand("CREATE TABLE articulos(articulo_id integer PRIMARY KEY, codigo VARCHAR(50), descripcion VARCHAR(50) NOT NULL,  " +
                        "rubro_id integer DEFAULT 0, salida integer DEFAULT 0, impresora_id integer DEFAULT 0, barcode VARCHAR(50), importe_costo decimal(10,2) DEFAULT 0, margen decimal(10,2) DEFAULT 0,  " +
                        "importe_margen decimal(10,2) DEFAULT 0," +
                        "importe_neto decimal(10,2) DEFAULT 0, iva decimal(10, 2) DEFAULT 0, importe_venta decimal(10, 2) DEFAULT 0, stock decimal(10, 2), stock_minimo decimal(10,2), " +
                        "imagen VARCHAR(50), borrado integer DEFAULT 0);");
                else
                    db.CreateCommand("CREATE TABLE articulos(articulo_id integer NOT NULL AUTO_INCREMENT PRIMARY KEY, codigo VARCHAR(50), descripcion VARCHAR(50) NOT NULL,  " +
                        "rubro_id integer DEFAULT 0, salida integer DEFAULT 0, impresora_id integer DEFAULT 0, barcode VARCHAR(50), importe_costo decimal(10,2) DEFAULT 0, margen decimal(10,2) DEFAULT 0,  " +
                        "importe_margen decimal(10,2) DEFAULT 0," +
                        "importe_neto decimal(10,2) DEFAULT 0, iva decimal(10, 2) DEFAULT 0, importe_venta decimal(10, 2) DEFAULT 0, stock decimal(10, 2), stock_minimo decimal(10,2), " +
                        "imagen VARCHAR(50), borrado integer DEFAULT 0);");

                db.ExecuteCommand();
                db.DisConnect();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Articulos GetArticulo(Int32 Id)
        {
            Articulos oArt = new Articulos();

            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT *,IFNULL((select impresora from impresoras where impresora_id = articulos.impresora_id), '') as impresora FROM articulos WHERE articulo_id = @id");
                db.AsignarParametroEntero("@id", Id);
                dt = db.GetDataTable();
                db.DisConnect();

                oArt.Articulo_Id = Id;
                oArt.Codigo = dt.Rows[0]["codigo"].ToString();
                oArt.Descripcion = dt.Rows[0]["descripcion"].ToString();
                oArt.Rubro_Id = Convert.ToInt32(dt.Rows[0]["rubro_id"]);
                oArt.Salida = Convert.ToInt32(dt.Rows[0]["salida"]);
                oArt.Impresora_Id = Convert.ToInt32(dt.Rows[0]["impresora_id"]);
                oArt.Barcode = dt.Rows[0]["barcode"].ToString();
                oArt.Importe_Costo = Convert.ToDecimal(dt.Rows[0]["importe_costo"].ToString());
                oArt.Margen = Convert.ToDecimal(dt.Rows[0]["margen"].ToString());
                oArt.Importe_Margen = Convert.ToDecimal(dt.Rows[0]["importe_margen"].ToString());
                oArt.Importe_Neto = Convert.ToDecimal(dt.Rows[0]["importe_neto"].ToString());
                oArt.Iva = Convert.ToDecimal(dt.Rows[0]["iva"].ToString());
                oArt.Importe_Venta = Convert.ToDecimal(dt.Rows[0]["importe_venta"].ToString());
                oArt.Imagen = dt.Rows[0]["imagen"].ToString();
                oArt.Stock = Convert.ToDecimal(dt.Rows[0]["stock"]);
                oArt.Stock_Minimo = Convert.ToDecimal(dt.Rows[0]["stock_minimo"]);
                oArt.Impresora = dt.Rows[0]["impresora"].ToString();
            }
            catch (Exception)
            {

                throw;
            }

            return oArt;
        }

        public DataTable GetArticulos()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT codigo, descripcion, rubro, stock, stock_minimo, importe_venta, articulo_id FROM articulos LEFT JOIN rubros on rubros.rubro_id = articulos.rubro_id WHERE articulos.borrado = 0 ORDER BY articulo_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetListaPrecios()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT codigo, descripcion, rubro, importe_costo, iva, margen, importe_venta, articulo_id FROM articulos LEFT JOIN rubros on rubros.rubro_id = articulos.rubro_id WHERE articulos.borrado = 0 ORDER BY articulo_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetArticulosRubros(Int32 Rubro_Id)
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand(String.Format("SELECT codigo, descripcion, importe_venta, imagen, articulo_id, " +
                    "IFNULL((select impresora from impresoras where impresora_id = articulos.impresora_id), '') AS impresora FROM articulos " +
                    "WHERE articulos.rubro_id = {0} AND articulos.borrado = 0 ORDER BY descripcion DESC", Rubro_Id));

                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public DataTable GetStockCritico()
        {
            DataTable dt = new DataTable();

            try
            {
                db.Connect();
                db.CreateCommand("SELECT codigo, descripcion, rubro, stock, stock_minimo FROM articulos LEFT JOIN rubros on rubros.rubro_id = articulos.rubro_id WHERE articulos.borrado = 0 and stock_minimo > stock ORDER BY articulo_id DESC");
                dt = db.GetDataTable();
                db.DisConnect();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dt;
        }

        public Boolean Save(Articulos oArticulo)
        {
            bool result = false;

            try
            {
                db.Connect();

                if (oArticulo.Articulo_Id == 0)
                    db.CreateCommand("INSERT INTO articulos(codigo, descripcion, rubro_id, salida, impresora_id, barcode, importe_costo, margen, importe_margen, " +
                        "importe_neto, iva, importe_venta, stock, stock_minimo, imagen) VALUES(@cod, @descrip, @rub, @sal, @imp, @bar, @costo, @mar, @impmar, " +
                        "@impnet, @iv, @impven, @stock, @stomin, @img)");
                else
                {
                    db.CreateCommand("UPDATE articulos SET codigo = @cod, descripcion = @descrip, rubro_id = @rub, salida = @sal, impresora_id = @imp, barcode = @bar, importe_costo = @costo, " +
                        "margen = @mar, importe_margen = @impmar, importe_neto = @impnet, iva = @iv, importe_venta = @impven, stock = @stock, stock_minimo = @stomin, " +
                        "imagen = @img WHERE articulo_id = @id");

                    db.AsignarParametroEntero("@id", oArticulo.Articulo_Id);
                }

                db.AsignarParametroCadena("@cod", oArticulo.Codigo);
                db.AsignarParametroCadena("@descrip", oArticulo.Descripcion);
                db.AsignarParametroEntero("@rub", oArticulo.Rubro_Id);
                db.AsignarParametroEntero("@sal", oArticulo.Salida);
                db.AsignarParametroEntero("@imp", oArticulo.Impresora_Id);
                db.AsignarParametroCadena("@bar", oArticulo.Barcode);
                db.AsignarParametroDecimal("@costo", oArticulo.Importe_Costo);
                db.AsignarParametroDecimal("@mar", oArticulo.Margen);
                db.AsignarParametroDecimal("@impmar", oArticulo.Importe_Margen);
                db.AsignarParametroDecimal("@impnet", oArticulo.Importe_Neto);
                db.AsignarParametroDecimal("@iv", oArticulo.Iva);
                db.AsignarParametroDecimal("@impven", oArticulo.Importe_Venta);
                db.AsignarParametroDecimal("@stock", oArticulo.Stock);
                db.AsignarParametroDecimal("@stomin", oArticulo.Stock_Minimo);
                db.AsignarParametroCadena("@img", oArticulo.Imagen);
                
                db.ExecuteCommand();
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

        public void Delete(Int32 Id)
        {
            try
            {
                db.Connect();
                db.CreateCommand("UPDATE articulos SET borrado = 1 WHERE articulo_id = @id");
                db.AsignarParametroEntero("@id", Id);
                db.ExecuteCommand();
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdatePrecios(DataTable dt)
        {
            try
            {
                db.Connect();

                foreach (DataRow dr in dt.Rows)
                {
                    db.CreateCommand("UPDATE articulos SET importe_costo = @costo, iva = @iva, margen = @margen, importe_venta = @venta WHERE articulo_id = @id");

                    db.AsignarParametroEntero("@id", Convert.ToInt32(dr["articulo_id"]));
                    db.AsignarParametroDecimal("@costo", Convert.ToDecimal(dr["importe_costo"]));
                    db.AsignarParametroDecimal("@iva", Convert.ToDecimal(dr["iva"]));
                    db.AsignarParametroDecimal("@margen", Convert.ToDecimal(dr["margen"]));
                    db.AsignarParametroDecimal("@venta", Convert.ToDecimal(dr["importe_venta"]));
                    db.ExecuteCommand();
                }
                
                db.DisConnect();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
