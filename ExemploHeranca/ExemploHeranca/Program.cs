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

            Sprite heroi = new Sprite();
            Sprite inimigo;

            heroi.Nome = "Batman";
            heroi.PosicaoX = 100;
            heroi.andaEsquerda();
        }
    }
}
