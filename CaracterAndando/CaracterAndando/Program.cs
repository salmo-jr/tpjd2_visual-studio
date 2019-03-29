using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterAndando
{
    class Program
    {
        static void Main(string[] args)
        {
            // CRIA UMA INSTANCIA DA CLASSE CARACTER - OBJETO
            Caracter player = new Caracter("<", ">");
            Cenario cenario = new Cenario("_", 60);

            player.Posicao = 30;
            player.Pulando = true;

            cenario.Imprime(player);
            Console.ReadKey();
        }
    }
}
