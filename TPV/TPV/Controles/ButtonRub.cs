using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class ButtonRub : UserControl
    {
        public ButtonRub()
        {
            InitializeComponent();

            this.MouseEnter += new EventHandler(Mouse_Enter);
            this.MouseLeave += new EventHandler(Mouse_Leave);

            rectangleShape1.MouseEnter += new EventHandler(Mouse_Enter);
            rectangleShape1.MouseLeave += new EventHandler(Mouse_Leave);

            lblCaption.MouseEnter += new EventHandler(Mouse_Enter);
            lblCaption.MouseLeave += new EventHandler(Mouse_Leave);

            rectangleShape1.Click += new EventHandler(ButtonRub_Click);
            lblCaption.Click += new EventHandler(ButtonRub_Click);
        }

        public String Value
        {
            get { return lblCaption.Text; }
            set
            {
                //if (value.Length >= 10)
                lblCaption.Font = new Font("Tahoma", 10, FontStyle.Regular);

                lblCaption.Text = value;
            }
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            lblCaption.BackColor = Color.FromArgb(28, 142, 186);
            rectangleShape1.FillColor = Color.FromArgb(28, 142, 186);
            lblCaption.ForeColor = Color.White;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            lblCaption.BackColor = Color.WhiteSmoke;
            rectangleShape1.FillColor = Color.WhiteSmoke;
            lblCaption.ForeColor = Color.DimGray;
        }

        private void ButtonRub_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
