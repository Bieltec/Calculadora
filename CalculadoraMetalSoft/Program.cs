using Calculadora;
using Calculadora.Function;

//while positionFunction deve receber um lenght/conth no lugar do 6
//gostaria de fazer um keypress no outWhile caso queira ficar aperte enter para sair aperte esc
// clean code para os nomes da function, estudar e verificar
// estudar function lambda
// sets privados porém poderia estar lancado a excessao no construtor


Console.WriteLine("Seja Bem Vindo!");
Console.WriteLine("Segue as soluções:");

var calculadora = new Calculator();
calculadora.ListFunction();
calculadora.PositionFunction();
calculadora.ReceiveFunctionValues();
calculadora.Calculate();

















































