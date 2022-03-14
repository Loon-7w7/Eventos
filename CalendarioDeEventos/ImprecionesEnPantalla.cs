using System;
using CalendarioDeEventos.Feature.Interfaces;

namespace CalendarioDeEventos
{
    internal class ImprecionesEnPantalla : IImprecionesEnPantalla
    {


        ConvertirdorDeArryStringAArrayDateTime convertarrystringADatetime = new ConvertirdorDeArryStringAArrayDateTime();
        SelectorDeColoresDeImprecion SelectorDeColores = new SelectorDeColoresDeImprecion();
        ObtenerDiaRestanteyFaltante Diasrestantesfaltantes = new ObtenerDiaRestanteyFaltante();
        ObtenerStringOcurrioUOcurriraClass StringOcurrio_riara = new ObtenerStringOcurrioUOcurriraClass();

        public void ImprecionesAPantalla(string[] NombreEventos, DateTime[] FechasEventos)
        {

            for (int i = 0; i < NombreEventos.Length; i++) {

                if (NombreEventos[i] != null)
                {
                    ContructorDelmesnaje(NombreEventos[i], FechasEventos[i]);
                }
            }
        
        
        }

        private void ContructorDelmesnaje(string NombreEventos, DateTime FechasEventos) {

            Console.ForegroundColor = ObtenerConsoleColor(FechasEventos);

            Console.WriteLine(NombreEventos + ObtenerOcurrenciadelEvento(FechasEventos) +
                ObtenerDiasRestantesOFaltamtes(FechasEventos));

        }


        private ConsoleColor ObtenerConsoleColor(DateTime FechasEventos)
        {
            return SelectorDeColores.Definircolor(FechasEventos);
        }

        private string ObtenerOcurrenciadelEvento(DateTime FechasEventos)
        {
            return StringOcurrio_riara.ObtenerStringOcurrioUOcurrira(FechasEventos);
        }

        private string ObtenerDiasRestantesOFaltamtes(DateTime FechasEventos)
        {
            return Diasrestantesfaltantes.ObtenerDiasRestantesyFaltantes(FechasEventos);
        }
    }
}
