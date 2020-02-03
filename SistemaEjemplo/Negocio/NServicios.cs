using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NServicios
    {
        public static string Insertar(DServicio servicio)
        {
            return new DServicio().Insertar(servicio);
        }
        public static DataTable Mostrar()
        {
            return new DServicio().Mostrar();
        }
        public static string Editar(DServicio servicio)
        {
            return new DServicio().Editar(servicio);
        }
        public static DataTable Buscar(string dato)
        {
            return new DServicio().Buscar(dato);
        }
        public static double MostrarPrecio(int ServicioId)
        {
            return new DServicio().MostrarPrecio(ServicioId);
        }
    }
}
