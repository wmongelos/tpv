using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmCajaEgreso : Form
    {
        private Caja_Egresos oEgreso = new Caja_Egresos();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oEgreso = oEgreso.GetCaja_Egresos(value);
                    txtDescripcion.Value = oEgreso.Descripcion;
                    lblTitulo.Text = String.Format("EDITAR EGRESO: {0}", oEgreso.Descripcion);
                }
                else
                    oEgreso.Caja_Egreso_Id = 0;
            }
        }

        public frmAbmCajaEgreso()
        {
            InitializeComponent();
        }

        private void frmAbmCajaEgreso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtDescripcion.Value.Trim() == string.Empty)
                txtDescripcion.Focus();
            else
            {
                if (oFun.ValidarRepetido("caja_egresos", "descripcion", txtDescripcion.Value.ToString().Trim()))
                {
                    oEgreso.Descripcion = txtDescripcion.Value.ToUpper();

                    if (oEgreso.Save(oEgreso))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    frmMsgBox.Show("EL EGRESO INGRESADO YA EXISTE", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

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
