using System;
using System.Data;
using System.Net.Mail;
using System.Windows.Forms;
using TPV.Abms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmCajaDiaria : Form
    {
        private DataTable dt;
        private DataTable dtSaldosFPagos;
        private Caja_Detalle oCajDet = new Caja_Detalle();
        private Decimal totalInicial;
        private Decimal totalEfectivo;
        private Decimal totalCredito;
        private Decimal totalDebito;
        private Decimal totalIngresos;
        private Decimal totalEgresos;
        private Label oLabel;

        public frmCajaDiaria()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.SuspendLayout();

            
            dt = oCajDet.getCajaDetalle();

            if (dt.Rows.Count > 0)
            {
                pnData.Controls.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    CustomRowCaja row = new CustomRowCaja();
                    row.Column1 = dr["fechahora"].ToString().Substring(0, 16);
                    row.Column2 = dr["concepto"].ToString();
                    row.Column3 = String.Format("{0:C2}", Convert.ToDecimal(dr["importe_haber"].ToString()));
                    row.Column4 = String.Format("{0:C2}", Convert.ToDecimal(dr["importe_debe"].ToString()));
                    row.Dock = DockStyle.Top;

                    this.pnData.Controls.Add(row);

                    row.Select();
                }
            }
            else
            {
                pnData.Controls.Clear();
                
                pnData.Controls.Add(oLabel);
                oLabel.Dock = DockStyle.Top;
            }

            totalInicial = oCajDet.GetSaldoInicial();

            lblSaldoInicial.Text = String.Format("{0:C2}", totalInicial);

            dtSaldosFPagos = oCajDet.getSaldosFPagos();

            totalEfectivo = Convert.ToDecimal(dtSaldosFPagos.Rows[0]["total"]);
            totalCredito = Convert.ToDecimal(dtSaldosFPagos.Rows[1]["total"]);
            totalDebito = Convert.ToDecimal(dtSaldosFPagos.Rows[2]["total"]);


            lblTotalEfectivo.Text = String.Format("{0:C2}", totalEfectivo);
            lblTotalTarjCredito.Text = String.Format("{0:C2}", totalCredito);
            lblTotalTarjDebito.Text = String.Format("{0:C2}", totalDebito);

            decimal total = Convert.ToDecimal(dtSaldosFPagos.Rows[0]["total"]) + Convert.ToDecimal(dtSaldosFPagos.Rows[1]["total"]) + Convert.ToDecimal(dtSaldosFPagos.Rows[2]["total"]);

            lblTotalVentas.Text = String.Format("{0:C2}", total);

            object sumIng = dt.Compute("sum(importe_haber)", "caja_ingreso_id > 0");
            object sumEgr = dt.Compute("sum(importe_debe)", "caja_egreso_id > 0");

            totalIngresos = sumIng == null || sumIng.ToString() == String.Empty ? Convert.ToDecimal("0") : Convert.ToDecimal(sumIng);
            totalEgresos = sumEgr == null || sumEgr.ToString() == String.Empty ? Convert.ToDecimal("0") : Convert.ToDecimal(sumEgr);


            lblTotIng.Text = String.Format("{0:C2}",totalIngresos);
            lblTotEgr.Text = String.Format("{0:C2}", totalEgresos);

            decimal saldoCaja = (totalInicial + Convert.ToDecimal(dtSaldosFPagos.Rows[0]["total"]) + totalIngresos) - totalEgresos;

            lblTotalCaja.Text = String.Format("{0:C2}", saldoCaja);

            lblCubiertos.Text = oCajDet.GetCubiertos().ToString();

            this.PerformLayout();
        }

        private void CajaDiaria_Load(object sender, EventArgs e)
        {
            oLabel = lblDataCaption;

            this.LoadData();
        }

        private void frmCajaDiaria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmCajaMov frmMov = new frmAbmCajaMov();

                frm.oForm = frmMov;

                frmMov.Tipo = 1;
                

                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmCajaMov frmMov = new frmAbmCajaMov();

                frm.oForm = frmMov;

                frmMov.Tipo = 2;

                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void btnCierreTurno_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Confirma el Cierre de Turno?", "Cierre de Turno", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                Plano_Estados oPlaEst = new Plano_Estados();
                DataTable dt = oPlaEst.GetEstados();

                if (Convert.ToInt32(dt.Rows[1]["total"]) > 0 || Convert.ToInt32(dt.Rows[2]["total"]) > 0)
                {
                    if (Convert.ToInt32(dt.Rows[1]["total"]) > 0)
                        frmMsgBox.Show(String.Format("Existen Mesas Ocupadas. Total: {0}", Convert.ToInt32(dt.Rows[1]["total"])), "Cierre de Turno",
                            frmMsgBox.MessageButton.OK);
                    else
                        frmMsgBox.Show(String.Format("Existen Mesas Pendientes de Cierre. Total: {0}", Convert.ToInt32(dt.Rows[2]["total"])), "Cierre de Turno",
                            frmMsgBox.MessageButton.OK);
                }
                else
                {
                    Caja oCaja = new Caja();
                    oCaja.Fecha = DateTime.Now;
                    oCaja.Usuario_Id = GlobalVar.CurrentUser_Id;
                    oCaja.Importe_Saldo_Inicial = totalInicial;
                    oCaja.Importe_Total_Efe = totalEfectivo;
                    oCaja.Importe_Total_Cred = totalCredito;
                    oCaja.Importe_Total_Deb = totalDebito;
                    oCaja.Importe_Total_Ing = totalIngresos;
                    oCaja.Importe_Total_Egr = totalEgresos;
                    oCaja.Save(oCaja);

                    SendEmail();
                    LoadData();
                }             
            }
        }

        private void SendEmail()
        {
            //System.Net.Mail.MailMessage mailNew = new MailMessage();
            //mailNew.From = new System.Net.Mail.MailAddress("wmongelos@sbcode.com.ar");
            //mailNew.To.Add("walttersb@msn.com");
            //mailNew.Subject = "INFORM DE VENTAS 31072017";
            //mailNew.Body = "TPV SOFTWARE";
            //mailNew.IsBodyHtml = true;
            //mailNew.Priority = MailPriority.Normal;

            //System.Net.Mail.SmtpClient SmtpDominio = new System.Net.Mail.SmtpClient();
            //SmtpDominio.Host = "mx1.hostinger.com.ar";
            //SmtpDominio.Port = 25;
            //SmtpDominio.EnableSsl = true;
            //SmtpDominio.Credentials = new System.Net.NetworkCredential("wmongelos@sbcode.com.ar", "722633");

            //SmtpDominio.Send(mailNew);
        }

        private void btnSaldoInicial_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frm.oForm = new frmAbmCajaSaldo();

                if (frm.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
