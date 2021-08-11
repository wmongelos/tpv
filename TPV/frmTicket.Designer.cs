namespace TPV
{
    partial class frmTicket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicket));
            this.pnTop = new System.Windows.Forms.Panel();
            this.lblCubiertos = new System.Windows.Forms.Label();
            this.btnCambio = new TPV.Controles.ButtonTicket();
            this.btnAnular = new TPV.Controles.ButtonTicket();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.btnEfectivo = new TPV.Controles.ButtonTicket();
            this.pnVentas = new System.Windows.Forms.Panel();
            this.pnItems = new System.Windows.Forms.Panel();
            this.pnVentasEnc = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnRubros = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnVentas.SuspendLayout();
            this.pnVentasEnc.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.pnTop.Controls.Add(this.lblCubiertos);
            this.pnTop.Controls.Add(this.btnCambio);
            this.pnTop.Controls.Add(this.btnAnular);
            this.pnTop.Controls.Add(this.lblPersonal);
            this.pnTop.Controls.Add(this.lblMesa);
            this.pnTop.Controls.Add(this.btnEfectivo);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1020, 50);
            this.pnTop.TabIndex = 0;
            // 
            // lblCubiertos
            // 
            this.lblCubiertos.AutoSize = true;
            this.lblCubiertos.ForeColor = System.Drawing.Color.White;
            this.lblCubiertos.Location = new System.Drawing.Point(97, 18);
            this.lblCubiertos.Name = "lblCubiertos";
            this.lblCubiertos.Size = new System.Drawing.Size(101, 16);
            this.lblCubiertos.TabIndex = 7;
            this.lblCubiertos.Text = "[CUBIERTOS: 0]";
            // 
            // btnCambio
            // 
            this.btnCambio.BackColor = System.Drawing.Color.Transparent;
            this.btnCambio.Caption = "CAMBIO DE MESA";
            this.btnCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambio.Icon = global::TPV.Properties.Resources.Command_Undo_Redo_32;
            this.btnCambio.Location = new System.Drawing.Point(362, 0);
            this.btnCambio.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnCambio.Name = "btnCambio";
            this.btnCambio.Size = new System.Drawing.Size(161, 50);
            this.btnCambio.TabIndex = 6;
            this.btnCambio.Visible = false;
            this.btnCambio.Click += new System.EventHandler(this.btnCambio_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.Caption = "ANULAR MESA";
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.Icon = global::TPV.Properties.Resources.Command_Redo_32;
            this.btnAnular.Location = new System.Drawing.Point(529, 0);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(137, 44);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.ForeColor = System.Drawing.Color.White;
            this.lblPersonal.Location = new System.Drawing.Point(224, 18);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(69, 16);
            this.lblPersonal.TabIndex = 4;
            this.lblPersonal.Text = "[MOZO: 0]";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.ForeColor = System.Drawing.Color.White;
            this.lblMesa.Location = new System.Drawing.Point(12, 18);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(67, 16);
            this.lblMesa.TabIndex = 3;
            this.lblMesa.Text = "[MESA: 0]";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.btnEfectivo.Caption = "EFECTIVO";
            this.btnEfectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEfectivo.Icon = global::TPV.Properties.Resources.ATM_32;
            this.btnEfectivo.Location = new System.Drawing.Point(787, 0);
            this.btnEfectivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(115, 50);
            this.btnEfectivo.TabIndex = 2;
            this.btnEfectivo.Visible = false;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // pnVentas
            // 
            this.pnVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnVentas.Controls.Add(this.pnItems);
            this.pnVentas.Controls.Add(this.pnVentasEnc);
            this.pnVentas.Controls.Add(this.panel2);
            this.pnVentas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnVentas.Location = new System.Drawing.Point(785, 50);
            this.pnVentas.Name = "pnVentas";
            this.pnVentas.Size = new System.Drawing.Size(235, 540);
            this.pnVentas.TabIndex = 7;
            // 
            // pnItems
            // 
            this.pnItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnItems.Location = new System.Drawing.Point(1, 50);
            this.pnItems.Name = "pnItems";
            this.pnItems.Size = new System.Drawing.Size(234, 490);
            this.pnItems.TabIndex = 3;
            // 
            // pnVentasEnc
            // 
            this.pnVentasEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pnVentasEnc.Controls.Add(this.panel5);
            this.pnVentasEnc.Controls.Add(this.label1);
            this.pnVentasEnc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnVentasEnc.Location = new System.Drawing.Point(1, 0);
            this.pnVentasEnc.Name = "pnVentasEnc";
            this.pnVentasEnc.Size = new System.Drawing.Size(234, 50);
            this.pnVentasEnc.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 2);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 540);
            this.panel2.TabIndex = 0;
            // 
            // pnRubros
            // 
            this.pnRubros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRubros.AutoScroll = true;
            this.pnRubros.Location = new System.Drawing.Point(0, 50);
            this.pnRubros.Name = "pnRubros";
            this.pnRubros.Size = new System.Drawing.Size(784, 218);
            this.pnRubros.TabIndex = 9;
            // 
            // pnMain
            // 
            this.pnMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMain.AutoScroll = true;
            this.pnMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnMain.Location = new System.Drawing.Point(0, 271);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(785, 386);
            this.pnMain.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(786, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 69);
            this.panel3.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 1);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(234, 68);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "$ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 1);
            this.panel6.TabIndex = 0;
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnFooter.Controls.Add(this.panel3);
            this.pnFooter.Controls.Add(this.panel1);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 590);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1020, 70);
            this.pnFooter.TabIndex = 5;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1020, 660);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnRubros);
            this.Controls.Add(this.pnVentas);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnTop);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTicket";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTicket_KeyDown);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.pnVentas.ResumeLayout(false);
            this.pnVentasEnc.ResumeLayout(false);
            this.pnVentasEnc.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnVentas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnVentasEnc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnItems;
        private Controles.ButtonTicket btnEfectivo;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.FlowLayoutPanel pnRubros;
        private System.Windows.Forms.FlowLayoutPanel pnMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnFooter;
        private Controles.ButtonTicket btnAnular;
        private Controles.ButtonTicket btnCambio;
        private System.Windows.Forms.Label lblCubiertos;
    }
}