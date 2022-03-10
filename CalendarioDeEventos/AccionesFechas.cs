using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    internal class AccionesFechas
    {
        private string MHDM = " Minutos";
        private DateTime ConversionDeFechas(string stringFecha) {
            DateTime TipoDFechas = DateTime.Now;
            try {
                TipoDFechas = DateTime.ParseExact(stringFecha, "dd/MM/yyyy HH:mm", CultureInfo.CurrentCulture);
            }
            catch(FormatException) {
                Console.WriteLine("esto no es una fecha");
            }
            return TipoDFechas;

        }

        public DateTime[] FchasConvercion(string[] StringsFechas) {
        
            DateTime[] FechasDevolucion = new DateTime[StringsFechas.Length];
            for (int i = 0; i < StringsFechas.Length; i++) {
                if (StringsFechas[i] != null) {

                    FechasDevolucion[i] = ConversionDeFechas(StringsFechas[i]);
                }
            }

            return FechasDevolucion;
        
        
        }

        public string convertidorgeneral(int Convertido) { 
        
           int horas = converirMinutosAHoras(Convertido);
           int dias = converirHorasAdias(horas);
           int mess = converirDiasAmeses(dias);

            return mess.ToString() + MHDM;
        
        }

        private int converirMinutosAHoras (int minutos) {

            if (minutos > 60)
            {
                minutos = minutos / 60;
                MHDM = " Horas";
            }
            return minutos;
        
        }
        private int converirHorasAdias (int Horas)
        {
            if (Horas > 24)
            {
                Horas = Horas / 24;
                MHDM = " Dias";
            }

            return Horas;

        }
        private int converirDiasAmeses(int dias)
        {
            if (dias > 24)
            {
                dias = dias / 30;
                MHDM = " Meses";
            }

            return dias;

        }


    }
}
