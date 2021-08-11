using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmRubro : Form
    {
        private Rubros oRub = new Rubros();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oRub = oRub.GetRubro(value);
                    txtDescripcion.Value = oRub.Rubro;
                    lblTitulo.Text = String.Format("EDITAR RUBRO: {0}", oRub.Rubro);
                }
                else
                    oRub.Rubro_Id = 0;
            }
        }

        public frmAbmRubro()
        {
            InitializeComponent();
        }

        private void frmAbmRubro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmRubro_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtDescripcion.Value.Trim() == string.Empty)
                txtDescripcion.Focus();
            else
            {
                if (oFun.ValidarRepetido("rubros", "rubro", txtDescripcion.Value.ToString().Trim()))
                {
                    oRub.Rubro = txtDescripcion.Value.ToUpper();

                    if (oRub.Save(oRub))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    frmMsgBox.Show("EL RUBRO INGRESADO YA EXISTE", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                    txtDescripcion.Focus();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
