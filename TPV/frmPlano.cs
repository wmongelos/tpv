using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmPlano : Form
    {
        private DataTable dtPlano;
        private Plano oPlano = new Plano();

        private static frmPlano oForm = null;

        public static frmPlano Instance()
        {
            if (oForm == null)
                oForm = new frmPlano();

            return oForm;
        }

        private frmPlano()
        {
            InitializeComponent();

            lblUserLogin.Text = GlobalVar.CurrentUser_Name.ToUpper();
        }

        private void LoadData()
        {
            this.SuspendLayout();
            this.pnContenedor.Controls.Clear();

            dtPlano = oPlano.getPlano();

            if (dtPlano.Rows.Count > 0)
            {
                foreach (DataRow dr in dtPlano.Rows)
                {
                    switch (dr["tipo"].ToString())
                    {
                        case "mesa_1":
                            Mesa_1 oMesa = new Mesa_1();
                            oMesa.Move_Object = false;
                            oMesa.Tag = dr["plano_id"].ToString();
                            oMesa.Caption = dr["nombre"].ToString();
                            oMesa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oMesa.Click += new EventHandler(Buscador);
                            oMesa.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oMesa);
                            oMesa.Top = Convert.ToInt32(dr["top"]);
                            oMesa.Left = Convert.ToInt32(dr["_left"]);
                           
                            break;
                        case "mesa_2":
                            Mesa_2 oMesa2 = new Mesa_2();
                            oMesa2.Move_Object = false;
                            oMesa2.Tag = dr["plano_id"].ToString();
                            oMesa2.Caption = dr["nombre"].ToString();
                            oMesa2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oMesa2.Click += new EventHandler(Buscador);
                            oMesa2.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oMesa2);
                            oMesa2.Top = Convert.ToInt32(dr["top"]);
                            oMesa2.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_3":
                            Mesa_3 oMesa3 = new Mesa_3();
                            oMesa3.Move_Object = false;
                            oMesa3.Tag = dr["plano_id"].ToString();
                            oMesa3.Caption = dr["nombre"].ToString();
                            oMesa3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oMesa3.Click += new EventHandler(Buscador);
                            oMesa3.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oMesa3);
                            oMesa3.Top = Convert.ToInt32(dr["top"]);
                            oMesa3.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_4":
                            Mesa_4 oMesa4 = new Mesa_4();
                            oMesa4.Move_Object = false;
                            oMesa4.Tag = dr["plano_id"].ToString();
                            oMesa4.Caption = dr["nombre"].ToString();
                            oMesa4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oMesa4.Click += new EventHandler(Buscador);
                            oMesa4.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oMesa4);
                            oMesa4.Top = Convert.ToInt32(dr["top"]);
                            oMesa4.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_5":
                            Mesa_5 oMesa5 = new Mesa_5();
                            oMesa5.Move_Object = false;
                            oMesa5.Tag = dr["plano_id"].ToString();
                            oMesa5.Caption = dr["nombre"].ToString();
                            oMesa5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oMesa5.Click += new EventHandler(Buscador);
                            oMesa5.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oMesa5);
                            oMesa5.Top = Convert.ToInt32(dr["top"]);
                            oMesa5.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "silla_1":
                            Silla_1 oSilla_1 = new Silla_1();
                            oSilla_1.Move_Object = false;
                            oSilla_1.Tag = dr["plano_id"].ToString();
                            oSilla_1.Caption = dr["nombre"].ToString();
                            oSilla_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oSilla_1.Click += new EventHandler(Buscador);
                            oSilla_1.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oSilla_1);
                            oSilla_1.Top = Convert.ToInt32(dr["top"]);
                            oSilla_1.Left = Convert.ToInt32(dr["_left"]);

                            if (Convert.ToInt32(dr["rotacion"]) == 2)
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;

                            if (Convert.ToInt32(dr["rotacion"]) == 3)
                            {
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            if (Convert.ToInt32(dr["rotacion"]) == 4)
                            {
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }
                            break;
                        case "silla_2":
                            Silla_2 oSilla_2 = new Silla_2();
                            oSilla_2.Move_Object = false;
                            oSilla_2.Tag = dr["plano_id"].ToString();
                            oSilla_2.Caption = dr["nombre"].ToString();
                            oSilla_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oSilla_2.Click += new EventHandler(Buscador);
                            oSilla_2.setEstado = Convert.ToInt32(dr["plano_estado_id"]);
                            this.pnContenedor.Controls.Add(oSilla_2);
                            oSilla_2.Top = Convert.ToInt32(dr["top"]);
                            oSilla_2.Left = Convert.ToInt32(dr["_left"]);

                            if (Convert.ToInt32(dr["rotacion"]) == 2)
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;

                            if (Convert.ToInt32(dr["rotacion"]) == 3)
                            {
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            if (Convert.ToInt32(dr["rotacion"]) == 4)
                            {
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }
                            break;
                        case "mesa_panel":
                            Mesa_Panel oPanel = new Mesa_Panel();
                            oPanel.Move_Object = false;
                            oPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oPanel.Width = Convert.ToInt32(dr["width"]);
                            oPanel.Height = Convert.ToInt32(dr["height"]);
                            this.pnContenedor.Controls.Add(oPanel);
                            oPanel.Top = Convert.ToInt32(dr["top"]);
                            oPanel.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        default:
                            break;
                    }
                }
            }

            this.ResumeLayout();
        }

        private void Buscador(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                string caption = "";
                int id = 0;
                int estado = 0;
                

                if(sender is Mesa_1)
                {
                   Mesa_1 oMes = (Mesa_1)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                        }

                if (sender is Mesa_2)
                {
                    Mesa_2 oMes = (Mesa_2)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }


                if (sender is Mesa_3)
                {
                    Mesa_3 oMes = (Mesa_3)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }


                if (sender is Mesa_4)
                {
                    Mesa_4 oMes = (Mesa_4)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }


                if (sender is Mesa_5)
                {
                    Mesa_5 oMes = (Mesa_5)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }

                if (sender is Silla_1)
                {
                    Silla_1 oMes = (Silla_1)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }

                if (sender is Silla_2)
                {
                    Silla_2 oMes = (Silla_2)sender;
                    caption = oMes.Caption;
                    id = Convert.ToInt32(oMes.Tag);
                    estado = oMes.setEstado;
                }

                if (estado == 1)
                {
                    frmBuscador frmBus = new frmBuscador();
                    frmBus.Tabla = "Personal";
                    frm.oForm = frmBus;

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        

                        using (frmModal frmModCub = new frmModal())
                        {
                            frmCubiertos frmCub = new frmCubiertos();
                            frmModCub.oForm = frmCub;

                            if (frmModCub.ShowDialog() == DialogResult.OK)
                            {
                                using (frmModal frmMod = new frmModal())
                                {
                                    frmTicket frmTick = new frmTicket();
                                    frmMod.oForm = frmTick;
                                    frmTick.Personal_Id = frmBus.Id;
                                    frmTick.Mesa_Id = id;
                                    frmTick.Mesa = caption;
                                    frmTick.Cubiertos = frmCub.Cantidad;

                                    if (frmMod.ShowDialog() == DialogResult.OK)
                                        LoadData();
                                }
                            }
                        }
                            
                    }
                }
                else
                {
                    if (estado == 2)
                    {
                        using (frmModal frmMod = new frmModal())
                        {
                            frmTicket frmTick = new frmTicket();
                            frmMod.oForm = frmTick;
                            frmTick.Mesa_Id = id;
                            frmTick.Mesa = caption;

                            if (frmMod.ShowDialog() == DialogResult.OK)
                                LoadData();
                        }
                    }
                    else {
                        using (frmModal frmMod = new frmModal())
                        {
                            frmTicketFPago frmFPago = new frmTicketFPago();
                            frmMod.oForm = frmFPago;
                            frmFPago.Mesa_Id = id;

                            if (frmMod.ShowDialog() == DialogResult.OK)
                                LoadData();
                        }
                    }
                }
            }
        }

        private void frmPlano_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 30;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 30;

            this.LoadData();
        }

        private void oReloj_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = String.Format("{0} {1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
        }

        private void frmPlano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                oForm = null; 
                this.Close();
            }

            if (e.KeyCode == Keys.F10)
            {
                using (frmModal frmMod = new frmModal())
                {
                    frmTicket frmTick = new frmTicket();
                    frmMod.oForm = frmTick;
                    frmTick.Mesa_Id = 0;
                    frmTick.Mesa = "BARRA";

                    if (frmMod.ShowDialog() == DialogResult.OK)
                        LoadData();
                }
            }
        }

        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            oForm = null;
            this.Close();
        }
    }
}
