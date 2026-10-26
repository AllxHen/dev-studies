using System;

public class Exemplo001
{
    public static void Executar()
    {
        string[] nomes = { "Felipe", "Danilo", "Gustavo", "Caua", "Thomas", "Geovana", "lorrany", "allex gamer", "davi", "carol" };

        for (int indice = 0; indice < nomes.Length; indice++)
        {
            Console.Write($"{nomes[indice]}, ");
        }
    }
}
