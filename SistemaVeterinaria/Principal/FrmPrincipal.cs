using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria.Principal
{

    public partial class FrmPrincipal : Form
    {
        Button Activo;
        Color dark = Color.FromArgb(11, 56, 106);
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public static int ayuda = 0;
        public static string codEmp = "";
        public static string nombreEmp = "";
        public static string apelliEmp = "";
        public static string ruc = "";
        public static string cargoEmp = "";
        public static int contEmp = 1;
        public void loadForm(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            group.Controls.Clear();
            group.Controls.Add(form);
            form.Show();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnHistorial.BackColor = dark;
            btnGanancias.BackColor = dark;
            btnclientes.BackColor = dark;
            btnPProductos.BackColor = dark;
            btnHistorial.BackColor = dark;
            btnECanina.BackColor = dark;
            btnAActividades.BackColor = dark;
            btnRMascota.BackColor = dark;
            btnMPacientes.BackColor = dark;
            btncerrar.BackColor = dark;
            btnSVacunacion.BackColor = dark;
            panelIzquierdo.BackColor = Color.FromArgb(11, 56, 106);

            btnclientes.Enabled = false;
            btnPProductos.Enabled = false;
            btnHistorial.Enabled = false;
            btnECanina.Enabled = false;
            btnAActividades.Enabled = false;
            btnRMascota.Enabled = false;
            btnMPacientes.Enabled = false;
            btnSVacunacion.Enabled = false;
            btnGanancias.Enabled = false;

            if (cargoEmp.Equals("Medico Veterinario"))
            {
                btnclientes.Enabled = false;
                btnPProductos.Enabled =false;
                btnRMascota.Enabled = true;
                btnSVacunacion.Enabled = true;
                btnMPacientes.Enabled = true;
                btnECanina.Enabled = true;
                btnHistorial.Enabled = true;               
                btnAActividades.Enabled = true;
                btnGanancias.Enabled = true;

            }
            if (cargoEmp.Equals("Administrador"))
            {
                btnclientes.Enabled = true;
                btnPProductos.Enabled = true;
                btnRMascota.Enabled = true;
                btnSVacunacion.Enabled = true;
                btnMPacientes.Enabled = true;
                btnECanina.Enabled = true;
                btnHistorial.Enabled = true;
                btnAActividades.Enabled = true;
                btnGanancias.Enabled = true;
            }
            if (cargoEmp.Equals("Asistente"))
            {
                btnclientes.Enabled = true;
                btnPProductos.Enabled = false;
                btnRMascota.Enabled = true;
                btnSVacunacion.Enabled = true;
                btnMPacientes.Enabled = true;
                btnECanina.Enabled = true;
                btnHistorial.Enabled = true;
                btnAActividades.Enabled = true;
                btnGanancias.Enabled = false;
            }
            lblEmpleado.Text = cargoEmp;
            lblNombre.Text = apelliEmp+","+ nombreEmp;
        }
        public void setActiveForm(Button btn)
        {
            if (btn != Activo)
            {
                btn.BackColor = Color.FromArgb(0, 0, 60);
                if (Activo != null) { Activo.BackColor = Color.FromArgb(11, 56, 106); }
                Activo = btn;
            }
        
       }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            setActiveForm(btnclientes);
            loadForm(new FrmClientes());
        }

        private void btnPProductos_Click(object sender, EventArgs e)
        {
            setActiveForm(btnPProductos);
            loadForm(new FrmEmpleado());
        }

        private void btnECanina_Click(object sender, EventArgs e)
        {
            setActiveForm(btnECanina);
            loadForm(new FrmTratamientos());
        }

        private void btnAActividades_Click(object sender, EventArgs e)
        {
            setActiveForm(btnAActividades);
            loadForm(new FrmAgenda());
        }

        private void btnMPacientes_Click(object sender, EventArgs e)
        {
            setActiveForm(btnMPacientes);
            loadForm(new FrmMantenimiento());
        }

        private void btnSVacunacion_Click(object sender, EventArgs e)
        {
            setActiveForm(btnSVacunacion);
            loadForm(new FrmServicios());
        }

        private void btnRMascota_Click(object sender, EventArgs e)
        {
            setActiveForm(btnRMascota);
            loadForm(new FrmMascota());
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            FrmLogins frm = new FrmLogins();
            frm.Show();
            this.Hide();
        }



        private void group_Enter(object sender, EventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            setActiveForm(btnHistorial);
            loadForm(new FrmHistorial());
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            setActiveForm(btnGanancias);
            loadForm(new FrmGanancias());
        }

        public FrmEmpleado FrmEmpleado
        {
            get => default(FrmEmpleado);
            set
            {
            }
        }

        public FrmMascota FrmMascota
        {
            get => default(FrmMascota);
            set
            {
            }
        }

        public FrmServicios FrmServicios
        {
            get => default(FrmServicios);
            set
            {
            }
        }

        public FrmMantenimiento FrmMantenimiento
        {
            get => default(FrmMantenimiento);
            set
            {
            }
        }

        public FrmTratamientos FrmTratamientos
        {
            get => default(FrmTratamientos);
            set
            {
            }
        }

        public FrmHistorial FrmHistorial
        {
            get => default(FrmHistorial);
            set
            {
            }
        }

        public FrmAgenda FrmAgenda
        {
            get => default(FrmAgenda);
            set
            {
            }
        }

        public FrmGanancias FrmGanancias
        {
            get => default(FrmGanancias);
            set
            {
            }
        }

        public FrmClientes FrmClientes
        {
            get => default(FrmClientes);
            set
            {
            }
        }
    }
}
