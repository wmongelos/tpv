using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmPersonal : Form
    {
        private Personal oPer = new Personal();
        private DataTable dt = new DataTable();
     
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt = oPer.getPersonal();

            dgv.DataSource = dt;

            lblTotal.Text = String.Format("TOTAL DE REGISTROS: {0}", dt.Rows.Count);
            txtBuscar.Focus();
        }

        private void FormatGrid()
        {
            dgv.Columns["personal_id"].HeaderText = "REFERENCIA";
            dgv.Columns["personal_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["personal_id"].HeaderCell.SortGlyphDirection = SortOrder.Descending;

            dgv.Columns["apellido"].HeaderText = "APELLIDO";
            dgv.Columns["apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["nombre"].HeaderText = "NOMBRE";
            dgv.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["telefono_1"].HeaderText = "TELEFONO";
            dgv.Columns["telefono_1"].Width = 200;
            dgv.Columns["telefono_1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["telefono_2"].HeaderText = "TELEFONO ALT.";
            dgv.Columns["telefono_2"].Width = 200;
            dgv.Columns["telefono_2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["cuit"].HeaderText = "CUIT";
            dgv.Columns["cuit"].Width = 200;
            dgv.Columns["cuit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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
                Personal oPer = new Personal();
                oPer.Delete(Id);

                LoadData();
            }
        }

        private void Edit(Int32 Id)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmPersonal frmABM = new frmAbmPersonal();
                frmABM.Id = Id;
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmPersonal frmABM = new frmAbmPersonal();
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
                dtv.RowFilter = string.Format("CONVERT(personal_id, System.String) LIKE '%{0}%' or nombre LIKE '%{0}%' or apellido LIKE '%{0}%' or telefono_1 LIKE '%{0}%' or telefono_2 LIKE '%{0}%'", txtBuscar.Text.Trim());

                dgv.DataSource = dtv;
            }
            else
                LoadData();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                switch (dgv.Columns[e.ColumnIndex].Name)
                {
                    case "EDITAR":
                        this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["personal_id"].Value));
                        break;
                    case "ELIMINAR":
                        this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["personal_id"].Value));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
