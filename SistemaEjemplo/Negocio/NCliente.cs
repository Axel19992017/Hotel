using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEjemplo.Datos;
using System.Data;

namespace SistemaEjemplo.Negocio
{
    class NCliente
    {

        public static string Insertar(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {
            DCliente Obj = new DCliente();
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Insertar(Obj);
        }
        //Método Editar que llama al método Editar de la clase DPersonal
        //de la CapaDatos
        public static string Editar( int idcliente, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo)
        {

            DCliente Obj = new DCliente();
            Obj.Id_cliente = idcliente;
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        public static DataTable BuscarAsegurado(string dato)
        {
            return new DCliente().BuscarAsegurado(dato);
        }

        public static string CambiarEstado(int idCliente)
        {
            return new DCliente().cambiarEstado(idCliente);
        }

        public static DataTable MostrarCorto()
        {
            return new DCliente().MostrarCorto();
        }

    }
}
