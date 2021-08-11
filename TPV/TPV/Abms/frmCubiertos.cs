using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmCubiertos : Form
    {

        public Int32 Cantidad { get; set; }

        public frmCubiertos()
        {
            InitializeComponent();
        }

        private void frmCubiertos_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cantidad = Convert.ToInt32(spCantidad.Value);

            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmCubiertos_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            this.Cantidad = Convert.ToInt32(spCantidad.Value);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cantidad = Convert.ToInt32(spCantidad.Value);

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
