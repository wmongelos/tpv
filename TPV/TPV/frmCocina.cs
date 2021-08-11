using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmCocina : Form
    {
        private Comandas_Det oComandaDet = new Comandas_Det();
        private Int32 Cantidad = 0;
        private Comanda comandaSel;

        public frmCocina()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            DataTable dt = oComandaDet.getComanasCocina();

            if (dt.Rows.Count == 0)
                pnContent.Controls.Clear();

            if(Cantidad != dt.Rows.Count)
            {
                //SoundPlayer simpleSound = new SoundPlayer("RING.wav");
                //simpleSound.Play();

                Cantidad = dt.Rows.Count;

                pnContent.Controls.Clear();

                var results = from c in dt.AsEnumerable()
                              group c by c.Field<Int32>("comanda_id") into grupo
                              select grupo;

                int orden = 1;

                foreach (var item in results)
                {
                    Int32 id = Convert.ToInt32(item.Key);

                    IEnumerable<DataRow> query = from d in dt.AsEnumerable()
                                                 where d.Field<Int32>("comanda_id") == id
                                                 select d;

                    DataTable dtDetalle = query.CopyToDataTable<DataRow>();

                    Comanda comanda = new Comanda();
                    comanda.Hora = dtDetalle.Rows[0]["hora"].ToString();
                    comanda.Orden = orden.ToString();
                    comanda.Mesa = dtDetalle.Rows[0]["mesa"].ToString();
                    comanda.ComandaDetalle = dtDetalle;
                    pnContent.Controls.Add(comanda);
                    comanda.Leave += new EventHandler(clear);
                    comanda.Enter += new EventHandler(enter);
                    comanda.ClearSelection();

                    orden++;
                }
            }
        }

        private void clear(object sender, EventArgs e)
        {
            Comanda comanda = (Comanda)sender;
            comanda.ClearSelection();
        }

        private void enter(object sender, EventArgs e)
        {
            this.comandaSel = (Comanda)sender;
        }

        private void frmCocina_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCocinando_Click(object sender, EventArgs e)
        {
            if (this.comandaSel != null)
                oComandaDet.Preparando(comandaSel.Id);

            Cantidad = 0;

            LoadData();
        }

        private void btnDespacho_Click(object sender, EventArgs e)
        {
            if (this.comandaSel != null)
                oComandaDet.Despachar(comandaSel.Id);

            Cantidad = 0;

            LoadData();
        }

        private void oTimer_Tick(object sender, EventArgs e)
        {
            LoadData();
        }

        private void oTimerHS_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmCocina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                frmConfigTPV frm = new frmConfigTPV();
                frm.ShowDialog();
            }
        }
    }
}
