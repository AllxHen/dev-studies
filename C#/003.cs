using System;

namespace praticando
{
    class Ex02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operacao: +, -, *, /");
            string conta = Console.ReadLine();

            double resultado = 0; 

            if (conta == "+")
            {
                resultado = numero + numero2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (conta == "-")
            {
                resultado = numero - numero2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (conta == "*")
            {
                resultado = numero * numero2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else if (conta == "/")
            {
                resultado = (double)numero / numero2;
                Console.WriteLine($"Resultado: {resultado}");
            }
            else
            {
                Console.WriteLine("Operação inválida!");
            }
        }
    }
}
