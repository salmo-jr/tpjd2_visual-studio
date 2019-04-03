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
            


            Carro gol = new Carro();
            gol.Marca = "Volkswagen";
            gol.Acelera();

            Bicicleta bike = new Bicicleta();
            bike.Acelera();
            
        }
    }
}
