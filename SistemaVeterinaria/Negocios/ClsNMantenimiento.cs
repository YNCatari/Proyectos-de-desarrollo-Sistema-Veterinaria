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
    class ClsNMantenimiento
    {
        public Principal.FrmMantenimiento FrmMantenimiento
        {
            get => default(Principal.FrmMantenimiento);
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
            command.CommandText = "VetUSP_S_ListarMantenimiento";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarMySql(ClsEMantenimientos clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarMantenimiento";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdniman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pserman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdetman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppreman", MySqlDbType.VarChar));


                Objcomando.Parameters["pdniman"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomman"].Value = clsCar.Nombre;
                Objcomando.Parameters["pserman"].Value = clsCar.Tipo;
                Objcomando.Parameters["pdetman"].Value = clsCar.Detalle;
                Objcomando.Parameters["pfecman"].Value = clsCar.Fecha;
                Objcomando.Parameters["ppreman"].Value = clsCar.Precio;

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
        public Boolean MtdMoficarMySql(ClsEMantenimientos clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarMantenimiento";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdniman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnomman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pserman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pdetman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pfecman", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppreman", MySqlDbType.VarChar));


                Objcomando.Parameters["pdniman"].Value = clsCar.Dni;
                Objcomando.Parameters["pnomman"].Value = clsCar.Nombre;
                Objcomando.Parameters["pserman"].Value = clsCar.Tipo;
                Objcomando.Parameters["pdetman"].Value = clsCar.Detalle;
                Objcomando.Parameters["pfecman"].Value = clsCar.Fecha;
                Objcomando.Parameters["ppreman"].Value = clsCar.Precio;

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
       
        public DataTable MtdBuscarMySql(ClsEMantenimientos clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarMantenimientoConDni";
            command.Parameters.Add(new MySqlParameter("pdniman", MySqlDbType.VarChar));
            command.Parameters["pdniman"].Value = clsCar.Dni;

            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
