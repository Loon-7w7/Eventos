using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal interface ILecturaDeFicheros
    {
        string[] LecturaDelFichero(string NombreFichero);
    }
}
