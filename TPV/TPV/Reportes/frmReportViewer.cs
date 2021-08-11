using System.Data;
using System.Windows.Forms;

namespace TPV.Reportes
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(DataTable dt)
        {
            InitializeComponent();

            this.Left = 0;
            this.Top = 30;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 30;

            rptProductos rp = new rptProductos();
            rp.SetDataSource(dt);

            this.rptViewer.ReportSource = rp;


        }

        private void lblClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
