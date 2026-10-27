using System;

public class Hello2
{
    public static void aya()
    {
        int[,] numeros =
        {
            { 7, 8, 6, 9},
            { 5, 6, 7, 8},
            { 9, 9, 8, 4}
        };

        int contador = 0;


        foreach (int numeroF in numeros)
        {
            Console.Write(numeroF);
            contador++;
            if (contador >= 4)
            {
                Console.WriteLine();
                contador = 0;
            }
            
        }
    }
}
