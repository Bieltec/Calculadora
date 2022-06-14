internal class Divisao
{
    public List<double> ListDivisao { get; private set; }
    

    public Divisao(List<double> listDivisao)
    {
        ListDivisao = listDivisao;
    }

	public  double TotalDiv()
	{
		double aux = 0;
		foreach (var item in ListDivisao)
		{
			if (item > 0)
			{
				aux = aux == 0 ? item : aux / item;
			}

		}
		return aux;
	}
}