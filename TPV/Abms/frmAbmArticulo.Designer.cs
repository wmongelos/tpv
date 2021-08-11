namespace TPV.Abms
{
    partial class frmAbmArticulo
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboImpresoras = new TPV.Controles.ComboBoxAdv();
            this.cboSalida = new TPV.Controles.ComboBoxAdv();
            this.spStock_Minimo = new TPV.Controles.Spinner();
            this.spStock = new TPV.Controles.Spinner();
            this.spImporteVenta = new TPV.Controles.Spinner();
            this.spMargen = new TPV.Controles.Spinner();
            this.spIva = new TPV.Controles.Spinner();
            this.spImporteCosto = new TPV.Controles.Spinner();
            this.txtBarCode = new TPV.Controles.TextBoxAdv();
            this.cboRubros = new TPV.Controles.ComboBoxAdv();
            this.txtDescripcion = new TPV.Controles.TextBoxAdv();
            this.txtCodigo = new TPV.Controles.TextBoxAdv();
            this.img = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(760, 74);
            this.panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(72, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(244, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar producto a la carta";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(23, 574);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 1);
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
            this.btnAgregar.Location = new System.Drawing.Point(532, 582);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 43);
            this.btnAgregar.TabIndex = 12;
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
            this.btnCancelar.Location = new System.Drawing.Point(640, 582);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 43);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(760, 641);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(247)))));
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rectangleShape1.CornerRadius = 3;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(391, 116);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(355, 303);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(25, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "REFERENCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "DESCRIPCIÓN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(25, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "RUBRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(25, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "CODIGO DE BARRAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(25, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "IMPORTE DE COSTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(214, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "IVA (%)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(25, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "MARGEN (%)";
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(621, 364);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(102, 43);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.TabStop = false;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(214, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "IMPORTE DE VENTA";
            // 
            // op
            // 
            this.op.Title = "Seleccione un Archivo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(25, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "STOCK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(214, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "STOCK MINIMO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label11.Location = new System.Drawing.Point(101, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "●";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label12.Location = new System.Drawing.Point(96, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "●";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label13.Location = new System.Drawing.Point(21, 582);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "● DATOS OBLIGATORIOS";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(385, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 61;
            this.label14.Text = "IMPRESORA";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(385, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "IMPRESION DE COMANDA";
            // 
            // cboImpresoras
            // 
            this.cboImpresoras.DataSource = null;
            this.cboImpresoras.Display = "";
            this.cboImpresoras.Enabled = false;
            this.cboImpresoras.Location = new System.Drawing.Point(388, 525);
            this.cboImpresoras.Name = "cboImpresoras";
            this.cboImpresoras.SelectedValue = "";
            this.cboImpresoras.Size = new System.Drawing.Size(360, 40);
            this.cboImpresoras.TabIndex = 11;
            this.cboImpresoras.Value = "";
            // 
            // cboSalida
            // 
            this.cboSalida.DataSource = null;
            this.cboSalida.Display = "";
            this.cboSalida.Location = new System.Drawing.Point(388, 454);
            this.cboSalida.Name = "cboSalida";
            this.cboSalida.SelectedValue = "";
            this.cboSalida.Size = new System.Drawing.Size(360, 40);
            this.cboSalida.TabIndex = 10;
            this.cboSalida.Value = "";
            // 
            // spStock_Minimo
            // 
            this.spStock_Minimo.DecimalPlaces = 0;
            this.spStock_Minimo.Location = new System.Drawing.Point(213, 525);
            this.spStock_Minimo.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spStock_Minimo.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spStock_Minimo.Name = "spStock_Minimo";
            this.spStock_Minimo.Size = new System.Drawing.Size(170, 40);
            this.spStock_Minimo.TabIndex = 9;
            this.spStock_Minimo.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // spStock
            // 
            this.spStock.DecimalPlaces = 0;
            this.spStock.Location = new System.Drawing.Point(23, 525);
            this.spStock.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spStock.Minimum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            -2147483648});
            this.spStock.Name = "spStock";
            this.spStock.Size = new System.Drawing.Size(170, 40);
            this.spStock.TabIndex = 8;
            this.spStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // spImporteVenta
            // 
            this.spImporteVenta.DecimalPlaces = 2;
            this.spImporteVenta.Location = new System.Drawing.Point(214, 454);
            this.spImporteVenta.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.spImporteVenta.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spImporteVenta.Name = "spImporteVenta";
            this.spImporteVenta.Size = new System.Drawing.Size(170, 40);
            this.spImporteVenta.TabIndex = 7;
            this.spImporteVenta.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spImporteVenta.Leave += new System.EventHandler(this.spImporteVenta_Leave);
            // 
            // spMargen
            // 
            this.spMargen.DecimalPlaces = 2;
            this.spMargen.Location = new System.Drawing.Point(23, 454);
            this.spMargen.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spMargen.Minimum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            -2147483648});
            this.spMargen.Name = "spMargen";
            this.spMargen.Size = new System.Drawing.Size(170, 40);
            this.spMargen.TabIndex = 6;
            this.spMargen.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spMargen.Leave += new System.EventHandler(this.spMargen_Leave);
            // 
            // spIva
            // 
            this.spIva.DecimalPlaces = 2;
            this.spIva.Location = new System.Drawing.Point(214, 384);
            this.spIva.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spIva.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spIva.Name = "spIva";
            this.spIva.Size = new System.Drawing.Size(170, 40);
            this.spIva.TabIndex = 5;
            this.spIva.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spIva.Leave += new System.EventHandler(this.spIva_Leave);
            // 
            // spImporteCosto
            // 
            this.spImporteCosto.DecimalPlaces = 2;
            this.spImporteCosto.Location = new System.Drawing.Point(23, 384);
            this.spImporteCosto.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.spImporteCosto.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spImporteCosto.Name = "spImporteCosto";
            this.spImporteCosto.Size = new System.Drawing.Size(170, 40);
            this.spImporteCosto.TabIndex = 4;
            this.spImporteCosto.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // txtBarCode
            // 
            this.txtBarCode.AutoSize = true;
            this.txtBarCode.Location = new System.Drawing.Point(24, 315);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Numerico = false;
            this.txtBarCode.Size = new System.Drawing.Size(360, 40);
            this.txtBarCode.TabIndex = 3;
            this.txtBarCode.Value = "";
            // 
            // cboRubros
            // 
            this.cboRubros.DataSource = null;
            this.cboRubros.Display = "";
            this.cboRubros.Location = new System.Drawing.Point(24, 250);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.SelectedValue = "";
            this.cboRubros.Size = new System.Drawing.Size(360, 40);
            this.cboRubros.TabIndex = 2;
            this.cboRubros.Value = "";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(23, 184);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Numerico = false;
            this.txtDescripcion.Size = new System.Drawing.Size(360, 40);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Value = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(23, 116);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Numerico = false;
            this.txtCodigo.Size = new System.Drawing.Size(360, 40);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Value = "";
            // 
            // img
            // 
            this.img.BackColor = System.Drawing.Color.WhiteSmoke;
            this.img.Location = new System.Drawing.Point(432, 128);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(272, 227);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 26;
            this.img.TabStop = false;
            // 
            // BtnBack
            // 
            this.BtnBack.Image = global::TPV.Properties.Resources.icons8_back_to_48;
            this.BtnBack.Location = new System.Drawing.Point(23, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(48, 48);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnBack.TabIndex = 64;
            this.BtnBack.TabStop = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmAbmArticulo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(760, 641);
            this.Controls.Add(this.cboImpresoras);
            this.Controls.Add(this.cboSalida);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.spStock_Minimo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.spImporteVenta);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spMargen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.spIva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spImporteCosto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboRubros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.img);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmAbmArticulo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAbmArticulo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAbmArticulo_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.PictureBox img;
        private Controles.TextBoxAdv txtCodigo;
        private Controles.TextBoxAdv txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.ComboBoxAdv cboRubros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controles.TextBoxAdv txtBarCode;
        private Controles.Spinner spImporteCosto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Controles.Spinner spIva;
        private System.Windows.Forms.Label label7;
        private Controles.Spinner spMargen;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label label8;
        private Controles.Spinner spImporteVenta;
        private System.Windows.Forms.OpenFileDialog op;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label9;
        private Controles.Spinner spStock;
        private System.Windows.Forms.Label label10;
        private Controles.Spinner spStock_Minimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Controles.ComboBoxAdv cboSalida;
        private Controles.ComboBoxAdv cboImpresoras;
        private System.Windows.Forms.PictureBox BtnBack;
    }
}