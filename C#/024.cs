using System;

public class Hello4
{
    public static void aya()
    {
        static double Somar(double NotaA, double NotaB)
        {
            return NotaA + NotaB;
        }

        static void Saudar(string nome)
        {
            Console.WriteLine($"Olá, {nome}!");
        }

        double resultado = Somar(3, 4.5);
        Saudar($"Ana sua nota foi: {resultado}");
    }
}
