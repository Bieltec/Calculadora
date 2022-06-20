sealed class Multiplicacao
{
   public List<double> ListMulti { get; private set; }

   public Multiplicacao(List<double> listMulti)
    {

        ListMulti = listMulti;
    }

    public double TotalMultiplicacao()
    {
        double totalMulti = 1;
        foreach (var somaMulti in ListMulti)
        {
            totalMulti *= somaMulti;
        }
        return totalMulti;
    }

}

