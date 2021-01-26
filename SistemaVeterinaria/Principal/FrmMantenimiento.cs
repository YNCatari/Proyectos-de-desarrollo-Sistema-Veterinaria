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
    public partial class FrmMantenimiento : MaterialSkin.Controls.MaterialForm
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
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
            cmbServicios.Text = "";
            TxtDetalles.Text = "";
            txtSoles.Text = "";
            txtDni.Focus();

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (cmbServicios.Text.Equals("")) MessageBox.Show("El campo Servicios  esta vacio");
            else if (TxtDetalles.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else
            {
                ClsEMantenimientos objEMan = new ClsEMantenimientos();
                ClsNMantenimiento ojbjNMan = new ClsNMantenimiento();
                objEMan.Dni = txtDni.Text;
                objEMan.Nombre = txtNombre.Text;
                objEMan.Tipo = cmbServicios.Text;
                objEMan.Detalle = TxtDetalles.Text;
                objEMan.Fecha = dateFecha.Text;
                objEMan.Precio = txtSoles.Text;
                ojbjNMan.MtdAgregarMySql(objEMan);
                MessageBox.Show("Mantenimiento Agregado");
                MtdLimpiarCajas();
                ClsNMantenimiento objNMan = new ClsNMantenimiento();
                dgvMascota.DataSource = objNMan.MtdListarTodo();
                MtdLimpiarCajas();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (cmbServicios.Text.Equals("")) MessageBox.Show("El campo Servicios  esta vacio");
            else if (TxtDetalles.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else
            {
                ClsEMantenimientos objEMan = new ClsEMantenimientos();
                ClsNMantenimiento ojbjNMan = new ClsNMantenimiento();
                objEMan.Dni = txtDni.Text;
                objEMan.Nombre = txtNombre.Text;
                objEMan.Tipo = cmbServicios.Text;
                objEMan.Detalle = TxtDetalles.Text;
                objEMan.Fecha = dateFecha.Text;
                objEMan.Precio = txtSoles.Text;
                ojbjNMan.MtdMoficarMySql(objEMan);
                MessageBox.Show("Mantenimiento Modificado");
                MtdLimpiarCajas();
                ClsNMantenimiento objNMan = new ClsNMantenimiento();
                dgvMascota.DataSource = objNMan.MtdListarTodo();
            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            ClsNMantenimiento objNMan = new ClsNMantenimiento();
            dgvMascota.DataSource = objNMan.MtdListarTodo();
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
        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Equals("")) MessageBox.Show("El campo Buscar Dni esta vacio");
            else
            {
                ClsEMantenimientos objEC = new ClsEMantenimientos();
                ClsNMantenimiento ojbjNC = new ClsNMantenimiento();
                objEC.Dni = txtBuscar.Text;
                dgvMascota.DataSource = ojbjNC.MtdBuscarMySql(objEC);
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

        private void dgvMascota_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMascota.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvMascota.CurrentRow;
                txtDni.Text = tb.Cells[0].Value.ToString();
                txtNombre.Text = tb.Cells[1].Value.ToString();
                cmbServicios.Text = tb.Cells[2].Value.ToString();
                TxtDetalles.Text = tb.Cells[3].Value.ToString();
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
