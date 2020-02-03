using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DHabitacion
    {
        private int nohabitacion;
        private int codigotipo;
        private String descripcion;
        private int capacidad;
        private String estado;

        public int Nohabitacion { get => nohabitacion; set => nohabitacion = value; }
        public int Codigotipo { get => codigotipo; set => codigotipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public string Estado { get => estado; set => estado = value; }

        public DHabitacion() { }
        public DHabitacion(int nohabitacion,int codigotipo,String descripcion,int capacidad,String estado)
        {
            this.nohabitacion = nohabitacion;
            this.codigotipo = codigotipo;
            this.descripcion = descripcion;
            this.capacidad = capacidad;
            this.estado = estado;
        }

        public string EliminarHabitacion( int nohabitacion)
        {
            string rpta = "";
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "EliminarHabitacion";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter Parnohabitacion = new SqlParameter();
                Parnohabitacion.ParameterName = "@idhabitacion";
                Parnohabitacion.SqlDbType = SqlDbType.Int;
                Parnohabitacion.Value = nohabitacion;
                SqlComando.Parameters.Add(Parnohabitacion);

                //    //Ejecutamos nuestro comando

                rpta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlConexion.State == ConnectionState.Open) SqlConexion.Close();
            }
            return rpta;
        }
        public string InsertarHabitacion(DHabitacion Habitacion)
        {
            string rpta = "";
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                //Código
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlConexion.Open();
                //Establecer el Comando
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "InsertarHabitacion";
                SqlComando.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter Parnohabitacion = new SqlParameter();
                Parnohabitacion.ParameterName = "@nohabitacion";
                Parnohabitacion.SqlDbType = SqlDbType.Int;
                Parnohabitacion.Value = Habitacion.nohabitacion;
                SqlComando.Parameters.Add(Parnohabitacion);

                SqlParameter Parcodtipo = new SqlParameter();
                Parcodtipo.ParameterName = "@codtipo";
                Parcodtipo.SqlDbType = SqlDbType.Int;
                Parcodtipo.Value = Habitacion.codigotipo;
                SqlComando.Parameters.Add(Parcodtipo);

                SqlParameter Pardescripcion = new SqlParameter();
                Pardescripcion.ParameterName = "@descripcion";
                Pardescripcion.SqlDbType = SqlDbType.VarChar;
                Pardescripcion.Size = 50;
                Pardescripcion.Value = Habitacion.descripcion;
                SqlComando.Parameters.Add(Pardescripcion);

                SqlParameter Parcapacidad = new SqlParameter();
                Parcapacidad.ParameterName = "@capacidad";
                Parcapacidad.SqlDbType = SqlDbType.Int;
                Parcapacidad.Value = Habitacion.capacidad;
                SqlComando.Parameters.Add(Parcapacidad);

                SqlParameter Parestado = new SqlParameter();
                Parestado.ParameterName = "@estado";
                Parestado.SqlDbType = SqlDbType.VarChar;
                Parestado.Size = 20;
                Parestado.Value = Habitacion.estado;
                SqlComando.Parameters.Add(Parestado);

                //Ejecutamos nuestro comando

                rpta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlConexion.State == ConnectionState.Open) SqlConexion.Close();
            }
            return rpta;

        }

        public string EditarHabitacion(DHabitacion Habitacion)
        {
            string rpta = "";
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "EditarHabitacion";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter Parnohabitacion = new SqlParameter();
                Parnohabitacion.ParameterName = "@idhabitacion";
                Parnohabitacion.SqlDbType = SqlDbType.Int;
                Parnohabitacion.Value = Habitacion.nohabitacion;
                SqlComando.Parameters.Add(Parnohabitacion);

                SqlParameter Parcodtipo = new SqlParameter();
                Parcodtipo.ParameterName = "@nuevotipo";
                Parcodtipo.SqlDbType = SqlDbType.Int;
                Parcodtipo.Value = Habitacion.codigotipo;
                SqlComando.Parameters.Add(Parcodtipo);

                SqlParameter Pardescripcion = new SqlParameter();
                Pardescripcion.ParameterName = "@nuevodescripcion";
                Pardescripcion.SqlDbType = SqlDbType.VarChar;
                Pardescripcion.Size = 50;
                Pardescripcion.Value = Habitacion.descripcion;
                SqlComando.Parameters.Add(Pardescripcion);

                SqlParameter Parcapacidad = new SqlParameter();
                Parcapacidad.ParameterName = "@nuevocapacidad";
                Parcapacidad.SqlDbType = SqlDbType.Int;
                Parcapacidad.Value = Habitacion.capacidad;
                SqlComando.Parameters.Add(Parcapacidad);

                SqlParameter Parestado = new SqlParameter();
                Parestado.ParameterName = "@nuevoestado";
                Parestado.SqlDbType = SqlDbType.VarChar;
                Parestado.Size = 20;
                Parestado.Value = Habitacion.estado;
                SqlComando.Parameters.Add(Parestado);


                //    //Ejecutamos nuestro comando

                rpta = SqlComando.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlConexion.State == ConnectionState.Open) SqlConexion.Close();
            }
            return rpta;
        }


        public DataTable MostrarTablaHabitacion()
        {
            DataTable DtResultado = new DataTable("habitacion");
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "MostrarHabitacion";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlComando);
                SqlData.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable BuscarHabitacion(string dato)
        {
            DataTable DtResultado = new DataTable("Habitacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarHabitacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 50;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine(ex.Message);
            }
            return DtResultado;

        }

        public DataTable MostrarPrecioHabitacion(int idHabit)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "mostrarPrecioHabit";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabit", SqlDbType.Int);
                parameter.Value = idHabit;
                SqlComando.Parameters.Add(parameter);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlComando);
                SqlData.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DtResultado = null;
            }
            return DtResultado;

        }

        public int MostrarCodTipoHabitacion(int idHabit)
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "mostrarCodTipoHabit";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@idHabit", SqlDbType.Int);
                parameter.Value = idHabit;
                SqlComando.Parameters.Add(parameter);

                SqlDataAdapter SqlData = new SqlDataAdapter(SqlComando);
                SqlData.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DtResultado = null;
            }
            return Convert.ToInt32(DtResultado.Rows[0][0].ToString());

        }

    }
}
