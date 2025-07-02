using System;

class Program
{

    //     🔹 Exercício 11 – Vetor e Fatoriais
    // a) Crie um procedimento que leia n números inteiros e armazene em um vetor.
    // b) Crie uma função que receba um número e retorne seu fatorial.
    // c) Crie um procedimento que mostre o vetor original e outro vetor com os fatoriais correspondentes.

    static void LerNumeroN(out int n)
    {
        Console.Write("Informe o número (n) de elementos do vetor: ");
        n = int.Parse(Console.ReadLine());
    }
    static void LerNumeros(int n, int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int RetornaFatorial(int n)
    {
        int fatorial = 1;

        for (int i = n; i >= 1; i--)
        {
            fatorial *= i;
        }

        return fatorial;
    }

    static void MostraVetores(int[] vetor)
    {
        int[] vetorFatorial = new int[vetor.Length];

        Console.WriteLine("\nVetor Original: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetor[i] + " ");
            vetorFatorial[i] = RetornaFatorial(vetor[i]);
        }

        Console.WriteLine("\nVetor Fatorial: ");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write(vetorFatorial[i] + " ");
        }
    }

    //     🔹 Exercício 13 – Matriz de Presença
    // a) Leia n alunos e m dias letivos.
    // b) Crie uma matriz presencas[n, m] com valores 1 (presente) ou 0 (faltou).
    // c) Crie uma função que calcule o número de faltas de um aluno (linha).
    // d) Mostre, para cada aluno, o total de faltas.

    static void LerAlunosEFaltas(out int n, out int m)
    {
        Console.Write("Informe o número (n) de alunos: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Informe o número (m) de dias letivos: ");
        m = int.Parse(Console.ReadLine());
    }

    static void PreencheMatriz(int[,] matriz)
    {
        Console.WriteLine("Informe 1 para Presença | 0 para falta");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"ALuno {i + 1} no dia {j + 1}: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    static int VerificaFaltas(int[,] matriz, int indice)
    {
        int contafaltas = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (i == indice && matriz[i, j] == 0) contafaltas++;
            }
        }

        return contafaltas;
    }
    static void MostraResumo(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine($"Faltas do Aluno [{i + 1}]: {VerificaFaltas(matriz, i)}");
        }
    }

    static void Main()
    {

        Console.Write("Qual questão deseja corrigir? (1-5)\n ->  ");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                LerNumeroN(out int n);
                int[] vetor = new int[n];
                LerNumeros(n, vetor);
                MostraVetores(vetor);
                break;
            case 2:
                LerAlunosEFaltas(out int n2, out int m);
                int[,] matriz = new int[n2, m];
                PreencheMatriz(matriz);
                MostraResumo(matriz);
                break;
        }

    }
}