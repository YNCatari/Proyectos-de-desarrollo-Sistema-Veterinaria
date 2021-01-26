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
    class ClsNMascota
    {
        public Principal.FrmMascota FrmMascota
        {
            get => default(Principal.FrmMascota);
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
            command.CommandText = "VetUSP_S_ListarMascota";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public Boolean MtdAgregarMySql(ClsEMascota clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_I_AgregarMascota";
                Objcomando.CommandType = CommandType.StoredProcedure;

                Objcomando.Parameters.Add(new MySqlParameter("pdnimas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnommas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pespmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("prazmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppesmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("psexmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnacmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pestmas", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnimas"].Value = clsCar.Dni;
                Objcomando.Parameters["pnommas"].Value = clsCar.Nombres;
                Objcomando.Parameters["pespmas"].Value = clsCar.Especie;
                Objcomando.Parameters["prazmas"].Value = clsCar.Raza;
                Objcomando.Parameters["ppesmas"].Value = clsCar.Peso;
                Objcomando.Parameters["psexmas"].Value = clsCar.Sexo;
                Objcomando.Parameters["pnacmas"].Value = clsCar.Nacimiento;
                Objcomando.Parameters["pestmas"].Value = clsCar.Estado;

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
        public Boolean MtdMoficarMySql(ClsEMascota clsCar)
        {
            try
            {
                ClsNConexion Objconexion = new ClsNConexion();
                MySqlCommand Objcomando = new MySqlCommand();
                Objcomando.Connection = Objconexion.conectar();
                Objcomando.CommandText = "VetUSP_U_ActualizarMascota";
                Objcomando.CommandType = CommandType.StoredProcedure;


                Objcomando.Parameters.Add(new MySqlParameter("pdnimas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnommas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pespmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("prazmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("ppesmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("psexmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pnacmas", MySqlDbType.VarChar));
                Objcomando.Parameters.Add(new MySqlParameter("pestmas", MySqlDbType.VarChar));

                Objcomando.Parameters["pdnimas"].Value = clsCar.Dni;
                Objcomando.Parameters["pnommas"].Value = clsCar.Nombres;
                Objcomando.Parameters["pespmas"].Value = clsCar.Especie;
                Objcomando.Parameters["prazmas"].Value = clsCar.Raza;
                Objcomando.Parameters["ppesmas"].Value = clsCar.Peso;
                Objcomando.Parameters["psexmas"].Value = clsCar.Sexo;
                Objcomando.Parameters["pnacmas"].Value = clsCar.Nacimiento;
                Objcomando.Parameters["pestmas"].Value = clsCar.Estado;


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
       
        public DataTable MtdBuscarMySql(ClsEMascota clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarMascota";
            command.Parameters.Add(new MySqlParameter("pdnimas", MySqlDbType.VarChar));
            command.Parameters["pdnimas"].Value = clsCar.Dni;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }

        public DataTable MtdBuscarMascota(ClsEMascota clsCar)
        {
            ClsNConexion conn = new ClsNConexion();
            DataTable result = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn.conectar();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "VetUSP_S_BuscarMascotaConDni";
            command.Parameters.Add(new MySqlParameter("pdnimas", MySqlDbType.VarChar));
            command.Parameters.Add(new MySqlParameter("pnommas", MySqlDbType.VarChar));
            command.Parameters["pdnimas"].Value = clsCar.Dni;
            command.Parameters["pnommas"].Value = clsCar.Nombres;
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            adapter.Fill(result);

            return result;
        }
    }
}
