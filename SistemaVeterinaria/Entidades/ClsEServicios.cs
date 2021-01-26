using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEServicios
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }
      
        public string Vacuna { get; set; }
        public string Detalle { get; set; }
        public string Fecha { get; set; }
        public string Precio { get; set; }

        public Principal.FrmServicios FrmServicios
        {
            get => default(Principal.FrmServicios);
            set
            {
            }
        }
    }
}
