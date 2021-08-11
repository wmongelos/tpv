using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;

namespace TPV
{
    public partial class frmConfigTPV : Form
    {
        private DataTable dtApp = new DataTable();
        private DataTable dtPDV = new DataTable();
        private DataTable dtModelos = new DataTable();

        public frmConfigTPV()
        {
            InitializeComponent();

            dtApp.Columns.Add("id", typeof(Int32));
            dtApp.Columns.Add("nombre", typeof(String));

            dtPDV.Columns.Add("id", typeof(Int32));
            dtPDV.Columns.Add("punto", typeof(String));

            dtModelos.Columns.Add("id", typeof(Int32));
            dtModelos.Columns.Add("modelo", typeof(String));

            dtApp.AcceptChanges();
            dtPDV.AcceptChanges();
            dtModelos.AcceptChanges();

            dtApp.Rows.Add(1, "PUNTO DE VENTA");
            dtApp.Rows.Add(2, "GESTION DE COCINA");

            dtApp.AcceptChanges();

            for (int i = 1; i < 1000; i++)
                dtPDV.Rows.Add(i, i.ToString().PadLeft(4, '0'));

            dtPDV.AcceptChanges();

            dtModelos.Rows.Add(0, "NINGUNO");
            dtModelos.AcceptChanges();
        }

        private void frmConfigTPV_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TPV_Modulo = cboTipoApp.SelectedValue.ToString();
            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }

        private void frmConfigTPV_Load(object sender, EventArgs e)
        {
            cboTipoApp.DataSource = dtApp;
            cboTipoApp.Value = "id";
            cboTipoApp.Display = "nombre";

            cboPDV.DataSource = dtPDV;
            cboPDV.Value = "id";
            cboPDV.Display = "punto";

            cboModeloFiscal.DataSource = dtModelos;
            cboModeloFiscal.Value = "id";
            cboModeloFiscal.Display = "modelo";
        }
    }
}
