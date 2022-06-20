using CalculadoraMetalSoft.Implementacao;

internal sealed class Soma : ITotalOperacao
{
    public List<double> ListSoma { get; private set; }
    public Soma(List<double> listSoma)
    {
        ListSoma = listSoma;
    }

    public double TotalOperacao()
    {
        double totalSoma = 0;
        foreach (var soma in ListSoma)
        {
            totalSoma += soma;
        }
        return totalSoma;
    }



}