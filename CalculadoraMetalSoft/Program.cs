using CalculadoraMetalSoft;
using CalculadoraMetalSoft.Funcao;

//while positionFunction deve receber um lenght/conth no lugar do 6
//gostaria de fazer um keypress no outWhile caso queira ficar aperte enter para sair aperte esc
// clean code para os nomes da function, estudar e verificar
// estudar function lambda
// sets privados porém poderia estar lancado a excessao no construtor


Console.WriteLine("Calculadora MetalSoft. Seja Bem Vindo!");


Console.WriteLine("Segue as soluções:");

var showList = new ListaCalculadora();

showList.obterLista();
int positionFunction;
// chamada da lista com as opções de function
try
{
    Console.WriteLine("Digite o número da função que deseja:");
       positionFunction = Int32.Parse(Console.ReadLine());

    while (positionFunction > showList.Count())
    {
        Console.WriteLine("Função inexistente por favor digite novamente:");
        positionFunction = Int32.Parse(Console.ReadLine());
    }

}
catch (FormatException)
{
    Console.WriteLine("O valor da função inserida é null ou inválido.");
    throw;
}

var ValorOperacao = new List<double>();


// responsavel por receber os valores 
switch (positionFunction)
{
    case 1:
    case 2:
    case 3:
    case 4:
        {          
            int outWhile = 1;

            Console.WriteLine("Valor:");
            ValorOperacao.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Valor:");
            ValorOperacao.Add(double.Parse(Console.ReadLine()));

            do
            {
                Console.WriteLine("Deseja continuar a operação, SIM(1) NÃO(2):");
                outWhile = int.Parse(Console.ReadLine());

                if (outWhile == 1)
                {
                    Console.WriteLine("Valor:");
                    ValorOperacao.Add(double.Parse(Console.ReadLine()));
                }

            } while (outWhile == 1);

            break;
        }    
}

// responsavel por instanciar as positons function
try
{
    switch (positionFunction)
    {
        case 1:
            {
       

                var a = new Soma(ValorOperacao);
                Console.WriteLine($"O resultado da sua operação: {a.TotalOperacao().ToString("N2")}");
                break;
            }
        case 2:
            {
                
       
                var subtracao = new Subtracao(ValorOperacao);

                Console.WriteLine($"O resultado da sua operação: {subtracao.TotalOperacao().ToString("N2")}");

                break;

            }
        case 3:
            {
       
                var divisao = new Divisao(ValorOperacao);
                Console.WriteLine($"O resultado da sua operação: {divisao.TotalOperacao().ToString("N2")}");
                break;


            }
        case 4:
            {
      

                var multi = new Multiplicacao(ValorOperacao);
                Console.WriteLine($"Resultado da operação: {multi.TotalOperacao().ToString("N2")}");
                break;

            }

        case 5:
            {
                Console.WriteLine("Digite a porcentagem:");
                int valor = Int32.Parse(Console.ReadLine());

                while (valor < 0)
                {
                    Console.WriteLine("Valor da porcentagem negativo, digite novamente:");
                    valor = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite a percentagem:");
                int valor2 = Int32.Parse(Console.ReadLine());

                while (valor2 < 0)
                {
                    Console.WriteLine("Valor negativo, digite novamente:");
                    valor2 = Int32.Parse(Console.ReadLine());
                }

                var e = new Porcentagem(valor, valor2);
                Console.WriteLine($"Valor da porcentagem de {valor}% de {valor2} é: " + e.TotalOperacao().ToString("N2"));
                break;

            }

        case 6:
            {
                Console.WriteLine("Valor da raiz quadrada:");
                int valor = Int32.Parse(Console.ReadLine());
                while (valor < 0)
                {
                    Console.WriteLine("Raiz quadrada negativa, inválida!");
                    Console.WriteLine("Raiz Quadrada:");
                    valor = Int32.Parse(Console.ReadLine());

                }
                var f = new RaizQuadrada(valor);

                Console.WriteLine("Valor da Raiz Quadrada é: " + f.TotalOperacao().ToString("N2"));

                break;

            }

    }
 }
catch (FormatException)
{
    Console.WriteLine("O valor inserido na operação é null ou inválido.");
    throw;

}










