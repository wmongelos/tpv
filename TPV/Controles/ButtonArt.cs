using System;
using System.Drawing;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class ButtonArt : UserControl
    {
        public ButtonArt()
        {
            InitializeComponent();

            foreach (Control cs in this.Controls)
                cs.Click += new EventHandler(ButtonArt_Click);

            pnImporte.Click += new EventHandler(ButtonArt_Click);
            lblImporte.Click += new EventHandler(ButtonArt_Click);
        }

        private void ButtonArt_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        public String Descripcion
        {
            get { return lblCaption.Text; }
            set { lblCaption.Text = value; }
        }

        public String Importe
        {
            get { return lblImporte.Text; }
            set { lblImporte.Text = value; }
        }

        public Image Imagen
        {
            get { return pbImagen.Image; }
            set { pbImagen.Image = value; }
        }

        public String Impresora { get; set; }
    }
}
