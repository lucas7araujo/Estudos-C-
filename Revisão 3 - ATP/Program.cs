using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization.Formatters;
using System.Security.Authentication;

class Program
{

    // 1. Faça um programa em C# que contenha:
    // (a) um procedimento que leia um número inteiro n;
    // (b) um procedimento que leia n números inteiros e os armazene em um vetor;
    // (c) uma função que receba um número inteiro x e retorna quantas vezes x aparece no vetor. 

    static void LerNumero(out int n)
    {
        Console.Write("Informe um número inteiro: ");
        n = int.Parse(Console.ReadLine());
    }

    static void LerEArmazenar(int n, int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o número da posição[{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static int BuscaX(int[] vetor, out int x)
    {
        int cont = 0;

        Console.Write("Informe o valor de X: ");
        x = int.Parse(Console.ReadLine());

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == x) cont++;
        }

        return cont;
    }

    // 2. Faça um programa em C# que contenha:
    // (a) uma função que leia e retorne um número inteiro n ;
    // (b) um procedimento que leia n números inteiros e os armazene em um vetor;
    // (c) um procedimento que informe qual é o maior número armazenado no vetor. 

    static int RetornaN()
    {
        Console.Write("Informe um número inteiro: ");
        return int.Parse(Console.ReadLine());
    }

    // Ler e Armazenar 

    static void InformaMaior(out int maior, int[] vetor)
    {
        maior = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > maior) maior = vetor[i];
        }

        Console.WriteLine(maior);
    }

    // 3. Faça em C# um programa que:
    // (a) leia um vetor de números inteiros (utlize um procedimento);
    // (b) calcule a média dos elementos presentes no vetor (utilize uma função)

    static void LerVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    static double RetornaMedia(int[] vetor)
    {
        double soma = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        return Math.Round(soma / vetor.Length, 2);
    }

    //     4. Faça um programa em C# que:
    // (a) leia dois valores inteiros positivos q1 e q2 (utilize um procedimento);
    // (b) leia q1 números inteiros e os armazene em um vetor V1 (utilize um procedimento);
    // (c) leia q2 números inteiros e os armazene em um vetor V2 (utilize um procedimento);;
    // (d) para cada número presente no vetor V1, verifique quantas vezes ele está presente no
    // vetor V2 (utilize um procedimento).

    static void LerDoisNumeros(out int q1, out int q2)
    {
        Console.Write("Informe um número inteiro: ");
        q1 = int.Parse(Console.ReadLine());
        Console.Write("Informe outro número inteiro: ");
        q2 = int.Parse(Console.ReadLine());
    }

    static void LerVetor(int q, int[] v)
    {
        Console.WriteLine("");
        for (int i = 0; i < q; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            v[i] = int.Parse(Console.ReadLine());
        }
    }

    static void VerificaPresenca(int[] v1, int[] v2)
    {
        for (int i = 0; i < v1.Length; i++)
        {
            int cont = 0;

            for (int j = 0; j < v2.Length; j++)
            {
                if (v2[j] == v1[i]) cont++;
            }

            Console.WriteLine($"\nO número {v1[i]} aparece {cont} vezes no V2.");
        }
    }

    //     5. Faça um programa em C# que:
    // (a) preencha um vetor de inteiros de n posições com valores informados pelo usuário
    // (utilize um procedimento);
    // (b) determine quantos números no vetor são pares e quantos são ímpares (utilize um
    // procedimento com parâmetros out)

    static void PreencheVetor(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o valor da posição [{i}]: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    static void VerificaParesImpares(int[] vetor, out int pares, out int impares)
    {
        pares = 0;
        impares = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 == 0) pares++;
            else impares++;
        }

        Console.WriteLine("\nPares: " + pares);
        Console.WriteLine("Ímpares: " + impares);
    }

    // 6. Faça um programa em C# que:
    // (a) leia dois números inteiros m e n, correspondentes às dimensões de uma matriz (utilize
    // procedimento);
    // (b) preencha a matriz com valores sequenciais de 1 até (m × n) (utilize procedimento);
    // (c) mostre o conteúdo da matriz (utilize procedimento). 

    static void LerMeN(out int m, out int n)
    {
        Console.Write("Informe o valor de M: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Informe o valor de N: ");
        n = int.Parse(Console.ReadLine());
    }

    static void PreencherMatriz(int[,] matriz)
    {
        int cont = 1;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = cont;
                cont++;
            }
        }
    }

    static void MostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
    }

    // 7. Faça um programa em C# que:
    // (a) leia dois números inteiros m e n, correspondentes às dimensões de uma matriz (utilize
    // procedimento);
    // (b) preencha a matriz com valores sequenciais de 1 até (m × n) (utilize procedimento);
    // (c) mostre a soma dos elementos de cada linha da matriz (utilize procedimento). 

    // LerMeN

    // Preencher Matriz

    static void MostrarSomaLinha(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int soma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
            Console.WriteLine($"Soma da Linha [{i}] = {soma}");
        }
    }

    //     8. Faça um programa em C# que:
    // (a) leia dois números inteiros m e n, correspondentes às dimensões de uma matriz m x n
    // (utilize procedimento);
    // (b) preencha a matriz com valores inteiros informados pelo usuário (utilize procedimento);
    // (c) crie o vetor soma de m posições, calcule e armazene em cada posição i do vetor soma a
    // soma dos elementos da linha i da matriz (utilize função).

    // LerMeN

    static void PreencherMatrizUsuario(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Informe o valor da posição [{i}, {j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[] RetornaSoma(int[,] matriz)
    {
        int[] vetor = new int[matriz.GetLength(0)];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int soma = 0;
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
            vetor[i] = soma;
        }

        return vetor;
    }

    // 9. Faça um programa em C# que:
    // (a) leia dois números inteiros m e n, correspondentes às dimensões de uma matriz (utilize
    // procedimento);
    // (b) preencha a matriz com valores sequenciais de 1 até (m × n) (utilize procedimento);
    // (c) crie e retorne a matriz transposta da matriz lida na letra b (utilize função). 

    // LerMeN
    // PreencherMatriz

    static int[,] RetornaTransposta(int[,] matriz)
    {
        int[,] matrizaux = new int[matriz.GetLength(1), matriz.GetLength(0)];

        for (int i = 0; i < matrizaux.GetLength(0); i++)
        {
            for (int j = 0; j < matrizaux.GetLength(1); j++)
            {
                matrizaux[i, j] = matriz[j, i];
            }
        }

        return matrizaux;
    }

    // 10. Elabore um programa em C# para auxiliar o controle de notas de uma turma. O
    // programa deve:
    // a) Ler o número de alunos n e o número de provas m.
    // b) Criar uma matriz notas[n][m] para armazenar as notas dos alunos.
    // c) Criar um vetor medias[n] para armazenar a média de cada aluno.
    // d) Utilizar:
    // o Um procedimento para ler todas as notas e preencher a matriz.
    // o Uma função para calcular a média das notas de um aluno.
    // o Um procedimento para preencher o vetor de médias utilizando a função.
    // o Um procedimento para exibir a matriz de notas e o vetor de médias.

    static void LerAlunosProvas(out int n, out int m)
    {
        Console.Write("Informe o número (n) de alunos: ");
        n = int.Parse(Console.ReadLine());

        Console.Write("Informe o número (m) de provas: ");
        m = int.Parse(Console.ReadLine());
    }
    static void LerNotas(int[,] notas)
    {
        for (int i = 0; i < notas.GetLength(0); i++)
        {
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                Console.Write($"Informe a nota {j + 1} do aluno {i + 1}: ");
                notas[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    static double CalculaMediaUmAluno(int[,] notas, int indice)
    {
        int auxiliar = indice;

        double media = 0;

        for (int i = 0; i < notas.GetLength(0); i++)
        {
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                if (auxiliar == i) media += notas[i, j];
            }
        }

        return media / notas.GetLength(1);
    }
    static void PreencherMedias(double[] medias, int[,] notas)
    {
        for (int i = 0; i < medias.Length; i++)
        {
            medias[i] = CalculaMediaUmAluno(notas, i);
        }
    }
    static void ExibeAlunosEMedia(double[] medias, int[,] notas)
    {
        Console.WriteLine("\nMatriz Alunos x Notas: ");

        for (int i = 0; i < notas.GetLength(0); i++)
        {
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                Console.Write(notas[i, j] + " ");
            }
            Console.WriteLine(" ");
        }

        Console.WriteLine("\nVetor de Médias: ");
        for (int i = 0; i < medias.Length; i++)
        {
            Console.Write(medias[i] + " ");
        }
    }
    static void Main()
    {
        LerAlunosProvas(out int n, out int m);
        int[,] notas = new int[n, m];
        double[] medias = new double[n];
        LerNotas(notas);
        PreencherMedias(medias, notas);
        ExibeAlunosEMedia(medias, notas);

    }
}