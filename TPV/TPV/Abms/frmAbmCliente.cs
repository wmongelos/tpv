using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmCliente : Form
    {
        private Clientes oCli = new Clientes();
        private Tipos_Responsables oTip = new Tipos_Responsables();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oCli = oCli.getCliente(value);

                    txtRSocial.Value = oCli.RSocial;
                    cboTiposResp.SelectedValue = oCli.Tipo_Responsable_Id.ToString();
                    txtCuit.Value = oCli.Cuit;
                    txtDomicilio.Value = oCli.Domicilio;
                    txtApellido.Value = oCli.Apellido;
                    txtNombre.Value = oCli.Nombre;
                    txtTelefono_1.Value = oCli.Telefono_1;
                    txtTelefono_2.Value = oCli.Telefono_2;
                    txtEmail.Value = oCli.Email;

                    lblTitulo.Text = String.Format("EDITAR CLIENTE: {0}", oCli.RSocial);
                }
                else
                    oCli.Cliente_Id = 0;
            }
        }

        public frmAbmCliente()
        {
            InitializeComponent();
        }

        private void frmAbmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmCliente_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtRSocial.Value.Trim() == "")
                txtRSocial.Focus();
            else
            { 
                oCli.RSocial = txtRSocial.Value.ToString();
                oCli.Tipo_Responsable_Id = Convert.ToInt32(cboTiposResp.SelectedValue);
                oCli.Cuit = txtCuit.Value.ToString();
                oCli.Domicilio = txtDomicilio.Value.ToString();
                oCli.Apellido = txtApellido.Value.ToString();
                oCli.Nombre = txtNombre.Value.ToString();
                oCli.Telefono_1 = txtTelefono_1.Value.ToString();
                oCli.Telefono_2 = txtTelefono_2.Value.ToString();
                oCli.Email = txtEmail.Value.ToString();

                oCli.Save(oCli);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmCliente_Load(object sender, EventArgs e)
        {
            cboTiposResp.DataSource = oTip.GetTipoResponsables();
            cboTiposResp.Display = "descripcion";
            cboTiposResp.Value = "tipo_responsable_id";
        }
    }
}
