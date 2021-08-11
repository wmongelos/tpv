using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPV.Controles
{
    public partial class CustomGrid : DataGridView
    {
        public CustomGrid()
        {
            InitializeComponent();
        }

        private void CustomGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
                using (Pen p = new Pen(Color.Gainsboro, 1))
                {
                    Rectangle rect = e.CellBounds;
                    rect.Width -= 3;
                    rect.Height -= 3;

                    e.Graphics.DrawRectangle(p, rect);
                }
                e.Handled = true;
            }
        }

        private void CustomGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                // e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }
    }
}
