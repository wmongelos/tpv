using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class Mesa_1 : UserControl
    {
        public Mesa_1()
        {
            InitializeComponent();

            this.lblCaption.MouseDown += new MouseEventHandler(Mouse_Down);
            this.lblCaption.MouseMove += new MouseEventHandler(Mouse_Move);

            this.img.MouseDown += new MouseEventHandler(Mouse_Down);
            this.img.MouseMove += new MouseEventHandler(Mouse_Move);

            this.lblCaption.Click += new EventHandler(Mesa_1_Click);
            this.img.Click += new EventHandler(Mesa_1_Click);
            this.Width = 89;
            this.Height = 55;
        }

        private Int32 estado;
        public Int32 setEstado
        {
            get { return estado; }
            set
            {
                estado = value;
                switch (setEstado)
                {
                    case 1:
                        this.img.Image = Properties.Resources.Mesa_1;
                        this.lblCaption.BackColor = Color.FromArgb(152, 77, 42);
                        break;
                    case 2:
                        this.img.Image = Properties.Resources.Mesa_1_O;
                        this.lblCaption.BackColor = Color.FromArgb(191, 8, 17);
                        break;
                    case 3:
                        this.img.Image = Properties.Resources.Mesa_1_C;
                        this.lblCaption.BackColor = Color.FromArgb(221, 220, 27);
                        break;
                    default:
                        break;
                }
            }
        }

        public String Caption
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public Boolean Move_Object { get; set; }

        private Point MouseDownLocation;

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            if (Move_Object) { 
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    MouseDownLocation = e.Location;
                }
            }
        }

        private void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (Move_Object)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    this.Left = e.X + this.Left - MouseDownLocation.X;
                    this.Top = e.Y + this.Top - MouseDownLocation.Y;
                }
            }
        }

        private void Mesa_1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
