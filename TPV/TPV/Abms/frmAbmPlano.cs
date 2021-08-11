using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmAbmPlano : Form
    {
        private DataTable dtPlano;
        private Plano oPlano = new Plano();

        public frmAbmPlano()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dtPlano = oPlano.getPlano();

            if (dtPlano.Rows.Count > 0)
            {
                foreach (DataRow dr in dtPlano.Rows)
                {
                    switch (dr["tipo"].ToString())
                    {
                        case "mesa_1":
                            Mesa_1 oMesa = new Mesa_1();
                            oMesa.Move_Object = true;
                            oMesa.Caption = dr["nombre"].ToString();
                            oMesa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa);
                            oMesa.Top = Convert.ToInt32(dr["top"]);
                            oMesa.Left = Convert.ToInt32(dr["_left"]);
                            oMesa.Width = 89;
                            oMesa.Height = 55;
                            break;
                        case "mesa_2":
                            Mesa_2 oMesa2 = new Mesa_2();
                            oMesa2.Move_Object = true;
                            oMesa2.Caption = dr["nombre"].ToString();
                            oMesa2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa2);
                            oMesa2.Top = Convert.ToInt32(dr["top"]);
                            oMesa2.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_3":
                            Mesa_3 oMesa3 = new Mesa_3();
                            oMesa3.Move_Object = true;
                            oMesa3.Caption = dr["nombre"].ToString();
                            oMesa3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa3);
                            oMesa3.Top = Convert.ToInt32(dr["top"]);
                            oMesa3.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_4":
                            Mesa_4 oMesa4 = new Mesa_4();
                            oMesa4.Move_Object = true;
                            oMesa4.Caption = dr["nombre"].ToString();
                            oMesa4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa4);
                            oMesa4.Top = Convert.ToInt32(dr["top"]);
                            oMesa4.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "mesa_5":
                            Mesa_5 oMesa5 = new Mesa_5();
                            oMesa5.Move_Object = true;
                            oMesa5.Caption = dr["nombre"].ToString();
                            oMesa5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa5);
                            oMesa5.Top = Convert.ToInt32(dr["top"]);
                            oMesa5.Left = Convert.ToInt32(dr["_left"]);
                            break;
                        case "silla_1":
                            Silla_1 oSilla_1 = new Silla_1();
                            oSilla_1.Move_Object = true;
                            oSilla_1.Caption = dr["nombre"].ToString();
                            oSilla_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
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
                            oSilla_2.Move_Object = true;
                            oSilla_2.Caption = dr["nombre"].ToString();
                            oSilla_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
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
                            oPanel.Move_Object = true;
                            oPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oPanel.Width = Convert.ToInt32(dr["width"]);
                            oPanel.Height = Convert.ToInt32(dr["height"]);
                            this.pnContenedor.Controls.Add(oPanel);
                            oPanel.Top = Convert.ToInt32(dr["top"]);
                            oPanel.Left = Convert.ToInt32(dr["_left"]);
                            oPanel.BringToFront();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void frmAbmPlano_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 30;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 30;

            this.LoadData();
        }

        private void iconAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmPlano_Objetos frmObj = new frmAbmPlano_Objetos();
                frm.oForm = frmObj;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    switch (frmObj.Tipo)
                    {
                        case "Mesa_1":
                            Mesa_1 oMesa = new Mesa_1();
                            oMesa.Move_Object = true;
                            oMesa.Caption = frmObj.Nombre;
                            oMesa.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa);
                            break;
                        case "Mesa_2":
                            Mesa_2 oMesa2 = new Mesa_2();
                            oMesa2.Move_Object = true;
                            oMesa2.Caption = frmObj.Nombre;
                            oMesa2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa2);
                            break;
                        case "Mesa_3":
                            Mesa_3 oMesa3 = new Mesa_3();
                            oMesa3.Move_Object = true;
                            oMesa3.Caption = frmObj.Nombre;
                            oMesa3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa3);
                            break;
                        case "Mesa_4":
                            Mesa_4 oMesa4 = new Mesa_4();
                            oMesa4.Move_Object = true;
                            oMesa4.Caption = frmObj.Nombre;
                            oMesa4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa4);
                            break;
                        case "Mesa_5":
                            Mesa_5 oMesa5 = new Mesa_5();
                            oMesa5.Move_Object = true;
                            oMesa5.Caption = frmObj.Nombre;
                            oMesa5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oMesa5);
                            break;
                        case "Silla_1":
                            Silla_1 oSilla_1 = new Silla_1();
                            oSilla_1.Move_Object = true;
                            oSilla_1.Caption = frmObj.Nombre;
                            oSilla_1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oSilla_1.NroRotacion = frmObj.Rotacion - 1;
                            if (frmObj.Rotacion == 2)
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;

                            if (frmObj.Rotacion == 3)
                            {
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            if (frmObj.Rotacion == 4)
                            {
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_1.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            this.pnContenedor.Controls.Add(oSilla_1);
                            break;
                        case "Silla_2":
                            Silla_2 oSilla_2 = new Silla_2();
                            oSilla_2.Move_Object = true;
                            oSilla_2.Caption = frmObj.Nombre;
                            oSilla_2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            oSilla_2.NroRotacion = frmObj.Rotacion - 1;
                            if (frmObj.Rotacion == 2)
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;

                            if (frmObj.Rotacion == 3)
                            {
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            if (frmObj.Rotacion == 4)
                            {
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                                oSilla_2.Rotacion = RotateFlipType.Rotate90FlipNone;
                            }

                            this.pnContenedor.Controls.Add(oSilla_2);
                            break;
                        case "Panel":
                            Mesa_Panel oPanel = new Mesa_Panel();
                            oPanel.Move_Object = true;
                            oPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                            this.pnContenedor.Controls.Add(oPanel);
                            oPanel.BringToFront();
                            break;
                    }
                }
            }
        }

        private void iconGuardar_Click(object sender, EventArgs e)
        {

            if (frmMsgBox.Show("¿Desea Confirmar los cambios en el Diseño del Plano?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                dtPlano.Rows.Clear();
                dtPlano.AcceptChanges();

                foreach (Control cs in this.pnContenedor.Controls)
                {
                    if (cs is Mesa_1)
                    {
                        Mesa_1 o = (Mesa_1)cs;

                        dtPlano.Rows.Add(0, "mesa_1", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                    if (cs is Mesa_2)
                    {
                        Mesa_2 o = (Mesa_2)cs;

                        dtPlano.Rows.Add(0, "mesa_2", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                    if (cs is Mesa_3)
                    {
                        Mesa_3 o = (Mesa_3)cs;

                        dtPlano.Rows.Add(0, "mesa_3", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                    if (cs is Mesa_4)
                    {
                        Mesa_4 o = (Mesa_4)cs;

                        dtPlano.Rows.Add(0, "mesa_4", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                    if (cs is Mesa_5)
                    {
                        Mesa_5 o = (Mesa_5)cs;

                        dtPlano.Rows.Add(0, "mesa_5", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                    if (cs is Silla_1)
                    {
                        Silla_1 o = (Silla_1)cs;

                        dtPlano.Rows.Add(0, "silla_1", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, o.NroRotacion);
                    }

                    if (cs is Silla_2)
                    {
                        Silla_2 o = (Silla_2)cs;

                        dtPlano.Rows.Add(0, "silla_2", o.Caption, o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, o.NroRotacion);
                    }

                    if (cs is Mesa_Panel)
                    {
                        Mesa_Panel o = (Mesa_Panel)cs;

                        dtPlano.Rows.Add(0, "mesa_panel", "", o.Top, o.Left, o.Height, o.Width, o.Location.X, o.Location.Y, 1, 0);
                    }

                }

                dtPlano.AcceptChanges();

                oPlano.Save(dtPlano);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbmPlano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void iconEditar_Click(object sender, EventArgs e)
        {
            if (dtPlano.Rows.Count > 0)
            {
                using (frmModal frm = new frmModal())
                {
                    frmPlano_Obj frmObj = new frmPlano_Obj();
                    frmObj.dt = dtPlano;

                    frm.oForm = frmObj;

                    if (frm.ShowDialog() == DialogResult.OK)
                        LoadData();
                }
            }
        }
    }
}
