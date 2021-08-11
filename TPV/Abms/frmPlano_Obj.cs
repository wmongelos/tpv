using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPV.Controles;

namespace TPV.Abms
{
    public partial class frmPlano_Obj : Form
    {
        public DataTable dt { get; set; }

        public frmPlano_Obj()
        {
            InitializeComponent();


        }

        private void LoadData()
        {
            dgv.DataSource = dt;

            for (int i = 0; i < dgv.Columns.Count; i++)
                dgv.Columns[i].Visible = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            dgv.Columns["plano_id"].Visible = true;
            dgv.Columns["plano_id"].HeaderText = "REFERENCIA";
            dgv.Columns["nombre"].Visible = true;
            dgv.Columns["nombre"].HeaderText = "NOMBRE";
            dgv.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["plano_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Bitmap imgEdit = new Bitmap(Properties.Resources.Data_Edit_24);
            DataGridViewImageColumn imgColEdit = new DataGridViewImageColumn();
            imgColEdit.Image = imgEdit;
            dgv.Columns.Add(imgColEdit);

            Bitmap imgDelete = new Bitmap(Properties.Resources.Garbage_Closed_24);
            DataGridViewImageColumn imgColDel = new DataGridViewImageColumn();
            imgColDel.Image = imgDelete;
            dgv.Columns.Add(imgColDel);
        }

        private void Edit(Int32 id, String Nombre) { }

        private void Delete(Int32 id) {
            MessageBox.Show(id.ToString());
        } 

        private void frmPlano_Obj_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmPlano_Obj_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                using (Pen p = new Pen(Color.Gainsboro, 1))
                {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 3;
                    rect.Height -= 3;

                    e.Graphics.DrawRectangle(p, rect);
                }
                e.Handled = true;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 11:
                    this.Edit(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["plano_id"].Value), dgv.Rows[e.RowIndex].Cells["nombre"].Value.ToString());
                    break;
                case 12:
                    this.Delete(Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["plano_id"].Value));
                    break;
                default:
                    break;
            }
        }
    }
}
