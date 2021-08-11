using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmTicket : Form
    {
        #region [PROPIEDADES]
        private Rubros oRub = new Rubros();
        private Articulos oArt = new Articulos();
        private DataTable dtItem = new DataTable();
        private Decimal importeFinal = 0;
        private Personal oPer = new Personal();
        private Comandas oComanda = new Comandas();
        private Comandas_Det oComandaDet = new Comandas_Det();
        private Plano_Estados oPlano = new Plano_Estados();
        private Boolean itemSeleccionado = false;
        private Int32 itemId = 0;

        private Int32 Comanda_Id;
        #endregion

        public Int32 Personal_Id
        {
            get { return Convert.ToInt32(lblPersonal.Tag); }
            set
            {
                if(value > 0) { 
                    oPer = oPer.getPersonal(value);

                    lblPersonal.Tag = oPer.Personal_Id.ToString();
                    lblPersonal.Text = String.Format("PERSONAL: {0}, {1}", oPer.Apellido, oPer.Nombre);
                }
            }
        }

        private Int32 cub;
        public Int32 Cubiertos
        {
            get { return cub; }
            set {
                cub = value;
                lblCubiertos.Text = String.Format("CUBIERTOS: {0}", value);
            }
        }
        private Int32 mesa_id;
        public Int32 Mesa_Id
        {
            get { return mesa_id; }
            set
            {
                mesa_id = value;

                if (value == 0)
                {
                    this.Personal_Id = 0;
                    this.lblPersonal.Visible = false;
                    this.btnEfectivo.Visible = true;
                }
                else
                { 
                    Comanda_Id = oComanda.getId(value);



                    if (Comanda_Id > 0)
                    {
                        DataTable dt = oComandaDet.getComandaDetalle(Comanda_Id);

                        foreach (DataRow dr in dt.Rows)
                        {
                            Item item = new Item();
                            item.Name = dr["articulo_Id"].ToString();
                            item.Articulo_Id = Convert.ToInt32(dr["articulo_Id"].ToString());
                            item.Descripcion = dr["descripcion"].ToString();
                            item.Importe = Convert.ToDecimal(dr["importe_total"]).ToString("N2");
                            item.Cantidad = String.Format("{0} X {1}", dr["cantidad"].ToString(), Convert.ToDecimal(dr["importe_unitario"]).ToString("N2"));
                            item.Dock = DockStyle.Top;
                            item.Click += new EventHandler(SeleccionarItem);
                            pnItems.Controls.Add(item);

                            dtItem.Rows.Add(Convert.ToInt32(dr["articulo_Id"].ToString()), dr["descripcion"].ToString(), Convert.ToInt32(dr["cantidad"].ToString()), Convert.ToDecimal(dr["importe_unitario"]), Convert.ToDecimal(dr["importe_total"]), "", Convert.ToInt32(dr["comandas_det_estados_id"]), 0, 0);
                        }

                        dtItem.AcceptChanges();
                        CalcularTotal();

                        oComanda = oComanda.getComanda(Comanda_Id);

                        this.Personal_Id = oComanda.Personal_Id;
                        this.Cubiertos = oComanda.Cubiertos;
                        btnCambio.Visible = true;
                    }
                }
            }
        }

        public String Mesa
        {
            get { return lblMesa.Tag.ToString(); }
            set
            {
                lblMesa.Text = String.Format("MESA: {0}", value);
                lblMesa.Tag = value;
            }
        }

        public frmTicket()
        {
            InitializeComponent();

            
            dtItem.Columns.Add("Articulo_Id", typeof(Int32));
            dtItem.Columns.Add("Descripcion", typeof(String));
            dtItem.Columns.Add("Cantidad", typeof(Int32));
            dtItem.Columns.Add("Importe", typeof(Decimal));
            dtItem.Columns.Add("Final", typeof(Decimal));
            dtItem.Columns.Add("Impresora", typeof(String));
            dtItem.Columns.Add("IdEstado", typeof(Int32));
            dtItem.Columns.Add("Id", typeof(Int32));
            dtItem.Columns.Add("Cantidad_Real", typeof(Int32));
        }

        private void Clear()
        {
            pnMain.Controls.Clear();

        }

        private void VentaDirecta(bool imprimir)
        {
            Comprobantes_Venta oVenta = new Comprobantes_Venta();
            oVenta.Cliente_Id = 0;
            oVenta.Fecha = DateTime.Now;
            oVenta.Numero = 1;
            oVenta.Formas_Pago_Id = Convert.ToInt32(Formas_Pago.Estados.EFECTIVO);
            oVenta.Importe_Bruto = importeFinal;
            oVenta.Importe_Desc = 0;
            oVenta.Importe_Final = importeFinal;
            oVenta.Usuario_Id = GlobalVar.CurrentUser_Id;

            DataTable dtItems = dtItem;
            dtItems.Columns["Importe"].ColumnName = "Importe_Unitario";

            int Comprobante_Venta_Id = oVenta.Save(oVenta, dtItems);

            Caja_Detalle oCajaDet = new Caja_Detalle();
            oCajaDet.Comprobantes_Venta_Id = Comprobante_Venta_Id;
            oCajaDet.FechaHora = DateTime.Now;
            oCajaDet.Concepto = "VENTA EN EFECTIVO";
            oCajaDet.Importe_Haber = oVenta.Importe_Final;
            oCajaDet.Usuario_Id = GlobalVar.CurrentUser_Id;
            oCajaDet.Save(oCajaDet);

            if(imprimir)
            { 
                Ticket ticket = new Ticket();
                ticket.TextoIzquierda(String.Format("ATENDIO: {0}", String.Format("{0}", String.Format("PERSONAL: {0}, {1}", oPer.Apellido, oPer.Nombre))));
                ticket.TextoIzquierda(String.Format("MESA: {0}", this.Mesa));
                ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda(String.Format("FECHA: {0} HORA: {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                ticket.TextoIzquierda("");
                ticket.lineasAsteriscos();

                ticket.EncabezadoVenta();
                ticket.lineasAsteriscos();

                foreach (DataRow dr in dtItems.Rows)
                    ticket.AgregaArticulo(dr["descripcion"].ToString(), Convert.ToInt32(dr["cantidad"]), Convert.ToDecimal(dr["importe_unitario"]), Convert.ToDecimal(dr["final"]));


                ticket.lineasIgual();
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda((" SUBTOTAL: ").PadLeft(15) + String.Format("{0:C2}", importeFinal));
                ticket.TextoIzquierda(("DESCUENTO: ").PadLeft(15) + String.Format("% {0}", 0));
                ticket.TextoIzquierda(("    TOTAL: ").PadLeft(15) + String.Format("{0:C2}", importeFinal));
                ticket.TextoIzquierda("");
                ticket.TextoIzquierda("");
                ticket.TextoCentro("¡GRACIAS POR SU VISITA!");
                ticket.TextoIzquierda("");
                ticket.CortaTicket();
                ticket.ImprimirTicket("TM-T20");
            }


            this.DialogResult = DialogResult.OK;
        }

        private void LoadData(object sender, EventArgs e)
        {
            Clear();

            ButtonRub btn = (ButtonRub)sender;

            Int32 rubro_id = Convert.ToInt32(btn.Tag.ToString());

            DataTable dt = oArt.GetArticulosRubros(rubro_id);

            foreach (DataRow dr in dt.Rows)
            {
                ButtonArt btnArt = new ButtonArt();
                btnArt.Tag = dr["articulo_id"].ToString();
                btnArt.Descripcion = dr["descripcion"].ToString();
                btnArt.Importe = String.Format("$ {0}", Convert.ToDecimal(dr["importe_venta"]).ToString("N2"));
                btnArt.Impresora = dr["impresora"].ToString();


                string path = System.IO.Path.Combine(String.Format("{0}\\Files", Application.StartupPath), dr["imagen"].ToString());

                if (File.Exists(path))
                    btnArt.Imagen = Image.FromFile(path);

                btnArt.Height = 110;
                btnArt.Width = 115;

                btnArt.Click += new EventHandler(AddItem);

                pnMain.Controls.Add(btnArt);
                pnMain.Focus();
            }
        }

        private void SeleccionarItem(object sender, EventArgs e)
        {
            foreach (Control cs in pnItems.Controls)
            {
                if (cs is Item)
                {
                    Item item = (Item)cs;
                    item.Seleccionar = 0;
                }
            }

            itemSeleccionado = true;
            Item itemSel = (Item)sender;
            itemSel.Seleccionar = 1;
            itemId = itemSel.Articulo_Id;

            pnItems.Focus();
        }

        private void AddItem(object sender, EventArgs e)
        {
            this.SuspendLayout();

            pnItems.Controls.Clear();

            ButtonArt btn = (ButtonArt)sender;
            Int32 id = Convert.ToInt32(btn.Tag);

            DataRow[] filteredRows = dtItem.Select(string.Format("Articulo_Id = {0}", id));

            Decimal importe = Convert.ToDecimal(btn.Importe.Replace('$', ' '));

            if (filteredRows.Length == 0)
                dtItem.Rows.Add(id, btn.Descripcion, 1, importe, importe, btn.Impresora, Convert.ToInt32(Comandas_Det.Estados.PREPARACION), 0, 1);
            else
            {
                filteredRows[0]["Cantidad"] = Convert.ToInt32(filteredRows[0]["Cantidad"]) + 1;
                filteredRows[0]["Final"] = Convert.ToDecimal(filteredRows[0]["Cantidad"]) * Convert.ToDecimal(filteredRows[0]["Importe"]);
                filteredRows[0]["Cantidad_Real"] = Convert.ToInt32(filteredRows[0]["Cantidad_Real"]) + 1;
                filteredRows[0]["Impresora"] = "TM - T20";
            }

            dtItem.AcceptChanges();

            foreach (DataRow dr in dtItem.Rows)
            {
                Item item = new Item();
                item.Name = dr["Articulo_Id"].ToString();
                item.Articulo_Id = Convert.ToInt32(dr["Articulo_Id"].ToString());
                item.Descripcion = dr["Descripcion"].ToString();
                item.Importe = Convert.ToDecimal(dr["Final"]).ToString("N2");
                item.Cantidad = String.Format("{0} X {1}", dr["Cantidad"].ToString(), Convert.ToDecimal(dr["Importe"]).ToString("N2"));
                item.Dock = DockStyle.Top;
                item.Click += new EventHandler(SeleccionarItem);
                
                pnItems.Controls.Add(item);
            }

            CalcularTotal();

            this.ResumeLayout();
        }

        private void CalcularTotal()
        {
            importeFinal = dtItem.AsEnumerable().Sum(row => row.Field<decimal>("Final"));
            lblTotal.Text = String.Format("$ {0}", importeFinal.ToString("N2"));
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 20;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;

            DataTable dtRubros = oRub.GetRubros();

            foreach (DataRow dr in dtRubros.Rows)
            {
                ButtonRub btn = new ButtonRub();
                btn.Name = String.Format("btn{0}", dr["rubro_id"].ToString());
                btn.Tag = dr["rubro_id"].ToString();
                btn.Value = String.Format("{0}", dr["rubro"].ToString());
                btn.Click += new EventHandler(this.LoadData);
                pnRubros.Controls.Add(btn);
            }


            //pnRubros.AutoScroll = true;
            //pnRubros.AutoSize = true;
            //pnRubros.AutoSizeMode = AutoSizeMode.GrowAndShrink;


            //pnRubros.AutoScroll = true;
            //pnRubros.PerformLayout();
            //this.PerformLayout();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            if(dtItem.Rows.Count > 0)
                this.VentaDirecta(false);
        }

        private void frmTicket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract && itemSeleccionado == true)
            {
                if (itemId > 0)
                {
                    DataRow[] filteredRows = dtItem.Select(string.Format("Articulo_Id = {0}", itemId));

                    if (Convert.ToInt32(filteredRows[0]["Cantidad"]) > 1)
                    {
                        filteredRows[0]["Cantidad"] = Convert.ToInt32(filteredRows[0]["Cantidad"]) - 1;
                        filteredRows[0]["Final"] = Convert.ToDecimal(filteredRows[0]["Cantidad"]) * Convert.ToDecimal(filteredRows[0]["Importe"]);
                    }
                    else
                        filteredRows[0].Delete();

                    dtItem.AcceptChanges();

                    pnItems.Controls.Clear();

                    foreach (DataRow dr in dtItem.Rows)
                    {
                        Item item = new Item();
                        item.Name = dr["Articulo_Id"].ToString();
                        item.Articulo_Id = Convert.ToInt32(dr["Articulo_Id"].ToString());
                        item.Descripcion = dr["Descripcion"].ToString();
                        item.Importe = Convert.ToDecimal(dr["Final"]).ToString("N2");
                        item.Cantidad = String.Format("{0} X {1}", dr["Cantidad"].ToString(), Convert.ToDecimal(dr["Importe"]).ToString("N2"));
                        item.Dock = DockStyle.Top;
                        item.Click += new EventHandler(SeleccionarItem);
                        pnItems.Controls.Add(item);
                    }

                    CalcularTotal();

                    if (dtItem.Rows.Count == 0)
                    {
                        foreach (Control cs in pnItems.Controls)
                        {
                            if (cs is Item)
                            {
                                Item item = (Item)cs;
                                item.Seleccionar = 0;
                            }
                        }

                        itemSeleccionado = false;
                        itemId = 0;
                    }

                }
            }

            if (e.KeyCode == Keys.Add && itemSeleccionado == true)
            {
                if (itemId > 0)
                {
                    DataRow[] filteredRows = dtItem.Select(string.Format("Articulo_Id = {0}", itemId));

                    if (Convert.ToInt32(filteredRows[0]["Cantidad"]) >= 1)
                    { 
                        filteredRows[0]["Cantidad"] = Convert.ToInt32(filteredRows[0]["Cantidad"]) + 1;
                        filteredRows[0]["Final"] = Convert.ToDecimal(filteredRows[0]["Cantidad"]) * Convert.ToDecimal(filteredRows[0]["Importe"]);
                        filteredRows[0]["Cantidad_Real"] = Convert.ToInt32(filteredRows[0]["Cantidad_Real"]) + 1;
                        filteredRows[0]["Impresora"] = "TM - T20";
                    }

                    dtItem.AcceptChanges();

                    pnItems.Controls.Clear();

                    foreach (DataRow dr in dtItem.Rows)
                    {
                        Item item = new Item();
                        item.Name = dr["Articulo_Id"].ToString();
                        item.Articulo_Id = Convert.ToInt32(dr["Articulo_Id"].ToString());
                        item.Descripcion = dr["Descripcion"].ToString();
                        item.Importe = Convert.ToDecimal(dr["Final"]).ToString("N2");
                        item.Cantidad = String.Format("{0} X {1}", dr["Cantidad"].ToString(), Convert.ToDecimal(dr["Importe"]).ToString("N2"));
                        item.Dock = DockStyle.Top;
                        item.Click += new EventHandler(SeleccionarItem);
                        pnItems.Controls.Add(item);
                    }

                    CalcularTotal();


                    if (dtItem.Rows.Count == 0)
                    {
                        foreach (Control cs in pnItems.Controls)
                        {
                            if (cs is Item)
                            {
                                Item item = (Item)cs;
                                item.Seleccionar = 0;
                            }
                        }

                        itemSeleccionado = false;
                        itemId = 0;
                    }
                    

                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (dtItem.Rows.Count > 0)
                {
                    if (Comanda_Id == 0)
                    {
                        oComanda.Plano_Id = this.Mesa_Id;
                        oComanda.Personal_Id = this.Personal_Id;
                        oComanda.Cliente_Id = 0;
                        oComanda.Usuario_Id = GlobalVar.CurrentUser_Id;
                        oComanda.Fecha = DateTime.Today;
                        oComanda.Hora = DateTime.Now.ToShortTimeString();
                        oComanda.Cubiertos = this.Cubiertos;

                        Int32 comanda_id = oComanda.Save(oComanda);

                        oComandaDet.Save(dtItem, comanda_id);

                        oPlano.SetEstado(this.Mesa_Id, Plano_Estados.Estados.OCUPADA);

                        DataRow[] filteredRows = dtItem.Select(string.Format("Impresora <> ''"));

                        if (filteredRows.Length > 0)
                        {
                            if (frmMsgBox.Show("¿Desea Imprimir la Comanda?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
                            {
                                Ticket ticket = new Ticket();
                                ticket.TextoIzquierda(String.Format("ATENDIÓ: {0}", oPer.Nombre));
                                ticket.TextoIzquierda(String.Format("MESA: {0}", this.Mesa));
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda(String.Format("FECHA: {0} HORA: {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                                ticket.TextoIzquierda("");
                                ticket.lineasIgual();

                                for (int i = 0; i < filteredRows.Length; i++)
                                {
                                    ticket.TextoIzquierda(String.Format("{0} - {1}", filteredRows[i]["Cantidad"].ToString(), filteredRows[i]["Descripcion"].ToString()));
                                }

                                ticket.lineasIgual();
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.CortaTicket();
                                ticket.ImprimirTicket("TM-T20");
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        oComandaDet.Delete(oComanda.Comanda_Id);
                        oComandaDet.Save(dtItem, oComanda.Comanda_Id);

                        DataRow[] filteredRows = dtItem.Select(string.Format("Impresora <> ''"));

                        if (filteredRows.Length > 0)
                        {
                            if (frmMsgBox.Show("¿Desea Imprimir la Comanda?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
                            {
                                Ticket ticket = new Ticket();
                                ticket.TextoIzquierda(String.Format("ATENDIÓ: {0}", oPer.Nombre));
                                ticket.TextoIzquierda(String.Format("MESA: {0}", this.Mesa));
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda(String.Format("FECHA: {0} HORA: {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                                ticket.TextoIzquierda("");
                                ticket.lineasIgual();

                                for (int i = 0; i < filteredRows.Length; i++)
                                {
                                    ticket.TextoIzquierda(String.Format("{0} - {1}", filteredRows[i]["Cantidad_Real"].ToString(), filteredRows[i]["Descripcion"].ToString()));
                                }

                                ticket.lineasIgual();
                                ticket.TextoIzquierda("");
                                ticket.TextoIzquierda("");
                                ticket.CortaTicket();
                                ticket.ImprimirTicket("TM-T20");
                            }
                        }

                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }

            if (e.KeyCode == Keys.F8)
            {
                if (btnEfectivo.Visible == true)
                    this.VentaDirecta(true);
                else
                {
                    using (frmModal frm = new frmModal())
                    {
                        if (Comanda_Id == 0)
                        {
                            oComanda.Plano_Id = this.Mesa_Id;
                            oComanda.Personal_Id = this.Personal_Id;
                            oComanda.Cliente_Id = 0;
                            oComanda.Usuario_Id = GlobalVar.CurrentUser_Id;
                            oComanda.Fecha = DateTime.Today;
                            oComanda.Hora = DateTime.Now.ToShortTimeString();
                            oComanda.Cubiertos = this.Cubiertos;

                            Int32 comanda_id = oComanda.Save(oComanda);

                            oComandaDet.Save(dtItem, comanda_id);

                            this.Comanda_Id = comanda_id;

                            oPlano.SetEstado(this.Mesa_Id, Plano_Estados.Estados.OCUPADA);
                        }
                        else {
                            oComandaDet.Delete(oComanda.Comanda_Id);
                            oComandaDet.Save(dtItem, oComanda.Comanda_Id);
                        }

                        frmTicketCierre frmCie = new frmTicketCierre();
                        frmCie.Comanda_Id = this.Comanda_Id;
                        frmCie.Mesa = this.Mesa;
                        frmCie.Personal = oPer.Nombre;
                        frmCie.Total = importeFinal;
                        frmCie.Items = dtItem;
                        frmCie.Cubiertos = this.Cubiertos;

                        frm.oForm = frmCie;

                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            oPlano.SetEstado(this.Mesa_Id, Plano_Estados.Estados.PENDIENTE_DE_COBRO);

                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.F1)
            {
                using (frmModal frm = new frmModal())
                {
                    frmBuscador frmBus = new frmBuscador();
                    frmBus.Tabla = "Articulos";
                    frm.oForm = frmBus;

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        this.SuspendLayout();

                        pnItems.Controls.Clear();

                        Articulos oArt = new Articulos();
                        oArt = oArt.GetArticulo(frmBus.Id);

                        DataRow[] filteredRows = dtItem.Select(string.Format("Articulo_Id = {0}", oArt.Articulo_Id));

                        if (filteredRows.Length == 0)
                            dtItem.Rows.Add(oArt.Articulo_Id, oArt.Descripcion, 1, oArt.Importe_Venta, oArt.Importe_Venta);
                        else
                        {
                            filteredRows[0]["Cantidad"] = Convert.ToInt32(filteredRows[0]["Cantidad"]) + 1;
                            filteredRows[0]["Final"] = Convert.ToDecimal(filteredRows[0]["Cantidad"]) * Convert.ToDecimal(filteredRows[0]["Importe"]);
                        }

                        dtItem.AcceptChanges();

                        foreach (DataRow dr in dtItem.Rows)
                        {
                            Item item = new Item();
                            item.Name = dr["Articulo_Id"].ToString();
                            item.Articulo_Id = Convert.ToInt32(dr["Articulo_Id"].ToString());
                            item.Descripcion = dr["Descripcion"].ToString();
                            item.Importe = Convert.ToDecimal(dr["Final"]).ToString("N2");
                            item.Cantidad = String.Format("{0} X {1}", dr["Cantidad"].ToString(), Convert.ToDecimal(dr["Importe"]).ToString("N2"));
                            item.Dock = DockStyle.Top;
                            item.Click += new EventHandler(SeleccionarItem);
                            pnItems.Controls.Add(item);
                        }

                        CalcularTotal();

                        this.ResumeLayout();
                    }
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmBuscador frmBus = new frmBuscador();
                frmBus.Tabla = "Mesas";
                frm.oForm = frmBus;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (frmMsgBox.Show("¿Confirma Realizar el Cambio de Mesa?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
                    {
                        oComandaDet.Delete(oComanda.Comanda_Id);
                        oComandaDet.Save(dtItem, oComanda.Comanda_Id);

                        DataRow[] filteredRows = dtItem.Select(string.Format("Impresora <> ''"));

                        if (filteredRows.Length > 0)
                        {
                            Ticket ticket = new Ticket();
                            ticket.TextoIzquierda(String.Format("ATENDIÓ: {0}", oPer.Nombre));
                            ticket.TextoIzquierda(String.Format("MESA: {0}", this.Mesa));
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda(String.Format("FECHA: {0} HORA: {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
                            ticket.TextoIzquierda("");
                            ticket.lineasIgual();

                            for (int i = 0; i < filteredRows.Length; i++)
                            {
                                ticket.TextoIzquierda(String.Format("{0} - {1}", filteredRows[i]["Cantidad_Real"].ToString(), filteredRows[i]["Descripcion"].ToString()));
                            }

                            ticket.lineasIgual();
                            ticket.TextoIzquierda("");
                            ticket.TextoIzquierda("");
                            ticket.CortaTicket();
                            ticket.ImprimirTicket("TM-T20");
                        }

                        oComanda.CambioMesa(oComanda.Comanda_Id, this.Mesa_Id, frmBus.Id);

                        this.Mesa_Id = frmBus.Id;
                        this.Mesa = frmBus.Campo;

                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
