using CalculadoraMetalSoft.Implementacao;

internal sealed class RaizQuadrada : ITotalOperacao
{
    public double raiz { get; private set; }
    public RaizQuadrada(double raiz)
    {
        this.raiz = raiz;
    }
    public double TotalOperacao()
    {
        double resultado = Math.Sqrt(raiz);
        return resultado;
    }
}