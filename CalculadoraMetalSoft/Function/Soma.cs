using CalculadoraMetalSoft.Implementacao;

internal sealed class Soma : ICalculoOperacao
{
    public List<double> ListSoma { get; private set; }
    public Soma(List<double> listSoma)
    {
        ListSoma = listSoma;
    }

    public double CalcularOperacao()
    {
        double totalSoma = 0;
        foreach (var soma in ListSoma)
        {
            totalSoma += soma;
        }
        return totalSoma;
    }



}