using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmPersonal : Form
    {
        private Personal oPer = new Personal();
        private Tipos_Responsables oTip = new Tipos_Responsables();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oPer = oPer.getPersonal(value);

                    txtApellido.Value = oPer.Apellido;
                    txtNombre.Value = oPer.Nombre;
                    txtCuit.Value = oPer.Cuit;
                    txtDomicilio.Value = oPer.Domicilio;
                    txtTelefono_1.Value = oPer.Telefono_1;
                    txtTelefono_2.Value = oPer.Telefono_2;
                    txtEmail.Value = oPer.Email;

                    lblTitulo.Text = String.Format("EDITAR PERSONAL: {0}", oPer.Apellido);
                }
                else
                    oPer.Personal_Id = 0;
            }
        }

        public frmAbmPersonal()
        {
            InitializeComponent();
        }

        private void frmAbmPersonal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmPersonal_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtApellido.Value.Trim() == "" || txtNombre.Value == "")
            {
                if (txtApellido.Value == "")
                    txtApellido.Focus();
                else
                    txtNombre.Focus();
            }
            else
            { 
                oPer.Apellido = txtApellido.Value.ToString();
                oPer.Nombre = txtNombre.Value.ToString();
                oPer.Cuit = txtCuit.Value.ToString();
                oPer.Domicilio = txtDomicilio.Value.ToString();
                oPer.Telefono_1 = txtTelefono_1.Value.ToString();
                oPer.Telefono_2 = txtTelefono_2.Value.ToString();
                oPer.Email = txtEmail.Value.ToString();

                oPer.Save(oPer);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmPersonal_Load(object sender, EventArgs e)
        {
          
        }
    }
}
