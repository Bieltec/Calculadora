

using Calculadora.Implementation;

internal sealed class Percentage : ICalculationOperation
{
    public List<double> Value { get; private set; }

    public Percentage(List<double> value)
    {    
        Value = value;
    }

    public double CalculateOperation()
    {
        double auxiliar = 0;
        foreach (var value in Value)
        {
            if (value > 0)
            {
                auxiliar = auxiliar == 0 ? value : (value * auxiliar) /100;
            }
        }
        return auxiliar;
    }
}