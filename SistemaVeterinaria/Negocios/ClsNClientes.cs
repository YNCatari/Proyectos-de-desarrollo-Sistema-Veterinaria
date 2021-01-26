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
    class ClsNClientes
    {
        public Principal.FrmClientes FrmClientes
        {
            get => default(Principal.FrmClientes);
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
            command.CommandText = "VetUSP_S_ListarCliente";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarClienteMysql(ClsEClientes clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                DataTable result = new DataTable();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarCliente";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnicli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomcli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("papecli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptelcli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pemacli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdircli", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnicli"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomcli"].Value = clsCar.Nombre;
                Objcomando.Parameters["papecli"].Value = clsCar.Apellido;
                Objcomando.Parameters["ptelcli"].Value = clsCar.Telefono;
                Objcomando.Parameters["pemacli"].Value = clsCar.Email;
                Objcomando.Parameters["pdircli"].Value = clsCar.Direccion;
               

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
        public Boolean MtdMoficarMysql(ClsEClientes clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarCliente";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnicli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomcli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("papecli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptelcli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pemacli", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdircli", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnicli"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomcli"].Value = clsCar.Nombre;
                Objcomando.Parameters["papecli"].Value = clsCar.Apellido;
                Objcomando.Parameters["ptelcli"].Value = clsCar.Telefono;
                Objcomando.Parameters["pemacli"].Value = clsCar.Email;
                Objcomando.Parameters["pdircli"].Value = clsCar.Direccion;

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
        public Boolean MtdEliminarMySql(ClsEClientes clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                DataTable result = new DataTable();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_D_EliminarCliente";
                Objcomando.CommandType = CommandType.StoredProcedure;
                Objcomando.Parameters.Add(new MySqlParameter("pdnicli", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnicli"].Value = clsCar.Dni;

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
        public DataTable MtdBuscarMySql(ClsEClientes clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarCliente";
            command.Parameters.Add(new MySqlParameter("pdnicli", MySqlDbType.VarChar));
            command.Parameters["pdnicli"].Value = clsCar.Dni;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
