internal class Multiplicacao
{
    public double valorA { get; set; }
    public double valorB { get; set; }

    public Multiplicacao(double a, double b)
    {
        valorA = a;
        valorB = b;
    }

    public double TotalMulti()
    {
        return valorA * valorB;
    }


}