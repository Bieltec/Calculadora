internal class RaizQuadrada
{
    public double raiz { get; set; }
    public RaizQuadrada(double raiz)
    {
        this.raiz = raiz;
    }

    public double ObterRaizQuadrada()
    {
        double resultado = Math.Sqrt(raiz);
        return resultado;
    }

}