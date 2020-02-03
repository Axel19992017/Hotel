using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NHabitacion
    {
        public static string EliminarHabitacion(int nohabitacion)
        {
            return new DHabitacion().EliminarHabitacion(nohabitacion);
        }

        public static DataTable BuscarHabitacion(string dato)
        {
            return new DHabitacion().BuscarHabitacion(dato);
        }

        public static string InsertarHabitacion(int nohabitacion,int codigotipo,string descripcion,int capacidad,string estado)
        {
            DHabitacion datoshabitacion = new DHabitacion(nohabitacion,codigotipo,descripcion,capacidad,estado);
            return datoshabitacion.InsertarHabitacion(datoshabitacion);
        }

        public static string EditarHabitacion(int nohabitacion, int codigotipo, string descripcion, int capacidad, string estado)
        {

            DHabitacion datoshabitacion = new DHabitacion(nohabitacion, codigotipo, descripcion, capacidad, estado);
            return datoshabitacion.EditarHabitacion(datoshabitacion);
        }

        public static DataTable MostrarTablaHabitacion()
        {
            return new DHabitacion().MostrarTablaHabitacion();
        }
        public static DataTable MostrarPrecioHabitacion(int idHabit)
        {
            return new DHabitacion().MostrarPrecioHabitacion(idHabit);
        }

        public static int MostrarCodTipoHabitacion(int idHabit)
        {
            return new DHabitacion().MostrarCodTipoHabitacion(idHabit);
        }
    }
}
