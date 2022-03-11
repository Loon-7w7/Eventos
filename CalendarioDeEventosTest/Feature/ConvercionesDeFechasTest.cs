using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CalendarioDeEventos;

namespace Tests.CalendarioDeEventosTest
{
    public class ConvercionesDeFechasTest 
    {
        [Fact(DisplayName = "dado un numero entero convertir a minutos horas dias y meses")]
        public void dadounnumeroenteroconvertiraminutoshorasdiasymeses() 
        {
            var minutos = 60;
            var SUT = GeneralInstanciaSUT();

            var valor = SUT.Convertidorgeneral(minutos);
            Assert.Equal("1 Horas", valor);

            


        }


        [Fact(DisplayName = "dado un numero entero convertir a horas dias")]
        public void dadounnumeroenteroconvertirahorasdias()
        {
            
            var SUT = GeneralInstanciaSUT();

            

            var horas = 1440;
            var valor2 = SUT.Convertidorgeneral(horas);
            Assert.Equal("1 Dias", valor2);


        }

        [Fact(DisplayName = "dado un numero entero convertir a dias meses")]
        public void dadounnumeroenteroconvertiradiasmeses()
        {

            var SUT = GeneralInstanciaSUT();



            var horas = 43200;
            var valor2 = SUT.Convertidorgeneral(horas);
            Assert.Equal("1 Meses", valor2);


        }

        private ConvercionesDeFechas GeneralInstanciaSUT()
        {
            var SUT = new ConvercionesDeFechas();
            return SUT;
        }
        // Convertir minutos a horas
        // Convertir horas a dias
        // Convertir dias a meses
    }
}
