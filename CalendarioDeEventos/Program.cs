using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalendarioDeEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();

            Iniciador iniciar = new Iniciador(configuration);
            iniciar.arranque();



            Console.ReadKey();
        }   
    }
}
