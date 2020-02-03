using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaEjemplo.Datos
{
    class DCliente
    {
        // Variables de Clase

        private int id_cliente;
        private String p_nombre;
        private String s_nombre;
        private String p_apellido;
        private String s_apellido;
        private String direccion;
        private String telefono;
        private String correo;

        public string P_nombre
        {
            get
            {
                return p_nombre;
            }

            set
            {
                p_nombre = value;
            }
        }

        public string S_nombre
        {
            get
            {
                return s_nombre;
            }

            set
            {
                s_nombre = value;
            }
        }

        public string P_apellido
        {
            get
            {
                return p_apellido;
            }

            set
            {
                p_apellido = value;
            }
        }

        public string S_apellido
        {
            get
            {
                return s_apellido;
            }

            set
            {
                s_apellido = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public String Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public int Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
            }
        }

        public DCliente(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            this.p_nombre = p_nombre;
            this.s_nombre = s_nombre;
            this.p_apellido = p_apellido;
            this.s_apellido = s_apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }



        public DCliente()
        { }




        public string Insertar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Insertar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = Cliente.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = Cliente.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = Cliente.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = Cliente.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = Cliente.telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método Editar
        public string Editar(DCliente Cliente)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Editar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;//Se Puede ingredar una tabla una lista no solamente un procedimiento almacenado

                SqlParameter ParidCliente = new SqlParameter();
                ParidCliente.ParameterName = "@idcliente";
                ParidCliente.SqlDbType = SqlDbType.Int;
                //  ParidCliente.Size = 60;
                ParidCliente.Value = Cliente.Id_cliente;
                SqlCmd.Parameters.Add(ParidCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = Cliente.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = Cliente.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = Cliente.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = Cliente.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = Cliente.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = Cliente.telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 60;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);


                //    //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Actualizo el Registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }


        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine(ex.Message);
            }
            return DtResultado;

        }
        public DataTable BuscarAsegurado(string dato)
        {
            DataTable DtResultado = new DataTable("Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Registro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 60;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine(ex.Message);

            }
            return DtResultado;

        }

        public string cambiarEstado(int idCliente)
        {
            DataTable DtResultado = new DataTable("Respuesta");
            string res = null;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Conexión.Cn;
            sqlConnection.Open();
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "changeStateCustomers";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter ParidCliente = new SqlParameter();
                ParidCliente.ParameterName = "@idCliente";
                ParidCliente.SqlDbType = SqlDbType.Int;
                ParidCliente.Value = idCliente;
                command.Parameters.Add(ParidCliente);
                SqlDataAdapter SqlDat = new SqlDataAdapter(command);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception e)
            {
                res = e.Message;
            }
            finally
            {
                sqlConnection.Close();
            }
            return (string) DtResultado.Rows[0][0];
        }
        public DataTable MostrarCorto()
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrarClientesCorto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
                Console.WriteLine(ex.Message);
            }
            return DtResultado;

        }
    }

}
