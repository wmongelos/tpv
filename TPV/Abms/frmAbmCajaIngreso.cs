using System;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmCajaIngreso : Form
    {
        private Caja_Ingresos oIngreso = new Caja_Ingresos();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oIngreso = oIngreso.GetCaja_Ingresos(value);
                    txtDescripcion.Value = oIngreso.Descripcion;
                    lblTitulo.Text = String.Format("EDITAR INGRESO: {0}", oIngreso.Descripcion);
                }
                else
                    oIngreso.Caja_Ingreso_Id = 0;
            }
        }

        public frmAbmCajaIngreso()
        {
            InitializeComponent();
        }

        private void frmAbmCajaIngreso_KeyDown(object sender, KeyEventArgs e)
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
                if (oFun.ValidarRepetido("caja_ingresos", "descripcion", txtDescripcion.Value.ToString().Trim()))
                {
                    oIngreso.Descripcion = txtDescripcion.Value.ToUpper();

                    if (oIngreso.Save(oIngreso))
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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
        }
    }
}
