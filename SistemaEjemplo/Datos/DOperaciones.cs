using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DOperaciones
    {
        public DataTable DisponibilidadHabitConid(int idHabitacion, string fechaEntrada, string fechaSalida )
        {
            DataTable resultado = new DataTable("Operaciones");
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "HabitDisponible";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabit", SqlDbType.Int);
                parameter.Value = idHabitacion;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@PfechaEntrada", SqlDbType.Date);
                parameter.Value = fechaEntrada;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@PfechaSalida", SqlDbType.Date);
                parameter.Value = fechaSalida;
                command.Parameters.Add(parameter);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(resultado);

            }
            catch (Exception e)
            {
                resultado = null;
                Console.WriteLine(e.Message);

            }
            return resultado;
        }

        public DataTable DisponibilidadHabit(string fechaEntrada, string fechaSalida)
        {
            DataTable resultado = new DataTable("Operaciones");
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Habitaciones";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@fechaentrada", SqlDbType.Date);
                parameter.Value = fechaEntrada;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@fechasalida", SqlDbType.Date);
                parameter.Value = fechaSalida;
                command.Parameters.Add(parameter);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(resultado);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resultado = null;
            }
            return resultado;
        }

        public DataTable DisponibilidadHabitReserva(string fechaEntrada, string fechaSalida)
        {
            DataTable resultado = new DataTable("Operaciones");
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "HabitacionesAReservar";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@fechaentrada", SqlDbType.Date);
                parameter.Value = fechaEntrada;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@fechasalida", SqlDbType.Date);
                parameter.Value = fechaSalida;
                command.Parameters.Add(parameter);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(resultado);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resultado = null;
            }
            return resultado;
        }


        public DataTable GetIdHabitaciones()
        {
            DataTable res = new DataTable("Resultado");
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "getIdHabit";
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(res);
            }
            catch (Exception e)
            {
                res = null;
                Console.WriteLine(e.Message);

            }
            return res;
        }

        public DataTable ValidarPass(string usuario, string pass)
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "validarPass";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                parameter.Value = usuario;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                parameter.Value = pass;
                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return res;
        }

        public DataTable Recaudaciones(int mes, int año)
        {
            SqlConnection connection = new SqlConnection();
            DataTable res = new DataTable("Resultado");
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "recaudaciones";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@mes",SqlDbType.Int);
                parameter.Value = mes;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@año", SqlDbType.Int);
                parameter.Value = año;
                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }
}
