using System;
using System.Diagnostics;
using System.Runtime.Serialization;

public class Hello5
{
    public static void aya()
    {
        Console.WriteLine("Digite o numero da base do retangulo: ");
        double based = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero da altura do retangulo: ");
        double altura = double.Parse(Console.ReadLine());

        static double AreaRetangulo(double based, double altura)
        {
            double soma = based * altura;
            return soma;
        }

        double area = AreaRetangulo(based, altura);
        Console.Write($"Area do retangulo: {area} cm");
    }
}
