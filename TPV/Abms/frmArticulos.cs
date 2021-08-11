using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;
using TPV.Reportes;

namespace TPV.Abms
{
    public partial class frmArticulos : Form
    {
        private Articulos oArt = new Articulos();
        private DataTable dt = new DataTable();

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
       
            dt = oArt.GetArticulos();

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
            dgv.Columns["rubro"].Width = 200;
            dgv.Columns["rubro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["stock"].HeaderText = "STOCK";
            dgv.Columns["stock"].Width = 100;
            dgv.Columns["stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["stock_minimo"].HeaderText = "STOCK MIN";
            dgv.Columns["stock_minimo"].Width = 110;
            dgv.Columns["stock_minimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_venta"].HeaderText = "IMPORTE";
            dgv.Columns["importe_venta"].Width = 200;
            dgv.Columns["importe_venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["importe_venta"].DefaultCellStyle.Format = "C2";

            dgv.Columns["articulo_id"].Visible = false;

            Bitmap imgEdit = new Bitmap(Properties.Resources.Data_Edit_24);
            DataGridViewImageColumn imgColEdit = new DataGridViewImageColumn();
            imgColEdit.Name = "EDITAR";
            imgColEdit.HeaderText = "";
            imgColEdit.Image = imgEdit;

            dgv.Columns.Add(imgColEdit);


            Bitmap imgDelete = new Bitmap(Properties.Resources.Garbage_Closed_24);
            DataGridViewImageColumn imgColDel = new DataGridViewImageColumn();
            imgColDel.Image = imgDelete;
            imgColDel.Name = "ELIMINAR";
            imgColDel.HeaderText = "";
            dgv.Columns.Add(imgColDel);
        }

        private void Delete(Int32 Id)
        {
            if (frmMsgBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                Articulos oArt = new Articulos();
                oArt.Delete(Id);

                LoadData();
            }
        }

        private void Edit(Int32 Id)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmArticulo frmABM = new frmAbmArticulo();
                frmABM.Id = Id;
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmArticulo frmABM = new frmAbmArticulo();
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("codigo LIKE '%{0}%' or descripcion LIKE '%{0}%' or rubro LIKE '%{0}%'", txtBuscar.Text.Trim());
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "EDITAR":
                        this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["articulo_id"].Value));
                        break;
                    case "ELIMINAR":
                        this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["articulo_id"].Value));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
