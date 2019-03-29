using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterAndando
{
    class Cenario
    {
        public String Chao { set; get; }
        public Byte Tamanho { set; get; }

        public Cenario(String Chao, Byte Tamanho)
        {
            this.Chao = Chao;
            this.Tamanho = Tamanho;
        }

        public void Imprime(Caracter c)
        {
            Console.Clear();
            Console.WriteLine();

            // IMPRIME A PRIMEIRA LINHA
            if (c.Pulando)
            {
                for (Byte i = 0; i < c.Posicao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(c.Aparencia);
            }
            else
            {
                Console.WriteLine();
            }

            // IMPRIME SEGUNDA LINHA
            for (Byte i = 0; i < c.Posicao; i++)
            {
                Console.Write(Chao);
            }

            if (c.Pulando)
            {
                Console.Write(Chao);
            }
            else
            {
                Console.Write(c.Aparencia);
            }

            for (Byte i = 0; i < (Tamanho - c.Posicao); i++)
            {
                Console.Write(Chao);
            }
        }
    }
}
