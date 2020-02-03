using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NReserva
    {
        public static DataTable Mostrar()
        {
            return new DReserva().Mostrar();
        }
        public static int GetIdReservaNueva()
        {
            return new DReserva().GetIdReservaNueva();
        }
        public static string Agregar(DReserva reserva)
        {
            return new DReserva().Agregar(reserva);
        }
    }
}
