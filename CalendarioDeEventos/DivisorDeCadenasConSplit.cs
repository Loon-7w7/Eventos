using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class DivisorDeCadenasConSplit : IDivisorDeCadenasConSplit
    {
        private const string IdentificarFechas = "Fechas";
        private const string IdentificarNombres = "Nombres";
        private const char Separador = ',';
        public string DividirCadenaConSplit (string CanedaDivisora, string ClaseDatos)
        {

            string Devolucion = "";
            string[] CadenasCeparadas;

            switch (ClaseDatos)
            {

                case IdentificarFechas:
                    CadenasCeparadas = CanedaDivisora.Split(Separador);
                    Devolucion = CadenasCeparadas[1].ToString();
                    break;
                case IdentificarNombres:
                    CadenasCeparadas = CanedaDivisora.Split(Separador);
                    Devolucion = CadenasCeparadas[0].ToString();
                    break;
            }
            return Devolucion;


        }
    }
}
