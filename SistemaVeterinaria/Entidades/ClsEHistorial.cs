using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEHistorial
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Principal.FrmHistorial FrmHistorial
        {
            get => default(Principal.FrmHistorial);
            set
            {
            }
        }

        internal Negocios.ClsNHistorial ClsNHistorial
        {
            get => default(Negocios.ClsNHistorial);
            set
            {
            }
        }

        public Principal.FrmHistorial FrmHistorial1
        {
            get => default(Principal.FrmHistorial);
            set
            {
            }
        }
    }
}
