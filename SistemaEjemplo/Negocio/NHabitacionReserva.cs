using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NHabitacionReserva
    {
        public static DataTable MostrarHabitaciones(int idReserva)
        {
            return new DHabitacionReserva().MostrarHabitacionReserva(idReserva);
        }
        public static string Borrar(int idHabitReserva)
        {
            return new DHabitacionReserva().Borrar(idHabitReserva);
        }
        public static string Agregar(DHabitacionReserva habitacionReserva)
        {
            return new DHabitacionReserva().Agregar(habitacionReserva);
        }
    }
}
