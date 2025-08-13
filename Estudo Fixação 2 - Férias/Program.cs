using System;
using System.Linq;
using System.Net.Http.Headers;

class Program
{

    //     🚀 1. Verificar Número Primo
    // Enunciado:
    // Crie um programa que leia um número inteiro e diga se ele é primo ou não.
    // Dica: Um número primo só é divisível por 1 e por ele mesmo.

    static void LerNumero(out int n)
    {
        Console.Write("Informe o valor de n: ");
        n = int.Parse(Console.ReadLine());
    }

    static string VerificaNumeroPrimo(int n)
    {
        int divisores = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0) divisores++;
        }

        if (divisores == 2) return "É primo.";
        else return "Não é primo.";
    }

    // 👉 Próximo desafio:
    // 🔁 2. Soma dos Números Pares

    // Faça um código que leia 10 números inteiros e mostre a soma dos que forem pares.

    static void LerVetor(int[] v)
    {
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            v[i] = int.Parse(Console.ReadLine());
        }
    }

    static int SomaPares(int[] v)
    {

        int[] pares = v.Where(n => n % 2 == 0).ToArray();
        return pares.Sum();


    }

    // 👉 Bora pra próxima?
    // 📊 3. Média de Notas com Situação

    // Leia 3 notas de um aluno, calcule a média e exiba:

    // "Aprovado" se média ≥ 7

    // "Recuperação" se média ≥ 5 e < 7

    // "Reprovado" se média < 5

    static void LerNotas(int[] notas)
    {
        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Informe o valor da nota {i + 1}: ");
            notas[i] = int.Parse(Console.ReadLine());
        }
    }
    static string RetornaNotas(int[] notas)
    {
        double media = notas.Average();
        if (media >= 7) return "Aprovado | " + "Média: " + Math.Round(media, 2);
        else if (media >= 5 && media < 7) return "Recuperação | " + "Média: " + Math.Round(media, 2);
        else return "Reprovado | " + "Média: " + Math.Round(media, 2);
    }

    // 🎯 Agora, desafio bônus se quiser continuar:
    // Faça um programa que leia o nome de 5 pessoas e diga qual tem o maior nome (em número de caracteres).

    static void LerNomes(string[] nomes)
    {
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.Write($"Informe o nome {i + 1}: ");
            nomes[i] = Console.ReadLine();
        }
    }

    static string VerificaMaiorNome(string[] nomes)
    {
        string maior = "";
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i].Length > maior.Length) maior = nomes[i];
        }
        return maior;
    }



    static void Main()
    {
        // LerNumero(out int n);
        // Console.WriteLine(VerificaNumeroPrimo(n));

        // int[] vetor = new int[10];
        // LerVetor(vetor);
        // Console.WriteLine(SomaPares(vetor));

        // int[] notas = new int[3];
        // LerNotas(notas);
        // var resultado = RetornaNotas(notas);
        // Console.WriteLine("Situação: " + resultado);

        // string[] nomes = new string[5];
        // LerNomes(nomes);
        // var resultado = VerificaMaiorNome(nomes);
        // Console.WriteLine("Maior nome: " + resultado);

        
    }

}
