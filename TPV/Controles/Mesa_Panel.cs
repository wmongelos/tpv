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
    public partial class Mesa_Panel : UserControl
    {
        private bool mouseClicked = false;
        private Point MouseDownLocation;

        public Mesa_Panel()
        {
            InitializeComponent();
        }

        public Boolean Move_Object { get; set; }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;

            //if (Move_Object)
            //{
            //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //    {
            //        MouseDownLocation = e.Location;
            //    }
            //}
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move_Object == false)
            {
                if (mouseClicked)
                {
                    this.Height = e.Y;
                    this.Width = e.X;
                }
            }
            else
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    this.Left = e.X + this.Left - MouseDownLocation.X;
                    this.Top = e.Y + this.Top - MouseDownLocation.Y;
                }
            }

            //if (Move_Object == true)
            //{
            //    if (e.Button == System.Windows.Forms.MouseButtons.Left)
            //    {
            //        this.Left = e.X + this.Left - MouseDownLocation.X;
            //        this.Top = e.Y + this.Top - MouseDownLocation.Y;
            //    }
            //}
        }

        private void Mesa_Panel_DoubleClick(object sender, EventArgs e)
        {
            this.Move_Object = !this.Move_Object;
        }
    }
}
