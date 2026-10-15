using System;

namespace pratica
{
    internal class Ex03

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu valor: ");
            int valor = int.Parse(Console.ReadLine());
            valor = valor - 1;
            Console.WriteLine($"valor antecessor: {valor}");
        }
    }
}
