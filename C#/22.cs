using System;
using System.Runtime.ExceptionServices;

public class Hello3 
{
    public static void aya()
    {
        string[] alunos = { "Ana", "Bia", "Lais" };
        double[,] notas =
        {
            { 7, 8, 9, 6},
            { 5, 6, 4, 2},
            { 9, 9, 8, 10}
        };

        for (int linha = 0; linha < notas.GetLength(0); linha++)
        {
            double soma = 0;
            for (int coluna = 0; coluna < notas.GetLength(1); coluna++)
            {
                soma += notas[linha, coluna];
            }
            double media = soma / notas.GetLength(1);
            Console.Write($"{alunos[linha]}: {media}, ");
        }
    }
}
