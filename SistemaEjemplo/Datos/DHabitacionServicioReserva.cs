using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DHabitacionServicioReserva
    {
        private int idHabitacionReserva;
        private int idServicio;
        private double precio;

        public int IdHabitacionReserva { get => idHabitacionReserva; set => idHabitacionReserva = value; }
        public int IdServicio { get => idServicio; set => idServicio = value; }
        public double Precio { get => precio; set => precio = value; }

        public DHabitacionServicioReserva(int idHabitacionReserva, int idServicio, double precio)
        {
            this.idHabitacionReserva = idHabitacionReserva;
            this.idServicio = idServicio;
            this.precio = precio;
        }

        public DHabitacionServicioReserva(int idHabitacionReserva, int idServicio)
        {
            this.idHabitacionReserva = idHabitacionReserva;
            this.idServicio = idServicio;
        }

        public DHabitacionServicioReserva()
        {
        }

        public DataTable MostrarServiciosHabitReserva(int idHabitReserva)
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ServicioIdHabitReserva";

                SqlParameter parameter = new SqlParameter("@idHabitReserva", SqlDbType.Int);
                parameter.Value = idHabitReserva;
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
        public string Agregar(DHabitacionServicioReserva habitacionServicioReserva)
        {
            string res = "";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                connection.Open();
                SqlCommand command = new SqlCommand("addServicioHabitación",connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idServicio", SqlDbType.Int);
                parameter.Value = habitacionServicioReserva.IdServicio;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@idHabitaciónReserva", SqlDbType.Int);
                parameter.Value = habitacionServicioReserva.IdHabitacionReserva;
                command.Parameters.Add(parameter);

                res = command.ExecuteNonQuery() == 1 ? "Listo" : "Error al Guardar";
            }
            catch (Exception e)
            {
                connection.Close();
                res = e.Message;
            }
            connection.Close();
            return res;
        }
        public string Borrar(DHabitacionServicioReserva habitacionServicioReserva)
        {
            SqlConnection connection = new SqlConnection();
            string res;
            try
            {
                connection.ConnectionString = Conexión.Cn;
                connection.Open();
                SqlCommand command = new SqlCommand("borrarHabitReserServicio", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabitReserva", SqlDbType.Int);
                parameter.Value = habitacionServicioReserva.IdHabitacionReserva;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@IdServicio", SqlDbType.Int);
                parameter.Value = habitacionServicioReserva.IdServicio;
                command.Parameters.Add(parameter);

                res = command.ExecuteNonQuery() == 1 ? "Listo" : "Error al Borrar";
                
            }
            catch (Exception e)
            {
                connection.Close();
                res = e.Message;
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return res;
        }

        public DataTable MostrarServicHabitReserDispon(int idHabitReserva)
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "mostrarServicioDisp";

                SqlParameter parameter = new SqlParameter("@idHabitReserva", SqlDbType.Int);
                parameter.Value = idHabitReserva;
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

    }
}
