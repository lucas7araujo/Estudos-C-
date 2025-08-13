using System;

class Program
{
    static string InverteFrase(string frase) => string.Join(" ", frase.Split(' ').Reverse());
    static void Main()
    {
        string s = "a good example";
        string resultado = InverteFrase(s);

        Console.WriteLine(resultado);

        // O Slit é responsável por dividir as palavras nos espaços " ";
        // O .Reverse() inverte a ordem ("gabriel", "lucas");
        // Join junta as palavras e adiciona o espaço entre elas 

        // frase = "hello world"
        // ↓
        // Split → ["hello", "world"]
        // ↓
        // Reverse → ["world", "hello"]
        // ↓
        // Join → "world hello"

        Console.WriteLine();
        int[] v = { 1, 2, 3, 4, 5 };
        var inverso = v.Reverse();

        foreach (var item in inverso)
        {
            Console.Write(item + " ");
        }
    }
}