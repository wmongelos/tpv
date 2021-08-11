using System;
using System.Data;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV
{
    public partial class frmCajaDiariaHistorial : Form
    {
        private Caja oCaja = new Caja();
        private DataTable dt = new DataTable();

        public frmCajaDiariaHistorial()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;

            dt = oCaja.GetCajas(desde, hasta);

            dgv.Visible = dt.Rows.Count == 0 ? false : true;

            dgv.DataSource = dt;
            dgv.Columns["caja_id"].Visible = false;
            dgv.Columns["usuario_id"].Visible = false;
            dgv.Columns["fechahora"].HeaderText = "FECHA";
            dgv.Columns["fechahora"].Width = 200;
            dgv.Columns["importe_saldo_inicial"].HeaderText = "S. INICIAL";
            dgv.Columns["importe_saldo_inicial"].Width = 100;
            dgv.Columns["importe_saldo_inicial"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_saldo_inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_total_efe"].HeaderText = "EFECTIVO";
            dgv.Columns["importe_total_efe"].Width = 100;
            dgv.Columns["importe_total_efe"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_total_efe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_total_cred"].HeaderText = "T. CREDITO";
            dgv.Columns["importe_total_cred"].Width = 100;
            dgv.Columns["importe_total_cred"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_total_cred"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_total_deb"].HeaderText = "T. DEBITO";
            dgv.Columns["importe_total_deb"].Width = 100;
            dgv.Columns["importe_total_deb"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_total_deb"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_total_egr"].HeaderText = "EGRESOS";
            dgv.Columns["importe_total_egr"].Width = 100;
            dgv.Columns["importe_total_egr"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_total_egr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["importe_total_ing"].HeaderText = "INGRESOS";
            dgv.Columns["importe_total_ing"].Width = 100;
            dgv.Columns["importe_total_ing"].DefaultCellStyle.Format = "c2";
            dgv.Columns["importe_total_ing"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["usuario"].HeaderText = "USUARIO";
            dgv.Columns["usuario"].DisplayIndex = 0;
            dgv.Columns["usuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv.Columns["cubiertos"].HeaderText = "CUBIERTOS";
            dgv.Columns["cubiertos"].Width = 100;
            dgv.Columns["cubiertos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

           // var total = dt.Select("SUM")

        }

        private void frmCajaDiariaHistorial_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
