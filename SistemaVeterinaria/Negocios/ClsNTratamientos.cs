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
    class ClsNTratamientos
    {
        public Principal.FrmTratamientos FrmTratamientos
        {
            get => default(Principal.FrmTratamientos);
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
            command.CommandText = "VetUSP_S_ListarTratamiento";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarMySql(ClsEtratamientos clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarTratamiento";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnitra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomtra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptratra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdettra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("prectra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfectra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pcittra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppretra", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnitra"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomtra"].Value = clsCar.Nombre;
                Objcomando.Parameters["ptratra"].Value = clsCar.Tratamientos;
                Objcomando.Parameters["pdettra"].Value = clsCar.Detalle;
                Objcomando.Parameters["prectra"].Value = clsCar.Receta;
                Objcomando.Parameters["pfectra"].Value = clsCar.Fecha; 
                Objcomando.Parameters["pcittra"].Value = clsCar.Cita;
                Objcomando.Parameters["ppretra"].Value = clsCar.Precio;

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
        public Boolean MtdMoficarMySql(ClsEtratamientos clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarTratamiento";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnitra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomtra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ptratra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdettra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("prectra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfectra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pcittra", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppretra", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnitra"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomtra"].Value = clsCar.Nombre;
                Objcomando.Parameters["ptratra"].Value = clsCar.Tratamientos;
                Objcomando.Parameters["pdettra"].Value = clsCar.Detalle;
                Objcomando.Parameters["prectra"].Value = clsCar.Receta;
                Objcomando.Parameters["pfectra"].Value = clsCar.Fecha;
                Objcomando.Parameters["pcittra"].Value = clsCar.Cita;
                Objcomando.Parameters["ppretra"].Value = clsCar.Precio;


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
       
        public DataTable MtdBuscarMySql(ClsEtratamientos clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarTratamientoConDni";
            command.Parameters.Add(new MySqlParameter("pdnitra", MySqlDbType.VarChar));
            command.Parameters["pdnitra"].Value = clsCar.Dni;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

    }
}
