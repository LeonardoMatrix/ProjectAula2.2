using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2._2
{
    class Calculo
    {

        public Decimal ValorA { get; set; }
        public Decimal ValorB { get; set; }


        public Decimal Somar()
        {

            return ValorA + ValorB;

        }

        public Decimal Subtrair()
        {
            return ValorA - ValorB;

        }

        public Decimal Multiplicar()
        {
            return ValorA * ValorB;

        }

        public Decimal Dividir()
        {
     
            return ValorA / ValorB;


        }

    }
}
