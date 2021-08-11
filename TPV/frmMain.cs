using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TPV.Abms;
using TPV.Entidades;
using TPV.Activacion;
using TPV.Controles;

namespace TPV
{
    public partial class frmMain : Form
    {
        private Usuarios_Roles oRol = new Usuarios_Roles();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static frmMain oForm = null;

        public static frmMain Instance()
        {
            if (oForm == null)
                oForm = new frmMain();

            return oForm;
        }

        private frmMain()
        {
            InitializeComponent();

            btnConfiguracion.Click += new System.EventHandler(this.ClickMenu);
            btnCompras.Click += new System.EventHandler(this.ClickMenu);
            btnContabilidad.Click += new System.EventHandler(this.ClickMenu);
            btnInformes.Click += new System.EventHandler(this.ClickMenu);
            btnVentas.Click += new System.EventHandler(this.ClickMenu);

            lblUserLogin.Text = GlobalVar.CurrentUser_Name.ToUpper();

            pnMenu.MouseMove += new MouseEventHandler(MoveForm);
            pnContent.MouseMove += new MouseEventHandler(MoveForm);

            pnMenu.Height = 50;
            pnConfiguracion.Location = new Point(0, 50);
            pnCompras.Location = new Point(0, 50);
            pnContabilidad.Location = new Point(0, 50);
            pnInformes.Location = new Point(0, 50);
            pnVentas.Location = new Point(0, 50);
        }

        private void openForm(Form oForm)
        {
            this.pnMenu.Height = 50;

            oForm.TopLevel = false;
            pnContent.Controls.Add(oForm);
            oForm.WindowState = FormWindowState.Maximized;

            oForm.Show();
        }

        private Boolean validarAcceso(int objeto_id)
        {
            if (oRol.ValidarPermiso(GlobalVar.CurrentUser_Rol_Id, objeto_id) == false)
            {
                frmMsgBox.Show("No posee permisos de acceso", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                return false;
            }

            return true;
        }

        private void opcionesMenu()
        {
            for (int i = 0; i < pnContent.Controls.Count; i++)
                pnContent.Controls.RemoveAt(i);

            pnVentas.Visible = false;
            pnCompras.Visible = false;
            pnConfiguracion.Visible = false;
            pnInformes.Visible = false;
            pnContabilidad.Visible = false;

            this.pnMenu.Height = 150;
        }

        private void ClickMenu(object sender, EventArgs e)
        {
            this.opcionesMenu();

            for (int i = 0; i < pnContent.Controls.Count; i++)
                pnContent.Controls.RemoveAt(i);

            var button = (Button)sender;
            if (button != null)
            { 
                switch (button.Name)
                {
                    case "btnConfiguracion":
                        pnConfiguracion.Visible = true;
                        break;
                    case "btnCompras":
                        pnCompras.Visible = true;
                        break;
                    case "btnContabilidad":
                        pnContabilidad.Visible = true;
                        break;
                    case "btnInformes":
                        pnInformes.Visible = true;
                        break;
                    case "btnTPV":
                        break;
                    case "btnVentas":
                        pnVentas.Visible = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private void pnContent_Paint(object sender, PaintEventArgs e)
        {
            int width = this.pnContent.Width - 1;
            int height = this.pnContent.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void MoveForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnRubros_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmRubros());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmArticulos());
        }

        public void Minimized()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTPV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnContent.Controls.Count; i++)
                pnContent.Controls.RemoveAt(i);

            
            frmPlano frm = frmPlano.Instance();

            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if(this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmClientes());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmProveedores());
        }

        private void btnPlano_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
            { 
                using (frmModal frm = new frmModal())
                {
                    frm.oForm = new frmAbmPlano();
                    frm.ShowDialog();            
                }
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmPersonal());
        }

        private void oReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

            if (this.WindowState == FormWindowState.Normal)
                this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmUsuarios_Roles());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmUsuarios());
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmCaja_Egresos());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmCaja_Ingresos());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmCajaDiaria());
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmOpciones());
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            //foreach (Form frm in Application.OpenForms)
            //{
            //    if (this.WindowState == FormWindowState.Normal)
            //        frm.Show();

            //    frm.WindowState = this.WindowState;
            //}
        }

        private void btnCierres_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmCajaDiariaHistorial());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            Left = Top = 0;

            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            //Funciones oFunc = new Funciones();
            //oFunc.GenerarBackup();
        }

        private void btnFacturaCompra_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmFacturaCompra());
        }

        private void btnCocina_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pnContent.Controls.Count; i++)
                pnContent.Controls.RemoveAt(i);

            frmCocina frm = new frmCocina();
            frm.Show();
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
            { 
                frmConfigTPV frm = new frmConfigTPV();
                frm.ShowDialog();
            }
        }

        private void btnImpresoras_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmImpresoras());
        }

        private void btnListaPrecios_Click(object sender, EventArgs e)
        {
            ButtonMain btn = (ButtonMain)sender;

            if (this.validarAcceso(Convert.ToInt32(btn.Tag)))
                openForm(new frmListaPrecios());
        }

        private void btnCierreX_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Emitir el Cierre Fiscal X?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                FiscalPrinterLib.HASAR oFiscal = new FiscalPrinterLib.HASAR();
                oFiscal.Puerto = 3;
                oFiscal.Modelo = FiscalPrinterLib.ModelosDeImpresoras.MODELO_P441 ;
                oFiscal.Comenzar();
                oFiscal.TratarDeCancelarTodo();

                object t;
                oFiscal.ReporteX(out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t
                    , out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t);
                oFiscal.Finalizar();
            }
        }

        private void btnCierreZ_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Emitir el Cierre Fiscal Z?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                FiscalPrinterLib.HASAR oFiscal = new FiscalPrinterLib.HASAR();
                oFiscal.Puerto = 3;
                oFiscal.Modelo = FiscalPrinterLib.ModelosDeImpresoras.MODELO_P441;
                oFiscal.Comenzar();
                oFiscal.TratarDeCancelarTodo();

                object t;
                oFiscal.ReporteZ(out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t
                    , out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t);
                oFiscal.Finalizar();
            }
        }
    }
}
