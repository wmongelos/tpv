using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class frmMsgBox : Form
    {
        public frmMsgBox()
        {
            InitializeComponent();

            
        }

        private void frmMsgBox_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void setMsg(string msg, string title, MessageButton btn)
        {
            this.lblTitulo.Text = title;
            this.lblMensaje.Text = msg;

            string caption = "";
            string caption_2 = "";
            bool visible = true;
            bool visible_2 = true;
            switch (btn)
            {
                case MessageButton.OK:
                    caption = "ACEPTAR";                    
                    visible_2 = false;
                    break;
                case MessageButton.OKCancel:
                    caption = "ACEPTAR";
                    caption_2 = "CANCELAR";
                    break;
                case MessageButton.YesNo:
                case MessageButton.YesNoCancel:
                    caption = "SI";
                    caption_2 = "NO";
                    break;
                default:
                    caption = "ACEPTAR";
                    caption_2 = "CANCELAR";
                    break;
            }

            this.btnAceptar.Text = caption;
            this.btnCancelar.Text = caption_2;

            this.btnAceptar.Visible = visible;
            this.btnCancelar.Visible = visible_2;

            if(visible_2 == false)
                this.btnAceptar.Left = this.btnCancelar.Left;

            btnAceptar.Focus();
        }

        internal static DialogResult Show(string msg, string title, MessageButton button)
        {
            frmMsgBox frm = new frmMsgBox();
            frm.setMsg(msg, title, button);

            return frm.ShowDialog();
        }

        internal enum MessageButton
        {
            OK,
            YesNo,
            YesNoCancel,
            OKCancel
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
