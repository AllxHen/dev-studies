using System;
using System.Runtime.Serialization;

namespace Praticando
{
    internal class EX03
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha: +, -, /, *");
            string processo = (Console.ReadLine());

            if (processo == "-")
            {
                Console.Write(numero1 - numero2);

            }

            else if (processo == "+") {
                Console.Write(numero1 + numero2);
            }

            else if (processo == "/")
            {
                Console.Write(numero1 / numero2);
            }

            else if (processo == "*")
            {
                Console.Write(numero1 * numero2);
            }

        }
    }
}
