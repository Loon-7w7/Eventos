using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace CalendarioDeEventos
{
    internal class Iniciador
    {
        private readonly IConfiguration configuration;
        public Iniciador(IConfiguration configuration) => this.configuration = configuration;



        LecturaDeFicheros fichero = new LecturaDeFicheros();
        DivizorPorNombresDeEventosYFechas accionesDeArray = new DivizorPorNombresDeEventosYFechas();
        AccionesFechas accionfechas = new AccionesFechas();
        AccionesEnPantalla pantalla = new AccionesEnPantalla();


        public void arranque(){
            
            string NombreDelarchivo = configuration["Archivo:NombreDelArchivo"];

            string[] FechasDelEvento = accionesDeArray.FechasDelEventos(fichero.LecturaDelFichero(NombreDelarchivo));
            string[] NombresDeLosEventos = accionesDeArray.NombresDeLosEventos(fichero.LecturaDelFichero(NombreDelarchivo));
            DateTime[] fechasConvertidas = accionfechas.FchasConvercion(FechasDelEvento);

            pantalla.ImprecionesAPantalla(NombresDeLosEventos, fechasConvertidas);
        }
            
    }
}
