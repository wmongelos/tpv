using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using TPV.Activacion;

namespace TPV
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new FrmPrincipal());

            //Application.ThreadException += new ThreadExceptionEventHandler(Form1_UIThreadException);

            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //{
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);


            //    try
            //    {
            //        frmSplash frmSp = new frmSplash();

            //        if (frmSp.ShowDialog() == DialogResult.OK)
            //        {
            //            TrialMaker t = new TrialMaker("TMTest1", Application.StartupPath + "\\RegFile.reg",
            //            Application.StartupPath + "\\TMSetp.dbf",
            //            "Phone: +98 21 88281536\nMobile: +98 912 2881860",
            //            30, 10, "722");

            //            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63,
            //    4, 54, 87, 56, 123, 10, 3, 62,
            //    7, 9, 20, 36, 37, 21, 101, 57};
            //            t.TripleDESKey = MyOwnKey;


            //            TrialMaker.RunTypes RT = t.ShowDialog();

            //            if (RT != TrialMaker.RunTypes.Expired)
            //            {
            //                if (RT == TrialMaker.RunTypes.Full)
            //                    GlobalVar.isTrial = false;
            //                else
            //                    GlobalVar.isTrial = true;

            //                frmLogin frmLog = new frmLogin();

            //                if (GlobalVar.isTrial == true)
            //                {
            //                    if (File.Exists(Application.StartupPath + "\\db.sqlite") == true)
            //                    {
            //                        if (frmLog.ShowDialog() == DialogResult.OK)
            //                            if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                Application.Run(frmMain.Instance());
            //                            else
            //                                Application.Run(new frmCocina());
            //                        else
            //                            Application.Exit();
            //                    }
            //                    else
            //                    {
            //                        frmCreateDB frm = new frmCreateDB();

            //                        if (frm.ShowDialog() == DialogResult.OK)
            //                        {
            //                            if (frmLog.ShowDialog() == DialogResult.OK)
            //                                if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                    Application.Run(frmMain.Instance());
            //                                else
            //                                    Application.Run(new frmCocina());
            //                            else
            //                                Application.Exit();
            //                        }
            //                        else
            //                            Application.Exit();
            //                    }
            //                }
            //                else
            //                {
            //                    frmConfigDB frmConfig = new frmConfigDB();

            //                    if (Properties.Settings.Default.DB_Server == String.Empty)
            //                    {
            //                        if (frmConfig.ShowDialog() == DialogResult.OK)
            //                        {
            //                            if (DbHelper.getDbHelper().ExistMySqlDataBase())
            //                            {
            //                                if (frmLog.ShowDialog() == DialogResult.OK)
            //                                    if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                        Application.Run(frmMain.Instance());
            //                                    else
            //                                        Application.Run(new frmCocina());
            //                                else
            //                                    Application.Exit();
            //                            }
            //                            else
            //                            {
            //                                DbHelper.getDbHelper().CreateDataBase();

            //                                frmCreateDB frm = new frmCreateDB();

            //                                if (frm.ShowDialog() == DialogResult.OK)
            //                                {
            //                                    if (frmLog.ShowDialog() == DialogResult.OK)
            //                                        if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                            Application.Run(frmMain.Instance());
            //                                        else
            //                                            Application.Run(new frmCocina());
            //                                    else
            //                                        Application.Exit();
            //                                }
            //                                else
            //                                    Application.Exit();
            //                            }
            //                        }
            //                        else
            //                            Application.Exit();
            //                    }
            //                    else
            //                    {
            //                        if (DbHelper.getDbHelper().ExistMySqlDataBase())
            //                        {
            //                            if (frmLog.ShowDialog() == DialogResult.OK)
            //                                if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                    Application.Run(frmMain.Instance());
            //                                else
            //                                    Application.Run(new frmCocina());
            //                            else
            //                                Application.Exit();
            //                        }
            //                        else
            //                        {
            //                            DbHelper.getDbHelper().CreateDataBase();

            //                            frmCreateDB frm = new frmCreateDB();

            //                            if (frm.ShowDialog() == DialogResult.OK)
            //                            {
            //                                if (frmLog.ShowDialog() == DialogResult.OK)
            //                                    if (Properties.Settings.Default.TPV_Modulo.ToString() == "1")
            //                                        Application.Run(frmMain.Instance());
            //                                    else
            //                                        Application.Run(new frmCocina());
            //                                else
            //                                    Application.Exit();
            //                            }
            //                            else
            //                                Application.Exit();
            //                        }
            //                    }

            //                }
            //            }
            //        }
            //    }
            //    catch { }

            //}
        }

        public static void Form1_UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            //MessageBox.Show(t.Exception.Message);
            //MessageBox.Show(t.ToString());
        }
    }
}
