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
            Caracter player = new Caracter("q", "p");
            Cenario cenario = new Cenario(".", 60);
            ConsoleKey tecla;

            cenario.Imprime(player);

            do
            {
                tecla = Console.ReadKey().Key;
                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        // ANDA PARA ESQUERDA
                        player.anda(false, cenario.Tamanho);
                        cenario.Imprime(player);
                        break;
                    case ConsoleKey.RightArrow:
                        // ANDA PARA DIREITA
                        player.anda(true, cenario.Tamanho);
                        cenario.Imprime(player);
                        break;
                    case ConsoleKey.UpArrow:
                        // PULA
                        player.Pulando = true;
                        cenario.Imprime(player);
                        player.pula();
                        player.Pulando = false;
                        cenario.Imprime(player);
                        break;
                    default:
                        cenario.Imprime(player);
                        break;
                }
            } while (tecla != ConsoleKey.Escape);






            cenario.Imprime(player);
            Console.ReadKey();
        }
    }
}
