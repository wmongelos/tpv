namespace TPV.Abms
{
    partial class frmPlano
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlano));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.pnLine = new System.Windows.Forms.Panel();
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.oReloj = new System.Windows.Forms.Timer(this.components);
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.pnControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnMenu.TabIndex = 4;
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
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnFooter.Controls.Add(this.pnLine);
            this.pnFooter.Controls.Add(this.lblReloj);
            this.pnFooter.Controls.Add(this.lblUserLogin);
            this.pnFooter.Controls.Add(this.pictureBox1);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 747);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1190, 35);
            this.pnFooter.TabIndex = 5;
            // 
            // pnLine
            // 
            this.pnLine.BackColor = System.Drawing.Color.Silver;
            this.pnLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLine.Location = new System.Drawing.Point(0, 0);
            this.pnLine.Name = "pnLine";
            this.pnLine.Size = new System.Drawing.Size(1190, 1);
            this.pnLine.TabIndex = 18;
            // 
            // lblReloj
            // 
            this.lblReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReloj.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.DimGray;
            this.lblReloj.Location = new System.Drawing.Point(951, 8);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(235, 20);
            this.lblReloj.TabIndex = 17;
            this.lblReloj.Text = "[FECHA Y HORA]";
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblUserLogin.Location = new System.Drawing.Point(51, 11);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(71, 16);
            this.lblUserLogin.TabIndex = 16;
            this.lblUserLogin.Text = "[USUARIO]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Image = global::TPV.Properties.Resources.User_Shield_24;
            this.pictureBox1.Location = new System.Drawing.Point(21, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // oReloj
            // 
            this.oReloj.Enabled = true;
            this.oReloj.Tick += new System.EventHandler(this.oReloj_Tick);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 50);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(1190, 697);
            this.pnContenedor.TabIndex = 27;
            // 
            // frmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1190, 782);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPlano_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPlano_KeyDown);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnControlBox;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Panel pnLine;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer oReloj;
        private System.Windows.Forms.Panel pnContenedor;
    }
}