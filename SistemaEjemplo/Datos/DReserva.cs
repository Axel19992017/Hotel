using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class DReserva
    {
        private int id_reserva;
        private int id_cliente;
        private int id_empleado;
        private string fecha_reserva;
        private string forma_pago;
        private string divisa;
        private string stat;

        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_empleado { get => id_empleado; set => id_empleado = value; }
        public string Fecha_reserva { get => fecha_reserva; set => fecha_reserva = value; }
        public string Forma_pago { get => forma_pago; set => forma_pago = value; }
        public string Divisa { get => divisa; set => divisa = value; }
        public string Stat { get => stat; set => stat = value; }

        public DReserva(int id_reserva, int id_cliente, int id_empleado, string fecha_reserva, string forma_pago, string divisa, string stat)
        {
            this.id_reserva = id_reserva;
            this.id_cliente = id_cliente;
            this.id_empleado = id_empleado;
            this.fecha_reserva = fecha_reserva;
            this.forma_pago = forma_pago;
            this.divisa = divisa;
            this.stat = stat;
        }

        public DReserva(int id_cliente, int id_empleado, string fecha_reserva, string forma_pago, string divisa, string stat)
        {
            this.id_cliente = id_cliente;
            this.id_empleado = id_empleado;
            this.fecha_reserva = fecha_reserva;
            this.forma_pago = forma_pago;
            this.divisa = divisa;
            this.stat = stat;
        }

        public DReserva()
        {
        }

        public DataTable Mostrar()
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "mostrarReserva";
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }

        public int GetIdReservaNueva()
        {
            int res = 0;
            SqlConnection connection = new SqlConnection();
            try
            {

                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand("getIdReservaNueva", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataTable data = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(data);
                res = Convert.ToInt32(data.Rows[0][0]);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return res;
        }

        public string Agregar(DReserva reserva)
        {
            string res = "";
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                connection.Open();
                SqlCommand command = new SqlCommand("addReserva", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idCliente", SqlDbType.Int);
                parameter.Value = reserva.Id_cliente;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@idEmpleado", SqlDbType.Int);
                parameter.Value = reserva.Id_empleado;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@fechaReserva", SqlDbType.Date);
                parameter.Value = reserva.Fecha_reserva;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@formaPago", SqlDbType.VarChar, 15);
                parameter.Value = reserva.Forma_pago;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@divisa", SqlDbType.VarChar, 3);
                parameter.Value = reserva.Divisa;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@estado", SqlDbType.VarChar, 15);
                parameter.Value = reserva.Stat;
                command.Parameters.Add(parameter);

                res = command.ExecuteNonQuery() == 1 ? "Listo" : "Error al Guardar";
            }
            catch (Exception e)
            {
                res = e.Message;
                Console.WriteLine(e.Message);
            }
            return res;
        }
    }
}
