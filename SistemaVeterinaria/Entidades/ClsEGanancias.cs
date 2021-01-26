using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEGanancias
    {
        public string FechaI { get; set; }
        public string FechaF { get; set; }
        public string PrecioTotalV { get; set; }
        public string PrecioTotalM { get; set; }
        public string PrecioTotalT { get; set; }

        public Principal.FrmGanancias FrmGanancias
        {
            get => default(Principal.FrmGanancias);
            set
            {
            }
        }

        internal Negocios.ClsNGanancias ClsNGanancias
        {
            get => default(Negocios.ClsNGanancias);
            set
            {
            }
        }
    }
}
