using CalculadoraMetalSoft.Function;


namespace CalculadoraMetalSoft
{
    internal class Calculator
    {
        private List<double> ValueOperation = new List<double>();
        public int Position { get; set; }
        public double ValueA { get; set; }
        public double ValueB { get; private set; }

        List<string> function = new List<string>()
        {
            "1 - Soma",
            "2 - Subtração",
            "3 - Divisão",
            "4 - Multiplicação",
            "5 - Porcentagem",
            "6 - Raiz Quadrada"
        };
        public void ListFunction()
        {
            foreach (var r in function)
            {
                Console.WriteLine(r);
            }
        }
        public int FunctionCount()
        {
            int count = 0;
            foreach (var r in function)
            {
                count++;
            }
            return count;
        }
        public void PositionFunction()
        {
            try
            {
                Console.WriteLine("Digite o número da função que deseja:");
                Position = Int32.Parse(Console.ReadLine());

                while (Position > FunctionCount())
                {
                    Console.WriteLine("Função inexistente por favor digite novamente:");
                    Position = Int32.Parse(Console.ReadLine());
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("O valor da função inserida é null ou inválido.");
                throw;
            }
        }
        public void ReceiveFunctionValues()
        {
            try
            {
                if (Position >= 1 && Position <= 4)
                {
                    int outWhile = 1;
                    Console.WriteLine("Valor:");
                    ValueOperation.Add(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Valor:");
                    ValueOperation.Add(double.Parse(Console.ReadLine()));

                    do
                    {
                        Console.WriteLine("Deseja continuar sum operação, SIM(1) NÃO(2):");
                        outWhile = int.Parse(Console.ReadLine());

                        if (outWhile == 1)
                        {
                            Console.WriteLine("Valor:");
                            ValueOperation.Add(double.Parse(Console.ReadLine()));
                        }

                    } while (outWhile == 1);
                }
                if (Position == 5)
                {
                    Console.WriteLine("Digite sum percentage:");
                    ValueA = double.Parse(Console.ReadLine());
                    if (ValueA > 0)
                    {
                        ValueOperation.Add(ValueA);
                    }
                    else
                    {
                        while (ValueA < 0)
                        {
                            Console.WriteLine("Valor da percentage negativo, digite novamente:");
                            ValueA = double.Parse(Console.ReadLine());
                        }
                        ValueOperation.Add(ValueA);
                    }
                    
                    Console.WriteLine("Digite sum percentagem:");
                    ValueB = double.Parse(Console.ReadLine());
                    if (ValueB > 0)
                    {
                        ValueOperation.Add(ValueB);
                    }
                    else
                    {
                        while (ValueB < 0)
                        {
                            Console.WriteLine("Valor da percentage negativo, digite novamente:");
                            ValueB = Int32.Parse(Console.ReadLine());
                        }
                        ValueOperation.Add(ValueB);
                    }
                   
                }
                if (Position == 6)
                {
                    Console.WriteLine("Valor da raiz quadrada:");
                    ValueA = double.Parse(Console.ReadLine());
                    if (ValueA > 0)
                    {
                        ValueOperation.Add(ValueA);
                    }
                    else
                    {
                        while (ValueA < 0)
                        {
                            Console.WriteLine("Raiz quadrada negativa, inválida!");
                            Console.WriteLine("Raiz Quadrada:");
                            ValueA = double.Parse(Console.ReadLine());
                        }
                        ValueOperation.Add(ValueA);
                    }
                    
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor da função inserida é null ou inválido.");
                throw;
            }
            
            
        }
        public void Calculate()
        {
            switch (Position)
            {
                case 1:
                    {
                        var sum = new Sum(ValueOperation);
                        Console.WriteLine($"O resultado da sua operação: {sum.CalculateOperation().ToString("N2")}");
                        break;
                    }
                case 2:
                    {
                        var subtraction = new Subtraction(ValueOperation);
                        Console.WriteLine($"O resultado da sua operação: {subtraction.CalculateOperation().ToString("N2")}");
                        break;
                    }
                case 3:
                    {
                        var division = new Division(ValueOperation);
                        Console.WriteLine($"O resultado da sua operação: {division.CalculateOperation().ToString("N2")}");
                        break;
                    }
                case 4:
                    {
                        var multiplication = new Multiplication(ValueOperation);
                        Console.WriteLine($"Resultado da operação: {multiplication.CalculateOperation().ToString("N2")}");
                        break;
                    }
                case 5:
                    {
                        var percentage = new Percentage(ValueOperation);
                        Console.WriteLine($"Valor da percentage de {ValueA}% de {ValueB} é: " + percentage.CalculateOperation().ToString("N2"));
                        break;
                    }
                case 6:
                    {
                        var raiz = new SquareRoot(ValueOperation);
                        Console.WriteLine("Valor da Raiz Quadrada é: " + raiz.CalculateOperation().ToString("N2"));
                        break;
                    }
                   
            }

        }

    }
}
//, System.Globalization.CultureInfo.GetCultureInfo("en-US") PASSO ESTE METODO COMO SOBRECARGA NO PARSE CASO QUEIRA CONVERTER