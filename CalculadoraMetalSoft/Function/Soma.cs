internal sealed class Soma
{
    public List<double> ListSoma { get; private set; }
    public Soma(List<double> listSoma)
    {
        ListSoma = listSoma;
    }


    public double TotalSoma()
    {
        double totalSoma = 0;
        foreach (var soma in ListSoma)
        {
            totalSoma += soma;
        }
        return totalSoma;

    }

    //bugs: permitir a soma de mais de um valor

}