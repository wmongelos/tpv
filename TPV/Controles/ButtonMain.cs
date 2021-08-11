using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPV.Activacion
{
    public partial class ButtonMain : UserControl
    {
        public string Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public Image Icon
        {
            get { return imgIcon.Image; }
            set { imgIcon.Image = value; }
        }

        public ButtonMain()
        {
            InitializeComponent();

            this.imgIcon.Click += new EventHandler(this.clickControl);
            this.lblCaption.Click += new EventHandler(this.clickControl);
            this.imgIcon.MouseEnter += new EventHandler(this.ButtonMain_MouseEnter);
            this.imgIcon.MouseLeave += new EventHandler(this.ButtonMain_MouseLeave);
            this.lblCaption.MouseEnter += new EventHandler(this.ButtonMain_MouseEnter);
            this.lblCaption.MouseLeave += new EventHandler(this.ButtonMain_MouseLeave);
        }

        private void clickControl(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void ButtonMain_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(51, 169, 228);
        }

        private void ButtonMain_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(28, 142, 186);
        }
    }
}
