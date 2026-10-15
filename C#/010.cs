using System;

namespace pratica
{
    internal class Ex03

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base do triangulo:");
            int based = int.Parse(Console.ReadLine());
            Console.WriteLine("Altura do triangulo");
            int altura = int.Parse(Console.ReadLine());
            

            Console.WriteLine($"Resultado: {based * altura / 2}");
            Console.Beep();


        }
    }
}
