namespace TPV
{
    partial class frmTicketCierre
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
            this.components = new System.ComponentModel.Container();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboTiposResp = new TPV.Controles.ComboBoxAdv();
            this.cbo = new TPV.Controles.ComboExt(this.components);
            this.comboExt1 = new TPV.Controles.ComboExt(this.components);
            this.txtCuit = new TPV.Controles.TextBoxAdv();
            this.txtRSocial = new TPV.Controles.TextBoxAdv();
            this.spTotal = new TPV.Controles.Spinner();
            this.spDescuento = new TPV.Controles.Spinner();
            this.spSubTotal = new TPV.Controles.Spinner();
            this.panel1.SuspendLayout();
            this.cboTiposResp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(7, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 23);
            this.lblTitulo.TabIndex = 26;
            this.lblTitulo.Text = "CIERRE DE MESA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 50);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(455, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "SUBTOTAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(455, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "DESCUENTO %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(455, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "TOTAL";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(514, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 43);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(406, 301);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 43);
            this.btnConfirmar.TabIndex = 43;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(25, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 1);
            this.panel2.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "CUIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "RESPONSABLE IVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "RAZON SOCIAL";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(413, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 202);
            this.panel3.TabIndex = 51;
            // 
            // cboTiposResp
            // 
            this.cboTiposResp.Controls.Add(this.cbo);
            this.cboTiposResp.Controls.Add(this.comboExt1);
            this.cboTiposResp.DataSource = null;
            this.cboTiposResp.Display = "";
            this.cboTiposResp.Location = new System.Drawing.Point(12, 139);
            this.cboTiposResp.Name = "cboTiposResp";
            this.cboTiposResp.SelectedValue = "";
            this.cboTiposResp.Size = new System.Drawing.Size(360, 40);
            this.cboTiposResp.TabIndex = 50;
            this.cboTiposResp.Value = "";
            // 
            // cbo
            // 
            this.cbo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo.ForeColor = System.Drawing.Color.DimGray;
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(7, 5);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(342, 31);
            this.cbo.TabIndex = 1;
            // 
            // comboExt1
            // 
            this.comboExt1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboExt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExt1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExt1.ForeColor = System.Drawing.Color.DimGray;
            this.comboExt1.FormattingEnabled = true;
            this.comboExt1.Location = new System.Drawing.Point(7, 5);
            this.comboExt1.Name = "comboExt1";
            this.comboExt1.Size = new System.Drawing.Size(342, 31);
            this.comboExt1.TabIndex = 0;
            // 
            // txtCuit
            // 
            this.txtCuit.AutoSize = true;
            this.txtCuit.Location = new System.Drawing.Point(13, 204);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Numerico = true;
            this.txtCuit.Size = new System.Drawing.Size(360, 40);
            this.txtCuit.TabIndex = 46;
            this.txtCuit.Value = "";
            // 
            // txtRSocial
            // 
            this.txtRSocial.AutoSize = true;
            this.txtRSocial.Location = new System.Drawing.Point(12, 78);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Numerico = false;
            this.txtRSocial.Size = new System.Drawing.Size(360, 40);
            this.txtRSocial.TabIndex = 45;
            this.txtRSocial.Tag = "0";
            this.txtRSocial.Value = "PUBLICO EN GENERAL";
            // 
            // spTotal
            // 
            this.spTotal.DecimalPlaces = 2;
            this.spTotal.Enabled = false;
            this.spTotal.Location = new System.Drawing.Point(453, 204);
            this.spTotal.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spTotal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spTotal.Name = "spTotal";
            this.spTotal.Size = new System.Drawing.Size(170, 40);
            this.spTotal.TabIndex = 40;
            this.spTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spTotal.Validated += new System.EventHandler(this.spTotal_Validated);
            // 
            // spDescuento
            // 
            this.spDescuento.DecimalPlaces = 2;
            this.spDescuento.Location = new System.Drawing.Point(453, 139);
            this.spDescuento.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.spDescuento.Minimum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            -2147483648});
            this.spDescuento.Name = "spDescuento";
            this.spDescuento.Size = new System.Drawing.Size(170, 40);
            this.spDescuento.TabIndex = 38;
            this.spDescuento.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spDescuento.Validated += new System.EventHandler(this.spDescuento_Validated);
            // 
            // spSubTotal
            // 
            this.spSubTotal.DecimalPlaces = 2;
            this.spSubTotal.Enabled = false;
            this.spSubTotal.Location = new System.Drawing.Point(453, 78);
            this.spSubTotal.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spSubTotal.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spSubTotal.Name = "spSubTotal";
            this.spSubTotal.Size = new System.Drawing.Size(170, 40);
            this.spSubTotal.TabIndex = 36;
            this.spSubTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frmTicketCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cboTiposResp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRSocial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spDescuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spSubTotal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmTicketCierre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Mesa";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTicketCierre_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTicketCierre_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cboTiposResp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Controles.Spinner spSubTotal;
        private System.Windows.Forms.Label label1;
        private Controles.Spinner spDescuento;
        private System.Windows.Forms.Label label2;
        private Controles.Spinner spTotal;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panel2;
        private Controles.ComboBoxAdv cboTiposResp;
        private Controles.ComboExt cbo;
        private Controles.ComboExt comboExt1;
        private System.Windows.Forms.Label label4;
        private Controles.TextBoxAdv txtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Controles.TextBoxAdv txtRSocial;
        private System.Windows.Forms.Panel panel3;
    }
}