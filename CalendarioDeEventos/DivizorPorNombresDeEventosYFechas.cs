using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class DivizorPorNombresDeEventosYFechas:DividirNombresDeEnevtosYFechas
    {
        private const string Fechas = "Fechas";
        private const string NombresEventos = "Nombres";
        public string[] FechasDelEventos(string[] LienasFichero) {

            string[] FechaPorEvento = new string[LienasFichero.Length];

            for (int i = 0; i < LienasFichero.Length; i++) {

                if (LienasFichero[i] != null)
                {

                    FechaPorEvento[i] = DivisoSplit(LienasFichero[i], Fechas);
                }
                else {

                    return FechaPorEvento;
                }

            }

            return FechaPorEvento;
        }

        public string[] NombresDeLosEventos(string[] LienasFichero)
        {

            string[] NombresPorEvento = new string[LienasFichero.Length];

            for (int i = 0; i < LienasFichero.Length; i++)
            {

                if (LienasFichero[i] != null)
                {

                    NombresPorEvento[i] = DivisoSplit(LienasFichero[i], NombresEventos) ;
                }
                else
                {

                    return NombresPorEvento;
                }

            }

            return NombresPorEvento;
        }


        private string DivisoSplit(string CanedaDivisora, string ClaseDatos) {

            string Devolucion = "";
            string[] divicion;

            switch (ClaseDatos) {

                case "Fechas":
                    divicion = CanedaDivisora.Split(',');
                    Devolucion = divicion[1].ToString();
                break;
                case "Nombres":
                    divicion = CanedaDivisora.Split(',');
                    Devolucion = divicion[0].ToString();
                    break;    
            }
            return Devolucion;


        }


    }
}
