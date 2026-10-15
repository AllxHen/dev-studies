using System;

namespace EX02
{
    internal class EX02
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Questão A)");
            int A = 10;
            int B = 20;
            Console.WriteLine(B);
            B = 5;
            Console.WriteLine($"{A}, {B}");
          
          Console.WriteLine("Questão B)");
            int A = 30;
            int B = 20;
            int C = A + B;
            Console.WriteLine(C);
            B = 10;
            Console.WriteLine($"{B}, {C}");
            C = A + B;
            Console.WriteLine($"{A},{B},{C}");

          Console.WriteLine("Questão C)");
            int X = 1;
            int Y = 2;
            int Z = X - Y;
            Console.WriteLine(Z);
            X = 5;
            Y = X + Z;
            Console.WriteLine($"{X}, {Y}, {Z}");   
        }
    }
}
