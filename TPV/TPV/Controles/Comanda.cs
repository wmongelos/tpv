using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class Comanda : UserControl
    {
        public Comanda()
        {
            InitializeComponent();

        }

        public Int32 Id { get; set; }

        public String Orden
        {
            get
            {
                return lblOrden.Tag.ToString();
            }
            set
            {
                lblOrden.Text = value;
                lblOrden.Tag = value;
            }
        }

        public String Mesa
        {
            get
            {
                return lblMesa.Tag.ToString();
            }
            set
            {
                lblMesa.Text = String.Format("[ MESA {0}]", value);
                lblMesa.Tag = value;
            }
        }

        public String Hora
        {
            get
            {
                return lblHora.Text;
            }
            set
            {
                lblHora.Text = value;
            }
        }

        private DataTable dt;
        public DataTable ComandaDetalle
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;

                dgv.DataSource = dt;
                dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgv.Columns[1].Width = 60;
                dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[2].Visible = false;
                dgv.Columns[3].Visible = false;
                dgv.Columns[4].Visible = false;
                dgv.Columns[5].Visible = false;
                dgv.Columns[6].Visible = false;
                dgv.Columns[7].Visible = false;


            }
        }

        public void ClearSelection()
        {
            dgv.ClearSelection();
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Rows[e.RowIndex].Cells["estado"].Value.ToString() == "P")
            {
                e.CellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
                e.CellStyle.ForeColor = Color.Green;
            }
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.SelectedRows.Count > 0)
                this.Id = Convert.ToInt32(dgv.SelectedRows[0].Cells["comanda_det_id"].Value);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
                this.Id = Convert.ToInt32(dgv.SelectedRows[0].Cells["comanda_det_id"].Value);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
                this.Id = Convert.ToInt32(dgv.SelectedRows[0].Cells["comanda_det_id"].Value);
        }
    }
}
