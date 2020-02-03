using SistemaEjemplo.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEjemplo.Negocio
{
    class NUsuario
    {
        public static DataTable ValidarPass(string usuario,string pass)
        {
            return new DUsuario().ValidarPass(usuario, pass);
        }
        public static string Agregar(DUsuario usuario)
        {
            return new DUsuario().Agregar(usuario);
        }
        public static string Borrar(string usuario)
        {
            return new DUsuario().Borrar(usuario);
        }

        public static DataTable Mostrar()
        {
            return new DUsuario().Mostrar();
        }
    }
}
