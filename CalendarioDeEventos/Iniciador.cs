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
        ConvercionesDeFechas accionfechas = new ConvercionesDeFechas();
        ImprecionesEnPantalla pantalla = new ImprecionesEnPantalla();


        public void arranque(){
            
            string NombreDelarchivo = configuration["Archivo:NombreDelArchivo"];

            string[] FechasDelEvento = accionesDeArray.FechasDelEventos(fichero.LecturaDelFichero(NombreDelarchivo));
            string[] NombresDeLosEventos = accionesDeArray.NombresDeLosEventos(fichero.LecturaDelFichero(NombreDelarchivo));
            DateTime[] fechasConvertidas = accionfechas.StringaFchasConvercion(FechasDelEvento);

            pantalla.ImprecionesAPantalla(NombresDeLosEventos, fechasConvertidas);
        }
            
    }
}
