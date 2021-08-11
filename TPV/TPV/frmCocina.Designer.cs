namespace TPV
{
    partial class frmCocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCocina));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnBar = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnDespacho = new System.Windows.Forms.Button();
            this.btnCocinando = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.FlowLayoutPanel();
            this.oTimer = new System.Windows.Forms.Timer(this.components);
            this.oTimerHS = new System.Windows.Forms.Timer(this.components);
            this.pnMenu.SuspendLayout();
            this.pnControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnBar.SuspendLayout();
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
            this.lblMaximizar.Click += new System.EventHandler(this.lblMaximizar_Click);
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
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
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
            // pnBar
            // 
            this.pnBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnBar.Controls.Add(this.lblHora);
            this.pnBar.Controls.Add(this.btnDespacho);
            this.pnBar.Controls.Add(this.btnCocinando);
            this.pnBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnBar.Location = new System.Drawing.Point(1053, 50);
            this.pnBar.Name = "pnBar";
            this.pnBar.Size = new System.Drawing.Size(137, 732);
            this.pnBar.TabIndex = 6;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(5, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(123, 23);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "lblHora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDespacho
            // 
            this.btnDespacho.BackColor = System.Drawing.Color.Tomato;
            this.btnDespacho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespacho.FlatAppearance.BorderSize = 0;
            this.btnDespacho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespacho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespacho.ForeColor = System.Drawing.Color.White;
            this.btnDespacho.Image = global::TPV.Properties.Resources.Restaurant_32;
            this.btnDespacho.Location = new System.Drawing.Point(5, 113);
            this.btnDespacho.Name = "btnDespacho";
            this.btnDespacho.Size = new System.Drawing.Size(123, 52);
            this.btnDespacho.TabIndex = 3;
            this.btnDespacho.Text = "DESPACHADO";
            this.btnDespacho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDespacho.UseVisualStyleBackColor = false;
            this.btnDespacho.Click += new System.EventHandler(this.btnDespacho_Click);
            // 
            // btnCocinando
            // 
            this.btnCocinando.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCocinando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCocinando.FlatAppearance.BorderSize = 0;
            this.btnCocinando.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocinando.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCocinando.ForeColor = System.Drawing.Color.White;
            this.btnCocinando.Image = global::TPV.Properties.Resources.Chef_32;
            this.btnCocinando.Location = new System.Drawing.Point(5, 55);
            this.btnCocinando.Name = "btnCocinando";
            this.btnCocinando.Size = new System.Drawing.Size(123, 52);
            this.btnCocinando.TabIndex = 2;
            this.btnCocinando.Text = "COCINANDO   ";
            this.btnCocinando.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCocinando.UseVisualStyleBackColor = false;
            this.btnCocinando.Click += new System.EventHandler(this.btnCocinando_Click);
            // 
            // pnContent
            // 
            this.pnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContent.Location = new System.Drawing.Point(0, 50);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(1053, 732);
            this.pnContent.TabIndex = 7;
            // 
            // oTimer
            // 
            this.oTimer.Enabled = true;
            this.oTimer.Interval = 5000;
            this.oTimer.Tick += new System.EventHandler(this.oTimer_Tick);
            // 
            // oTimerHS
            // 
            this.oTimerHS.Enabled = true;
            this.oTimerHS.Tick += new System.EventHandler(this.oTimerHS_Tick);
            // 
            // frmCocina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1190, 782);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnBar);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCocina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCocina_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCocina_KeyDown);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnControlBox;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnBar;
        private System.Windows.Forms.FlowLayoutPanel pnContent;
        private System.Windows.Forms.Button btnCocinando;
        private System.Windows.Forms.Button btnDespacho;
        private System.Windows.Forms.Timer oTimer;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer oTimerHS;
    }
}