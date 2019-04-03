using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSenseDialog
{
    class Heroi : Personagem
    {
        public String Liga { set; get; }

        public Heroi(String Nome, String Liga) : base(Nome)
        {
            this.Liga = Liga;
        }
    }
}
