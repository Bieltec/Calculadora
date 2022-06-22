using CalculadoraMetalSoft.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetalSoft.Function
{
    internal sealed class Subtracao : ICalculoOperacao
    {
        public List<double> ListSubtracao { get; private set; }

        public Subtracao(List<double> listSubtracao)
        {
            ListSubtracao = listSubtracao;
        }

        public double CalcularOperacao()
        {
            double auxiliar = 0;
            foreach (var subtracao in ListSubtracao)
            {
                if (subtracao > 0)
                {
                    auxiliar = auxiliar == 0 ? subtracao : auxiliar - subtracao;
                }
            }
            return auxiliar;
        }
    }
}
