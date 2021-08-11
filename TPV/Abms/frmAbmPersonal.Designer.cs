namespace TPV.Abms
{
    partial class frmAbmPersonal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.OpenFileDialog();
            this.txtCuit = new TPV.Controles.TextBoxAdv();
            this.txtCodigo = new TPV.Controles.TextBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDomicilio = new TPV.Controles.TextBoxAdv();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new TPV.Controles.TextBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new TPV.Controles.TextBoxAdv();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono_2 = new TPV.Controles.TextBoxAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono_1 = new TPV.Controles.TextBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new TPV.Controles.TextBoxAdv();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 74);
            this.panel1.TabIndex = 3;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = global::TPV.Properties.Resources.icons8_back_to_48;
            this.BtnBack.Location = new System.Drawing.Point(14, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(48, 48);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnBack.TabIndex = 60;
            this.BtnBack.TabStop = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(81, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 25);
            this.lblTitulo.TabIndex = 59;
            this.lblTitulo.Text = "Agregar Personal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(1, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(550, 491);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 43);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(658, 491);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 43);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "REFERENCIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(393, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "CUIT";
            // 
            // op
            // 
            this.op.Title = "Seleccione un Archivo";
            // 
            // txtCuit
            // 
            this.txtCuit.AutoSize = true;
            this.txtCuit.Location = new System.Drawing.Point(396, 256);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Numerico = true;
            this.txtCuit.Size = new System.Drawing.Size(365, 42);
            this.txtCuit.TabIndex = 3;
            this.txtCuit.Value = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 115);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Numerico = false;
            this.txtCodigo.Size = new System.Drawing.Size(365, 42);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Value = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(14, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "DOMICILIO";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AutoSize = true;
            this.txtDomicilio.Location = new System.Drawing.Point(12, 256);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Numerico = false;
            this.txtDomicilio.Size = new System.Drawing.Size(365, 42);
            this.txtDomicilio.TabIndex = 2;
            this.txtDomicilio.Value = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(11, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.AutoSize = true;
            this.txtApellido.Location = new System.Drawing.Point(12, 181);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Numerico = false;
            this.txtApellido.Size = new System.Drawing.Size(365, 42);
            this.txtApellido.TabIndex = 0;
            this.txtApellido.Value = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(393, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(396, 181);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Numerico = false;
            this.txtNombre.Size = new System.Drawing.Size(365, 42);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Value = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(393, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 53;
            this.label8.Text = "TELEFONO ALTERNATIVO";
            // 
            // txtTelefono_2
            // 
            this.txtTelefono_2.AutoSize = true;
            this.txtTelefono_2.Location = new System.Drawing.Point(396, 340);
            this.txtTelefono_2.Name = "txtTelefono_2";
            this.txtTelefono_2.Numerico = false;
            this.txtTelefono_2.Size = new System.Drawing.Size(365, 42);
            this.txtTelefono_2.TabIndex = 5;
            this.txtTelefono_2.Value = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(11, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 51;
            this.label9.Text = "TELEFONO ";
            // 
            // txtTelefono_1
            // 
            this.txtTelefono_1.AutoSize = true;
            this.txtTelefono_1.Location = new System.Drawing.Point(12, 340);
            this.txtTelefono_1.Name = "txtTelefono_1";
            this.txtTelefono_1.Numerico = false;
            this.txtTelefono_1.Size = new System.Drawing.Size(365, 42);
            this.txtTelefono_1.TabIndex = 4;
            this.txtTelefono_1.Value = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(11, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(12, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Numerico = false;
            this.txtEmail.Size = new System.Drawing.Size(365, 42);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Value = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(74, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = "●";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(14, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 17);
            this.label12.TabIndex = 58;
            this.label12.Text = "● DATOS OBLIGATORIOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label1.Location = new System.Drawing.Point(461, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "●";
            // 
            // frmAbmPersonal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefono_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAbmPersonal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbmPersonal_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private Controles.TextBoxAdv txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Controles.TextBoxAdv txtCuit;
        private System.Windows.Forms.OpenFileDialog op;
        private System.Windows.Forms.Label label5;
        private Controles.TextBoxAdv txtDomicilio;
        private System.Windows.Forms.Label label6;
        private Controles.TextBoxAdv txtApellido;
        private System.Windows.Forms.Label label7;
        private Controles.TextBoxAdv txtNombre;
        private System.Windows.Forms.Label label8;
        private Controles.TextBoxAdv txtTelefono_2;
        private System.Windows.Forms.Label label9;
        private Controles.TextBoxAdv txtTelefono_1;
        private System.Windows.Forms.Label label10;
        private Controles.TextBoxAdv txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnBack;
    }
}