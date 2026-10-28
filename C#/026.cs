using System;
using System.Diagnostics;
using System.Runtime.Serialization;

public class Hello6
{
    public static void aya()
    {
        Console.WriteLine("Digite a sua media final (ex: 0...10): ");
        double media = double.Parse(Console.ReadLine());

        static double Situacao(double media)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            if (media >= 6)
            {
                Console.WriteLine($"Opa {nome}, Muito bem foi Aprovado :D");
            }
            if (media == 5)
            {
                Console.WriteLine($"Poxa {nome}, Foi quase! ficou de Recuperação :|");
            }
            if (media < 5)
            {
                Console.WriteLine($"Pessimo {nome}, Melhore! foi Reprovado >:(");
            }
            return media;
        }
        double resultado = Situacao(media);
    }
}
