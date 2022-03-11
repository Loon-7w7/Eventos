using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CalendarioDeEventos
{
    internal class ImprecionesEnPantalla:IimprecionesEnPantalla
    {
       

        ConvercionesDeFechas acctionfechas = new ConvercionesDeFechas();
        SelectorDeColores SelectorDeColores = new SelectorDeColores();
        MomentoEnElTiempo momento = new MomentoEnElTiempo();

        public void ImprecionesAPantalla(string[] NombreEventos , DateTime[] FechasEventos) {

            for (int i = 0; i < NombreEventos.Length; i++) {

                if (NombreEventos[i] != null)
                {
                    ContructorDelmesnaje(NombreEventos[i], FechasEventos[i]);
                }
            }
        
        
        }

        private void ContructorDelmesnaje(string NombreEventos, DateTime FechasEventos) {

            Console.ForegroundColor = SelectorDeColores.Definircolor(FechasEventos);
            Console.WriteLine(NombreEventos + " " + momento.Momentoocurrido(FechasEventos) +
                momento.DiasRestantesyFaltantes(FechasEventos));

        }
    }
}
