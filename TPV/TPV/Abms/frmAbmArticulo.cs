using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmArticulo : Form
    {
        private Articulos oArt = new Articulos();
        private Rubros oRub = new Rubros();
        private Impresoras oImp = new Impresoras();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oArt = oArt.GetArticulo(value);

                    txtCodigo.Value = oArt.Codigo;
                    txtDescripcion.Value = oArt.Descripcion;
                    cboRubros.SelectedValue = oArt.Rubro_Id.ToString();
                    txtBarCode.Value = oArt.Barcode;
                    spImporteCosto.Value = oArt.Importe_Costo;
                    spIva.Value = oArt.Iva;
                    spMargen.Value = oArt.Margen;
                    spImporteVenta.Value = oArt.Importe_Venta;
                    spStock.Value = oArt.Stock;
                    spStock_Minimo.Value = oArt.Stock_Minimo;

                    if (oArt.Imagen.Trim() != String.Empty)
                    {
                        img.Image = Image.FromFile(System.IO.Path.Combine(String.Format("{0}\\Files", Application.StartupPath), oArt.Imagen));
                        op.FileName = oArt.Imagen;
                    }

                    lblTitulo.Text = String.Format("EDITAR PRODUCTO: {0}", oArt.Descripcion);
                }
                else
                    oArt.Articulo_Id = 0;
            }
        }

        private void calcularImporteVenta()
        {
            decimal costo = spImporteCosto.Value;
            decimal iva = spIva.Value;
            decimal margen = spMargen.Value;
            decimal totaliva = (iva * costo) / 100;
            costo = costo + totaliva;

            decimal totalmargen = (margen * costo) / 100;
            decimal venta = costo + totalmargen;

            spImporteVenta.Value = venta;
        }

        public frmAbmArticulo()
        {
            InitializeComponent();

            
        }

        private void frmAbmArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmArticulo_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtDescripcion.Value == "" || txtCodigo.Value == "")
            {
                if (txtDescripcion.Value == "")
                    txtDescripcion.Focus();
                else
                    txtCodigo.Focus();
            }
            else
            { 
                oArt.Codigo = txtCodigo.Value.ToString();
                oArt.Descripcion = txtDescripcion.Value.ToString();
                oArt.Rubro_Id = cboRubros.SelectedValue == string.Empty ? 0 : Convert.ToInt32(cboRubros.SelectedValue);
                oArt.Barcode = txtBarCode.Value.ToString();
                oArt.Importe_Costo = spImporteCosto.Value;
                oArt.Iva = spIva.Value;
                oArt.Margen = spMargen.Value;
                oArt.Importe_Venta = spImporteVenta.Value;
                oArt.Stock = spStock.Value;
                oArt.Stock_Minimo = spStock_Minimo.Value;
                oArt.Imagen = Path.GetFileName(op.FileName);
                oArt.Salida = Convert.ToInt32(cboSalida.SelectedValue);
                oArt.Impresora_Id = cboSalida.SelectedValue == "0" || cboSalida.SelectedValue == "1" ? 0 : Convert.ToInt32(cboImpresoras.SelectedValue);

                if (oArt.Imagen != "")
                    guardarImagen();

                oArt.Save(oArt);

                if (frmMsgBox.Show("¿Desea Agregar otro Producto?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
                {
                    txtCodigo.Value = "";
                    txtDescripcion.Value = "";
                    txtBarCode.Value = "";
                    spImporteCosto.Value = 0;
                    spIva.Value = 0;
                    spMargen.Value = 0;
                    spImporteVenta.Value = 0;
                    spStock.Value = 0;
                    spStock_Minimo.Value = 0;
                    img.Image = null;
                    txtCodigo.Focus();
                }
                else
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void guardarImagen()
        {
            try
            {
                string fileName = oArt.Imagen;
               
                string sourceFile = System.IO.Path.Combine(Path.GetDirectoryName(op.FileName), fileName);
                string destFile = System.IO.Path.Combine(String.Format("{0}\\Files", Application.StartupPath), fileName);
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            catch { }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmArticulo_Load(object sender, EventArgs e)
        {
            cboRubros.DataSource = oRub.GetRubros();
            cboRubros.Display = "rubro";
            cboRubros.Value = "rubro_id";
            cboRubros.SelectedValue = oArt.Rubro_Id.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Int32));
            dt.Columns.Add("Tipo", typeof(String));
            dt.AcceptChanges();
            dt.Rows.Add(0, "NINGUNA");
            dt.Rows.Add(1, "MONITOR");
            dt.Rows.Add(2, "IMPRESORA");
            dt.AcceptChanges();

            cboSalida.DataSource = dt;
            cboSalida.Display = "Tipo";
            cboSalida.Value = "Id";
            
            cboImpresoras.DataSource = oImp.GetImpresoras();
            cboImpresoras.Display = "nombre";
            cboImpresoras.Value = "impresora_id";
            cboImpresoras.SelectedValue = oArt.Impresora_Id.ToString();
        }

        private void spMargen_Leave(object sender, EventArgs e)
        {
            if (spMargen.Value == 0)
                spMargen.Value = spImporteCosto.Value;
            else
                calcularImporteVenta();
        }

        private void spIva_Leave(object sender, EventArgs e)
        {
            calcularImporteVenta();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                img.Image = Image.FromFile(op.FileName);
            }
        }

        private void spImporteVenta_Leave(object sender, EventArgs e)
        {
            decimal costo = spImporteCosto.Value;
            decimal iva = spIva.Value;
            decimal totaliva = (iva * costo) / 100;
            costo = costo + totaliva;

            if(costo > 0)
            { 
                decimal total = spImporteVenta.Value;
                decimal ganancia = total - costo;
                decimal margen = (ganancia * 100) / costo;

                spMargen.Value = margen;
            }
        }

        private void cboSalida_Seleccion(object sender, EventArgs e)
        {
            cboImpresoras.Enabled = Convert.ToInt32(cboSalida.SelectedValue) == 2 ? true : false;
        }
    }
}
