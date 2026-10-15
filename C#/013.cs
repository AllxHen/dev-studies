using System;

namespace Ex00
{
	public class Ex00
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu salario mensal: ");
			int salario = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o Percentual de reajuste: ");
			double Percentual = double.Parse(Console.ReadLine());

			double reajuste = Percentual/100;
			double novoSalario = salario*reajuste + salario;
			
			Console.WriteLine($"O novo salario é {novoSalario}R$");

		}
	}
}
