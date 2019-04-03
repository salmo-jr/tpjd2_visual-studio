using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSenseDialog
{
    class Inimigo : Personagem
    {
        public Boolean Gang { set; get; }
        public Inimigo(String Nome, Boolean Gang) : base(Nome)
        {
            this.Gang = Gang;
        }


        public override void Fala(String mensagem)
        {
            base.Fala(mensagem);
            Console.Write(" ... MANO");
        }
    }
}
