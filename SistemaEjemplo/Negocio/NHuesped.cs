using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NHuesped
    {

        public static string Insertar(string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string nacionalidad)
        {
            DHuesped Obj = new DHuesped();
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Nacionalidad = nacionalidad;
            return Obj.Insertar(Obj);
        }

        public static string Editar(int idHuesped, string p_nombre, string s_nombre, string p_apellido, string s_apellido, string direccion, string telefono, string correo, string nacionalidad)
        {

            DHuesped Obj = new DHuesped();
            Obj.Id_cliente = idHuesped;
            Obj.P_nombre = p_nombre;
            Obj.S_nombre = s_nombre;
            Obj.P_apellido = p_apellido;
            Obj.S_apellido = s_apellido;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Correo = correo;
            Obj.Nacionalidad = nacionalidad;
            return Obj.Editar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DHuesped().Mostrar();
        }

        public static DataTable BuscarAsegurado(string dato)
        {
            return new DHuesped().Buscar_Registro_Huesped(dato);
        }

    }
}
