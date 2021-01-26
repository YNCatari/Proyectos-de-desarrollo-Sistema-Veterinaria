using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using SistemaVeterinaria.Entidades;

namespace SistemaVeterinaria.Negocios
{
    class ClsNHistorial
    {
        public Principal.FrmHistorial FrmHistorial
        {
            get => default(Principal.FrmHistorial);
            set
            {
            }
        }

        public DataTable MtdBuscarMascota(ClsEHistorial Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarMascota";
            command.Parameters.Add(new MySqlParameter("pdnimas", MySqlDbType.VarChar));
            command.Parameters["pdnimas"].Value = Obj.Dni;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public DataTable MtdBuscarVacunas(ClsEHistorial Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarServicio";
            command.Parameters.Add(new MySqlParameter("pdniser", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pnomser", MySqlDbType.VarChar));
            command.Parameters["pdniser"].Value = Obj.Dni;
            command.Parameters["pnomser"].Value = Obj.Nombres;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
        public DataTable MtdBuscarMantenimiento(ClsEHistorial Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarMantenimiento";
            command.Parameters.Add(new MySqlParameter("pdniman", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pnomman", MySqlDbType.VarChar));
            command.Parameters["pdniman"].Value = Obj.Dni;
            command.Parameters["pnomman"].Value = Obj.Nombres;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public DataTable MtdBuscarTratamiento(ClsEHistorial Obj)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarTratamiento";
            command.Parameters.Add(new MySqlParameter("pdnitra", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pnomtra", MySqlDbType.VarChar));
            command.Parameters["pdnitra"].Value = Obj.Dni;
            command.Parameters["pnomtra"].Value = Obj.Nombres;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
