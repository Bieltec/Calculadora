using CalculadoraMetalSoft.Implementacao;

internal sealed class RaizQuadrada : ICalculoOperacao
{
    public List<double> Raiz { get; private set; }
    public RaizQuadrada(List<double> raiz)
    {
        Raiz = raiz;
    }
    public double CalcularOperacao()
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
