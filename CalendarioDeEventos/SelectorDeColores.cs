using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalendarioDeEventos
{
    internal class SelectorDeColores
    {

        public ConsoleColor Definircolor (DateTime FechasDeLosEventos)
        {

            if (FechasDeLosEventos < DateTime.Now)
            {


                return ConsoleColor.Red;
            }
            else
            {



                return ConsoleColor.White;
            }

        }

    }
}
