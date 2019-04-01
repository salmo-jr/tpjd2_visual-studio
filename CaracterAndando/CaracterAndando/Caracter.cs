using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaracterAndando
{
    /*
     * CLASSE: DEFINE UMA ENTIDADE DO SISTEMA,
     * DEFININDO PROPRIEDADES E ACOES QUE PODEM SER REALIZADAS (METODOS)
     */

    class Caracter
    {
        private Byte _posicao;
        public byte Posicao {
            get { return _posicao; }
            set { _posicao = value; }
        }

        public String Aparencia { set; get; }
        public String ViradoEsquerda { set; get; }
        public String ViradoDireita { set; get; }
        public Boolean Pulando { set; get; }

        public Caracter(String esquerda, String direita)
        {
            ViradoEsquerda = esquerda;
            ViradoDireita = direita;
            Aparencia = ViradoDireita;
            Posicao = 0;
            Pulando = false;
        }

        public void pula()
        {
            Console.Beep(234, 100);
        }

        public void anda(Boolean direcao, Byte limite)
        {
            if (direcao)
            {
                // ANDA PARA DIREITA
                if (Posicao < limite)
                {
                    Posicao++;
                    Aparencia = ViradoDireita;
                }
            }
            else
            {
                // ANDA PARA ESQUERDA
                if (Posicao > 0)
                {
                    Posicao--;
                    Aparencia = ViradoEsquerda;
                }
            }
        }

        /*
        public void confAparencia(String valor) { Aparencia = valor; }
        public String retornaAparencia() { return Aparencia;  }

        public void confViradoEsquerda(String valor) { ViradoEsquerda = valor; }
        public String retornaViradoEsquerda() { return ViradoEsquerda; }

        public void confViradoDireita(String valor) { ViradoDireita = valor; }
        public String retornaViradoDireita() { return ViradoDireita; }

        public void confPulando(Boolean valor) { Pulando = valor; }
        public Boolean retornaPulando() { return Pulando; }
        */
    }
}
