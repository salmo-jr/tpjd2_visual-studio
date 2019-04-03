using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSenseDialog
{
    class Personagem
    {
        public String Nome { set; get; }

        public Personagem(String Nome)
        {
            this.Nome = Nome;
        }

        public virtual void Fala(String mensagem)
        {
            Console.Write(mensagem);
        }
    }
}
