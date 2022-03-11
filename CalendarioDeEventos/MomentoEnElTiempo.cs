using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CalendarioDeEventos
{
    internal class MomentoEnElTiempo
    {

        //private IConfiguration configuration;
        //public MomentoEnElTiempo(IConfiguration configuration) {
        
        //    this.configuration = configuration;
        //}

        ConvercionesDeFechas acctionfechas = new ConvercionesDeFechas();
        public string DiasRestantesyFaltantes(DateTime FechasDeLosEventos)
        {

            var DiasFT = DateTime.Now - FechasDeLosEventos;
            string Devolucion;
            if (FechasDeLosEventos < DateTime.Now)
            {


            }
            else
            {

                DiasFT = FechasDeLosEventos - DateTime.Now;


            }


            int minutos = (int)DiasFT.TotalMinutes;


            Devolucion = acctionfechas.Convertidorgeneral(minutos);
            return Devolucion;
        }



        public string Momentoocurrido(DateTime FechasDeLosEventos)
        {

            if (FechasDeLosEventos < DateTime.Now)
            {


                return "Ocurrio hace: ";
            }
            else
            {



                return "Ocurrira En: ";
            }

        }

    }
}
