﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class ComboExt : ComboBox
    {
        public ComboExt()
        {
            InitializeComponent();
        }

        public ComboExt(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private static int WM_PAINT = 0x000F;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_PAINT)
            {
                Graphics g = Graphics.FromHwnd(Handle);
                Rectangle bounds = new Rectangle(0, 0, Width, Height);
                ControlPaint.DrawBorder(g, bounds, Color.WhiteSmoke, ButtonBorderStyle.Solid);
            }
        }
    }
}
