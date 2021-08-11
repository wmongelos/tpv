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
    public partial class CustomRowCaja : UserControl
    {
        public CustomRowCaja()
        {
            InitializeComponent();

            lblColumn1.DoubleClick += new EventHandler(DbClick);
            lblColumn2.DoubleClick += new EventHandler(DbClick);
            // iconDelete.Click += new EventHandler(this.Delete);
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

        public string Column3
        {
            set
            {
                lblColumn3.Text = value;
            }
            get { return lblColumn3.Text; }
        }

        public string Column4
        {
            set
            {
                lblColumn4.Text = value;
            }
            get { return lblColumn4.Text; }
        }

        private void DbClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(e);
        }

        //private void CustomRowArt_Click(object sender, EventArgs e)
        //{
        //    this.BackColor = Color.WhiteSmoke;
        //}

        private void CustomRowCaja_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
        }

        private void CustomRowCaja_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(237, 237, 237);
        }

        //private void iconDelete_MouseHover(object sender, EventArgs e)
        //{
        //    ToolTip tt = new ToolTip();
        //    tt.SetToolTip(this.iconDelete, "Eliminar");
        //}
    }
}
