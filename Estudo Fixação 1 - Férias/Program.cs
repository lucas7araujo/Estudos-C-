
using System;

class Program
{
    //     🚀 1. Soma de Múltiplos de 3 ou 5
    // Enunciado:
    // Crie um programa que receba um número inteiro n e retorne a soma de todos os números menores que n que são múltiplos de 3 ou 5.
    // Exemplo:
    // Entrada: 10 → Saída: 23 (3 + 5 + 6 + 9)
    static int RetornaSoma(int n)
    {
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) soma += i;
        }

        return soma;
    }
    // 🧮 2. Número Perfeito
    // Enunciado:
    // Um número é perfeito quando a soma de seus divisores (exceto ele mesmo) é igual ao número.
    // Ex: 6 → divisores: 1, 2, 3 → 1+2+3 = 6
    // Escreva uma função que verifique se um número é perfeito.

    static bool Perfeito(int n)
    {
        int soma = 0;
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && n % i == 0) soma += i;
        }

        return (soma == n);
    }
    //     🔄 3. Inverter Array
    // Enunciado:
    // Crie uma função que recebe um array de inteiros e retorna um novo array invertido.

    // Exemplo:
    // Entrada: [1, 2, 3, 4]
    // Saída: [4, 3, 2, 1]
    static int[] Inverso(int[] v) => v.OrderByDescending(v => v).ToArray();

    static void Main()
    {
        Console.WriteLine(RetornaSoma(10));
        Console.WriteLine(Perfeito(6));
        int[] v = { 1, 2, 3, 4, 5 };
        int[]inverso = Inverso(v);
        var resultado = string.Join(", ", inverso);
        Console.WriteLine(resultado);
    }
}