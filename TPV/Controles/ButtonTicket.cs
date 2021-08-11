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
    public partial class ButtonTicket : UserControl
    {
        public ButtonTicket()
        {
            InitializeComponent();

            this.MouseEnter += new EventHandler(Mouse_Enter);
            this.MouseLeave += new EventHandler(Mouse_Leave);

            lblCaption.MouseEnter += new EventHandler(Mouse_Enter);
            lblCaption.MouseLeave += new EventHandler(Mouse_Leave);

            imgIcon.MouseEnter += new EventHandler(Mouse_Enter);
            imgIcon.MouseLeave += new EventHandler(Mouse_Leave);

            imgIcon.Click += new EventHandler(ButtonRub_Click);
            lblCaption.Click += new EventHandler(ButtonRub_Click);
        }

        public String Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public Image Icon
        {
            get { return imgIcon.Image; }
            set { imgIcon.Image = value; }
        }

        private void ButtonRub_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 160, 220);
            lblCaption.BackColor = Color.FromArgb(0, 160, 220);
            lblCaption.ForeColor = Color.White;
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
            lblCaption.BackColor = Color.Transparent;
            lblCaption.ForeColor = Color.White;
        }
    }
}
