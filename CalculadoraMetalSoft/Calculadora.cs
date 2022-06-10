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
            "5 - Raiz Quadrada",
            "6 - Porcentagem"

        };

        public void obterLista()
        {
            foreach (var r in opcao)
            {
                Console.WriteLine(r);
            }

        }



    }
}
