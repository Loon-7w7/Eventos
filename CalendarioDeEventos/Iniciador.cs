using System;



namespace CalendarioDeEventos
{
    internal class Iniciador :IIniciador
    {
        private readonly string NombreDelArchivo = "Eventos.txt";

        readonly LecturaDeFicheros LeeArchivo = new LecturaDeFicheros();
        ObtenerFechasDelArchivo ObtenFechas = new ObtenerFechasDelArchivo();
        ObtenerNombresDelArchivo ObtenNombres = new ObtenerNombresDelArchivo();
        ConvertirdorDeArryStringAArrayDateTime ConverstrinADatetime = new ConvertirdorDeArryStringAArrayDateTime();
        ImprecionesEnPantalla pantalla = new ImprecionesEnPantalla();


        public void Arranque(){

            var LineasDelArchivo = LeerArchivo(NombreDelArchivo);
            var FechasDelEvento = ObtenerFechasDelArchivo(LineasDelArchivo);
            var NombresDeLosEventos = ObtenerFechasDelArchivo(LineasDelArchivo);
            var fechasConvertidas = ConveirtirStringADateTime(FechasDelEvento);

            pantalla.ImprecionesAPantalla(NombresDeLosEventos, fechasConvertidas);
        }
            

        private string[] LeerArchivo (string NombreDelArchivo)
        {
            return LeeArchivo.LecturaDelFichero(NombreDelArchivo);
        }

        private string[] ObtenerFechasDelArchivo(string[] LineasDelArchivo)
        {
            return ObtenFechas.ObtenerFechasDeArchivo(LineasDelArchivo);
        }

        private string[] ObtenerNombreDeEventosDElArchivo(string[] LineasDelArchivo)
        {
            return ObtenNombres.ObtenerNombreDeArchivo(LineasDelArchivo);
        }

        private DateTime[] ConveirtirStringADateTime(string[] FechasDelEvento)
        {
            return ConverstrinADatetime.ConvertirdorDeArryStringAArrayDateTimes(FechasDelEvento);
        }
    }
}
