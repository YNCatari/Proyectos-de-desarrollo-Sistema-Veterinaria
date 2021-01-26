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
    class ClsNServicios
    {
        public Principal.FrmServicios FrmServicios
        {
            get => default(Principal.FrmServicios);
            set
            {
            }
        }

        public DataTable MtdListarTodo()
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_ListarServicio";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarMySql(ClsEServicios clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarServicio";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdniser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pvacser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdetser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppreser", MySqlDbType.VarChar));

                Objcomando.Parameters["pdniser"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomser"].Value = clsCar.Nombres;
                Objcomando.Parameters["pvacser"].Value = clsCar.Vacuna;
                Objcomando.Parameters["pdetser"].Value = clsCar.Detalle;
                Objcomando.Parameters["pfecser"].Value = clsCar.Fecha;
                Objcomando.Parameters["ppreser"].Value = clsCar.Precio;

                Objcomando.Connection = Objconexion.conectar();
                Objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
        public Boolean MtdMoficarMySql(ClsEServicios clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarServicio";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdniser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pvacser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdetser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecser", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppreser", MySqlDbType.VarChar));

                Objcomando.Parameters["pdniser"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomser"].Value = clsCar.Nombres;
                Objcomando.Parameters["pvacser"].Value = clsCar.Vacuna;
                Objcomando.Parameters["pdetser"].Value = clsCar.Detalle;
                Objcomando.Parameters["pfecser"].Value = clsCar.Fecha;
                Objcomando.Parameters["ppreser"].Value = clsCar.Precio;

                Objcomando.Connection = Objconexion.conectar();
                Objcomando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }
       
        public DataTable MtdBuscarMySql(ClsEServicios clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarServicioConDni";
            command.Parameters.Add(new MySqlParameter("pdniser", MySqlDbType.VarChar));
            command.Parameters["pdniser"].Value = clsCar.Dni;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
