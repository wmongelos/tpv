using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmRubros : Form
    {
        private DataTable dt = new DataTable();
        private Rubros oRub = new Rubros();

        public frmRubros()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt = oRub.GetRubros();

            dgv.DataSource = dt;

            lblTotal.Text = String.Format("TOTAL DE REGISTROS: {0}", dt.Rows.Count);
            txtBuscar.Focus();
        }

        private void FormatGrid()
        {
            dgv.Columns["borrado"].Visible = false;

            dgv.Columns["rubro_id"].HeaderText = "REFERENCIA";
            dgv.Columns["rubro_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["rubro_id"].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            dgv.Columns["rubro"].HeaderText = "DESCRIPCION";
            dgv.Columns["rubro"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["total"].HeaderText = "PRODUCTOS";
            dgv.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                DataRow[] dr = dt.Select(String.Format("rubro_id = {0}", Id.ToString()));

                if (Convert.ToInt32(dr[0]["total"]) > 0)
                {
                    if (frmMsgBox.Show("El Rubro Seleccionado Tiene Productos Asociados. ¿Desea Continuar?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
                        oRub.Delete(Id);
                }
                else
                    oRub.Delete(Id);

                LoadData();
            }
        }

        private void Edit(Int32 Id)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmRubro frmABM = new frmAbmRubro();
                frmABM.Id = Id;
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void frmRubros_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmRubros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmRubro frmABM = new frmAbmRubro();
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
                dtv.RowFilter = string.Format("CONVERT(rubro_id, System.String) LIKE '%{0}%' or rubro LIKE '%{0}%'", txtBuscar.Text.Trim());

                dgv.DataSource = dtv;
            }
            else
                LoadData();
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
    }
}
