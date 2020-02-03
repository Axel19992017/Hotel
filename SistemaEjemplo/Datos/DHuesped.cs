using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DHuesped
    {
        private int idHuesped;
        private String p_nombre;
        private String s_nombre;
        private String p_apellido;
        private String s_apellido;
        private String direccion;
        private String telefono;
        private String correo;
        private String nacionalidad;

        public int Id_cliente { get => idHuesped; set => idHuesped = value; }
        public string P_nombre { get => p_nombre; set => p_nombre = value; }
        public string S_nombre { get => s_nombre; set => s_nombre = value; }
        public string P_apellido { get => p_apellido; set => p_apellido = value; }
        public string S_apellido { get => s_apellido; set => s_apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }

        public DHuesped(int idHuesped, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string nacionalidad)
        {
            this.idHuesped = idHuesped;
            this.p_nombre = p_nombre;
            this.s_nombre = s_nombre;
            this.p_apellido = p_apellido;
            this.s_apellido = s_apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.nacionalidad = nacionalidad;
        }

        public DHuesped(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string nacionalidad)
        {
            this.p_nombre = p_nombre;
            this.s_nombre = s_nombre;
            this.p_apellido = p_apellido;
            this.s_apellido = s_apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.nacionalidad = nacionalidad;
        }

        public DHuesped()
        {
        }
        public string Insertar(DHuesped huesped)
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
                SqlCmd.CommandText = "Insertar_Huesped";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = huesped.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = huesped.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = huesped.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = huesped.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = huesped.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 40;
                ParCorreo.Value = huesped.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = huesped.telefono;
                SqlCmd.Parameters.Add(ParTelefono);


                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@nacionalidad";
                ParNacionalidad.SqlDbType = SqlDbType.VarChar;
                ParNacionalidad.Size = 60;
                ParNacionalidad.Value = huesped.Correo;
                SqlCmd.Parameters.Add(ParNacionalidad);
                
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
        public string Editar(DHuesped huesped)
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
                SqlCmd.CommandText = "Editar_Huesped";
                SqlCmd.CommandType = CommandType.StoredProcedure;//Se Puede ingredar una tabla una lista no solamente un procedimiento almacenado

                SqlParameter ParidCliente = new SqlParameter();
                ParidCliente.ParameterName = "@idhuesped";
                ParidCliente.SqlDbType = SqlDbType.Int;
                //  ParidCliente.Size = 60;
                ParidCliente.Value = huesped.Id_cliente;
                SqlCmd.Parameters.Add(ParidCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@primernombre";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = huesped.P_nombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@segundonombre";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 60;
                ParSegundoNombre.Value = huesped.S_nombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@primerapellido";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 60;
                ParPrimerApellido.Value = huesped.P_apellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@segundoapellido";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 60;
                ParSegundoApellido.Value = huesped.S_apellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParDirección = new SqlParameter();
                ParDirección.ParameterName = "@direccion";
                ParDirección.SqlDbType = SqlDbType.VarChar;
                ParDirección.Size = 100;
                ParDirección.Value = huesped.Direccion;
                SqlCmd.Parameters.Add(ParDirección);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 40;
                ParCorreo.Value = huesped.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Value = huesped.telefono;
                SqlCmd.Parameters.Add(ParTelefono);


                SqlParameter ParNacionalidad = new SqlParameter();
                ParNacionalidad.ParameterName = "@nacionalidad";
                ParNacionalidad.SqlDbType = SqlDbType.VarChar;
                ParNacionalidad.Size = 60;
                ParNacionalidad.Value = huesped.Correo;
                SqlCmd.Parameters.Add(ParNacionalidad);


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
            DataTable DtResultado = new DataTable("huesped");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Huesped";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                DtResultado = null;
            }
            return DtResultado;

        }
        public DataTable Buscar_Registro_Huesped(string dato)
        {
            DataTable DtResultado = new DataTable("huesped");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Buscar_Registro_Huesped";
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
                Console.WriteLine(ex.Message);
                DtResultado = null;
            }
            return DtResultado;

        }


    }
}
