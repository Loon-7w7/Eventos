using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class ObtenerNombresDelArchivo
    {
        DivisorDeCadenasConSplit DividirConSplit = new DivisorDeCadenasConSplit();
        private const string stringNombresEventos = "Nombres";
        public string[] ObtenerNombreDeArchivo(string[] LienasFichero)
        {

            string[] NombresPorEvento = new string[LienasFichero.Length];

            for (int i = 0; i < LienasFichero.Length; i++)
            {

                if (LienasFichero[i] != null)
                {

                    NombresPorEvento[i] = DividirCaderna(LienasFichero[i]);
                }
                else
                {

                    return NombresPorEvento;
                }

            }

            return NombresPorEvento;
        }

        private string DividirCaderna(string LienasFichero)
        {
            return DividirConSplit.DividirCadenaConSplit(LienasFichero, stringNombresEventos);
        }
    }
}
