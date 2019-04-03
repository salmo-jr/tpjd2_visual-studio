using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    abstract class Veiculo
    {
        public String Marca { set; get; }
        public String Modelo { set; get; }
        public Int64 Ano { set; get; }
        public Byte Marchas { set; get; }

        public Veiculo() { }
        abstract public void Acelera();
        abstract public void Freia();
        abstract public void TrocaMarcha();
    }
}
