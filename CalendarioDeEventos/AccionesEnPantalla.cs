using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CalendarioDeEventos
{
    internal class AccionesEnPantalla
    {
       

        AccionesFechas acctionfechas = new AccionesFechas();
        SelectorDeColores SelectorDeColores = new SelectorDeColores();
        MomentoEnElTiempo momento = new MomentoEnElTiempo();

        public void ImprecionesAPantalla(string[] NombreEventos , DateTime[] FechasEventos) {

            for (int i = 0; i < NombreEventos.Length; i++) {

                if (NombreEventos[i] != null)
                {
                    Console.ForegroundColor = SelectorDeColores.Definircolor(FechasEventos[i]);
                    Console.WriteLine(NombreEventos[i]+ " " + momento.Momentoocurrido(FechasEventos[i])+
                        momento.DiasRestantesyFaltantes(FechasEventos[i]));
                }
            }
        
        
        }
    }
}
