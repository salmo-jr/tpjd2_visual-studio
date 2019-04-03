using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSenseDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] textos = new String[10];
            textos[0] = "Qual é o seu nome?";
            textos[1] = "Quero bolo";
            textos[2] = "Quero dormir";
            textos[3] = "Qual é a música?";
            textos[4] = "Onde estou?";
            textos[5] = "Onde está o Aquaman, Batman?";
            textos[6] = "Vamos jogar um jogo?";
            textos[7] = "Palmeiras não tem mundial";
            textos[8] = "Maldito estagiário";
            textos[9] = "Eu poderia estar em casa upando";

            Heroi h = new Heroi("Batman", "Liga da Justiça");
            Inimigo i = new Inimigo("Mais loko q o Batman", true);

            Random seletor = new Random();
            Personagem[] p = new Personagem[2];
            p[0] = i;
            p[1] = h;

            for (Byte j = 0; j < textos.Length; j++)
            {
                int per = seletor.Next(2);
                Console.Write(p[per].Nome + ": ");
                p[per].Fala(textos[seletor.Next(10)]);
                Console.WriteLine();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
