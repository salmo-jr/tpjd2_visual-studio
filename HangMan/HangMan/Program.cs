using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sorteio = new Random();
            String[] linhas = File.ReadAllLines("palavras.txt");
            // ElementAt(posicao) = pega o elemento na posicao dada
            Char[] palavraOculta = linhas.ElementAt(sorteio.Next(0, linhas.Length)).ToCharArray();

            Char[] palavra = new Char[palavraOculta.Length];

            for (Byte i = 0; i < palavra.Length; i++)
            {
                palavra[i] = '_';
            }

            Char letra;
            Byte letrasDaPalavra = 0;
            Boolean notificaMudanca = false;
            Byte erros = 0;

            do
            {
                ImprimeJogo(palavra, erros);
                Console.Write("Digite uma letra: ");
                letra = (Console.ReadLine())[0];

                for (Byte i = 0; i < palavraOculta.Length; i++)
                {
                    if (palavraOculta[i] == letra)
                    {
                        palavra[i] = letra;
                        letrasDaPalavra++;
                        notificaMudanca = true;
                    }
                }

                if (!notificaMudanca)
                {
                    erros++;
                }
                else
                {
                    notificaMudanca = false;
                }
            } while (letrasDaPalavra < palavraOculta.Length && erros < 6);

            ImprimeJogo(palavra, erros);

            if (letrasDaPalavra < palavraOculta.Length)
            {
                // GAME OVER
                Console.WriteLine();
                Console.WriteLine("LOOOOOOSER!!!");
                Console.WriteLine();
                Console.Write("A palavra era: ");
                Console.WriteLine(palavraOculta);
            }
            else
            {
                // CONGRATULATIONS
                Console.WriteLine();
                Console.WriteLine("PARABÉNS !!!");
            }

            Console.WriteLine("Pressione qualquer tecla para sair ...");
            Console.ReadKey();
        }

        static void ImprimeJogo(Char[] palavra, Byte erros)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("### HANGMAN ###");
            Console.WriteLine();
            Console.WriteLine(" _______ ");
            Console.WriteLine(" |     | ");

            // IMPRIME CABECA
            if (erros > 0)
            {
                Console.WriteLine(" |     O ");
            }
            else
            {
                Console.WriteLine(" |       ");
            }
            
            // IMPRIME CORPO COM BRACOS
            if (erros > 1)
            {
                if (erros > 2)
                {
                    if (erros > 3)
                    {
                        Console.WriteLine(@" |    /|\");
                    }
                    else
                    {
                        Console.WriteLine(" |    /| ");
                    }
                }
                else
                {
                    Console.WriteLine(" |     | ");
                }
                Console.WriteLine(" |     | ");
            }
            else
            {
                Console.WriteLine(" |       ");
                Console.WriteLine(" |       ");
            }

            // IMPRIME PERNAS
            if (erros > 4)
            {
                if (erros > 5)
                {
                    Console.WriteLine(@" |    / \");
                }
                else
                {
                    Console.WriteLine(" |    /  ");
                }
            }
            else
            {
                Console.WriteLine(" |       ");
            }
            Console.WriteLine(" |       ");

            Console.WriteLine();
            Console.WriteLine(palavra);
            Console.WriteLine();
        }
    }
}
