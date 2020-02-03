using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NEmpleado
    {
        public static DataTable MostrarTablaEmpleado()
        {
            return new DEmpleado().MostrarTablaEmpleado();
        }

        public static string InsertarEmpleado(string pnombre, string snombre, string papellido, string sapellido, string direccion, string telefono, string correo)
        {
            DEmpleado datosempleado = new DEmpleado(pnombre, snombre, papellido, sapellido, direccion, telefono, correo);
            return datosempleado.InsertarEmpleado(datosempleado);
        }

        public static string EditarEmpleado(int ID, string pnombre, string snombre, string papellido, string sapellido, string direccion, string telefono, string correo)
        {
            DEmpleado datosempleado = new DEmpleado(ID, pnombre, snombre, papellido, sapellido, direccion, telefono, correo);
            return datosempleado.EditarEmpleado(datosempleado);
        }

        internal static DataTable BuscarHabitacion(string dato)
        {
            return new DEmpleado().BuscarEmpleado(dato);
        }

        internal static string EliminarEmpleado(int ID)
        {
            return new DEmpleado().EliminarEmpleado(ID);
        }
        public static DataTable ObtenerIdEmpleado(string usuario)
        {
            return new DEmpleado().obtenerIdEmpleado(usuario);
        }
    }
}
