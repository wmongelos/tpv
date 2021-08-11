using System;
using System.Windows.Forms;
using System.Drawing;

namespace TPV.Controles
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();

            foreach (Control cs in this.Controls)
            { 
                cs.Click += new EventHandler(Item_Click);
                cs.KeyDown += new KeyEventHandler(Item_Key);
            }        
        }

        public Int32 Articulo_Id { get; set; }

        public String Descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        public String Cantidad
        {
            get { return lblCantidad.Text; }
            set { lblCantidad.Text = value; }
        }

        public String Importe
        {
            get { return lblImporte.Text; }
            set { lblImporte.Text = value; }
        }

        private Int32 estado;
        public Int32 Seleccionar
        {
            get { return estado; }
            set
            {
                estado = value;

                if (value == 1)
                {
                    this.BackColor = Color.SteelBlue;
                    this.lblDescripcion.ForeColor = Color.White;
                    this.lblCantidad.ForeColor = Color.White;
                    this.lblImporte.ForeColor = Color.White;
                }
                else
                {
                    this.BackColor = Color.WhiteSmoke;
                    this.lblDescripcion.ForeColor = Color.DimGray;
                    this.lblCantidad.ForeColor = Color.DimGray;
                    this.lblImporte.ForeColor = Color.DimGray;
                }

            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void Item_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            this.lblDescripcion.ForeColor = Color.DarkGray;
            this.lblCantidad.ForeColor = Color.DarkGray;
            this.lblImporte.ForeColor = Color.DarkGray;
        }

        private void Item_Key(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
    }
}
