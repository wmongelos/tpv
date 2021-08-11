using System;
using System.Drawing;
using System.Windows.Forms;
using TPV.Abms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class FrmPrincipal : Form
    {
        private static FrmPrincipal aForm = null;
        private Usuarios_Roles oRol = new Usuarios_Roles();

        




        public static FrmPrincipal Instance()
        {
            if (aForm == null)
                aForm = new FrmPrincipal();

            return aForm;
        }

        private Boolean ValidarAcceso(int objeto_id)
        {
            if (oRol.ValidarPermiso(GlobalVar.CurrentUser_Rol_Id, objeto_id) == false)
            {
                frmMsgBox.Show("No posee permisos de acceso", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);

                return false;
            }

            return true;
        }

        private void OpenForm(Objetos.Opciones Opcion, Form Form)
        {
            if(ValidarAcceso((Int32)Opcion))
            {
                PnContent.Controls.Clear();
                Form.TopLevel = false;
                Form.Dock = DockStyle.Fill;

                PnContent.Controls.Add(Form);
                Form.Show();
            }         
        }

        private FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;

            GlobalVar.CurrentUser_Id = 1;
            GlobalVar.CurrentUser_Rol_Id = 1;
            GlobalVar.CurrentUser_Name = "ADMIN";
        }

        private void PnMinimize_MouseEnter(object sender, EventArgs e)
        {
            PnMinimize.BackColor = Color.FromArgb(81, 92, 107);
        }

        private void PnMinimize_MouseLeave(object sender, EventArgs e)
        {
            PnMinimize.BackColor = Color.Transparent;
        }

        private void PnClose_MouseEnter(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.Coral;
        }

        private void PnClose_MouseLeave(object sender, EventArgs e)
        {
            PnClose.BackColor = Color.Transparent;
        }

        private void PnMinimize_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea Cerrar el Sistema?", "Mensaje del Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_PERSONAL, new frmPersonal());
        }

        private void rolesDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.ROLES_USUARIO, new frmUsuarios_Roles());
        }

        private void usuariosDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_USUARIOS, new frmUsuarios());
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_RUBROS_PRODUCTOS, new frmRubros());
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_PRODUCTOS, new frmArticulos());
        }

        private void listaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_PRODUCTOS, new frmListaPrecios());
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PnContent.Controls.Clear();

            frmPlano frm = frmPlano.Instance();

            if (frm.WindowState == FormWindowState.Minimized)
                frm.WindowState = FormWindowState.Maximized;

            frm.Show();
        }

        private void stockCriticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_PRODUCTOS, new frmStockCritico());
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.GESTION_DE_PROVEEDORES, new frmProveedores());
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.COMPRAS, new frmFacturaCompra());
        }

        private void cierreXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Emitir el Cierre Fiscal X?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                FiscalPrinterLib.HASAR oFiscal = new FiscalPrinterLib.HASAR();
                oFiscal.Puerto = Convert.ToInt32(Properties.Settings.Default.Fiscal_Port);
                oFiscal.Modelo = Properties.Settings.Default.Fiscal_Model == "32" ? FiscalPrinterLib.ModelosDeImpresoras.MODELO_P441 : FiscalPrinterLib.ModelosDeImpresoras.MODELO_715;
                oFiscal.Comenzar();
                oFiscal.TratarDeCancelarTodo();

                object t;
                oFiscal.ReporteX(out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t
                    , out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t);
                oFiscal.Finalizar();
            }
        }

        private void cierreZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Emitir el Cierre Fiscal Z?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                FiscalPrinterLib.HASAR oFiscal = new FiscalPrinterLib.HASAR();
                oFiscal.Puerto = Convert.ToInt32(Properties.Settings.Default.Fiscal_Port);
                oFiscal.Modelo = Properties.Settings.Default.Fiscal_Model == "32" ? FiscalPrinterLib.ModelosDeImpresoras.MODELO_P441 : FiscalPrinterLib.ModelosDeImpresoras.MODELO_715;
                oFiscal.Comenzar();
                oFiscal.TratarDeCancelarTodo();

                object t;
                oFiscal.ReporteZ(out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t
                    , out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t, out t);
                oFiscal.Finalizar();
            }
        }

        private void ingresosDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.CAJA_DIARIA, new frmCaja_Ingresos());
        }

        private void egresosDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.CAJA_DIARIA, new frmCaja_Egresos());
        }

        private void cajaDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.CAJA_DIARIA, new frmCajaDiaria());
        }

        private void historialDeCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(Objetos.Opciones.CAJA_DIARIA, new frmCajaDiariaHistorial());
        }
    }
}
