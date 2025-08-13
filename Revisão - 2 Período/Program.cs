/*
==============================================
🔁 ATIVIDADE DE REVISÃO - C# BÁSICO
Autor: Lucas (Fullstack em formação 🔥)
Objetivo: Revisar vetores, matrizes, funções e listas
==============================================
*/

// 1. Crie uma função que receba um vetor de inteiros e retorne a média dos valores.
// Ex: int[] numeros = { 10, 20, 30, 40 }; → retorna 25

// 2. Crie uma matriz 3x3 de inteiros e preencha com valores aleatórios de 1 a 100.
// Em seguida, crie uma função que imprima SOMENTE os valores pares da matriz.

// 3. Crie uma lista de nomes (List<string>):
// - Adicione pelo menos 5 nomes
// - Remova um nome específico
// - Verifique se um nome existe na lista (com Console.WriteLine)
// - Imprima todos os nomes usando foreach

// 4. EXTRA: Crie uma função chamada "CadastrarAluno"
// - Ela deve receber nome, nota1, nota2
// - Calcular a média
// - Retornar uma string com nome + média final
// - Chame a função no Main() e exiba o resultado

/*
🚀 Desafio completo? Parabéns!
Quer treinar mais? Tenta transformar esse console app em algo com menu interativo:
1 - Cadastrar aluno
2 - Listar alunos
3 - Sair
*/

using System;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{

    static double RetornaMedia(int[] vetor) => vetor.Average();

    static int[,] PreencheMatriz(int[,] matriz)
    {
        Random random = new Random();

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = random.Next(0, 100);
            }
        }

        return matriz;
    }

    static int[] RetornaPares(int[,] matriz)
    {
        int[] vetor = new int[matriz.GetLength(0) + matriz.GetLength(1)];
        int cont = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    vetor[cont] = matriz[i, j];
                    cont++;
                }
            }
        }

        return vetor;
    }

    static void Questao01()
    {
        int[,] matriz = new int[3, 3];
        PreencheMatriz(matriz);
        int[] vetorPares = RetornaPares(matriz);

        for (int i = 0; i < vetorPares.Length; i++)
        {
            if (vetorPares[i] != 0) Console.Write(vetorPares[i] + " ");
        }
    }

    static void Questao02()
    {
        List<string> nomes = new List<string>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Informe um nome: ");
            nomes.Add(Console.ReadLine());
        }

        Console.WriteLine("\nLista de nomes: \n");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

        Console.Write("\nInforme um nome que deseja remover: ");
        nomes.Remove(Console.ReadLine());

        Console.Write("\nInforme um nome para verificar presença na lista: ");
        bool verifica = nomes.Contains(Console.ReadLine());

        if (verifica) Console.WriteLine("\nNome inscrito na lista!");
        else Console.WriteLine("\nNome não inscrito na lista");

        Console.WriteLine("\nLista de nomes: \n");

        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

    }

    static string CadastrarAluno(string nome, double n1, double n2)
    {
        double media = Math.Round((n1 + n2) / 2, 2);
        return $"Nome: {nome} | Média: {media}";  
    }
    static void Main()
    {
        string nome = "Lucas";
        int n1 = 10, n2 = 8;

        Console.WriteLine(CadastrarAluno(nome, n1, n2));
    }
}