using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmProveedor : Form
    {
        private Proveedores oPro = new Proveedores();
        private Tipos_Responsables oTip = new Tipos_Responsables();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oPro = oPro.getProveedor(value);

                    txtRSocial.Value = oPro.RSocial;
                    cboTiposResp.SelectedValue = oPro.Tipo_Responsable_Id.ToString();
                    txtCuit.Value = oPro.Cuit;
                    txtDomicilio.Value = oPro.Domicilio;
                    txtApellido.Value = oPro.Apellido;
                    txtNombre.Value = oPro.Nombre;
                    txtTelefono_1.Value = oPro.Telefono_1;
                    txtTelefono_2.Value = oPro.Telefono_2;
                    txtEmail.Value = oPro.Email;

                    lblTitulo.Text = String.Format("EDITAR PROVEEDOR: {0}", oPro.RSocial);
                }
                else
                    oPro.Proveedor_Id = 0;
            }
        }

        public frmAbmProveedor()
        {
            InitializeComponent();
        }

        private void frmAbmProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmProveedor_Paint(object sender, PaintEventArgs e)
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
                oPro.RSocial = txtRSocial.Value.ToString();
                oPro.Tipo_Responsable_Id = Convert.ToInt32(cboTiposResp.SelectedValue);
                oPro.Cuit = txtCuit.Value.ToString();
                oPro.Domicilio = txtDomicilio.Value.ToString();
                oPro.Apellido = txtApellido.Value.ToString();
                oPro.Nombre = txtNombre.Value.ToString();
                oPro.Telefono_1 = txtTelefono_1.Value.ToString();
                oPro.Telefono_2 = txtTelefono_2.Value.ToString();
                oPro.Email = txtEmail.Value.ToString();

                oPro.Save(oPro);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmProveedor_Load(object sender, EventArgs e)
        {
            cboTiposResp.DataSource = oTip.GetTipoResponsables();
            cboTiposResp.Display = "descripcion";
            cboTiposResp.Value = "tipo_responsable_id";
            //cboTiposResp.SelectedValue = oTip.Codigo.ToString();
        }
    }
}
