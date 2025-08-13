using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Select - Transforma os itens de um vetor.

        int[] inteiros = { 4, 5, 7, 1, 2, 6, 8, 4 };
        var quadrados = inteiros.Select(n => n * n);
        var cubo = inteiros.Select(n => n * n * n);

        foreach (var item in cubo)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Where - Seleciona itens específicos
        var pares = inteiros.Where(n => n % 2 == 0);
        foreach (var item in pares)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        var impares = inteiros.Where(n => n % 2 != 0);
        foreach (var item in impares)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Order - Ordenar os números
        var ordenadosInteirosDecrescentes = inteiros.OrderByDescending(n => n); // Decrescente
        foreach (var item in ordenadosInteirosDecrescentes)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        var ordenadosInteiros = inteiros.OrderBy(n => n); // Crescente
        foreach (var item in ordenadosInteiros)
        {
            Console.Write(item + " ");
        }

        


    }
}