using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal interface IConvercionesDeFechas
    {
        DateTime[] StringaFchasConvercion(string[] StringsFechas);
        string Convertidorgeneral(int Convertido);
    }
}
