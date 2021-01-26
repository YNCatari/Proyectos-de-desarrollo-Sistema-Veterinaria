using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEMantenimientos
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
      
        public string Tipo { get; set; }
        public string Detalle { get; set; }
        public string Fecha { get; set; }
        public string Precio { get; set; }

        public Principal.FrmMantenimiento FrmMantenimiento
        {
            get => default(Principal.FrmMantenimiento);
            set
            {
            }
        }

        internal Negocios.ClsNMantenimiento ClsNMantenimiento
        {
            get => default(Negocios.ClsNMantenimiento);
            set
            {
            }
        }
    }
}
