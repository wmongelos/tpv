using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;

namespace TPV
{
    public partial class frmActivacion : Form
    {
        private string _Pass;

        public frmActivacion(string BaseString,
            string Password, int DaysToEnd, int Runed, string info)
        {
            InitializeComponent();

            _Pass = Password;
            lblDias.Text = DaysToEnd.ToString();

            serialBox1.Text = BaseString;

            if (DaysToEnd <= 0)
            { 
                lblDias.Text = "FINALIZADO";
                btnPrueba.Enabled = false;
            }

            serialBox2.Select();

        }

        private void frmActivacion_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (_Pass == serialBox2.Text)
            {
                frmMsgBox.Show("Muchas gracias por su compra.", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
               frmMsgBox.Show("La clave de activación es incorrecta. Intente nuevamente.", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);
               serialBox2.Select   ();
            }
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
