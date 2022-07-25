using Calculadora.Implementation;

internal sealed class SquareRoot : ICalculationOperation
{
    public List<double> Raiz { get; private set; }
    public SquareRoot(List<double> raiz)
    {
        Raiz = raiz;
    }                                                       
    public double CalculateOperation()
    {
        double auxiliar = 0;    
        foreach (var raiz in Raiz)
        {
            if (raiz > 0)
            {
                auxiliar = raiz;
                auxiliar = Math.Sqrt(raiz);
            }
        }
        return auxiliar;
    }
}
