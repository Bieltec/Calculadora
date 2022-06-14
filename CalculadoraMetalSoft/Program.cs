using CalculadoraMetalSoft;
using CalculadoraMetalSoft.Funcao;

//while positionFunction deve receber um lenght/conth no lugar do 6
//gostaria de fazer um keypress no outWhile caso queira ficar aperte enter para sair aperte esc
// clean code para os nomes da function, estudar e verificar
// estudar function lambda


Console.WriteLine("Calculadora MetalSoft. Seja Bem Vindo!");


Console.WriteLine("Segue as soluções:");

var showList = new Calculadora();

showList.obterLista();
int positionFunction;
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

try
{
    switch (positionFunction)
    {
        case 1:
            {
                var contSoma = new List<double>();
                int outWhile = 1;
                do
                {
                    Console.WriteLine("Digite o valor:");
                    /* double valorSoma = Double.Parse(Console.ReadLine());
                     contSoma.Add(valorSoma);*/
                    contSoma.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Deseja continuar a operação, SIM(1) NÃO(2):");
                    outWhile = int.Parse(Console.ReadLine());


                } while (outWhile == 1);

                var a = new Soma(contSoma);
                Console.WriteLine($"O resultado da sua operação: {a.TotalSoma().ToString("N2")}");
                break;
            }
        case 2:
            {
                Console.WriteLine("Digite primeiro valor da subtração:");
                int valor1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Digite segundo valor da subtração:");
                int valor2 = Int32.Parse(Console.ReadLine());

                var b = new Subtracao(valor1, valor2);
                Console.WriteLine("Valor da subtração é: " + b.TotalSub().ToString("N2"));
                break;

            }
        case 3:
            {
                var contDiv = new List<double>();
                int outWhile = 1;
                do
                {
                    Console.WriteLine("Digite o valor:");
                    contDiv.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Deseja continuar a operação, SIM(1) NÃO(2):");
                    outWhile = int.Parse(Console.ReadLine());

                } while (outWhile == 1);

                var divisao = new Divisao(contDiv);
                Console.WriteLine($"O resultado da sua operação: {divisao.TotalDiv().ToString("N2")}");
                break;


            }
        case 4:
            {
                var contMulti = new List<double>();
                int outWhile = 1;
                do
                {
                    Console.WriteLine("Digite o valor:");
                    contMulti.Add(Double.Parse(Console.ReadLine()));
                    Console.WriteLine("Deseja continuar a operação, SIM(1) NÃO(2):");
                    outWhile = int.Parse(Console.ReadLine());


                } while (outWhile == 1);

                var multi = new Multiplicacao(contMulti);
                Console.WriteLine($"Resultado da operação: {multi.TotalMulti().ToString("N2")}");
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
                Console.WriteLine($"Valor da porcentagem de {valor}% de {valor2} é: " + e.TotalPor().ToString("N2"));
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

                Console.WriteLine("Valor da Raiz Quadrada é: " + f.ObterRaizQuadrada().ToString("N2"));

                break;

            }

    }
 }
catch (FormatException)
{
    Console.WriteLine("O valor inserido na operação é null ou inválido.");
    throw;
}












//switch (calculadora)
//{
//    default:
//        break;
//}




//var a = new Divisao();
//var b = new Soma();
//var c = new Multiplicacao();
//var d = new RaizQuadrada(); 
//var e = new Porcentagem();


