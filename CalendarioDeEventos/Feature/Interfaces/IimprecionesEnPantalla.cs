using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal interface IimprecionesEnPantalla
    {
        void ImprecionesAPantalla(string[] NombreEventos, DateTime[] FechasEventos);
    }
}
