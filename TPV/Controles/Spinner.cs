using System;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class Spinner : UserControl
    {
        public Spinner()
        {
            InitializeComponent();
        }

        public Int32 DecimalPlaces
        {
            get { return spValue.DecimalPlaces; }
            set { spValue.DecimalPlaces = value; }
        }

        public Decimal Value
        {
            get { return spValue.Value; }
            set { spValue.Value = value; }
        }

        public Decimal Maximum
        {
            get { return spValue.Maximum; }
            set { spValue.Maximum = value; }
        }

        public Decimal Minimum
        {
            get { return spValue.Minimum; }
            set { spValue.Minimum = value; }
        }

        private void spValue_Enter(object sender, EventArgs e)
        {
            spValue.Select(0, spValue.ToString().Length);
        }

        private void spValue_MouseClick(object sender, MouseEventArgs e)
        {
            spValue.Select(0, spValue.ToString().Length);
        }

        public void Select_Value()
        {
            spValue.Select(0, spValue.ToString().Length);
        }

        private void spValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;

                SendKeys.Send("{TAB}");
                // e.Handled = true;
            }
        }
    }
}
