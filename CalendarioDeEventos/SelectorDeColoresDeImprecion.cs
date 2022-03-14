using System;


namespace CalendarioDeEventos
{
    internal class SelectorDeColoresDeImprecion : ISelectorDeColoresDeImprecion
    {

        private const ConsoleColor ColorOcurrido = ConsoleColor.Red;
        private const ConsoleColor ColorOcurrira = ConsoleColor.White;
        private readonly DateTime FechadeAhora = DateTime.Now;
        public ConsoleColor Definircolor (DateTime FechasDeLosEventos)
        {

            return FechasDeLosEventos < FechadeAhora ? ColorOcurrido : ColorOcurrira;

        }

    }
}
