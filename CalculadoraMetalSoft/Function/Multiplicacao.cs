public class Multiplicacao
{
   public List<double> ListMulti { get; set; }

   public Multiplicacao(List<double> listMulti)
    {
        ListMulti = listMulti;
    }

    public double TotalMulti()
    {
        double totalMulti = 1;
        foreach (var somaMulti in ListMulti)
        {
            totalMulti *= somaMulti;
        }
        return totalMulti;
    }






    /*public double Valor { get; set; }
    public static List<Multiplicacao> Valores { get; set; }

    public Multiplicacao(double valor)
    {
        Valor = valor; 
        
    }

    public void Add()
    {
       Valores.Add( new Multiplicacao(Valor) );
    }

    public void Lista() 
    {
        foreach (var a in Valores)
        {
            Console.WriteLine(a);
        }
    }*/


}

/*public class ListMulti
{
    public static List<Multiplicacao> Valores { get; set; }

    public static void Add(Multiplicacao valores)
    {
        Valores.Add(valores);
    }



}*/



/*public double valorA { get; set; }
    public double valorB { get; set; }

    public Multiplicacao(double a, double b)
    {
        valorA = a;
        valorB = b;
    }

    public double TotalMulti()
    {

        return valorA * valorB;
    }*/