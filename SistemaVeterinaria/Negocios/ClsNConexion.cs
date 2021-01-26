using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SistemaVeterinaria.Negocios
{
    class ClsNConexion
    {
        public string Servidor = "www.exgperu.com";
        public string Basedatos = "excellet_elard";
        public string usuario = "excellet_elard";
        public string clave = "elard@2018";

        public static MySqlConnection conn;

        internal ClsNGanancias ClsNGanancias
        {
            get => default(ClsNGanancias);
            set
            {
            }
        }

        internal ClsNAgenda ClsNAgenda
        {
            get => default(ClsNAgenda);
            set
            {
            }
        }

        internal ClsNHistorial ClsNHistorial
        {
            get => default(ClsNHistorial);
            set
            {
            }
        }

        internal ClsNTratamientos ClsNTratamientos
        {
            get => default(ClsNTratamientos);
            set
            {
            }
        }

        internal ClsNMantenimiento ClsNMantenimiento
        {
            get => default(ClsNMantenimiento);
            set
            {
            }
        }

        internal ClsNServicios ClsNServicios
        {
            get => default(ClsNServicios);
            set
            {
            }
        }

        internal ClsNMascota ClsNMascota
        {
            get => default(ClsNMascota);
            set
            {
            }
        }

        internal ClsNEmpleados ClsNEmpleados
        {
            get => default(ClsNEmpleados);
            set
            {
            }
        }

        internal ClsNClientes ClsNClientes
        {
            get => default(ClsNClientes);
            set
            {
            }
        }

        //public static string ConBDcadena;
        public MySqlConnection conectar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "server=" + Servidor + ";" +
                "database=" + Basedatos +
                ";uid=" + usuario + ";" +
                "pwd= " + clave + " ;SslMode=none;";
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            return conn;
        }

        public MySqlConnection cerrar()
        {
            try
            {
                conn = new MySqlConnection();
                conn.Close();
            }
            catch (MySqlException ex) { throw ex; }
            return conn;
        }
    }
}
