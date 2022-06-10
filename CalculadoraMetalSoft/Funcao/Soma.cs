internal class Soma
{
    public double somaA { get; set; }
    public double somaB { get; set; }
    public Soma(double a, double b)
    {
        this.somaA = a;
        this.somaB = b;
    }

    public double TotalSoma()
    {
        return somaA + somaB;
    }

    //bugs: permitir a soma de mais de um valor

}