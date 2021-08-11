using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class Silla_1 : UserControl
    {
        public Silla_1()
        {
            InitializeComponent();

            this.lblCaption.MouseDown += new MouseEventHandler(Mouse_Down);
            this.lblCaption.MouseMove += new MouseEventHandler(Mouse_Move);

            this.img.MouseDown += new MouseEventHandler(Mouse_Down);
            this.img.MouseMove += new MouseEventHandler(Mouse_Move);

            this.lblCaption.Click += new EventHandler(Silla_1_Click);
            this.img.Click += new EventHandler(Silla_1_Click);

            //var bmp = new Bitmap(this.img.Image);
            //bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //this.img.Image = bmp;

            //this.lblCaption.Left = 10;
            //this.lblCaption.Top = 30;
        }

        public Int32 NroRotacion { get; set; }

        public RotateFlipType Rotacion
        {
            get { return RotateFlipType.RotateNoneFlipNone; }
            set {
                var bmp = new Bitmap(this.img.Image);
                bmp.RotateFlip(value);
                this.img.Image = bmp;

                if (NroRotacion == 4)
                    this.NroRotacion = 1;
                else
                    this.NroRotacion++;
            }
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
                        this.img.Image = Properties.Resources.Silla_1;
                        this.lblCaption.BackColor = lblCaption.Text == String.Empty ? Color.WhiteSmoke : Color.FromArgb(237, 237, 237);
                        break;
                    case 2:
                        this.img.Image = Properties.Resources.Silla_1_O;
                        this.lblCaption.BackColor = Color.FromArgb(237, 237, 237);
                        break;
                    case 3:
                        this.img.Image = Properties.Resources.Silla_1_C;
                        this.lblCaption.BackColor = Color.FromArgb(237, 237, 237);
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

        private void Silla_1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
