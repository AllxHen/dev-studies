using System;

namespace EX04
{
    internal class Ex04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do produto:");
            int valor = int.Parse(Console.ReadLine());
            double desconto = 0.90;
            

            Console.Write(valor*desconto);
        }
    }
}
