using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmImpresora : Form
    {
        private Impresoras oImp = new Impresoras();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oImp = oImp.GetImpresora(value);
                    txtDescripcion.Value = oImp.Nombre;
                    txtImpresora.Value = oImp.Impresora;
                    lblTitulo.Text = String.Format("EDITAR IMPRESORA: {0}", oImp.Nombre);
                }
                else
                    oImp.Impresora_Id = 0;
            }
        }

        public frmAbmImpresora()
        {
            InitializeComponent();
        }

        private void frmAbmImpresora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmImpresora_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtDescripcion.Value.Trim() == string.Empty || txtImpresora.Value.Trim() == string.Empty)
            {
                if (txtDescripcion.Value.Trim() == string.Empty)
                    txtDescripcion.Focus();
                else
                    txtImpresora.Focus();
            }
            else
            {
                if (oFun.ValidarRepetido("impresoras", "nombre", txtDescripcion.Value.ToString().Trim()))
                {
                    oImp.Nombre = txtDescripcion.Value.ToUpper();
                    oImp.Impresora = txtImpresora.Value;

                    if (oImp.Save(oImp))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    frmMsgBox.Show("EL NOMBRE DE LA IMPRESORA INGRESADO YA EXISTE", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                    txtDescripcion.Focus();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnPrintDialog_Click(object sender, EventArgs e)
        {
            frmBuscador frm = new frmBuscador();
            frm.Tabla = "Impresoras";

            if (frm.ShowDialog() == DialogResult.OK)
                txtImpresora.Value = frm.Impresora;  
        }
    }
}
