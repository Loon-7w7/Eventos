using System.IO;

namespace CalendarioDeEventos
{
    internal class LecturaDeFicheros : ILecturaDeFicheros
    {
        public string[] LecturaDelFichero(string NombreFichero){

            StreamReader FiecheroEventos = new StreamReader(NombreFichero);
            string[] LienasFichero = new string[LongitudadDelFichero(NombreFichero)];
            for (int i = 0; (LienasFichero[i] = FiecheroEventos.ReadLine() ) != null; i++);
            FiecheroEventos.Close();

            return LienasFichero;
            
        }

        private int LongitudadDelFichero(string NombreFichero) {

            StreamReader FiecheroEventos = new StreamReader(NombreFichero);
            int longitiud = FiecheroEventos.ReadToEnd().Length;

            return longitiud;

        }
    }
}
