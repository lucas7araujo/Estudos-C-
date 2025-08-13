using System;
using System.Linq;
using System.Security.Cryptography;

class Program
{
    //     1. Filtrar números pares de um vetor e exibir ordenados
    // Receba um vetor de inteiros.
    // Use LINQ para filtrar somente os pares.
    // Ordene eles em ordem crescente.
    // Exiba usando string.Join().
    static void QuestaoUm()
    {
        int[] vetor = new int[3];
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        var pares = vetor.Where(x => x % 2 == 0);
        string resultado = string.Join(" ", pares);
        Console.WriteLine(resultado);

    }

    // Crie um vetor de 10 números inteiros.
    // Filtre os números impares maiores que 5.
    // Exiba esses números.

    static void QuestaoDois()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i * i + 5;
        }
        var maioresQueCinco = vetor.Where(x => x > 5 && x % 2 != 0);
        var resultado = string.Join(" ", maioresQueCinco);
        Console.WriteLine($"Números Ímpares maiores que 5: {resultado}");
    }

    // Crie um vetor com pelo menos 10 números.
    // Use LINQ para filtrar os pares.
    // Ordene em ordem decrescente.
    // Exiba com string.Join().

    static void QuestaoTres()
    {
        int[] vetor = new int[10];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = i * 3;
        }
        var pares = vetor.Where(x => x % 2 == 0);
        var paresOrdenadoCrescente = pares.OrderBy(x => x);
        var paresOrdenadoDescrescente = pares.OrderByDescending(x => x);
        string ordemCrescente = string.Join(" ", paresOrdenadoCrescente);
        string ordemDecrescente = string.Join(" ", paresOrdenadoDescrescente);
        Console.WriteLine("Números pares em ordem Crescente: " + ordemCrescente);
        Console.WriteLine("Números pares em ordem Decrescente: " + ordemDecrescente);
    }

    // Exercício 4: Somar os elementos de cada coluna de uma matriz 3x3
    // Crie uma matriz 3x3 com valores inteiros à sua escolha.
    // Calcule a soma dos valores de cada coluna.
    // Exiba as somas em uma única linha, separadas por espaço.

    static void QuestaoQuatro()
    {
        int[,] matriz = new int[3, 3];
        int preenchedor = 1;
        int[] vetor = new int[3];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int somaColuna = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[j, i] = preenchedor;
                somaColuna += matriz[j, i];
                preenchedor++;
            }
            vetor[i] = somaColuna;
        }
        var resultado = string.Join(", ", vetor);
        Console.WriteLine(resultado);

        for (int i = 0; i < matriz.GetLength(1); i++)
        {

            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                Console.Write(" " + matriz[i, j]);
            }
            Console.WriteLine();
  
        }

    }
    static void Main()
    {
        // QuestaoUm();
        // QuestaoDois();
        // QuestaoTres();
        QuestaoQuatro();
    }
}
