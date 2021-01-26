using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEEmpleados
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }

        public Principal.FrmEmpleado FrmEmpleado
        {
            get => default(Principal.FrmEmpleado);
            set
            {
            }
        }

        internal Negocios.ClsNEmpleados ClsNEmpleados
        {
            get => default(Negocios.ClsNEmpleados);
            set
            {
            }
        }
    }
}
