namespace TPV.Reportes
{
    partial class frmReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportViewer));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.rptViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnMenu.SuspendLayout();
            this.pnControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.pnMenu.Controls.Add(this.pnControlBox);
            this.pnMenu.Controls.Add(this.imgLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1190, 50);
            this.pnMenu.TabIndex = 5;
            // 
            // pnControlBox
            // 
            this.pnControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnControlBox.BackColor = System.Drawing.Color.Transparent;
            this.pnControlBox.Controls.Add(this.lblClose);
            this.pnControlBox.Controls.Add(this.lblMaximizar);
            this.pnControlBox.Controls.Add(this.lblMinimizar);
            this.pnControlBox.Location = new System.Drawing.Point(1053, 0);
            this.pnControlBox.Name = "pnControlBox";
            this.pnControlBox.Size = new System.Drawing.Size(109, 30);
            this.pnControlBox.TabIndex = 13;
            // 
            // lblClose
            // 
            this.lblClose.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(73, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(29, 23);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "r";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMaximizar
            // 
            this.lblMaximizar.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMaximizar.ForeColor = System.Drawing.Color.White;
            this.lblMaximizar.Location = new System.Drawing.Point(40, 1);
            this.lblMaximizar.Name = "lblMaximizar";
            this.lblMaximizar.Size = new System.Drawing.Size(29, 23);
            this.lblMaximizar.TabIndex = 1;
            this.lblMaximizar.Text = "2";
            this.lblMaximizar.Visible = false;
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.Font = new System.Drawing.Font("Webdings", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMinimizar.ForeColor = System.Drawing.Color.White;
            this.lblMinimizar.Location = new System.Drawing.Point(9, 1);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(29, 23);
            this.lblMinimizar.TabIndex = 0;
            this.lblMinimizar.Text = "0";
            this.lblMinimizar.Visible = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::TPV.Properties.Resources.logo_white;
            this.imgLogo.Location = new System.Drawing.Point(12, 8);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(100, 37);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // rptViewer
            // 
            this.rptViewer.ActiveViewIndex = -1;
            this.rptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 50);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowCloseButton = false;
            this.rptViewer.ShowLogo = false;
            this.rptViewer.ShowParameterPanelButton = false;
            this.rptViewer.Size = new System.Drawing.Size(1190, 732);
            this.rptViewer.TabIndex = 6;
            this.rptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1190, 782);
            this.Controls.Add(this.rptViewer);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresion";
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnControlBox;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.PictureBox imgLogo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptViewer;
    }
}