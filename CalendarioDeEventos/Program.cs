using System;

namespace CalendarioDeEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iniciador iniciar = new Iniciador();
            iniciar.Arranque();
            Console.ReadKey();
        }   
    }
}
