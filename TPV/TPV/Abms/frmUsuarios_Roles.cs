using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using TPV.Controles;
using TPV.Entidades;

namespace TPV.Abms
{
    public partial class frmUsuarios_Roles : Form
    {
        private DataTable dt = new DataTable();
        private DataTable dtRoles = new DataTable();
        private Usuarios_Roles oUsuRol = new Usuarios_Roles();
        private Usuarios_Roles_Obj oRolObj = new Usuarios_Roles_Obj();
        private Objetos oObjetos = new Objetos();

        private ComboBoxAdv cboRoles = new ComboBoxAdv();
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private Int32 IdRol;

        public frmUsuarios_Roles()
        {
            InitializeComponent();

            this.Controls.Add(cboRoles);
            cboRoles.Location = new Point(13, 71);
            cboRoles.Seleccion += new EventHandler(Cambiar);
        }

        private void LoadData()
        {
            pnData.Controls.Clear();
            

            dt = oObjetos.getObjetos();
            dt.Columns.Add("seleccion", typeof(Boolean));
            
            DataTable dtPermisos = oRolObj.getPermisos(IdRol);

            foreach (DataRow dr in dt.Rows)
            {
                DataRow[] drFilter = dtPermisos.Select(String.Format("objeto_id = {0}", dr["objeto_id"]));

                if(drFilter.Length == 0)
                {
                    this.addRow("", dr["objeto"].ToString(), dr["objeto_id"].ToString());
                    dr["seleccion"] = false;
                }
                else
                {
                    this.addRow("a", dr["objeto"].ToString(), dr["objeto_id"].ToString());
                    dr["seleccion"] = true;
                }
            }

            dt.AcceptChanges();

           // pnData.Location = new Point(0, 0);
        }

        private void LoadRoles()
        {
            dtRoles = oUsuRol.GetRoles();

            DataView dtv = new DataView(dtRoles, "usuario_rol_id > 1", "rol", DataViewRowState.CurrentRows);

            cboRoles.DataSource = dtv.ToTable();
            cboRoles.Display = "rol";
            cboRoles.Value = "usuario_rol_id";
        }

        private void Cambiar(object sender, EventArgs e)
        {
            IdRol = Convert.ToInt32(cboRoles.SelectedValue.ToString());

            this.LoadData();
        }

        private void addRow(string codigo, string descripcion, string idtag)
        {
            CustomRowSel row = new CustomRowSel();

            row.Column1 = codigo;
            row.Tag = idtag;
            row.Column2 = descripcion;
            row.Dock = DockStyle.Top;
            row.Click += new EventHandler(_ClikRow);
            pnData.Controls.Add(row);
            row.Focus();
        }

        private void _ClikRow(object sender, EventArgs e)
        {
            CustomRowSel row = (CustomRowSel)sender;
            row.Column1 = row.Column1 == "a" ? "" : "a";

            DataRow[] dr = dt.Select(String.Format("objeto_id = {0}", row.Tag));

            if (dr.Length > 0)
                dr[0]["seleccion"] = row.Column1 == "a" ? true : false;

            dt.AcceptChanges();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmUsuarios_Rol frmABM = new frmAbmUsuarios_Rol();
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.LoadRoles(); 
                    this.LoadData();
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarios_Roles_Load(object sender, EventArgs e)
        {
            this.LoadRoles();

            this.LoadData();
        }

        private void frmUsuarios_Roles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Guardar los Cambios en el Rol Seleccionado?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                DataRow[] drPermisos = dt.Select("Seleccion = true");

                DataTable dtFinal = dt.Clone();

                foreach (DataRow dr in drPermisos)
                    dtFinal.ImportRow(dr);

                oRolObj.setPermisos(IdRol, dtFinal);
                    
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (frmModal frm = new frmModal())
            {
                frmAbmUsuarios_Rol frmABM = new frmAbmUsuarios_Rol();
                frmABM.Id = Convert.ToInt32(cboRoles.SelectedValue);
                frm.oForm = frmABM;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.LoadRoles(); 
                    this.LoadData();
                }
            }
        }

        private void iconBorrar_Click(object sender, EventArgs e)
        {
            if (frmMsgBox.Show("¿Desea Eliminar el Rol Seleccionado?", "Mensaje del Sistema", frmMsgBox.MessageButton.YesNo) == DialogResult.OK)
            {
                int idRol = Convert.ToInt32(cboRoles.SelectedValue);

                if (idRol == 1)
                {
                    frmMsgBox.Show("No se puede Eliminar el Rol Administrador", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);
                }
                else
                {
                    DataRow[] dr = dtRoles.Select(String.Format("usuario_rol_id = {0}", cboRoles.SelectedValue));

                    if (Convert.ToInt32(dr[0]["Total"].ToString()) > 0)
                        frmMsgBox.Show("Existen Usuarios con el Rol Seleccionado. Debe modificar los usuarios", "Mensaje del Sistema", frmMsgBox.MessageButton.OK);
                    else
                    { 
                        oUsuRol.Delete(idRol);

                        this.LoadRoles();
                        this.LoadData();
                    }
                }
            }
        }
    }
}
