using System;
using DemoTesteUnitario.Domain;

namespace DemoTesteUnitario.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var milMetros = Distancia.EmMetros(1000);
            var umKm = Distancia.EmQuilometros(1);

            if (milMetros == umKm)
            {
                Console.WriteLine("Tudo certo");                
            }

            Console.WriteLine(milMetros.ToString());
            Console.ReadLine();
        }
    }
}
