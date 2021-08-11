using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            if (GlobalVar.isTrial)
                this.Text = "DEMO";
            else
                this.Text = "LOGIN";
                
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg != 0x1503) //EM_SHOWBALOONTIP
                base.WndProc(ref m);
        }

        private void frmLogin_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty || txtClave.Text == String.Empty)
            {
                if (txtUsuario.Text == String.Empty)
                    txtUsuario.Focus();
                else
                    txtClave.Focus();
            }
            else
            {
                Usuarios oUsuario = new Usuarios();

                if (oUsuario.ValidAccess(txtUsuario.Text.Trim(), txtClave.Text.Trim()))
                    this.DialogResult = DialogResult.OK;
                else
                {
                    txtUsuario.Text = "";
                    txtClave.Text = "";

                    txtUsuario.Focus();
                }
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.CapsLock)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            { 
                btnIngresar.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                txtClave.Focus();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
