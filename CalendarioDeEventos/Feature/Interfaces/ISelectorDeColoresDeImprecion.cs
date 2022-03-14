using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal interface ISelectorDeColoresDeImprecion
    {
        ConsoleColor Definircolor(DateTime FechasDeLosEventos);
    }
}
