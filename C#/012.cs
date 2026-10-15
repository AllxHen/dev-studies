using System;

namespace Ex06
{
	public class Ex06
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite a quantidade total de eleitores: ");
			int quantidade = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a quantidade de votos brancos: ");
			int branco = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a quantidade de votos nulos: ");
			int nulos = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a quantidade de votos validos: ");
			int validos = int.Parse(Console.ReadLine());

			Console.Write($"Percentual de votos: Brancos:{(double)branco/quantidade*100}%, Nulos:{(double)nulos/quantidade*100}%, Validos:{(double)validos/quantidade*100}%");

		}
	}
}
