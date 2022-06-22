using CalculadoraMetalSoft.Implementation;

sealed class Multiplication : ICalculationOperation
{
   public List<double> ListMulti { get; private set; }

   public Multiplication(List<double> listMulti)
    {

        ListMulti = listMulti;
    }

    public double CalculateOperation()
    {
        double totalMulti = 1;
        foreach (var somaMulti in ListMulti)
        {
            totalMulti *= somaMulti;
        }
        return totalMulti;
    }
}

