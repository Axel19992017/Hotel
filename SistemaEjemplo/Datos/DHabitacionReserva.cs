using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DHabitacionReserva
    {
        private int idHabitacion;
        private int idReserva;
        private string fechaEntrada;
        private string fechaSalida;
        private double precio;

        public int IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string FechaEntrada { get => fechaEntrada; set => fechaEntrada = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public double Precio { get => precio; set => precio = value; }

        public DHabitacionReserva(int idHabitacion, int idReserva, string fechaEntrada, string fechaSalida, double precio)
        {
            this.idHabitacion = idHabitacion;
            this.idReserva = idReserva;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
            this.precio = precio;
        }

        public DHabitacionReserva()
        {
        }

        public DHabitacionReserva(int idHabitacion, int idReserva, string fechaEntrada, string fechaSalida)
        {
            this.idHabitacion = idHabitacion;
            this.idReserva = idReserva;
            this.fechaEntrada = fechaEntrada;
            this.fechaSalida = fechaSalida;
        }

        public DataTable MostrarHabitacionReserva(int idReserva)
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "HabitacionIdReserva";

                SqlParameter parameter = new SqlParameter("@idReserva", SqlDbType.Int);
                parameter.Value = idReserva;
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

        public string Agregar(DHabitacionReserva habitacionReserva)
        {
            string res;
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                connection.Open();
                SqlCommand command = new SqlCommand("addHabitaciónReserva", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabitación", SqlDbType.Int);
                parameter.Value = habitacionReserva.IdHabitacion;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@idReserva", SqlDbType.Int);
                parameter.Value = habitacionReserva.idReserva;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@fechaEntrada", SqlDbType.Date);
                parameter.Value = habitacionReserva.FechaEntrada;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@fechaSalida", SqlDbType.Date);
                parameter.Value = habitacionReserva.FechaSalida;
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

        public string Borrar(int idHabitacionReserva)
        {
            string res = "";
            SqlConnection connection = new SqlConnection();

            try{
                connection.ConnectionString = Conexión.Cn;
                connection.Open();
                SqlCommand command = new SqlCommand("borrarHabitaciónReserva", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabitaciónReserva", SqlDbType.Int);
                parameter.Value = idHabitacionReserva;
                command.Parameters.Add(parameter);

                res = command.ExecuteNonQuery() == 1 ? "Listo" : "Error al Borrar";

            }
            catch (Exception e)
            {
                connection.Close();
                res = e.Message;
            }
            connection.Close();
            return res;
        }

    }
}
