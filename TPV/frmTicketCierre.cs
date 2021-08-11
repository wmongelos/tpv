using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmTicketCierre : Form
    {
        public Int32 Comanda_Id { get; set; }
        public Int32 Mesa_Id { get; set; }
        public String Mesa { get; set; }
        public Int32 Cubiertos { get; set; }

        public Int32 Personal_Id { get; set; }
        public String Personal { get; set; }

        public Decimal Total {
            get { return spSubTotal.Value; }
            set {
                spSubTotal.Value = value;
                spTotal.Value = value;
            }
        }
        public DataTable Items { get; set; }

        private Tipos_Responsables oTip = new Tipos_Responsables();
        private Comandas oComanda = new Comandas();

        public frmTicketCierre()
        {
            InitializeComponent();

            cboTiposResp.DataSource = oTip.GetTipoResponsables();
            cboTiposResp.Display = "descripcion";
            cboTiposResp.Value = "tipo_responsable_id";
        }

        private void frmTicketCierre_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void spDescuento_Validated(object sender, EventArgs e)
        {
            decimal subtotal = spSubTotal.Value;
            decimal porcdesc = spDescuento.Value;
            decimal total = 0;

            if (porcdesc == 0)
                total = subtotal;
            else
            { 
                total = subtotal - ((porcdesc * subtotal) / 100);
                spTotal.Enabled = true;
                spTotal.Focus();
            }

            spTotal.Value = total;

            if(porcdesc > 0)
                spTotal.Select_Value();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (Items.Rows.Count > 0)
            {
                 
                    Ticket ticket = new Ticket();
                    //ticket.TextoIzquierda("");
                    ticket.TextoIzquierda(String.Format("ATENDIO: {0}", String.Format("{0}", this.Personal)));
                    ticket.TextoIzquierda(String.Format("MESA: {0}", this.Mesa));
                    ticket.TextoIzquierda(String.Format("CUBIERTOS: {0}", this.Cubiertos));
                    ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda(String.Format("FECHA: {0} HORA: {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                    ticket.TextoIzquierda("");
                    ticket.lineasAsteriscos();

                    ticket.EncabezadoVenta();
                    ticket.lineasAsteriscos();

                    foreach (DataRow dr in Items.Rows)
                        ticket.AgregaArticulo(dr["descripcion"].ToString(), Convert.ToInt32(dr["cantidad"]), Convert.ToDecimal(dr["importe"]), Convert.ToDecimal(dr["final"]));


                    ticket.lineasIgual();
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda((" SUBTOTAL: ").PadLeft(15) + String.Format("{0:C2}", spSubTotal.Value));
                    ticket.TextoIzquierda(("DESCUENTO: ").PadLeft(15) + String.Format("% {0}", spDescuento.Value.ToString("#.00")));
                    ticket.TextoIzquierda(("    TOTAL: ").PadLeft(15) + String.Format("{0:C2}", spTotal.Value));
                    ticket.TextoIzquierda("");
                    ticket.TextoIzquierda("");
                    ticket.TextoCentro("¡GRACIAS POR SU VISITA!");
                    ticket.TextoIzquierda("");
                    ticket.CortaTicket();
                    ticket.ImprimirTicket("TM-T20");
                

                oComanda.Comanda_Id = this.Comanda_Id;
                oComanda.Cliente_Id = Convert.ToInt32(txtRSocial.Tag);
                oComanda.SubTotal = spSubTotal.Value;
                oComanda.Descuento = spDescuento.Value;
                oComanda.Importe_Desc = oComanda.Descuento == 0 ? 0 : (oComanda.Descuento * oComanda.SubTotal) / 100;
                oComanda.Importe_Final = spTotal.Value;
                oComanda.Update(oComanda);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmTicketCierre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;

            if (e.KeyCode == Keys.F8)
                btnConfirmar.PerformClick();
        }

        private void spTotal_Validated(object sender, EventArgs e)
        {
            if (spTotal.Value > 0)
            {
                decimal subtotal = spSubTotal.Value;
                decimal total = spTotal.Value;
                decimal porcdesc = 0;

                porcdesc = (total * 100) / subtotal;

                spDescuento.Value = 100- porcdesc;

                
            }
        }
    }
}
