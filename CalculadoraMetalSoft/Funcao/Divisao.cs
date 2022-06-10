internal class Divisao
{
    public double divisaoA { get; set; }
    public double divisaoB { get; set; }
    public Divisao(double a, double b)
    {
        divisaoA = a;
        divisaoB = b;
    }

    public double TotalDiv()
    {
        double div = divisaoA / divisaoB;
        return div;
    }
}