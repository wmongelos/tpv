using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV
{
    public partial class frmCreateDB : Form
    {
        public frmCreateDB()
        {
            InitializeComponent();
        }

        private void frmCreateDB_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            DbHelper.getDbHelper().CreateDataBase();
            bgw.ReportProgress(1);

            Usuarios oUsuario = new Usuarios();
            oUsuario.CreateTable();
            bgw.ReportProgress(2);

            Rubros oRub = new Rubros();
            oRub.CreateTable();
            bgw.ReportProgress(3);

            Articulos oArt = new Articulos();
            oArt.CreateTable();
            bgw.ReportProgress(4);

            Tipos_Responsables oTipRes = new Tipos_Responsables();
            oTipRes.CreateTable();
            bgw.ReportProgress(5);

            Comprobantes_Tipos oCompTipo = new Comprobantes_Tipos();
            oCompTipo.CreateTable();
            bgw.ReportProgress(6);

            Comprobantes_Venta oCompVen = new Comprobantes_Venta();
            oCompVen.CreateTable();
            bgw.ReportProgress(7);

            Comprobantes_Venta_Det oCompVenDet = new Comprobantes_Venta_Det();
            oCompVenDet.CreateTable();
            bgw.ReportProgress(8);

            Clientes oCli = new Clientes();
            oCli.CreateTable();
            bgw.ReportProgress(9);

            Proveedores oPro = new Proveedores();
            oPro.CreateTable();
            bgw.ReportProgress(10);

            Plano oPla = new Plano();
            oPla.CreateTable();
            bgw.ReportProgress(11);

            Personal oPer = new Personal();
            oPer.CreateTable();
            bgw.ReportProgress(12);

            Configuracion oConfig = new Configuracion();
            oConfig.CreateTable();
            bgw.ReportProgress(13);

            Objetos oObj = new Objetos();
            oObj.CreateTable();
            bgw.ReportProgress(14);

            Usuarios_Roles oUsrRol = new Usuarios_Roles();
            oUsrRol.CreateTable();
            bgw.ReportProgress(15);

            Usuarios_Roles_Obj oUsrObj = new Usuarios_Roles_Obj();
            oUsrObj.CreateTable();
            bgw.ReportProgress(16);

            DataTable dt = oObj.getObjetos();
            oUsrObj.setPermisos(1, dt);

            Caja_Egresos oEgre = new Caja_Egresos();
            oEgre.CreateTable();
            bgw.ReportProgress(17);

            Caja_Ingresos oIng = new Caja_Ingresos();
            oIng.CreateTable();
            bgw.ReportProgress(18);

            Plano_Estados oPlaEst = new Plano_Estados();
            oPlaEst.CreateTable();
            bgw.ReportProgress(19);

            Comandas oComa = new Comandas();
            oComa.CreateTable();
            bgw.ReportProgress(20);

            Comandas_Det oComaDet = new Comandas_Det();
            oComaDet.CreateTable();
            bgw.ReportProgress(21);

            Impresoras oImp = new Impresoras();
            oImp.CreateTable();
            bgw.ReportProgress(22);

            Caja_Detalle oCajDet = new Caja_Detalle();
            oCajDet.CreateTable();
            bgw.ReportProgress(23);

            Formas_Pago oFPagos = new Formas_Pago();
            oFPagos.CreateTable();
            bgw.ReportProgress(24);

            Caja oCaja = new Caja();
            oCaja.CreateTable();
            bgw.ReportProgress(25);

            oComaDet.CreateTableEstados();
            bgw.ReportProgress(26);

            oComa.CreateTableEstados();
            bgw.ReportProgress(27);

        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    lblProgress.Text = "Generando Base de Datos";
                    break;
                case 2:
                    lblProgress.Text = "Generando Tabla Usuarios";
                    break;
                case 3:
                    lblProgress.Text = "Generando Tabla Rubros";
                    break;
                case 4:
                    lblProgress.Text = "Generando Tabla Articulos";
                    break;
                case 5:
                    lblProgress.Text = "Generando Tabla Tipos de Responsables";
                    break;
                case 6:
                    lblProgress.Text = "Generando Tabla Tipos de Comprobantes";
                    break;
                case 7:
                    lblProgress.Text = "Generando Tabla Comprobantes de Venta";
                    break;
                case 8:
                    lblProgress.Text = "Generando Tabla Detalle de Comprobantes de Venta";
                    break;
                case 9:
                    lblProgress.Text = "Generando Tabla Clientes";
                    break;
                case 10:
                    lblProgress.Text = "Generando Tabla Proveedores";
                    break;
                case 11:
                    lblProgress.Text = "Generando Tabla Plano";
                    break;
                case 12:
                    lblProgress.Text = "Generando Tabla Personal";
                    break;
                case 13:
                    lblProgress.Text = "Generando Tabla Configuracion";
                    break;
                case 14:
                    lblProgress.Text = "Generando Tabla Objetos";
                    break;
                case 15:
                    lblProgress.Text = "Generando Tabla Usuarios Roles";
                    break;
                case 16:
                    lblProgress.Text = "Generando Tabla Usuarios Roles Objetos";
                    break;
                case 17:
                    lblProgress.Text = "Generando Tabla Caja Egresos";
                    break;
                case 18:
                    lblProgress.Text = "Generando Tabla Caja Ingresos";
                    break;
                case 19:
                    lblProgress.Text = "Generando Tabla Plano Estados";
                    break;
                default:
                    break;
            }
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmCreateDB_Load(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();
        }
    }
}
