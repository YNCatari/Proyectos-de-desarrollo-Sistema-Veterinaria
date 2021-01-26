using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEClientes
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public Principal.FrmClientes FrmClientes
        {
            get => default(Principal.FrmClientes);
            set
            {
            }
        }

        internal Negocios.ClsNClientes ClsNClientes
        {
            get => default(Negocios.ClsNClientes);
            set
            {
            }
        }
    }
}
