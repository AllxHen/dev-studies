using System;

namespace EX03
{
    internal class EX03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os minutos: ");
            double minutos = double.Parse(Console.ReadLine());

            Console.WriteLine($"{minutos / 60}h");
        }
    }
}
