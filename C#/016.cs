using System;

namespace ex00
{
    internal class Ex00
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero da semana: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Domingo com d de depressão");
                    break;
                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 3:
                    Console.WriteLine("Terça-feira");
                    break;
                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sexta-Feira Com S de churrasco");
                    break;
                default:
                    Console.WriteLine("Dia da semana não disponivel!");
                    break;

            }
        }
    }
}
