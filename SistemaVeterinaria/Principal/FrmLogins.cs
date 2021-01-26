using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Negocios;
using SistemaVeterinaria.Entidades;

namespace SistemaVeterinaria.Principal
{
    public partial class FrmLogins : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogins()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Cyan900, MaterialSkin.Accent.Pink100, MaterialSkin.TextShade.WHITE);
        }

        public FrmPrincipal FrmPrincipal
        {
            get => default(FrmPrincipal);
            set
            {
            }
        }

        private void FrmLogins_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == null || txtClave.Text == "")
            {
                if (txtClave.Text == null || txtCodigo.Text == "")
                {
                    MessageBox.Show("Error de datos");
                }
            }
            else
            {
                ClsEEmpleados objE = new ClsEEmpleados();
                ClsNEmpleados objN = new ClsNEmpleados();
                objE.Codigo = txtCodigo.Text;
                objE.Clave = txtClave.Text;
                objE.Estado = "TRUE";
                DataTable dtEmp = new DataTable();
                dtEmp = objN.MtdVAlidarLogin(objE);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    FrmPrincipal.codEmp = Fila["codigo"].ToString();
                    FrmPrincipal.nombreEmp = Fila["nombre"].ToString();
                    FrmPrincipal.apelliEmp = Fila["apellido"].ToString();
                    FrmPrincipal.cargoEmp = Fila["cargo"].ToString();

                    MessageBox.Show("Bienvenido " + FrmPrincipal.cargoEmp + " : " + FrmPrincipal.nombreEmp + " " + FrmPrincipal.apelliEmp);
                    FrmPrincipal frm = new FrmPrincipal();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("No existe el usuario");
                }
            }


           
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
