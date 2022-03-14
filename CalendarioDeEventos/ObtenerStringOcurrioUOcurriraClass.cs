using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class ObtenerStringOcurrioUOcurriraClass : IObtenerStringOcurrioUOcurrirainter
    {
        private const string StringOcurrio = " Ocurrio hace: ";
        private const string StringOcurrira = " Ocurrira En: ";
        private DateTime FechaEnEstosMomentos = DateTime.Now;
        public string ObtenerStringOcurrioUOcurrira(DateTime FechasDeLosEventos)
        {

            return FechasDeLosEventos < FechaEnEstosMomentos ? StringOcurrio : StringOcurrira;

        }
    }
}
