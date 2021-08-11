using System;
using System.Data;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class ComboBoxAdv : UserControl
    {
        public ComboBoxAdv()
        {
            InitializeComponent();

            cbo.SelectedValueChanged += new EventHandler(cbo_SelectedValueChanged);
        }

        private DataTable dt;
        public DataTable DataSource
        {
            get { return dt; }
            set {
                dt = value;
                cbo.DataSource = value;
            }
        } 

        public string Display
        {
            get { return cbo.DisplayMember; }
            set { cbo.DisplayMember = value; }
        }

        public string Value
        {
            get { return cbo.ValueMember; }
            set { cbo.ValueMember = value; }
        }

        public string SelectedValue
        {
            get
            {
                return cbo.SelectedValue == null ? "":cbo.SelectedValue.ToString();
            }

            set
            {
                cbo.SelectedValue = value;
            }
        }

        public string SelectedText
        {
            get
            {
                return cbo.SelectedValue == null ? "" : cbo.Text.ToString();
            }
        }

        private void ComboBoxAdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            { 
                SendKeys.Send("{TAB}");

                e.Handled = true;
            }
        }

        

        public event EventHandler Seleccion;

        private void cbo_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
