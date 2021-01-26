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
    class ClsNEmpleados
    {
        public Principal.FrmEmpleado FrmEmpleado
        {
            get => default(Principal.FrmEmpleado);
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
            command.CommandText = "VetUSP_S_ListarEmpleado";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarMySql(ClsEEmpleados clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarEmpleado";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pcodemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("papeemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdiremp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pemaemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pcaremp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pclaemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pestemp", MySqlDbType.VarChar));

                Objcomando.Parameters["pcodemp"].Value = clsCar.Codigo;
                Objcomando.Parameters["pnomemp"].Value = clsCar.Nombre;
                Objcomando.Parameters["papeemp"].Value = clsCar.Apellidos;
                Objcomando.Parameters["pdiremp"].Value = clsCar.Direccion;
                Objcomando.Parameters["pemaemp"].Value = clsCar.Email;
                Objcomando.Parameters["pcaremp"].Value = clsCar.Cargo;
                Objcomando.Parameters["pclaemp"].Value = clsCar.Clave;
                Objcomando.Parameters["pestemp"].Value = clsCar.Estado;

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

       

        public Boolean MtdMoficarMySql(ClsEEmpleados clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarEmpleado";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pcodemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("papeemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdiremp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pemaemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pcaremp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pclaemp", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pestemp", MySqlDbType.VarChar));

                Objcomando.Parameters["pcodemp"].Value = clsCar.Codigo;
                Objcomando.Parameters["pnomemp"].Value = clsCar.Nombre;
                Objcomando.Parameters["papeemp"].Value = clsCar.Apellidos;
                Objcomando.Parameters["pdiremp"].Value = clsCar.Direccion;
                Objcomando.Parameters["pemaemp"].Value = clsCar.Email;
                Objcomando.Parameters["pcaremp"].Value = clsCar.Cargo;
                Objcomando.Parameters["pclaemp"].Value = clsCar.Clave;
                Objcomando.Parameters["pestemp"].Value = clsCar.Estado;

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
      
        public DataTable MtdBuscarMySql(ClsEEmpleados clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarEmpleado";
            command.Parameters.Add(new MySqlParameter("pcodemp", MySqlDbType.VarChar));
            command.Parameters["pcodemp"].Value = clsCar.Codigo;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
        public DataTable MtdVAlidarLogin(ClsEEmpleados clsCar)
        {
            
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_ValidarLogin";
            command.Parameters.Add(new MySqlParameter("pcodemp", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pclaemp", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pestemp", MySqlDbType.VarChar));            
            command.Parameters["pcodemp"].Value = clsCar.Codigo;
            command.Parameters["pclaemp"].Value = clsCar.Clave;
            command.Parameters["pestemp"].Value = clsCar.Estado;
            
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }


    }
}
