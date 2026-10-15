using System;
using System.ComponentModel;

namespace pratica
{
    internal class Ex03

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu mes atual:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia atual: ");
            int dia = int.Parse(Console.ReadLine());

            int total = 0;
            idade = idade * 365;
            mes = mes * 30;

            total = dia + mes + idade;

            Console.WriteLine(total);
            
        }
    }
}
