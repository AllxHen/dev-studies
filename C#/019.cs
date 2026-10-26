using System;

public class Exercicio003
{
    public static void Sala()
    {
        double[] notas = { 8.6, 10, 7.4, 9.4, 6, 4.7 };
        double 
            maior = notas[0], 
            menor = notas[0], 
            soma = 0;

        for (int contador = 0; contador < notas.Length; contador++)
        {
            soma += notas[contador];
            if (notas[contador] > maior)
            {
                maior = notas[contador];
            }
            if (notas[contador] < menor)
            {
                menor = notas[contador];
            }

        }
        Console.WriteLine($"Sua media de foi: {soma / 3}");
        Console.WriteLine($"Sua maior nota foi: {maior}");
        Console.WriteLine($"Sua menor nota foi: {menor}");



    }

}

