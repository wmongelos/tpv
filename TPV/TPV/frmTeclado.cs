using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPV
{
    public partial class frmTeclado : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;

                return param;
            }
        }
        public frmTeclado()
        {
            InitializeComponent();

            btnA.Click += new EventHandler(this.Send);
        }

        private void Send(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button != null)
                SendKeys.Send(button.Text);
        }
    }
}
