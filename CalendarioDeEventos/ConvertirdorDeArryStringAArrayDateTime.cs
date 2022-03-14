using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioDeEventos
{
    public class ConvertirdorDeArryStringAArrayDateTime : IConvertirdorDeArryStringAArrayDateTime
    {
        private string MHDM = " Minutos";
        private const string FormatoDeFechas = "dd/MM/yyyy HH:mm";
        private const string MesajeDeFormatExecion = "esto no es una fecha";

        public DateTime[] ConvertirdorDeArryStringAArrayDateTimes(string[] StringsFechas) {
        
            DateTime[] FechasDevolucion = new DateTime[StringsFechas.Length];
            for (int i = 0; i < StringsFechas.Length; i++) {
                if (StringsFechas[i] != null) {

                    FechasDevolucion[i] = ConvertirStringADateTime(StringsFechas[i]);
                }
            }

            return FechasDevolucion;
        
        
        }
        private DateTime ConvertirStringADateTime(string stringFecha)
        {
            DateTime TipoDFechas = DateTime.Now;
            try
            {
                TipoDFechas = DateTime.ParseExact(stringFecha,FormatoDeFechas,CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine(MesajeDeFormatExecion);
            }
            return TipoDFechas;

        }


        public string Convertidorgeneral(int Convertido) { 
        
            
           int horas = ConverirMinutosAHoras(Convertido);
           int dias = ConverirHorasAdias(horas);
           int mess = ConverirDiasAmeses(dias);

            return mess.ToString() + MHDM;
        
        }

        private int ConverirMinutosAHoras (int minutos) {

            if (minutos >= 60)
            {
                minutos /= 60;
                MHDM = " Horas";
            }
            return minutos;
        
        }
        private int ConverirHorasAdias (int Horas)
        {
            if (Horas >= 24)
            {
                Horas /= 24;
                MHDM = " Dias";
            }

            return Horas;

        }
        private int ConverirDiasAmeses(int dias)
        {
            if (dias >= 30)
            {
                dias /= 30;
                MHDM = " Meses";
            }

            return dias;

        }


    }
}
