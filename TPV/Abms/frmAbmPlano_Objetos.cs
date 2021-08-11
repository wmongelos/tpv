using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TPV.Abms
{
    public partial class frmAbmPlano_Objetos : Form
    {
        public frmAbmPlano_Objetos()
        {
            InitializeComponent();
            this.Rotacion = 1;
            this.Tipo = "Mesa_1";
        }

        public String Tipo { get; set; }
        public String Nombre { get; set; }
        public Int32 Rotacion { get; set; }

        private void frmAbmPlano_Objetos_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Value.ToString().Trim() == string.Empty)
                txtNombre.Focus();
            else
            {
                
                this.Nombre = txtNombre.Value;

                
                var checkedButton = opgOption.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

                this.Tipo = checkedButton.Tag.ToString();

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnRotacionSilla_1_Click(object sender, EventArgs e)
        {
            silla_1.Rotacion = RotateFlipType.Rotate90FlipNone;

            this.Rotacion = silla_1.NroRotacion;
        }

        private void btnRotacionSilla_2_Click(object sender, EventArgs e)
        {
            silla_2.Rotacion = RotateFlipType.Rotate90FlipNone;

            this.Rotacion = silla_2.NroRotacion;
        }
    }
}
