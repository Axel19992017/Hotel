using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Datos
{
    class DUsuario
    {
        private string usuario;
        private string pass;
        private string rol;
        private int idEmpleado;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Rol { get => rol; set => rol = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public DUsuario(string usuario, string pass, string rol, int idEmpleado)
        {
            this.usuario = usuario;
            this.pass = pass;
            this.rol = rol;
            this.idEmpleado = idEmpleado;
        }

        public DUsuario()
        {
        }

        public DataTable ValidarPass(string usuario, string pass)
        {
            DataTable res = new DataTable("Resultado");
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "validarPass";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@usuario",SqlDbType.VarChar,50);
                parameter.Value = usuario;
                command.Parameters.Add(parameter);

                parameter = new SqlParameter("@pass", SqlDbType.VarChar, 50);
                parameter.Value = pass;
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

        public string Agregar(DUsuario usuario)
        {
            string respuesta = "";
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = Conexión.Cn;
            sql.Open();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sql;
                command.CommandText = "addUsuario";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter pUsuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 50);
                pUsuario.Value = usuario.Usuario;
                command.Parameters.Add(pUsuario);

                SqlParameter pPasss = new SqlParameter("@pass", SqlDbType.NVarChar, 50);
                pPasss.Value = usuario.Pass;
                command.Parameters.Add(pPasss);

                SqlParameter pRol = new SqlParameter("@rol", SqlDbType.NVarChar, 50);
                pRol.Value = usuario.Rol;
                command.Parameters.Add(pRol);

                SqlParameter pIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                pIdEmpleado.Value = usuario.IdEmpleado;
                command.Parameters.Add(pIdEmpleado);

                respuesta = command.ExecuteNonQuery() == 1 ? "Usuario Agregado" : "Error al agregar Usuario";
            }
            catch (Exception e)
            {
                respuesta = e.Message;
                Console.WriteLine(e.Message);
            }
            sql.Close();
            return respuesta;

        }

        public string Borrar(string usuario)
        {
            string respuesta = "";
            SqlConnection sql = new SqlConnection();
            sql.ConnectionString = Conexión.Cn;
            sql.Open();
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = sql;
                command.CommandText = "borrarUsuario";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter pUsuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 50);
                pUsuario.Value = usuario;
                command.Parameters.Add(pUsuario);


                respuesta = command.ExecuteNonQuery() == 1 ? "Usuario Eliminado" : "Error al eliminar usuario";
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
            DataTable table = new DataTable("Usuario");
            SqlConnection sql = new SqlConnection();
            try
            {
                sql.ConnectionString = Conexión.Cn;
                SqlCommand command = new SqlCommand
                {
                    Connection = sql,
                    CommandText = "mostrarUsuario",
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                table = null;
                Console.WriteLine(e.Message);

            }
            return table;
        }
    }
}
