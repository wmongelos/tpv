using System;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class TextBoxAdv : UserControl
    {
        public TextBoxAdv()
        {
            InitializeComponent();

            this.Value = this.Numerico == true ? 0.ToString() : "";
        }

        private Boolean isnumeric;
        public Boolean Numerico
        {
            get { return isnumeric; }
            set { isnumeric = value; }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { 
                SendKeys.Send("{TAB}");

                e.Handled = true;
            }
            else
            {
                if (Numerico == true)
                {
                    if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                    {
                        e.Handled = true;
                        return;
                    }
                }
            }

            this.OnKeyPress(e);
        }

        public String Value { get { return txt.Text; } set { txt.Text = value; } }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            this.Value = txt.Text == null ? "": txt.Text.ToString();
        }
    }
}
