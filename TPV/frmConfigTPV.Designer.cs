namespace TPV
{
    partial class frmConfigTPV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigTPV));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblApp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuertoFiscal = new TPV.Controles.TextBoxAdv();
            this.cboTipoApp = new TPV.Controles.ComboBoxAdv();
            this.cbo = new TPV.Controles.ComboExt(this.components);
            this.cboPDV = new TPV.Controles.ComboBoxAdv();
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7 = new TPV.Controles.ComboExt(this.components);
            this.comboExt1 = new TPV.Controles.ComboExt(this.components);
            this.cboModeloFiscal = new TPV.Controles.ComboBoxAdv();
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7 = new TPV.Controles.ComboExt(this.components);
            this.comboExt2 = new TPV.Controles.ComboExt(this.components);
            this.comboExt3 = new TPV.Controles.ComboExt(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.cboTipoApp.SuspendLayout();
            this.cboPDV.SuspendLayout();
            this.cboModeloFiscal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(136, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 43);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(265, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 43);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 115);
            this.panel1.TabIndex = 15;
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.DimGray;
            this.lblApp.Location = new System.Drawing.Point(23, 131);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(69, 13);
            this.lblApp.TabIndex = 28;
            this.lblApp.Text = "APLICACION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(23, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "NRO DE CAJA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(23, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "PUERTO FISCAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(23, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "MODELO";
            // 
            // txtPuertoFiscal
            // 
            this.txtPuertoFiscal.AutoSize = true;
            this.txtPuertoFiscal.Location = new System.Drawing.Point(21, 268);
            this.txtPuertoFiscal.Name = "txtPuertoFiscal";
            this.txtPuertoFiscal.Numerico = true;
            this.txtPuertoFiscal.Size = new System.Drawing.Size(360, 40);
            this.txtPuertoFiscal.TabIndex = 18;
            this.txtPuertoFiscal.Value = "";
            // 
            // cboTipoApp
            // 
            this.cboTipoApp.Controls.Add(this.cbo);
            this.cboTipoApp.DataSource = null;
            this.cboTipoApp.Display = "";
            this.cboTipoApp.Location = new System.Drawing.Point(21, 147);
            this.cboTipoApp.Name = "cboTipoApp";
            this.cboTipoApp.SelectedValue = "";
            this.cboTipoApp.Size = new System.Drawing.Size(360, 40);
            this.cboTipoApp.TabIndex = 32;
            this.cboTipoApp.Value = "";
            // 
            // cbo
            // 
            this.cbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // cboPDV
            // 
            this.cboPDV.Controls.Add(this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7);
            this.cboPDV.Controls.Add(this.comboExt1);
            this.cboPDV.DataSource = null;
            this.cboPDV.Display = "";
            this.cboPDV.Location = new System.Drawing.Point(21, 207);
            this.cboPDV.Name = "cboPDV";
            this.cboPDV.SelectedValue = "";
            this.cboPDV.Size = new System.Drawing.Size(360, 40);
            this.cboPDV.TabIndex = 33;
            this.cboPDV.Value = "";
            // 
            // object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7
            // 
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.ForeColor = System.Drawing.Color.DimGray;
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.FormattingEnabled = true;
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.Location = new System.Drawing.Point(7, 5);
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.Name = "object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7";
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.Size = new System.Drawing.Size(342, 31);
            this.object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7.TabIndex = 1;
            // 
            // comboExt1
            // 
            this.comboExt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboExt1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboExt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExt1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExt1.ForeColor = System.Drawing.Color.DimGray;
            this.comboExt1.FormattingEnabled = true;
            this.comboExt1.Location = new System.Drawing.Point(7, 5);
            this.comboExt1.Name = "comboExt1";
            this.comboExt1.Size = new System.Drawing.Size(342, 31);
            this.comboExt1.TabIndex = 1;
            // 
            // cboModeloFiscal
            // 
            this.cboModeloFiscal.Controls.Add(this.object_0d869170_0580_4668_8b5b_e63128ae3ad7);
            this.cboModeloFiscal.Controls.Add(this.comboExt2);
            this.cboModeloFiscal.Controls.Add(this.comboExt3);
            this.cboModeloFiscal.DataSource = null;
            this.cboModeloFiscal.Display = "";
            this.cboModeloFiscal.Location = new System.Drawing.Point(21, 330);
            this.cboModeloFiscal.Name = "cboModeloFiscal";
            this.cboModeloFiscal.SelectedValue = "";
            this.cboModeloFiscal.Size = new System.Drawing.Size(360, 40);
            this.cboModeloFiscal.TabIndex = 34;
            this.cboModeloFiscal.Value = "";
            // 
            // object_0d869170_0580_4668_8b5b_e63128ae3ad7
            // 
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.ForeColor = System.Drawing.Color.DimGray;
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.FormattingEnabled = true;
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.Location = new System.Drawing.Point(7, 5);
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.Name = "object_0d869170_0580_4668_8b5b_e63128ae3ad7";
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.Size = new System.Drawing.Size(342, 31);
            this.object_0d869170_0580_4668_8b5b_e63128ae3ad7.TabIndex = 1;
            // 
            // comboExt2
            // 
            this.comboExt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboExt2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboExt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExt2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExt2.ForeColor = System.Drawing.Color.DimGray;
            this.comboExt2.FormattingEnabled = true;
            this.comboExt2.Location = new System.Drawing.Point(7, 5);
            this.comboExt2.Name = "comboExt2";
            this.comboExt2.Size = new System.Drawing.Size(342, 31);
            this.comboExt2.TabIndex = 1;
            // 
            // comboExt3
            // 
            this.comboExt3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboExt3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboExt3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboExt3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboExt3.ForeColor = System.Drawing.Color.DimGray;
            this.comboExt3.FormattingEnabled = true;
            this.comboExt3.Location = new System.Drawing.Point(7, 5);
            this.comboExt3.Name = "comboExt3";
            this.comboExt3.Size = new System.Drawing.Size(342, 31);
            this.comboExt3.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(107, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONFIGURACION DE TERMINAL";
            // 
            // frmConfigTPV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(402, 455);
            this.Controls.Add(this.cboModeloFiscal);
            this.Controls.Add(this.cboPDV);
            this.Controls.Add(this.cboTipoApp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.txtPuertoFiscal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfigTPV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmConfigTPV_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmConfigTPV_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cboTipoApp.ResumeLayout(false);
            this.cboPDV.ResumeLayout(false);
            this.cboModeloFiscal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private Controles.TextBoxAdv txtPuertoFiscal;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controles.ComboBoxAdv cboTipoApp;
        private Controles.ComboExt cbo;
        private Controles.ComboBoxAdv cboPDV;
        private Controles.ComboExt object_d89939ce_a95d_4ee9_a9fa_be7483cd08f7;
        private Controles.ComboExt comboExt1;
        private Controles.ComboBoxAdv cboModeloFiscal;
        private Controles.ComboExt object_0d869170_0580_4668_8b5b_e63128ae3ad7;
        private Controles.ComboExt comboExt2;
        private Controles.ComboExt comboExt3;
        private System.Windows.Forms.Label lblTitulo;
    }
}