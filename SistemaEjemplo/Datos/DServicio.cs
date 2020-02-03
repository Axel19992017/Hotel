using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DServicio
    {
        //variables de clase
        private int id_servicio;
        private string descr;
        private double precio;

        public double Precio { get => precio; set => precio = value; }
        public string Descr { get => descr; set => descr = value; }
        public int Id_servicio { get => id_servicio; set => id_servicio = value; }

        public DServicio(string descr, double precio)
        {
            this.descr = descr;
            this.precio = precio;
        }

        public DServicio(int id_servicio, string descr, double precio)
        {
            this.id_servicio = id_servicio;
            this.descr = descr;
            this.precio = precio;
        }

        public DServicio() { }

        public string Insertar(DServicio servicio)
        {
            string respuesta = "";
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = Conexión.Cn;
            sql.Open();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sql;
                command.CommandText = "addServicio";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter pDescripción = new SqlParameter("@descripción",SqlDbType.NVarChar,60);
                pDescripción.Value = servicio.descr;
                command.Parameters.Add(pDescripción);

                SqlParameter pPrecio = new SqlParameter("@precio", SqlDbType.Money);
                pPrecio.Value = servicio.precio;
                command.Parameters.Add(pPrecio);

                respuesta = command.ExecuteNonQuery() == 1 ? "Servicio Agregado" : "Error al agregar servicio";
            }
            catch (Exception e)
            {
                respuesta = e.Message;
                Console.WriteLine(e.Message);
            }
            sql.Close();
            return respuesta;

        }
        public DataTable Mostrar()
        {
            DataTable table = new DataTable("servicio");
            SqlConnection sql = new SqlConnection();
            try
            {
                sql.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "mostrarServicios",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch(Exception e)
            {
                table = null;
                Console.WriteLine(e.Message);

            }
            return table;
        }
        public string Editar(DServicio Servicio)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "editarServicio";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idServicio", SqlDbType.Int);
                parameter.Value = Servicio.Id_servicio;
                sqlCommand.Parameters.Add(parameter);

                parameter = new SqlParameter("@descr", SqlDbType.VarChar, 60);
                parameter.Value = Servicio.Descr;
                sqlCommand.Parameters.Add(parameter);

                parameter = new SqlParameter("@precio", SqlDbType.Money);
                parameter.Value = Servicio.Precio;
                sqlCommand.Parameters.Add(parameter);
                respuesta = sqlCommand.ExecuteNonQuery() == 1 ? "Edición Completa y Exitosa" : "Error de edición de datos";


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                respuesta = e.Message;
            }
            finally
            {
                sqlConnection.Close();

            }
            return respuesta;
        }
        public DataTable Buscar(string dato)
        {
            DataTable resultado = new DataTable("Servicio");
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "buscarServicio";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@dato", SqlDbType.VarChar, 20);
                parameter.Value = dato;
                sqlCommand.Parameters.Add(parameter);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(resultado);
            }
            catch(Exception e)
            {
                resultado = null;
                Console.WriteLine(e.Message);

            }
            return resultado;
        }
        public double MostrarPrecio(int ServicioId)
        {
            DataTable table = new DataTable("servicio");
            SqlConnection sql = new SqlConnection();
            try
            {
                sql.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "mostrarPrecioServicio",
                    CommandType = CommandType.StoredProcedure
                };
                SqlParameter parameter = new SqlParameter("@idServicio", SqlDbType.Int);
                parameter.Value = ServicioId;
                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                table = null;
                Console.WriteLine(e.Message);

            }
            return Convert.ToDouble(table.Rows[0][0].ToString());
        }
    }
}
