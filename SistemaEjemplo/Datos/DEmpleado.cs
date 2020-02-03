using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DEmpleado
    {
        private int ID;
        private String pnombre;
        private String snombre;
        private String papellido;
        private String sapellido;
        private String direccion;
        private String telefono;
        private String correo;

        public DEmpleado() { }
        public DEmpleado(string pnombre, string snombre, string papellido, string sapellido, string direccion, string telefono, string correo)
        {
            this.pnombre = pnombre;
            this.snombre = snombre;
            this.papellido = papellido;
            this.sapellido = sapellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public DEmpleado(int ID,string pnombre, string snombre, string papellido, string sapellido, string direccion, string telefono, string correo)
        {
            this.ID = ID;
            this.pnombre = pnombre;
            this.snombre = snombre;
            this.papellido = papellido;
            this.sapellido = sapellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        internal string EliminarEmpleado(int iD)
        {
            string rpta = "";
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "EliminarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID= new SqlParameter();
                ParID.ParameterName = "@ID";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = iD;
                SqlComando.Parameters.Add(ParID);

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

        internal DataTable BuscarEmpleado(string dato)
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarEmpleado";
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
                Console.WriteLine(ex.Message);
                DtResultado = null;
            }
            return DtResultado;
        }

        public string Pnombre { get => pnombre; set => pnombre = value; }
        public string Snombre { get => snombre; set => snombre = value; }
        public string Papellido { get => papellido; set => papellido = value; }
        public string Sapellido { get => sapellido; set => sapellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public int ID1 { get => ID; set => ID = value; }

        public DataTable MostrarTablaEmpleado()
        {
            DataTable DtResultado = new DataTable("empleado");
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "MostrarEmpleado";
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

        public string InsertarEmpleado(DEmpleado Empleado)
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
                SqlComando.CommandText = "InsertarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter Parpnombre = new SqlParameter();
                Parpnombre.ParameterName = "@pnombre";
                Parpnombre.SqlDbType = SqlDbType.VarChar;
                Parpnombre.Size = 15;
                Parpnombre.Value = Empleado.pnombre;
                SqlComando.Parameters.Add(Parpnombre);

                SqlParameter Parsnombre = new SqlParameter();
                Parsnombre.ParameterName = "@snombre";
                Parsnombre.SqlDbType = SqlDbType.VarChar;
                Parsnombre.Size = 15;
                Parsnombre.Value = Empleado.snombre;
                SqlComando.Parameters.Add(Parsnombre);

                SqlParameter Parpapellido = new SqlParameter();
                Parpapellido.ParameterName = "@papellido";
                Parpapellido.SqlDbType = SqlDbType.VarChar;
                Parpapellido.Size = 15;
                Parpapellido.Value = Empleado.papellido;
                SqlComando.Parameters.Add(Parpapellido);

                SqlParameter Parsapellido = new SqlParameter();
                Parsapellido.ParameterName = "@sapellido";
                Parsapellido.SqlDbType = SqlDbType.VarChar;
                Parsapellido.Size = 15;
                Parsapellido.Value = Empleado.sapellido;
                SqlComando.Parameters.Add(Parsapellido);

                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 70;
                Pardireccion.Value = Empleado.direccion;
                SqlComando.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 10;
                Partelefono.Value = Empleado.telefono;
                SqlComando.Parameters.Add(Partelefono);

                SqlParameter Parcorreo = new SqlParameter();
                Parcorreo.ParameterName = "@correo";
                Parcorreo.SqlDbType = SqlDbType.VarChar;
                Parcorreo.Size = 25;
                Parcorreo.Value = Empleado.correo;
                SqlComando.Parameters.Add(Parcorreo);

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

        public string EditarEmpleado(DEmpleado Empleado)
        {
            string rpta = "";
            SqlConnection SqlConexion = new SqlConnection();
            try
            {
                SqlConexion.ConnectionString = Conexión.Cn;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "EditarEmpleado";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@idempleado";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = Empleado.ID;
                SqlComando.Parameters.Add(ParID);

                SqlParameter Parpnombre = new SqlParameter();
                Parpnombre.ParameterName = "@pnombre";
                Parpnombre.SqlDbType = SqlDbType.VarChar;
                Parpnombre.Size = 15;
                Parpnombre.Value = Empleado.pnombre;
                SqlComando.Parameters.Add(Parpnombre);

                SqlParameter Parsnombre = new SqlParameter();
                Parsnombre.ParameterName = "@snombre";
                Parsnombre.SqlDbType = SqlDbType.VarChar;
                Parsnombre.Size = 15;
                Parsnombre.Value = Empleado.snombre;
                SqlComando.Parameters.Add(Parsnombre);

                SqlParameter Parpapellido = new SqlParameter();
                Parpapellido.ParameterName = "@papellido";
                Parpapellido.SqlDbType = SqlDbType.VarChar;
                Parpapellido.Size = 15;
                Parpapellido.Value = Empleado.papellido;
                SqlComando.Parameters.Add(Parpapellido);

                SqlParameter Parsapellido = new SqlParameter();
                Parsapellido.ParameterName = "@sapellido";
                Parsapellido.SqlDbType = SqlDbType.VarChar;
                Parsapellido.Size = 15;
                Parsapellido.Value = Empleado.sapellido;
                SqlComando.Parameters.Add(Parsapellido);

                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 70;
                Pardireccion.Value = Empleado.direccion;
                SqlComando.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 10;
                Partelefono.Value = Empleado.telefono;
                SqlComando.Parameters.Add(Partelefono);

                SqlParameter Parcorreo = new SqlParameter();
                Parcorreo.ParameterName = "@correo";
                Parcorreo.SqlDbType = SqlDbType.VarChar;
                Parcorreo.Size = 25;
                Parcorreo.Value = Empleado.correo;
                SqlComando.Parameters.Add(Parcorreo);


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

        public DataTable obtenerIdEmpleado(string usuario)
        {
            DataTable res = new DataTable();
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "obtenerEmpleado";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@usuario", SqlDbType.NVarChar, 25);
                parameter.Value = usuario;
                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }



    }
}
