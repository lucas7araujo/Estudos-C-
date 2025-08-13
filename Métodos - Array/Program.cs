using System;
class Program
{
    static void Main()
    {
        // Iteração e Transformação

        // Executa uma ação para cada elemento do array. Não retorna nada — é usado para efeitos colaterais (como imprimir, alterar valores, etc).
        // int[] inteiros = { 1, 2, 7, 8, 9 };
        // Array.ForEach(inteiros, n => Console.Write(n + 1 + " "));
        // Console.WriteLine();

        // // Exibir ou percorrer um array
        // foreach (int n in inteiros) Console.Write(n + " ");

        // Retorna o índice da primeira ocorrência do valor. 
        // Se não encontrar, retorna -1.
        // int[] inteiros = { 10, 20, 30, 40, 20 };
        // int index = Array.IndexOf(inteiros, 20); // 1
        // Console.WriteLine(index);

        // Organiza os elementos em ordem crescente.
        
        int[] inteiros = { 10, 20, 30, 40, 20 };
        Array.Sort(inteiros);
        // Resultado: { 10, 20, 20, 30, 40 }
    }
}