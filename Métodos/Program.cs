using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        var fruits = new List<string>();

        fruits.Add("Banana");
        fruits.Add("Maçã");
        fruits.Add("Pêssego");
        fruits.Add("Tomate");
        fruits.Add("Uva");
        fruits.Add("Melancia");


        // 1 - Primeiro Elemento
        Console.WriteLine();
        Console.WriteLine(fruits.First());
        Console.WriteLine(fruits.FirstOrDefault("Não Encontrei"));

        // 2 - Verificar se um elemento existe - Valor Booleano
        Console.WriteLine();
        Console.WriteLine(fruits.Any(x => x == "Tomate"));

        // 3 - Verificar se todos os elementos são do mesmo tipo
        Console.WriteLine();
        Console.WriteLine(fruits.All(x => x == "Banana"));

        // 4 - Contagem - (Simula um Length)
        Console.WriteLine();
        Console.WriteLine(fruits.Count);
        Console.WriteLine(fruits.Count(x => x == "Banana"));

        // 5 - ElementAt - índice
        Console.WriteLine();
        Console.WriteLine(fruits.ElementAt(3));

        // 6 - Take
        Console.WriteLine();
        foreach (var fruit in fruits.Take(2..))
        {
            Console.WriteLine(fruit);
        }

        // 7 - Where
        Console.WriteLine();
        foreach (var fruit in fruits.Where(x => x == "Banana"))
        {
            Console.WriteLine(fruit);
        }

        // 8 - Single (Importante para Entrevistas!)
        Console.WriteLine();
        Console.WriteLine(fruits.Single(x => x == "Tomate"));
        // Pega somente um elemento se ele for único na lista

        // 9 - Último elemento
        Console.WriteLine();
        Console.WriteLine(fruits.Last());

        // 10 - Skip
        Console.WriteLine();
        foreach (var item in fruits.Skip(2))
        {
            Console.WriteLine(item);
        }

    }
}