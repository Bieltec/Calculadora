using CalculadoraMetalSoft;
using CalculadoraMetalSoft.Funcao;

//Soma - permitir a soma de mais de um valor
//Multiplicação - permitir multi de mais de um valor
//Calculos - negativos
//Estas são as observações primarias de bugs previstos, estarei atualizando.
//while deve mudar seu tamanho automatico pela lista

Console.WriteLine("Calculadora MetalSoft. Seja Bem Vindo!");

Console.ReadLine();

Console.WriteLine("Segue as soluções:");

var show = new Calculadora();

show.obterLista();

Console.WriteLine("Digite o número da função que deseja:");
int numero = Int32.Parse(Console.ReadLine());

while (numero > 6 )
{
    Console.WriteLine("Função inexistente por favor digite novamente:");
    numero = Int32.Parse(Console.ReadLine());
}

switch (numero)
{
    case 1:
        {
            Console.WriteLine("Digite primeiro valor da soma:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor da soma:");
            int valor2 = Int32.Parse(Console.ReadLine());

            var a = new Soma(valor1, valor2);
            Console.WriteLine(a.TotalSoma());
            break;
        }
    case 2:
        {
            Console.WriteLine("Digite primeiro valor da subtração:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor da subtração:");
            int valor2 = Int32.Parse(Console.ReadLine());

            var b = new Subtracao(valor1, valor2);
            Console.WriteLine("Valor da subtração é: ", b.TotalSub());
            break;

        }
    case 3:
        {
            Console.WriteLine("Digite primeiro valor da divisão:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor da divisão:");
            int valor2 = Int32.Parse(Console.ReadLine());

            var c = new Divisao(valor1, valor2);
            Console.WriteLine("Valor da divisão é: ", c.TotalDiv);
            break;

        }
    case 4:
        {
            Console.WriteLine("Digite primeiro valor da multiplicação:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor da multiplicação:");
            int valor2 = Int32.Parse(Console.ReadLine());

            var d = new Multiplicacao(valor1, valor2);
            Console.WriteLine("Valor da multiplicação é: ", d.TotalMulti);
            break;

        }

    case 5:
        {
            Console.WriteLine("Digite a porcentagem:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite segundo valor:");
            int valor2 = Int32.Parse(Console.ReadLine());

            var e = new Porcentagem(valor1, valor2);
            Console.WriteLine($"Valor da porcentagem de {valor1}% de {valor2} é: ", e.TotalPor());
            break;

        }

    case 6:
        {
            Console.WriteLine("Raiz Quadrada:");
            int valor1 = Int32.Parse(Console.ReadLine());

            var f = new RaizQuadrada(valor1);
            
            Console.WriteLine("Valor da Raiz Quadrada é: ", f.ObterRaizQuadrada());
            break;

        }



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


