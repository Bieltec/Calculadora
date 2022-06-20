using CalculadoraMetalSoft.Implementacao;

internal sealed class Porcentagem : ITotalOperacao
{
    public double valorA { get; private set; }
    public double valorB { get; private set; }

    public Porcentagem(double a, double b)
    {
        valorA = a;
        valorB = b;
    }

    public double TotalOperacao()
    {
        double total = (valorA * valorB) / 100;
        return total;
    }
}