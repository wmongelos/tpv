using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmCajaSaldo : Form
    {
        private Caja_Detalle oCajDet = new Caja_Detalle();

        public frmAbmCajaSaldo()
        {
            InitializeComponent();
        }

        private void frmAbmCajaSaldo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmCajaSaldo_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (spImporte.Value == 0)
                spImporte.Focus();
            else
            {
                oCajDet.SetSaldoInicial(spImporte.Value);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
