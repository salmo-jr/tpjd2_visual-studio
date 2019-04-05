using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSenseDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] frases = File.ReadAllLines("frases.txt");

            Heroi h = new Heroi("Batman", "Liga da Justiça");
            Inimigo i = new Inimigo("+loko q o Batman", true);

            Random seletor = new Random();
            Personagem[] p = new Personagem[2];
            p[0] = i;
            p[1] = h;

            for (Byte j = 0; j < frases.Length; j++)
            {
                int per = seletor.Next(2);
                Console.Write(p[per].Nome + ": ");
                p[per].Fala(frases[seletor.Next(frases.Length)]);
                Console.WriteLine();
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
