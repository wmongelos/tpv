using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmCajaMov : Form
    {
        private Caja_Ingresos oIngreso = new Caja_Ingresos();
        private Caja_Egresos oEgreso = new Caja_Egresos();
        private Caja_Detalle oCajDet = new Caja_Detalle();

        private int tipo;
        public Int32 Tipo 
        {
            get { return tipo; }
            set
            {
                tipo = value;
                DataTable dt = new DataTable();
                string campoid = "";

                switch (value)
                {
                    case 1:
                        dt = oIngreso.GetCaja_Ingresos();
                        lblTitulo.Text = "AGREGAR INGRESOS A CAJA DIARIA";
                        campoid = "caja_ingreso_id";
                        break;
                    case 2:
                        dt = oEgreso.GetCaja_Egresos();
                        lblTitulo.Text = "AGREGAR EGRESOS A CAJA DIARIA";
                        campoid = "caja_egreso_id";
                        break;
                }

                cboTMov.DataSource = dt;
                cboTMov.Display = "descripcion";
                cboTMov.Value = campoid;
            }
        }

        public frmAbmCajaMov()
        {
            InitializeComponent();
        }

        private void frmAbmCajaMov_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void frmAbmCajaMov_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen greenPen = new Pen(Color.LightGray, 1);
            e.Graphics.DrawRectangle(greenPen, 0, 0, width, height);
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if (spImporte.Value == 0)
                spImporte.Focus();
            else
            {
                oCajDet.Usuario_Id = GlobalVar.CurrentUser_Id;
                oCajDet.FechaHora = DateTime.Now;

                if (this.Tipo == 1)
                { 
                    oCajDet.Caja_Ingreso_Id = Convert.ToInt32(cboTMov.SelectedValue);
                    oCajDet.Importe_Haber = spImporte.Value;
                }
                else
                { 
                    oCajDet.Caja_Egreso_Id = Convert.ToInt32(cboTMov.SelectedValue);
                    oCajDet.Importe_Debe = spImporte.Value;
                }

                oCajDet.Concepto = String.Format("{0} | {1}", cboTMov.SelectedText, txtDetalle.Value);
                oCajDet.Save(oCajDet);

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
