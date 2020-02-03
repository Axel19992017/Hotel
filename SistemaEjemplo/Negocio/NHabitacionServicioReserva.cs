using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NHabitacionServicioReserva
    {
        public static DataTable MostrarServiciosHabitacion(int idHabitReserva)
        {
            return new DHabitacionServicioReserva().MostrarServiciosHabitReserva(idHabitReserva);
        }
        public static string Agregar(DHabitacionServicioReserva habitacionServicioReserva)
        {
            return new DHabitacionServicioReserva().Agregar(habitacionServicioReserva);
        }
        public static string Borrar(DHabitacionServicioReserva habitacionServicioReserva)
        {
            return new DHabitacionServicioReserva().Borrar(habitacionServicioReserva);
        }
        public static DataTable MostrarServicHabitReserDispon(int idHabitReserva)
        {
            return new DHabitacionServicioReserva().MostrarServicHabitReserDispon(idHabitReserva);
        }
    }
}
