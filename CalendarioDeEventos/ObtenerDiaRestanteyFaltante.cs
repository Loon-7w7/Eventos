using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class ObtenerDiaRestanteyFaltante : IObtenerDiaRestanteyFaltante
    {
        ConvertirdorDeArryStringAArrayDateTime acctionfechas = new ConvertirdorDeArryStringAArrayDateTime();
        private readonly DateTime FechaEnEstosMomentos = DateTime.Now;
        public string ObtenerDiasRestantesyFaltantes(DateTime FechasDeLosEventos)
        {

            var DiasFT = FechaEnEstosMomentos - FechasDeLosEventos;
            string Devolucion;
            if (FechasDeLosEventos > FechaEnEstosMomentos)
            {
                DiasFT = FechasDeLosEventos - FechaEnEstosMomentos;

            }
            

            int minutos = (int)DiasFT.TotalMinutes;

            Devolucion = acctionfechas.Convertidorgeneral(minutos);
            return Devolucion;
        }



       

    }
}
