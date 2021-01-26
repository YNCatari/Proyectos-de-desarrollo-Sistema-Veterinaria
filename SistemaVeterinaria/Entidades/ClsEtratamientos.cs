using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEtratamientos
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Tratamientos { get; set; }
        public string  Detalle{ get; set; }
        public string Receta { get; set; }
        public string Fecha { get; set; }
        public string Cita { get; set; }
        public string Precio { get; set; }

        internal Negocios.ClsNTratamientos ClsNTratamientos
        {
            get => default(Negocios.ClsNTratamientos);
            set
            {
            }
        }

        public Principal.FrmTratamientos FrmTratamientos
        {
            get => default(Principal.FrmTratamientos);
            set
            {
            }
        }
    }
}
