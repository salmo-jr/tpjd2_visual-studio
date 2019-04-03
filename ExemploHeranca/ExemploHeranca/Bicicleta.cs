using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Bicicleta : Veiculo
    {
        public Boolean Garupa { set; get; }
        public Boolean Sinalizador { set; get; }

        public Bicicleta() { }

        public void Empinar() { }

        public override void Acelera()
        {
            // PEDALANDO MAIS FORTE
        }

        public override void Freia()
        {
            // COLOCANDO O CHINELO NO PNEU
        }

        public override void TrocaMarcha()
        {
            // USANDO O CAMBIO
        }
    }
}
