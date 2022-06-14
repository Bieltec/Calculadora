using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMetalSoft
{
    internal class Calculadora
    {


        List<string> opcao = new List<string>()
        {
            "1 - Soma",
            "2 - Subtração",
            "3 - Divisão",
            "4 - Multiplicação",
            "5 - Porcentagem",
            "6 - Raiz Quadrada"

        };

        public void obterLista()
        {
            foreach (var r in opcao)
            {
                Console.WriteLine(r);
            }

        }

        public int Count()
        {
            int count = 0;  
            foreach(var r in opcao)
            {
                count++;
                
            }
            return count;
        }


    }
}
