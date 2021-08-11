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
    public partial class CustomRowSel : UserControl
    {
        public CustomRowSel()
        {
            InitializeComponent();

            lblColumn1.Click += new EventHandler(_Click);
            lblColumn2.Click += new EventHandler(_Click);
        }

        public string Column1
        {
            set
            {
                lblColumn1.Text = value;
            }
            get { return lblColumn1.Text; }
        }

        public string Column2
        {
            set
            {
                lblColumn2.Text = value;
            }
            get { return lblColumn2.Text; }
        }

        private void _Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
