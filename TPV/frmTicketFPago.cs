using System;
using System.Data;
using System.Windows.Forms;
using TPV.Entidades;

namespace TPV
{
    public partial class frmTicketFPago : Form
    {
        private Comandas oComanda = new Comandas();
        private Comandas_Det oComanda_Det = new Comandas_Det();
        private DataTable dtItems = new DataTable();
        private Formas_Pago.Estados FPago = Formas_Pago.Estados.EFECTIVO;
        private String ConceptoCaja = "VENTA EN EFECTIVO";
        private Decimal importeFinal = 0;
        private Double descuento = 0;
        private Int32 numero;
        private string fpago = "EFECTIVO";

        public Int32 Mesa_Id
        {
            get { return 0; }
            set
            {
                int comanda_id = oComanda.getId(value);
                oComanda = oComanda.getComanda(comanda_id);

                dtItems = oComanda_Det.getComandaDetalle(comanda_id);

                lblTotal.Text = String.Format("$ {0}", oComanda.Importe_Final);

                importeFinal = oComanda.Importe_Final;
                descuento = Convert.ToDouble(oComanda.Importe_Desc);
            }
        }

        public frmTicketFPago()
        {
            InitializeComponent();
        }

        private void imprimirFiscal()
        {
            FiscalPrinterLib.HASAR oFiscal = new FiscalPrinterLib.HASAR();

            oFiscal.Puerto = 3;
            oFiscal.Modelo = FiscalPrinterLib.ModelosDeImpresoras.MODELO_715;
            oFiscal.Comenzar();
            oFiscal.TratarDeCancelarTodo();

            numero = oFiscal.UltimoDocumentoFiscalBC + 1;

            oFiscal.DatosCliente("CONSUMIDOR FINAL", "0000000000001", FiscalPrinterLib.TiposDeDocumento.TIPO_DNI, FiscalPrinterLib.TiposDeResponsabilidades.CONSUMIDOR_FINAL, "DOMICILIO");
            oFiscal.AbrirComprobanteFiscal(FiscalPrinterLib.DocumentosFiscales.TICKET_FACTURA_B);

            foreach (DataRow dr in dtItems.Rows)
                oFiscal.ImprimirItem(dr["descripcion"].ToString(), Convert.ToDouble(dr["cantidad"]), Convert.ToDouble(dr["importe_unitario"]), Convert.ToDouble("21"), 0);

            //if (spPorcentajeDesc.Value > 0)
            //{
            //    double descuento = Convert.ToDouble(((spPorcentajeDesc.Value * importeFinal) / 100));

            //    oFiscal.DescuentoGeneral("DESCUENTO:", descuento, true);
            //}

            //oFiscal.EspecificarPercepcionGlobal("", 10);
            
            if(descuento > 0)
                oFiscal.DescuentoGeneral("DESCUENTO:", descuento, true);

            object t;
            oFiscal.ImprimirPago(fpago, Convert.ToDouble(importeFinal), "", out t);
            oFiscal.CerrarComprobanteFiscal(1, out t);
            oFiscal.Finalizar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(spDevolucion.Value < 0)
            {
                switch (this.FPago)
                {
                    case Formas_Pago.Estados.EFECTIVO:
                        
                        spEfectivo.Focus();
                        break;
                    case Formas_Pago.Estados.TARJETA_CREDITO:
                       
                        spTarjetaCredito.Focus();
                        break;
                    case Formas_Pago.Estados.TARJETA_DEBITO:
                      
                        spTarjetaDebito.Focus();
                        break;
                    default:
                        break;
                }
            }
            else
            {
               

                imprimirFiscal();

                Comprobantes_Venta oVenta = new Comprobantes_Venta();
                oVenta.Cliente_Id = oComanda.Cliente_Id;
                oVenta.Fecha = DateTime.Now;
                oVenta.Numero = numero;
                oVenta.Cubiertos = oComanda.Cubiertos;
                oVenta.Formas_Pago_Id = Convert.ToInt32(FPago);
                oVenta.Importe_Bruto = oComanda.SubTotal;
                oVenta.Importe_Desc = oComanda.Importe_Desc;
                oVenta.Importe_Final = oComanda.Importe_Final;
                oVenta.Usuario_Id = GlobalVar.CurrentUser_Id;

                int Comprobante_Venta_Id = oVenta.Save(oVenta, dtItems);

                Plano_Estados oPlano = new Plano_Estados();
                oPlano.SetEstado(oComanda.Plano_Id, Plano_Estados.Estados.DISPONIBLE);

                oComanda.Confirmar(oComanda.Comanda_Id);

                Caja_Detalle oCajaDet = new Caja_Detalle();
                oCajaDet.Comprobantes_Venta_Id = Comprobante_Venta_Id;
                oCajaDet.FechaHora = DateTime.Now;
                oCajaDet.Concepto = ConceptoCaja;
                oCajaDet.Importe_Haber = oVenta.Importe_Final;
                oCajaDet.Usuario_Id = GlobalVar.CurrentUser_Id;
                oCajaDet.Save(oCajaDet);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEfectivo.Checked == true)
            {
                this.FPago = Formas_Pago.Estados.EFECTIVO;
                ConceptoCaja = "VENTA EN EFECTIVO";
                spTarjetaCredito.Enabled = false;
                spTarjetaDebito.Enabled = false;

                spEfectivo.Enabled = true;
                spEfectivo.Focus();
            }
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredito.Checked == true)
            {
                this.FPago = Formas_Pago.Estados.TARJETA_CREDITO;
                ConceptoCaja = "VENTA EN TARJETA CREDITO";
                spEfectivo.Enabled = false;
                spTarjetaDebito.Enabled = false;

                spTarjetaCredito.Enabled = true;
                spTarjetaCredito.Focus();
            }
        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked == true)
            {
                this.FPago = Formas_Pago.Estados.TARJETA_DEBITO;
                ConceptoCaja = "VENTA EN TARJETA DEBITO";
                spEfectivo.Enabled = false;
                spTarjetaCredito.Enabled = false;

                spTarjetaDebito.Enabled = true;
                spTarjetaDebito.Focus();
            }
        }

        private void spEfectivo_Validated(object sender, EventArgs e)
        {
            if (spEfectivo.Value > 0)
            {
                spDevolucion.Value = spEfectivo.Value - oComanda.Importe_Final;
                fpago = "EFECTIVO";
                ConceptoCaja = "VENTA EN EFECTIVO";

                btnConfirmar.Focus();
            }
        }

        private void spTarjetaCredito_Validated(object sender, EventArgs e)
        {
            if (spTarjetaCredito.Value > 0)
            {
                spDevolucion.Value = spTarjetaCredito.Value - oComanda.Importe_Final;

                fpago = "TARJ. CREDITO";

                ConceptoCaja = "VENTA EN TARJETA CREDITO";

                btnConfirmar.Focus();
            }
        }

        private void spTarjetaDebito_Validated(object sender, EventArgs e)
        {
            if (spTarjetaDebito.Value > 0)
            {
                spDevolucion.Value = spTarjetaDebito.Value - oComanda.Importe_Final;

                fpago = "TARJ. DEBITO";

                ConceptoCaja = "VENTA EN TARJETA DEBITO";

                btnConfirmar.Focus();
            }
        }

        private void frmTicketFPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                Comprobantes_Venta oVenta = new Comprobantes_Venta();
                oVenta.Cliente_Id = oComanda.Cliente_Id;
                oVenta.Fecha = DateTime.Now;
                oVenta.Numero = 1;
                oVenta.Cubiertos = oComanda.Cubiertos;
                oVenta.Formas_Pago_Id = Convert.ToInt32(FPago);
                oVenta.Importe_Bruto = oComanda.SubTotal;
                oVenta.Importe_Desc = oComanda.Importe_Desc;
                oVenta.Importe_Final = oComanda.Importe_Final;
                oVenta.Usuario_Id = GlobalVar.CurrentUser_Id;

                int Comprobante_Venta_Id = oVenta.Save(oVenta, dtItems);

                Plano_Estados oPlano = new Plano_Estados();
                oPlano.SetEstado(oComanda.Plano_Id, Plano_Estados.Estados.DISPONIBLE);

                oComanda.Confirmar(oComanda.Comanda_Id);

                Caja_Detalle oCajaDet = new Caja_Detalle();
                oCajaDet.Comprobantes_Venta_Id = Comprobante_Venta_Id;
                oCajaDet.FechaHora = DateTime.Now;
                oCajaDet.Concepto = ConceptoCaja;
                oCajaDet.Importe_Haber = oVenta.Importe_Final;
                oCajaDet.Usuario_Id = GlobalVar.CurrentUser_Id;
                oCajaDet.Save(oCajaDet);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
