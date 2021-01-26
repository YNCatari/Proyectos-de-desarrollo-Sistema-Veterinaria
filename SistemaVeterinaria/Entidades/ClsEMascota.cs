using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria.Entidades
{
    class ClsEMascota
    {
        public string Dni { get; set; }
        public string Nombres { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Peso { get; set; }
        public string Sexo { get; set; }
        public string Nacimiento { get; set; }
        public string Estado { get; set; }

        public Principal.FrmMascota FrmMascota
        {
            get => default(Principal.FrmMascota);
            set
            {
            }
        }

        internal Negocios.ClsNMascota ClsNMascota
        {
            get => default(Negocios.ClsNMascota);
            set
            {
            }
        }
    }
}
