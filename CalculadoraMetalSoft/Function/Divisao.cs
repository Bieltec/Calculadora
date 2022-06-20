internal sealed class Divisao
{
    public List<double> ListDivisao { get; private set; }


	public Divisao(List<double> listDivisao)
	{
		ListDivisao = listDivisao;
	}


	// expressao que devo estar estudando para melhor aplicacao
	public  double TotalDivisao()
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