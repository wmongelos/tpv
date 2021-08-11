namespace TPV.Abms
{
    partial class frmAbmPlano
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
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconDelete = new System.Windows.Forms.PictureBox();
            this.iconEditar = new System.Windows.Forms.PictureBox();
            this.pnControlBox = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMaximizar = new System.Windows.Forms.Label();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.iconGuardar = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.iconAgregar = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditar)).BeginInit();
            this.pnControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(142)))), ((int)(((byte)(186)))));
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Controls.Add(this.iconDelete);
            this.pnMenu.Controls.Add(this.iconEditar);
            this.pnMenu.Controls.Add(this.pnControlBox);
            this.pnMenu.Controls.Add(this.iconGuardar);
            this.pnMenu.Controls.Add(this.imgLogo);
            this.pnMenu.Controls.Add(this.iconAgregar);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1190, 50);
            this.pnMenu.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(305, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 30);
            this.panel1.TabIndex = 27;
            // 
            // iconDelete
            // 
            this.iconDelete.Image = global::TPV.Properties.Resources.Garbage_Closed_48;
            this.iconDelete.Location = new System.Drawing.Point(247, 2);
            this.iconDelete.Name = "iconDelete";
            this.iconDelete.Size = new System.Drawing.Size(48, 48);
            this.iconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconDelete.TabIndex = 26;
            this.iconDelete.TabStop = false;
            // 
            // iconEditar
            // 
            this.iconEditar.Image = global::TPV.Properties.Resources.Data_Edit_48;
            this.iconEditar.Location = new System.Drawing.Point(197, 2);
            this.iconEditar.Name = "iconEditar";
            this.iconEditar.Size = new System.Drawing.Size(48, 48);
            this.iconEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconEditar.TabIndex = 25;
            this.iconEditar.TabStop = false;
            this.iconEditar.Click += new System.EventHandler(this.iconEditar_Click);
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
            // iconGuardar
            // 
            this.iconGuardar.Image = global::TPV.Properties.Resources.Save_48;
            this.iconGuardar.Location = new System.Drawing.Point(316, 2);
            this.iconGuardar.Name = "iconGuardar";
            this.iconGuardar.Size = new System.Drawing.Size(48, 48);
            this.iconGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconGuardar.TabIndex = 24;
            this.iconGuardar.TabStop = false;
            this.iconGuardar.Click += new System.EventHandler(this.iconGuardar_Click);
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
            // iconAgregar
            // 
            this.iconAgregar.Image = global::TPV.Properties.Resources.Add_New_48;
            this.iconAgregar.Location = new System.Drawing.Point(147, 2);
            this.iconAgregar.Name = "iconAgregar";
            this.iconAgregar.Size = new System.Drawing.Size(48, 48);
            this.iconAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconAgregar.TabIndex = 23;
            this.iconAgregar.TabStop = false;
            this.iconAgregar.Click += new System.EventHandler(this.iconAgregar_Click);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 50);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(1190, 732);
            this.pnContenedor.TabIndex = 26;
            // 
            // frmAbmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1190, 782);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAbmPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diseño de Plano";
            this.Load += new System.EventHandler(this.frmAbmPlano_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbmPlano_KeyDown);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditar)).EndInit();
            this.pnControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox iconAgregar;
        private System.Windows.Forms.PictureBox iconGuardar;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnControlBox;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMaximizar;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.PictureBox iconDelete;
        private System.Windows.Forms.PictureBox iconEditar;
        private System.Windows.Forms.Panel panel1;
    }
}