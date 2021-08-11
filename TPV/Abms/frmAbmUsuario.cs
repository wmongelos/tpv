using System;
using System.Data;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmUsuario : Form
    {
        private Usuarios oUsu = new Usuarios();
        private Usuarios_Roles oRol = new Usuarios_Roles();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oUsu = oUsu.GetUsuario(value);
                    txtUsuario.Value = oUsu.Usuario;
                    txtClave.Value = oUsu.Clave;
                    lblTitulo.Text = String.Format("EDITAR USUARIO: {0}", oUsu.Usuario);
                }
                else
                    oUsu.Usuario_Id = 0;
            }
        }

        public frmAbmUsuario()
        {
            InitializeComponent();
        }

        private void frmAbmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (txtUsuario.Value.Trim() == string.Empty)
                txtUsuario.Focus();
            else
            {
                if (oFun.ValidarRepetido("usuarios", "usuario", txtUsuario.Value.ToString().Trim()))
                {
                    oUsu.Usuario = txtUsuario.Value.ToUpper();
                    oUsu.Clave = txtClave.Value.ToUpper();
                    oUsu.Usuario_Rol_Id = Convert.ToInt32(cboUsuariosRoles.SelectedValue);

                    if (oUsu.Save(oUsu))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    frmMsgBox.Show("EL USUARIO INGRESADO YA EXISTE", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                    txtUsuario.Focus();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmUsuario_Load(object sender, EventArgs e)
        {
            DataView dtv = oRol.GetRoles().DefaultView;
            dtv.Sort = "rol asc";
            cboUsuariosRoles.DataSource = dtv.ToTable();
            cboUsuariosRoles.Display = "rol";
            cboUsuariosRoles.Value = "usuario_rol_id";

            if(oUsu.Usuario_Id > 0)
                cboUsuariosRoles.SelectedValue = oUsu.Usuario_Rol_Id.ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
