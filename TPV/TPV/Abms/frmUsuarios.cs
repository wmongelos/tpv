using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmUsuarios : Form
    {
        private DataTable dt = new DataTable();
        private Usuarios oUsu = new Usuarios();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dt = oUsu.GetUsuarios();

            dgv.DataSource = dt;
            dgv.Sort(dgv.Columns["usuario_id"], System.ComponentModel.ListSortDirection.Descending);

            lblTotal.Text = String.Format("TOTAL DE REGISTROS: {0}", dt.Rows.Count);
            txtBuscar.Focus();
        }

        private void FormatGrid()
        {
            dgv.Columns["borrado"].Visible = false;
            dgv.Columns["clave"].Visible = false;
            dgv.Columns["usuario_rol_id"].Visible = false;

            dgv.Columns["usuario_id"].HeaderText = "REFERENCIA";
            dgv.Columns["usuario_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgv.Columns["usuario_id"].HeaderCell.SortGlyphDirection = SortOrder.Descending;
            dgv.Columns["usuario"].HeaderText = "USUARIO";
            dgv.Columns["usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["rol"].HeaderText = "ROL DE USUARIO";
            dgv.Columns["rol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["rol"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                if (Id.ToString() == "1")
                    frmMsgBox.Show("No se puede Eliminar el Usuario Administrador", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);
                else
                { 
                    DataRow[] dr = dt.Select(String.Format("usuario_id = {0}", Id.ToString()));

                    oUsu.Delete(Id);

                    LoadData();
                }
            }
        }

        private void Edit(Int32 Id)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmUsuario frmABM = new frmAbmUsuario();
                frmABM.Id = Id;
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                    this.LoadData();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            this.LoadData();
            this.FormatGrid();
        }

        private void frmUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmUsuario frmABM = new frmAbmUsuario();
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
                dtv.RowFilter = string.Format("CONVERT(usuario_id, System.String) LIKE '%{0}%' or usuario LIKE '%{0}%'", txtBuscar.Text.Trim());

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
                        this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["usuario_id"].Value));
                        break;
                    case "ELIMINAR":
                        this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["usuario_id"].Value));
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
