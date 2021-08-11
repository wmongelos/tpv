using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPV.Controles;

namespace TPV
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private Point MouseDownLocation;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                button1.Left = e.X + button1.Left - MouseDownLocation.X;
                button1.Top = e.Y + button1.Top - MouseDownLocation.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Point Location = button1.FindForm().PointToClient(button1.Parent.PointToScreen(button1.Location));
            //MessageBox.Show(Location.ToString());

            ButtonArt btnArt = new ButtonArt();
            btnArt.Tag = 1;
            btnArt.Descripcion = "PRUEBA";
            btnArt.Importe = String.Format("$ {0}", Convert.ToDecimal(10).ToString("N2"));
            flowLayoutPanel1.Controls.Add(btnArt);
        }
    }
}
