using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetalSoft
{
    public class teste
    {
        public double valor { get; set; }

        public static List<teste> Teste { get; set; }

        public teste(double valor)
        {
            this.valor = valor;
            Teste = new List<teste>();
         
        }

        public double multi()
        {
            return valor * valor;
        }
        
        public void imprimir(List<teste> Teste)
        {
            for (int i = 0; i < Teste.Count; i++)
            {
                
            }

        }

    }
}
