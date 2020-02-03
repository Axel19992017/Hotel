using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NOperaciones
    {
        public static DataTable DisponibilidadHabitConid(int idHabit, string fechaEntrada, string fechaSalida)
        {
            return new DOperaciones().DisponibilidadHabitConid(idHabit, fechaEntrada, fechaSalida);
        }
        public static DataTable DisponibilidadHabit(string fechaEntrada, string fechaSalida)
        {
            return new DOperaciones().DisponibilidadHabit(fechaEntrada, fechaSalida);
        }
        public static DataTable GetIdHabitaciones()
        {
            return new DOperaciones().GetIdHabitaciones();
        }
        public static DataTable Recaudaciones(int mes, int año)
        {
            return new DOperaciones().Recaudaciones(mes, año);
        }
        public static DataTable DisponibilidadHabitReserva(string fechaEntrada, string fechaSalida)
        {
            return new DOperaciones().DisponibilidadHabitReserva(fechaEntrada, fechaSalida);
        }
    }
}
