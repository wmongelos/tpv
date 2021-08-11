using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPV.Controles;

namespace TPV
{
    public partial class frmConfigDB : Form
    {
        private DbHelper db = DbHelper.getDbHelper();

        public frmConfigDB()
        {
            InitializeComponent();
        }

        private void frmConfigDB_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string server = txtServer.Value.ToLower().Trim();
            string user = txtUsuario.Value.ToLower().Trim();
            string pwd = txtPwd.Value.ToLower().Trim();
            string port = txtPuerto.Value.ToLower().Trim();

            if (server == String.Empty || user == String.Empty || port == String.Empty)
            {
                if (server == String.Empty)
                    txtServer.Focus();

                if (user == String.Empty)
                    txtUsuario.Focus();

                if (port == String.Empty)
                    txtPuerto.Focus();
            }
            else
            {
                if (db.Connect(server, user, pwd, port))
                {
                    Properties.Settings.Default.DB_Server = server;
                    Properties.Settings.Default.DB_User = user;
                    Properties.Settings.Default.DB_Pwd = pwd;
                    Properties.Settings.Default.DB_Port = port;
                    Properties.Settings.Default.Save();

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    frmMsgBox.Show("Error de Conexion. Verique los Datos", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                    txtServer.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
