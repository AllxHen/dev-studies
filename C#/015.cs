using System;

namespace Ex00
{
    internal class Ex00
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero 1: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Operação  (+, -, *, /): ");
            string op = Console.ReadLine();
            Console.WriteLine("Número 2: ");
            double b = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+": Console.WriteLine($"Resultado: {a + b}");
                    break;
                case "-": Console.WriteLine($"Resultado: {a - b}");
                    break;
                case "*": Console.WriteLine($"Resultado: {a * b}");
                    break;
                case "/":
                    if (b == 0) { Console.WriteLine("Não e possivel dividir por zero"); }
                    else { Console.Write($"Resultado: {a / b}"); }
                        break;
                default: Console.WriteLine("Operação invalido");
                        break;
            }

        }
        }
    }
