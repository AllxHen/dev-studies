using System;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

public class Hello4
{
    public static void aya()
    {
        int[,] numeros =
        {
            { 10,9,6,8 },
            { 20,9,4,6 },
            { 45,5,7,8 },
            { 60,10,5,7 }
        };


        for (int linha = 0; linha < numeros.GetLength(0); linha++)
        {
            int soma = 0;
            for (int coluna = 0; coluna < numeros.GetLength(1); coluna++)
            {
                if (linha >= 0 && linha >= 0)
                {
                    soma += numeros[linha, coluna];

                }
            }
            Console.WriteLine(soma);
        }
    }
}

