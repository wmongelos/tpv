using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmOpciones : Form
    {
        private Configuracion oConfig = new Configuracion();
        private Tipos_Responsables oTip = new Tipos_Responsables();

        private ComboBoxAdv cboTiposResp = new ComboBoxAdv();

        public frmOpciones()
        {
            InitializeComponent();

            this.Controls.Add(cboTiposResp);
            cboTiposResp.Size = new Size(415, 41);
            cboTiposResp.Location = new Point(13, 147);
        }

        private void LoadData()
        {
            txtRSocial.Value = oConfig.getValue_C("RSocial");
            txtDomicilio.Value = oConfig.getValue_C("Direccion");
            txtCuit.Value = oConfig.getValue_C("Cuit");

            cboTiposResp.DataSource = oTip.GetTipoResponsables();
            cboTiposResp.Display = "descripcion";
            cboTiposResp.Value = "tipo_responsable_id";
            cboTiposResp.SelectedValue = oConfig.getValue_N("Condicion_IVA").ToString();

            txtDomicilio.Value = oConfig.getValue_C("Direccion");
            txtEmail.Value = oConfig.getValue_C("Email");
        }

        private void SaveData()
        {
            oConfig.setValue_C("RSocial", txtRSocial.Value);
            oConfig.setValue_C("Direccion", txtDomicilio.Value);
            oConfig.setValue_C("Cuit", txtCuit.Value);
            oConfig.setValue_N("Condicion_IVA", Convert.ToInt32(cboTiposResp.SelectedValue));
            oConfig.setValue_C("Direccion", txtDomicilio.Value);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOpciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            //PrintDialog pd = new PrintDialog();

            //if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    MessageBox.Show(pd.PrinterSettings.PrinterName);
            //}



            if (frmMsgBox.Show("¿Desea Guardar los Cambios?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                this.SaveData();
                this.Close();
            }
        }
    }
}
