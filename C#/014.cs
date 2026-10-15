using System;

namespace Ex00
{
	public class Ex00
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o custo do carro novo: ");
			double novo = double.Parse(Console.ReadLine());

			Console.WriteLine("Digite o custo  de fabrica: ");
			double fabrica = double.Parse(Console.ReadLine());

			double Distribuidor = 0.72;
			double imposto = 0.55;

			double custoNovo = fabrica * imposto * distribuidor;
			double custoFinal = novo + custoNovo;

			Console.WriteLine($"Custo final ao consumidor: {custoFinal}R$");

		}
	}
}
