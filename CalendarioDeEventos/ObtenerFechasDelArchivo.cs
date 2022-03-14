using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class ObtenerFechasDelArchivo : IObtenerFechasDelArchivo
    {
        DivisorDeCadenasConSplit DividirConSplit = new DivisorDeCadenasConSplit();

        private const string StringFechas = "Fechas";
        public string[] ObtenerFechasDeArchivo(string[] LienasFichero) {

            string[] FechaPorEvento = new string[LienasFichero.Length];

            for (int i = 0; i < LienasFichero.Length; i++) {

                if (LienasFichero[i] != null)
                {

                    FechaPorEvento[i] = DividirCaderna(LienasFichero[i]);
                }
                else {

                    return FechaPorEvento;
                }

            }

            return FechaPorEvento;
        }


        private string DividirCaderna (string LienasFichero) 
        {
            return DividirConSplit.DividirCadenaConSplit(LienasFichero, StringFechas);
        }

    }
}
