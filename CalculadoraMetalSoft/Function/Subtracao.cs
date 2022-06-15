using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetalSoft.Funcao
{
    internal class Subtracao
    {
        public double valorA { get; private set; }
        public double valorB { get; private set; }

        public Subtracao(double valorA, double valorB)
        {
            this.valorA = valorA;
            this.valorB = valorB;
        }

        public double TotalSub()
        {
            return valorA - valorB;
        }
    }
}
