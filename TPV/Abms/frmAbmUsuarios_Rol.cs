using System;
using System.Data;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmUsuarios_Rol : Form
    {
        private Usuarios_Roles oRol = new Usuarios_Roles();
        private Funciones oFun = new Funciones();

        public Int32 Id
        {
            get { return 0; }
            set
            {
                if (value > 0)
                {
                    oRol = oRol.GetUsuarios_Rol(value);
                    txtDescripcion.Value = oRol.Rol;
                    lblTitulo.Text = String.Format("EDITAR ROL DE USUARIO: {0}", oRol.Rol);
                }
                else
                    oRol.Usuario_Rol_Id = 0;
            }
        }

        public frmAbmUsuarios_Rol()
        {
            InitializeComponent();
        }

        private void frmAbmUsuarios_Rol_KeyDown(object sender, KeyEventArgs e)
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
                if (oFun.ValidarRepetido("usuarios_roles", "rol", txtDescripcion.Value.ToString().Trim()))
                {
                    oRol.Rol = txtDescripcion.Value.ToUpper().Trim();

                    if (oRol.Save(oRol, new DataTable()))
                        this.DialogResult = DialogResult.OK;
                    else
                        this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    frmMsgBox.Show("EL ROL INGRESADO YA EXISTE", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

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
