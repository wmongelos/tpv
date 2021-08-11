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
    public partial class frmModal : Form
    {
        public Form oForm { get; set; }
        public frmModal()
        {
            InitializeComponent();
        }

        private void frmModal_Load(object sender, EventArgs e)
        {
            this.DialogResult = oForm.ShowDialog();
        }
    }
}
