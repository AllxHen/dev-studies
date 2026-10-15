using System;

namespace EX04
{
    internal class EX04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} tem {idade * 365} Dias de vida!");
        }
    }
}
