using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmFacturaCompra : Form
    {
        private DataTable dt = new DataTable();
        private Proveedores oPro = new Proveedores();
        private Articulos oArt = new Articulos();

        public frmFacturaCompra()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt.Columns.Add("Descripcion", typeof(String));
            dt.Columns.Add("Unitario", typeof(Decimal));
            dt.Columns.Add("Cantidad", typeof(Decimal));
            dt.Columns.Add("Total", typeof(Decimal));
            dt.Columns.Add("Articulo_Id", typeof(Int32));

            dgv.DataSource = dt;
        }

        private void FormatGrid()
        {
            dgv.Columns["Articulo_Id"].Visible = false;

            dgv.Columns["Descripcion"].HeaderText = "DESCRIPCION";
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Unitario"].HeaderText = "UNITARIO";
            dgv.Columns["Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Unitario"].DefaultCellStyle.Format = "c2";
            dgv.Columns["Cantidad"].HeaderText = "CANTIDAD";
            dgv.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Total"].HeaderText = "TOTAL";
            dgv.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Total"].DefaultCellStyle.Format = "c2";

            Bitmap imgDelete = new Bitmap(Properties.Resources.Garbage_Closed_24);
            DataGridViewImageColumn imgColDel = new DataGridViewImageColumn();
            imgColDel.Image = imgDelete;
            imgColDel.Name = "ELIMINAR";
            dgv.Columns.Add(imgColDel);

           // dgv.CurrentCell = null;
        }

        private void Delete(Int32 Id)
        {
           
        }

        private void Edit(Int32 Id)
        {
            
        }

        private void BuscarProv()
        {
            using (frmModal frm = new frmModal())
            {
                frmBuscador frmBuscar = new frmBuscador();
                frmBuscar.Tabla = "Proveedores";

                frm.oForm = frmBuscar;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    oPro = oPro.getProveedor(frmBuscar.Id);
                    txtRazonSocial.Value = oPro.RSocial;
                }
            }
        }

        private void frmFacturaCompra_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmFacturaCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Value.ToString() != String.Empty)
            {
                dt.Rows.Add(txtDescripcion.Value, spImporteCosto.Value, spCantidad.Value, (spImporteCosto.Value * spCantidad.Value), 0);
                dt.AcceptChanges();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            { 
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "EDITAR":
                        this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["rubro_id"].Value));
                        break;
                    case "ELIMINAR":
                        this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["rubro_id"].Value));
                        break;
                    default:
                        break;
                }
            }

        }

        private void imgBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProv();
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkArticulos.CheckState == CheckState.Checked)
            {
                e.Handled = true;

                if (e.KeyChar == (char)Keys.Enter)
                {
                    using (frmModal frm = new frmModal())
                    {
                        frmBuscador frmBus = new frmBuscador();
                        frmBus.Tabla = "Articulos";
                        frm.oForm = frmBus;

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            Articulos oArt = new Articulos();
                            oArt = oArt.GetArticulo(frmBus.Id);

                            txtDescripcion.Value = oArt.Descripcion;
                            spImporteCosto.Value = oArt.Importe_Costo;
            
                        }
                    }
                }
            }
        }
    }
}
