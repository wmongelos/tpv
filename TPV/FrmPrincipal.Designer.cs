
namespace TPV
{
    partial class FrmPrincipal
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
            this.PnHeader = new System.Windows.Forms.Panel();
            this.PnMinimize = new System.Windows.Forms.Panel();
            this.PbMinimize = new System.Windows.Forms.Label();
            this.PnClose = new System.Windows.Forms.Panel();
            this.PbClose = new System.Windows.Forms.PictureBox();
            this.PnNavBar = new System.Windows.Forms.Panel();
            this.PnLineMenu = new System.Windows.Forms.Panel();
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listaDePreciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.diseñoDeSalónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.usuariosDeSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tipoDeMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egresosDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaDiariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.stockCriticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnFooter = new System.Windows.Forms.Panel();
            this.PnContent = new System.Windows.Forms.Panel();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.historialDeCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnHeader.SuspendLayout();
            this.PnMinimize.SuspendLayout();
            this.PnClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).BeginInit();
            this.PnNavBar.SuspendLayout();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnHeader
            // 
            this.PnHeader.BackColor = System.Drawing.Color.SlateGray;
            this.PnHeader.Controls.Add(this.PnMinimize);
            this.PnHeader.Controls.Add(this.PnClose);
            this.PnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnHeader.Location = new System.Drawing.Point(0, 0);
            this.PnHeader.Name = "PnHeader";
            this.PnHeader.Size = new System.Drawing.Size(800, 50);
            this.PnHeader.TabIndex = 0;
            // 
            // PnMinimize
            // 
            this.PnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnMinimize.BackColor = System.Drawing.Color.SlateGray;
            this.PnMinimize.Controls.Add(this.PbMinimize);
            this.PnMinimize.Location = new System.Drawing.Point(700, 1);
            this.PnMinimize.Name = "PnMinimize";
            this.PnMinimize.Size = new System.Drawing.Size(45, 29);
            this.PnMinimize.TabIndex = 6;
            this.PnMinimize.Click += new System.EventHandler(this.PnMinimize_Click);
            this.PnMinimize.MouseEnter += new System.EventHandler(this.PnMinimize_MouseEnter);
            this.PnMinimize.MouseLeave += new System.EventHandler(this.PnMinimize_MouseLeave);
            // 
            // PbMinimize
            // 
            this.PbMinimize.AutoSize = true;
            this.PbMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbMinimize.ForeColor = System.Drawing.Color.White;
            this.PbMinimize.Location = new System.Drawing.Point(14, 9);
            this.PbMinimize.Name = "PbMinimize";
            this.PbMinimize.Size = new System.Drawing.Size(19, 13);
            this.PbMinimize.TabIndex = 0;
            this.PbMinimize.Text = "__";
            this.PbMinimize.Click += new System.EventHandler(this.PnMinimize_Click);
            this.PbMinimize.MouseEnter += new System.EventHandler(this.PnMinimize_MouseEnter);
            this.PbMinimize.MouseLeave += new System.EventHandler(this.PnMinimize_MouseLeave);
            // 
            // PnClose
            // 
            this.PnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnClose.Controls.Add(this.PbClose);
            this.PnClose.Location = new System.Drawing.Point(745, 1);
            this.PnClose.Name = "PnClose";
            this.PnClose.Size = new System.Drawing.Size(45, 29);
            this.PnClose.TabIndex = 5;
            this.PnClose.Click += new System.EventHandler(this.PnClose_Click);
            this.PnClose.MouseEnter += new System.EventHandler(this.PnClose_MouseEnter);
            this.PnClose.MouseLeave += new System.EventHandler(this.PnClose_MouseLeave);
            // 
            // PbClose
            // 
            this.PbClose.Image = global::TPV.Properties.Resources.icons8_multiply_32;
            this.PbClose.Location = new System.Drawing.Point(10, 3);
            this.PbClose.Name = "PbClose";
            this.PbClose.Size = new System.Drawing.Size(24, 24);
            this.PbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbClose.TabIndex = 0;
            this.PbClose.TabStop = false;
            this.PbClose.Click += new System.EventHandler(this.PnClose_Click);
            this.PbClose.MouseEnter += new System.EventHandler(this.PnClose_MouseEnter);
            this.PbClose.MouseLeave += new System.EventHandler(this.PnClose_MouseLeave);
            // 
            // PnNavBar
            // 
            this.PnNavBar.Controls.Add(this.PnLineMenu);
            this.PnNavBar.Controls.Add(this.MnuPrincipal);
            this.PnNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnNavBar.Location = new System.Drawing.Point(0, 50);
            this.PnNavBar.Name = "PnNavBar";
            this.PnNavBar.Size = new System.Drawing.Size(800, 28);
            this.PnNavBar.TabIndex = 1;
            // 
            // PnLineMenu
            // 
            this.PnLineMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.PnLineMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnLineMenu.Location = new System.Drawing.Point(0, 27);
            this.PnLineMenu.Name = "PnLineMenu";
            this.PnLineMenu.Size = new System.Drawing.Size(800, 1);
            this.PnLineMenu.TabIndex = 1;
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salonToolStripMenuItem,
            this.contabilidadToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.configuracionToolStripMenuItem});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(800, 29);
            this.MnuPrincipal.TabIndex = 0;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartaToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.toolStripSeparator1,
            this.diseñoDeSalónToolStripMenuItem,
            this.toolStripSeparator2,
            this.seguridadToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rubrosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.toolStripSeparator4,
            this.listaDePreciosToolStripMenuItem});
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.cartaToolStripMenuItem.Text = "Carta de Productos";
            // 
            // rubrosToolStripMenuItem
            // 
            this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
            this.rubrosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.rubrosToolStripMenuItem.Text = "Rubros";
            this.rubrosToolStripMenuItem.Click += new System.EventHandler(this.rubrosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // listaDePreciosToolStripMenuItem
            // 
            this.listaDePreciosToolStripMenuItem.Name = "listaDePreciosToolStripMenuItem";
            this.listaDePreciosToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.listaDePreciosToolStripMenuItem.Text = "Lista de Precios";
            this.listaDePreciosToolStripMenuItem.Click += new System.EventHandler(this.listaDePreciosToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // diseñoDeSalónToolStripMenuItem
            // 
            this.diseñoDeSalónToolStripMenuItem.Name = "diseñoDeSalónToolStripMenuItem";
            this.diseñoDeSalónToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.diseñoDeSalónToolStripMenuItem.Text = "Diseño de Salón";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesDeUsuariosToolStripMenuItem,
            this.toolStripSeparator3,
            this.usuariosDeSistemaToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // rolesDeUsuariosToolStripMenuItem
            // 
            this.rolesDeUsuariosToolStripMenuItem.Name = "rolesDeUsuariosToolStripMenuItem";
            this.rolesDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.rolesDeUsuariosToolStripMenuItem.Text = "Roles de Usuarios";
            this.rolesDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.rolesDeUsuariosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // usuariosDeSistemaToolStripMenuItem
            // 
            this.usuariosDeSistemaToolStripMenuItem.Name = "usuariosDeSistemaToolStripMenuItem";
            this.usuariosDeSistemaToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.usuariosDeSistemaToolStripMenuItem.Text = "Usuarios de Sistema";
            this.usuariosDeSistemaToolStripMenuItem.Click += new System.EventHandler(this.usuariosDeSistemaToolStripMenuItem_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(61, 25);
            this.salonToolStripMenuItem.Text = "Salón";
            this.salonToolStripMenuItem.Click += new System.EventHandler(this.salonToolStripMenuItem_Click);
            // 
            // contabilidadToolStripMenuItem
            // 
            this.contabilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreFiscalToolStripMenuItem,
            this.toolStripSeparator8,
            this.tipoDeMovimientosToolStripMenuItem,
            this.cajaDiariaToolStripMenuItem,
            this.toolStripSeparator9,
            this.historialDeCajasToolStripMenuItem});
            this.contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            this.contabilidadToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // cierreFiscalToolStripMenuItem
            // 
            this.cierreFiscalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cierreXToolStripMenuItem,
            this.cierreZToolStripMenuItem});
            this.cierreFiscalToolStripMenuItem.Name = "cierreFiscalToolStripMenuItem";
            this.cierreFiscalToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cierreFiscalToolStripMenuItem.Text = "Cierre Fiscal";
            // 
            // cierreXToolStripMenuItem
            // 
            this.cierreXToolStripMenuItem.Name = "cierreXToolStripMenuItem";
            this.cierreXToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.cierreXToolStripMenuItem.Text = "Cierre X";
            this.cierreXToolStripMenuItem.Click += new System.EventHandler(this.cierreXToolStripMenuItem_Click);
            // 
            // cierreZToolStripMenuItem
            // 
            this.cierreZToolStripMenuItem.Name = "cierreZToolStripMenuItem";
            this.cierreZToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.cierreZToolStripMenuItem.Text = "Cierre Z";
            this.cierreZToolStripMenuItem.Click += new System.EventHandler(this.cierreZToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(223, 6);
            // 
            // tipoDeMovimientosToolStripMenuItem
            // 
            this.tipoDeMovimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosDeCajaToolStripMenuItem,
            this.egresosDeCajaToolStripMenuItem});
            this.tipoDeMovimientosToolStripMenuItem.Name = "tipoDeMovimientosToolStripMenuItem";
            this.tipoDeMovimientosToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.tipoDeMovimientosToolStripMenuItem.Text = "Tipo de Movimientos";
            // 
            // ingresosDeCajaToolStripMenuItem
            // 
            this.ingresosDeCajaToolStripMenuItem.Name = "ingresosDeCajaToolStripMenuItem";
            this.ingresosDeCajaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.ingresosDeCajaToolStripMenuItem.Text = "Ingresos de Caja";
            this.ingresosDeCajaToolStripMenuItem.Click += new System.EventHandler(this.ingresosDeCajaToolStripMenuItem_Click);
            // 
            // egresosDeCajaToolStripMenuItem
            // 
            this.egresosDeCajaToolStripMenuItem.Name = "egresosDeCajaToolStripMenuItem";
            this.egresosDeCajaToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.egresosDeCajaToolStripMenuItem.Text = "Egresos de Caja";
            this.egresosDeCajaToolStripMenuItem.Click += new System.EventHandler(this.egresosDeCajaToolStripMenuItem_Click);
            // 
            // cajaDiariaToolStripMenuItem
            // 
            this.cajaDiariaToolStripMenuItem.Name = "cajaDiariaToolStripMenuItem";
            this.cajaDiariaToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.cajaDiariaToolStripMenuItem.Text = "Caja Diaria";
            this.cajaDiariaToolStripMenuItem.Click += new System.EventHandler(this.cajaDiariaToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.toolStripSeparator5,
            this.facturaToolStripMenuItem,
            this.toolStripSeparator6,
            this.stockCriticoToolStripMenuItem,
            this.toolStripSeparator7});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(164, 6);
            // 
            // stockCriticoToolStripMenuItem
            // 
            this.stockCriticoToolStripMenuItem.Name = "stockCriticoToolStripMenuItem";
            this.stockCriticoToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.stockCriticoToolStripMenuItem.Text = "Stock Critico";
            this.stockCriticoToolStripMenuItem.Click += new System.EventHandler(this.stockCriticoToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(164, 6);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(120, 25);
            this.configuracionToolStripMenuItem.Text = "Configuración";
            // 
            // PnFooter
            // 
            this.PnFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnFooter.Location = new System.Drawing.Point(0, 420);
            this.PnFooter.Name = "PnFooter";
            this.PnFooter.Size = new System.Drawing.Size(800, 30);
            this.PnFooter.TabIndex = 2;
            // 
            // PnContent
            // 
            this.PnContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnContent.Location = new System.Drawing.Point(0, 78);
            this.PnContent.Name = "PnContent";
            this.PnContent.Size = new System.Drawing.Size(800, 342);
            this.PnContent.TabIndex = 3;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(223, 6);
            // 
            // historialDeCajasToolStripMenuItem
            // 
            this.historialDeCajasToolStripMenuItem.Name = "historialDeCajasToolStripMenuItem";
            this.historialDeCajasToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.historialDeCajasToolStripMenuItem.Text = "Historial de Cajas";
            this.historialDeCajasToolStripMenuItem.Click += new System.EventHandler(this.historialDeCajasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnContent);
            this.Controls.Add(this.PnFooter);
            this.Controls.Add(this.PnNavBar);
            this.Controls.Add(this.PnHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MnuPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "SBCode | Gestión";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PnHeader.ResumeLayout(false);
            this.PnMinimize.ResumeLayout(false);
            this.PnMinimize.PerformLayout();
            this.PnClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbClose)).EndInit();
            this.PnNavBar.ResumeLayout(false);
            this.PnNavBar.PerformLayout();
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnHeader;
        private System.Windows.Forms.Panel PnMinimize;
        private System.Windows.Forms.Label PbMinimize;
        private System.Windows.Forms.Panel PnClose;
        private System.Windows.Forms.PictureBox PbClose;
        private System.Windows.Forms.Panel PnNavBar;
        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.Panel PnLineMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem diseñoDeSalónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem usuariosDeSistemaToolStripMenuItem;
        private System.Windows.Forms.Panel PnFooter;
        private System.Windows.Forms.Panel PnContent;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rubrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listaDePreciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem stockCriticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreZToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem tipoDeMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egresosDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaDiariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem historialDeCajasToolStripMenuItem;
    }
}