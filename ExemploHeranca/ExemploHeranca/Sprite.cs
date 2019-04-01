using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Sprite {
        public String Nome { set; get; }
        public Int16 PosicaoX { set; get; }
        public Int16 Hp { set; get; }
        public Double Aceleracao { set; get; }
        public Boolean Visibilidade { set; get; }

        public Sprite()
        {
            Hp = 5;
            Visibilidade = false;
        }

        public void Desacelerar(Double valor)
        {
            Aceleracao = Aceleracao - valor;
        }
    }
}
