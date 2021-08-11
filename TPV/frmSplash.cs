using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPV
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            oTimer.Enabled = true;
            oTimer.Interval = 3000;
        }

        private void frmSplash_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void oTimer_Tick(object sender, EventArgs e)
        {
            oTimer.Stop();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
