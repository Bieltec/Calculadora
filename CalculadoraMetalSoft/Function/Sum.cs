using Calculadora.Implementation;

internal sealed class Sum : ICalculationOperation
{
    public List<double> ListSoma { get; private set; }
 
    public Sum(List<double> listSoma)
    {
        ListSoma = listSoma;
    }

    public double CalculateOperation()
    {
        double totalSoma = 0;
        foreach (var soma in ListSoma)
        {
            totalSoma += soma;
        }
        return totalSoma;
    }


}