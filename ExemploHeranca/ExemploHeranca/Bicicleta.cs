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
            Console.WriteLine("NHEC-NHEC-NHEC");
        }

        public override void Freia()
        {
            // COLOCANDO O CHINELO NO PNEU
            Console.WriteLine("OWA-OWA-OWA");
        }

        public override void TrocaMarcha()
        {
            // USANDO O CAMBIO
            Console.WriteLine("TREC-TREC");
        }
    }
}
