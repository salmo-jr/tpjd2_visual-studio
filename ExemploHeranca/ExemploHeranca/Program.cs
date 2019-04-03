using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro andando ....");
            Console.WriteLine();

            Carro gol = new Carro();
            gol.Marca = "Volkswagen";
            Console.WriteLine("Acelera ....");
            gol.Acelera();
            Console.WriteLine();
            Console.WriteLine("Freia ...");
            gol.Freia();
            Console.WriteLine();
            Console.WriteLine("Troca de marcha");
            gol.TrocaMarcha();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bicicleta andando ....");
            Console.WriteLine();

            Bicicleta bike = new Bicicleta();
            Console.WriteLine("Acelera ....");
            bike.Acelera();
            Console.WriteLine();
            Console.WriteLine("Freia ...");
            bike.Freia();
            Console.WriteLine();
            Console.WriteLine("Troca de marcha");
            bike.TrocaMarcha();

            Console.ReadKey();

        }
    }
}
