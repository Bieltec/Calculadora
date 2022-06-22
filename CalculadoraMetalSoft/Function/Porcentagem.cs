using CalculadoraMetalSoft.Implementacao;

internal sealed class Porcentagem : ICalculoOperacao
{
    public List<double> Value { get; private set; }

    public Porcentagem(List<double> value)
    {    
        Value = value;
    }

    public double CalcularOperacao()
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