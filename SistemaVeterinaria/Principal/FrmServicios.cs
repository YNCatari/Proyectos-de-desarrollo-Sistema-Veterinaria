using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVeterinaria.Entidades;
using SistemaVeterinaria.Negocios;

namespace SistemaVeterinaria.Principal
{
    public partial class FrmServicios : MaterialSkin.Controls.MaterialForm
    {
        public FrmServicios()
        {
            InitializeComponent();
        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            btnBuscarM.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {


            MtdLimpiarCajas();
        }
        private void MtdLimpiarCajas()
        {

            txtDni.Text = "";
            txtNombres.Text = "";
            txtNombre.Text = "";
            txtEspecie.Text = "";
            txtRaza.Text = "";
            txtPeso.Text = "";
            txtSexo.Text = "";
            txtNacimiento.Text = "";
            txtEstado.Text = "";
            txtVacuna.Text = "";
            txtDetalle.Text = "";
            dateFecha.Text = "";
            txtSoles.Text = "";
            txtDni.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtVacuna.Text.Equals("")) MessageBox.Show("El campo Vacuna  esta vacio");
            else if (txtDetalle.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else
            {
                ClsEServicios objESer = new ClsEServicios();
                ClsNServicios ojbjNSer = new ClsNServicios();
                objESer.Dni = txtDni.Text;
                objESer.Nombres = txtNombres.Text;
                objESer.Vacuna = txtVacuna.Text;
                objESer.Detalle = txtDetalle.Text;
                objESer.Fecha = dateFecha.Text;
                objESer.Precio = txtSoles.Text;
                ojbjNSer.MtdAgregarMySql(objESer);
                MessageBox.Show("Servicios Agregado");
                MtdLimpiarCajas();
                ClsNServicios objNcli = new ClsNServicios();
                dgvVacunacion.DataSource = objNcli.MtdListarTodo();
                MtdLimpiarCajas();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtVacuna.Text.Equals("")) MessageBox.Show("El campo Vacuna  esta vacio");
            else if (txtDetalle.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else
            {
                ClsEServicios objESer = new ClsEServicios();
                ClsNServicios ojbjNSer = new ClsNServicios();
                objESer.Dni = txtDni.Text;
                objESer.Nombres = txtNombre.Text;
                objESer.Vacuna = txtVacuna.Text;
                objESer.Detalle = txtDetalle.Text;
                objESer.Fecha = dateFecha.Text;
                objESer.Precio = txtSoles.Text;
                ojbjNSer.MtdMoficarMySql(objESer);
                MessageBox.Show("Servicios Modificado");
                MtdLimpiarCajas();
                ClsNServicios ojbjNS = new ClsNServicios();
                dgvVacunacion.DataSource = ojbjNS.MtdListarTodo();
            }
        }

       

        private void btnListar_Click(object sender, EventArgs e)
        {
            ClsNServicios ojbjNSer = new ClsNServicios();
            dgvVacunacion.DataSource = ojbjNSer.MtdListarTodo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else
            {
                ClsEClientes objEC = new ClsEClientes();
                ClsNClientes ojbjNC = new ClsNClientes();
                objEC.Dni = txtDni.Text;
                DataTable dtEmp = new DataTable();
                dtEmp = ojbjNC.MtdBuscarMySql(objEC);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    txtNombres.Text = Fila["apellido"].ToString() + "," + Fila["nombre"].ToString();
                    btnBuscarM.Enabled = true;
                }
            }
        }

        private void btnBuscarM_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de  Mascota esta vacio");
            else
            {
                ClsEMascota objEC = new ClsEMascota();
                ClsNMascota ojbjNC = new ClsNMascota();
                objEC.Dni = txtDni.Text;
                objEC.Nombres = txtNombre.Text;
                DataTable dtEmp = new DataTable();
                dtEmp = ojbjNC.MtdBuscarMascota(objEC);
                if (dtEmp.Rows.Count > 0)
                {
                    DataRow Fila = dtEmp.Rows[0];
                    txtNombre.Text = Fila["nombre"].ToString();
                    txtEspecie.Text = Fila["especie"].ToString();
                    txtRaza.Text = Fila["raza"].ToString();
                    txtPeso.Text = Fila["peso"].ToString();
                    txtSexo.Text = Fila["sexo"].ToString();
                    txtNacimiento.Text = Fila["nacimiento"].ToString();
                    txtEstado.Text = Fila["estado"].ToString();


                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }

        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) MessageBox.Show("El campo Buscar Dni esta vacio");
            else
            {
                ClsEServicios objEC = new ClsEServicios();
                ClsNServicios ojbjNC = new ClsNServicios();
                objEC.Dni = txtBuscar.Text;
                dgvVacunacion.DataSource = ojbjNC.MtdBuscarMySql(objEC);
            }
        }

        private void dgvVacunacion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvVacunacion.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvVacunacion.CurrentRow;
                txtDni.Text = tb.Cells[0].Value.ToString();
                txtNombre.Text = tb.Cells[1].Value.ToString();
                txtVacuna.Text = tb.Cells[2].Value.ToString();
                txtDetalle.Text = tb.Cells[3].Value.ToString();
                dateFecha.Text = tb.Cells[4].Value.ToString();
                txtSoles.Text = tb.Cells[5].Value.ToString();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtVacuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                e.Handled = true;
            }
        }
    }
}
