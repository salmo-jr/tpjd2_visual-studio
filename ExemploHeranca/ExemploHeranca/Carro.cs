using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Carro : Veiculo
    {
        public Byte Portas { set; get; }
        public String Combustivel { set; get; }

        public Carro() { }

        public void DarSeta() { }

        public override void Acelera()
        {
            // PISANDO NO ACELERADOR
        }

        public override void Freia()
        {
            // PISANDO NO FREIO
        }

        public override void TrocaMarcha()
        {
            // PISANDO NA EMBREAGEM E USANDO O CAMBIO
        }
    }
}
