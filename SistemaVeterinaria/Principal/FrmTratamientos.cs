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
    public partial class FrmTratamientos : MaterialSkin.Controls.MaterialForm
    {
        public FrmTratamientos()
        {
            InitializeComponent();
        }

        private void FrmEmergencia_Load(object sender, EventArgs e)
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
            txtTratamientos.Text = "";
            txtDetalle.Text = "";
            txtReceta.Text = "";
            dateFecha.Text = "";
            dateCita.Text = "";
            txtSoles.Text = "";
            txtDni.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtTratamientos.Text.Equals("")) MessageBox.Show("El campo Tratamiento  esta vacio");
            else if (txtDetalle.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else if (txtReceta.Text.Equals("")) MessageBox.Show("El campo Receta  esta vacio");
            else
            {
                ClsEtratamientos objETra = new ClsEtratamientos();
                ClsNTratamientos ojbjNTra = new ClsNTratamientos();
                objETra.Dni = txtDni.Text;
                objETra.Nombre = txtNombre.Text;
                objETra.Tratamientos = txtTratamientos.Text;
                objETra.Detalle = txtDetalle.Text;
                objETra.Receta = txtReceta.Text;
                objETra.Fecha = dateFecha.Text;
                objETra.Cita = dateCita.Text;
                objETra.Precio = txtSoles.Text;
                ojbjNTra.MtdAgregarMySql(objETra);
                MessageBox.Show("Tratamientos  Agregado");
                MtdLimpiarCajas();
                ClsNTratamientos ojbjNT = new ClsNTratamientos();
                dgvMascotas.DataSource = ojbjNT.MtdListarTodo();
                MtdLimpiarCajas();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Equals("")) MessageBox.Show("El campo Dni Cliente esta vacio");
            else if (txtNombre.Text.Equals("")) MessageBox.Show("El campo Nombre de Mascota  esta vacio");
            else if (txtTratamientos.Text.Equals("")) MessageBox.Show("El campo Tratamiento  esta vacio");
            else if (txtDetalle.Text.Equals("")) MessageBox.Show("El campo Detalle  esta vacio");
            else if (txtReceta.Text.Equals("")) MessageBox.Show("El campo Receta  esta vacio");
            else
            {
                ClsEtratamientos objETra = new ClsEtratamientos();
                ClsNTratamientos ojbjNTra = new ClsNTratamientos();
                objETra.Dni = txtDni.Text;
                objETra.Nombre = txtNombre.Text;
                objETra.Tratamientos = txtTratamientos.Text;
                objETra.Detalle = txtDetalle.Text;
                objETra.Receta = txtReceta.Text;
                objETra.Fecha = dateFecha.Text;
                objETra.Cita = dateCita.Text;
                objETra.Precio = txtSoles.Text;
                ojbjNTra.MtdMoficarMySql(objETra);
                MessageBox.Show("Tratamientos  Modificado");
                MtdLimpiarCajas();
                ClsNTratamientos objNcli = new ClsNTratamientos();
                dgvMascotas.DataSource = objNcli.MtdListarTodo();
            }
        }

       

        private void btnListar_Click(object sender, EventArgs e)
        {
            ClsNTratamientos ojbjNTra = new ClsNTratamientos();
            dgvMascotas.DataSource = ojbjNTra.MtdListarTodo();
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
                ClsEtratamientos objEC = new ClsEtratamientos();
                ClsNTratamientos ojbjNC = new ClsNTratamientos();
                objEC.Dni = txtBuscar.Text;
                dgvMascotas.DataSource = ojbjNC.MtdBuscarMySql(objEC);
            }
        }

        private void dgvMascotas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMascotas.Rows.Count > 0)
            {
                DataGridViewRow tb = dgvMascotas.CurrentRow;
                txtDni.Text = tb.Cells[0].Value.ToString();
                txtNombre.Text = tb.Cells[1].Value.ToString();
                txtTratamientos.Text = tb.Cells[2].Value.ToString();
                txtDetalle.Text = tb.Cells[3].Value.ToString();
                txtReceta.Text = tb.Cells[4].Value.ToString();
                dateFecha.Text = tb.Cells[5].Value.ToString();
                dateCita.Text = tb.Cells[6].Value.ToString();
                txtSoles.Text = tb.Cells[7].Value.ToString();
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

        private void txtTratamientos_KeyPress(object sender, KeyPressEventArgs e)
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
