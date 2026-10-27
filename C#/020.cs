using System;

public class Hello1
{
    public static void aya()
    {
        int[,] notas = new int[3, 4];
        notas[1, 2] = 7;
        notas[1, 3] = 9;

        foreach (int notasF in notas)
        {
            Console.WriteLine(notasF);
        }
    }
}
