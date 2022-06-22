using CalculadoraMetalSoft.Implementation;

internal sealed class Division : ICalculationOperation
{
    public List<double> ListDivisao { get; private set; }

	public Division(List<double> listDivisao)
	{
		ListDivisao = listDivisao;
	}

	// expressao que devo estar estudando para melhor aplicacao
    public double CalculateOperation()
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