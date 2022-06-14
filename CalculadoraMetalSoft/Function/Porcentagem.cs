internal class Porcentagem
{
    public double valorA { get; set; }
    public double valorB { get; set; }

    public Porcentagem(double a, double b)
    {
        valorA = a;
        valorB = b;
    }

    public double TotalPor()
    {
        double total = (valorA * valorB) / 100;
        return total;
    }
}