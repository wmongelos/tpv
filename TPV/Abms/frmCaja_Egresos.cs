using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmCaja_Egresos : Form
    {
        private Caja_Egresos oEgreso = new Caja_Egresos();
        private DataTable dt = new DataTable();

        public frmCaja_Egresos()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt = oEgreso.GetCaja_Egresos();

            dgv.DataSource = dt;

            lblTotal.Text = String.Format("TOTAL DE REGISTROS: {0}", dt.Rows.Count);
            txtBuscar.Focus();
        }

        private void FormatGrid()
        {
            dgv.Columns["caja_egreso_id"].HeaderText = "REFERENCIA";
            dgv.Columns["caja_egreso_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["caja_egreso_id"].HeaderCell.SortGlyphDirection = SortOrder.Descending;

            dgv.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dgv.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["borrado"].Visible = false;

            Bitmap imgEdit = new Bitmap(Properties.Resources.Data_Edit_24);
            DataGridViewImageColumn imgColEdit = new DataGridViewImageColumn();
            imgColEdit.Name = "EDITAR";
            imgColEdit.Image = imgEdit;

            dgv.Columns.Add(imgColEdit);

            Bitmap imgDelete = new Bitmap(Properties.Resources.Garbage_Closed_24);
            DataGridViewImageColumn imgColDel = new DataGridViewImageColumn();
            imgColDel.Image = imgDelete;
            imgColDel.Name = "ELIMINAR";
            dgv.Columns.Add(imgColDel);
        }

        private void Delete(Int32 Id)
        {
            if (frmMsgBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            { 
                oEgreso.Delete(Id);

                LoadData();
            }
        }

        private void Edit(Int32 Id)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmCajaEgreso frmABM = new frmAbmCajaEgreso();
                frmABM.Id = Convert.ToInt32(Id);
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void frmCaja_Egresos_Load(object sender, EventArgs e)
        { 
            this.LoadData();
            this.FormatGrid();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmCajaEgreso frmABM = new frmAbmCajaEgreso();
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
            if (txtBuscar.Text != string.Empty)
            {
                DataView dtv = new DataView(dt);
                dtv.RowFilter = string.Format("CONVERT(caja_egreso_id, System.String) LIKE '%{0}%' or descripcion LIKE '%{0}%'", txtBuscar.Text.Trim());

                dgv.DataSource = dtv;
            }
            else
                LoadData();
        }

        private void frmCaja_Egresos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "EDITAR":
                        this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["caja_egreso_id"].Value));
                        break;
                    case "ELIMINAR":
                        this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["caja_egreso_id"].Value));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
