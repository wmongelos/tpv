using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV
{
    public partial class frmBuscador : Form
    {
        private DataTable dt = new DataTable();

        public Int32 Id { get; set; }
        public String Tabla { get; set; }
        public String Impresora { get; set; }
        public String Campo { get; set; }

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            switch (this.Tabla)
            {
                case "Personal":
                    Personal oPer = new Personal();

                    dt = oPer.getPersonal();
                    break;
                case "Articulos":
                    Articulos oArt = new Articulos();

                    dt = oArt.GetArticulos();
                    break;
                case "Proveedores":
                    Proveedores oPro = new Proveedores();

                    dt = oPro.getProveedores();
                    break;
                case "Clientes":
                    Clientes oCli = new Clientes();

                    dt = oCli.getClientes();
                    break;
                case "Impresoras":
                    dt = new DataTable();
                    dt.Columns.Add("Impresora", typeof(String));

                    foreach (string printname in PrinterSettings.InstalledPrinters)
                        dt.Rows.Add(printname);

                    dt.AcceptChanges();
                    break;
                case "Mesas":
                    Plano oPlano = new Plano();

                    dt = oPlano.getMesas_Disponibles();
                    break;
                default:
                    break;
            }

            dgv.DataSource = dt;

            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            switch (this.Tabla)
            {
                case "Personal":
                    dgv.Columns["personal_id"].Visible = true;
                    dgv.Columns["personal_id"].HeaderText = "REFERENCIA";
                    dgv.Columns["personal_id"].DisplayIndex = 0;
                    dgv.Columns["personal_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns["apellido"].Visible = true;
                    dgv.Columns["apellido"].HeaderText = "PERSONAL";
                    dgv.Columns["apellido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "Articulos":
                    dgv.Columns["codigo"].Visible = true;
                    dgv.Columns["codigo"].HeaderText = "REFERENCIA";
                    dgv.Columns["codigo"].DisplayIndex = 0;
                    dgv.Columns["codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns["descripcion"].Visible = true;
                    dgv.Columns["descripcion"].HeaderText = "DESCRIPCION";
                    dgv.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "Proveedores":
                    dgv.Columns["proveedor_id"].Visible = true;
                    dgv.Columns["proveedor_id"].HeaderText = "REFERENCIA";
                    dgv.Columns["proveedor_id"].DisplayIndex = 0;
                    dgv.Columns["proveedor_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns["rsocial"].Visible = true;
                    dgv.Columns["rsocial"].HeaderText = "PROVEEDOR";
                    dgv.Columns["rsocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "Clientes":
                    dgv.Columns["cliente_id"].Visible = true;
                    dgv.Columns["cliente_id"].HeaderText = "REFERENCIA";
                    dgv.Columns["cliente_id"].DisplayIndex = 0;
                    dgv.Columns["cliente_id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns["rsocial"].Visible = true;
                    dgv.Columns["rsocial"].HeaderText = "CLIENTE";
                    dgv.Columns["rsocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "Mesas":
                    dgv.Columns["plano_id"].Visible = false;
                    dgv.Columns["nombre"].Visible = true;
                    dgv.Columns["nombre"].HeaderText = "MESA";
                    dgv.Columns["nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                case "Impresoras":
                    dgv.Columns["Impresora"].Visible = true;
                    dgv.Columns["Impresora"].HeaderText = "IMPRESORA";
                    dgv.Columns["Impresora"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    break;
                default:
                    break;
            }
        }

        private void frmBuscador_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != string.Empty)
            {
                DataView dtv = new DataView(dt);

                switch (this.Tabla)
                {
                    case "Personal":
                        dtv.RowFilter = string.Format("CONVERT(personal_id, System.String) LIKE '%{0}%' or nombre LIKE '%{0}%' or apellido LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    case "Articulos":
                        dtv.RowFilter = string.Format("codigo LIKE '%{0}%' or descripcion LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    case "Proveedores":
                        dtv.RowFilter = string.Format("CONVERT(proveedor_id, System.String) LIKE '%{0}%' or rsocial LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    case "Clientes":
                        dtv.RowFilter = string.Format("CONVERT(cliente_id, System.String) LIKE '%{0}%' or rsocial LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    case "Mesas":
                        dtv.RowFilter = string.Format("nombre LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    case "Impresoras":
                        dtv.RowFilter = string.Format("Impresora LIKE '%{0}%'", txtBuscar.Text.Trim());
                        break;
                    default:
                        break;
                }

                dgv.DataSource = dtv;
            }
            else
                LoadData();
        }

        private void frmBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.DialogResult = DialogResult.Cancel;
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBuscar.Text != String.Empty)
            {
                //Char ch = Convert.ToChar(txtBuscar.Text.ToString());

                int n;
                bool isNumeric = int.TryParse(txtBuscar.Text, out n);

                if (isNumeric)
                {
                    DataView dtv = new DataView(dt);

                    switch (Tabla)
                    {
                        case "Personal":
                            dtv.RowFilter = string.Format("personal_id = {0}", n);

                            if (dtv.Count > 0)
                            {
                                foreach (DataRowView drv in dtv)
                                    this.Id = Convert.ToInt32(drv["personal_id"]);


                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        case "Articulos":
                            dtv.RowFilter = string.Format("codigo = '{0}'", n);

                            if (dtv.Count > 0)
                            {
                                foreach (DataRowView drv in dtv)
                                    //this.Id = Convert.ToInt32(drv["codigo"]);
                                    this.Id = Convert.ToInt32(drv["articulo_id"]);

                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        case "Proveedores":
                            dtv.RowFilter = string.Format("proveedor_id = '{0}'", n);

                            if (dtv.Count > 0)
                            {
                                foreach (DataRowView drv in dtv)
                                    //this.Id = Convert.ToInt32(drv["codigo"]);
                                    this.Id = Convert.ToInt32(drv["proveedor_id"]);

                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        case "Clientes":
                            dtv.RowFilter = string.Format("cliente_id = '{0}'", n);

                            if (dtv.Count > 0)
                            {
                                foreach (DataRowView drv in dtv)
                                    //this.Id = Convert.ToInt32(drv["codigo"]);
                                    this.Id = Convert.ToInt32(drv["cliente_id"]);

                                this.DialogResult = DialogResult.OK;
                            }
                            break;
                        default:
                            break;
                    }

                }

            }
            //else
            //    dgv.Focus();
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridView dgv1 = (DataGridView)sender;
                dgv1.CurrentRow.Selected = true;

                string campo = "";
                switch (this.Tabla)
                {
                    case "Personal":
                        campo = "personal_id";
                        break;
                    case "Articulos":
                        campo = "articulo_id";
                        break;
                    case "Proveedores":
                        campo = "proveedor_id";
                        break;
                    case "Clientes":
                        campo = "cliente_id";
                        break;
                    case "Mesas":
                        campo = "plano_id";
                        break;
                    default:
                        break;
                }

                if (this.Tabla != "Impresoras")
                    this.Id = Convert.ToInt32(dgv1.Rows[dgv1.CurrentRow.Index].Cells[campo].Value.ToString());
                else
                    this.Impresora = dgv1.Rows[dgv1.CurrentRow.Index].Cells["Impresora"].Value.ToString();

                e.Handled = true;

                this.DialogResult = DialogResult.OK;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv1 = (DataGridView)sender;
            dgv1.CurrentRow.Selected = true;

            string campo = "";
            string campo_alt = "";
            switch (this.Tabla)
            {
                case "Personal":
                    campo = "personal_id";
                    break;
                case "Articulos":
                    campo = "articulo_id";
                    break;
                case "Proveedores":
                    campo = "proveedor_id";
                    break;
                case "Clientes":
                    campo = "cliente_id";
                    break;
                case "Mesas":
                    campo = "plano_id";
                    campo_alt = "nombre";
                    break;
                default:
                    break;
            }

            if (this.Tabla != "Impresoras")
            { 
                this.Id = Convert.ToInt32(dgv1.Rows[dgv1.CurrentRow.Index].Cells[campo].Value.ToString());

                if(campo_alt.Length > 0)
                    this.Campo = dgv1.Rows[dgv1.CurrentRow.Index].Cells[campo_alt].Value.ToString();
            }
            else
                this.Impresora = dgv1.Rows[dgv1.CurrentRow.Index].Cells["Impresora"].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }
    }
}
