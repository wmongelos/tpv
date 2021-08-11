using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;
using TPV.Reportes;

namespace TPV.Abms
{
    public partial class frmListaPrecios : Form
    {
        private Articulos oArt = new Articulos();
        private DataTable dt = new DataTable();

        public frmListaPrecios()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
       
            dt = oArt.GetListaPrecios();

            dgv.DataSource = dt;

            lblTotal.Text = String.Format("TOTAL DE REGISTROS: {0}", dt.Rows.Count);
            txtBuscar.Focus();
        }

        private void FormatGrid()
        {
            dgv.Columns["codigo"].HeaderText = "REFERENCIA";
            dgv.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["codigo"].HeaderCell.SortGlyphDirection = SortOrder.Descending;

            dgv.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dgv.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["rubro"].HeaderText = "RUBRO";
            dgv.Columns["rubro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["importe_costo"].HeaderText = "IMPORTE COSTO";
            dgv.Columns["importe_costo"].Width = 200;
            dgv.Columns["importe_costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["importe_costo"].DefaultCellStyle.Format = "C2";

            dgv.Columns["iva"].HeaderText = "IVA (%)";
            dgv.Columns["iva"].Width = 200;
            dgv.Columns["iva"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["iva"].DefaultCellStyle.Format = "N2";

            dgv.Columns["margen"].HeaderText = "MARGEN";
            dgv.Columns["margen"].Width = 200;
            dgv.Columns["margen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["margen"].DefaultCellStyle.Format = "N2";

            dgv.Columns["importe_venta"].HeaderText = "IMPORTE";
            dgv.Columns["importe_venta"].Width = 200;
            dgv.Columns["importe_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["importe_venta"].DefaultCellStyle.Format = "C2";

            dgv.Columns["articulo_id"].Visible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            
            dgv.ReadOnly = false;
        }


        private void frmListaPrecios_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmListaPrecios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("codigo LIKE '%{0}%' or descripcion LIKE '%{0}%'", txtBuscar.Text.Trim());
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Datos ds = new Datos();

            foreach (DataRow dr in dt.Rows)
                ds.Productos.Rows.Add(dr["codigo"].ToString(), dr["descripcion"].ToString(), dr["rubro"].ToString(), Convert.ToDecimal(dr["importe_venta"].ToString()).ToString("c2"));


            //using (frmModal frm = new frmModal())
            //{
            //    frmReportViewer frmview = new frmReportViewer(ds.Productos);
            //    frm.oForm = frmview;

            //    frm.ShowDialog();
            //}

        }

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                decimal costo = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["importe_costo"].Value);
                decimal iva = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["iva"].Value);
                decimal totaliva = (iva * costo) / 100;
                costo = costo + totaliva;

                if (costo > 0)
                {
                    decimal total = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["importe_venta"].Value);
                    decimal ganancia = total - costo;
                    decimal margen = (ganancia * 100) / costo;

                    dgv.Rows[e.RowIndex].Cells["margen"].Value = margen;
                }
            }
            else
            {
                decimal costo = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["importe_costo"].Value);
                decimal iva = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["iva"].Value);
                decimal margen = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells["margen"].Value);
                decimal totaliva = (iva * costo) / 100;
                costo = costo + totaliva;

                decimal totalmargen = (margen * costo) / 100;
                decimal venta = costo + totalmargen;

                dgv.Rows[e.RowIndex].Cells["importe_venta"].Value = venta;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Guardar los Cambios?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                oArt.UpdatePrecios(dt);
            }
        }
    }
}
