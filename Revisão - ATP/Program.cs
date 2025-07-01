using System;

class Program
{

    // 1. Faça um algoritmo em C# que:
    // a) leia o nome, a data de nascimento e a idade de uma pessoa; (utilize um
    // procedimento).
    // b) exiba os valores das três variáveis na tela (utilize um procedimento).

    static void LerInfo(out string nascimento, out string nome, out int idade)
    {
        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Informe sua data de nascimento - EX: 08/08/2006: ");
        nascimento = Console.ReadLine();

        Console.Write("Informe sua idade: ");
        idade = int.Parse(Console.ReadLine());
    }

    static void RetornaInfo(string nascimento, string nome, int idade)
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Data de nascimento: " + nascimento);
        Console.WriteLine("Idade: " + idade);
    }

    //     2. Faça um algoritmo em C# que:
    // a) leia dois valores numéricos inteiros (utilize um procedimento);
    // b) calcule os resultados das quatro operações aritméticas (adição, subtração,
    // multiplicação e divisão) (utilize funções);
    // c) exiba os valores lidos e os resultados das operações (utilize um procedimento)

    static void LerValores(out int n1, out int n2)
    {
        Console.Write("Informe um valor para N1: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Informe um valor para N2: ");
        n2 = int.Parse(Console.ReadLine());
    }
    static int Adicao(int n1, int n2)
    {
        return n1 + n2;
    }

    static int Subtracao(int n1, int n2)
    {
        return n1 - n2;
    }

    static int Multiplicaçao(int n1, int n2)
    {
        return n1 * n2;
    }

    static double Divisao(int n1, int n2)
    {
        double auxn1 = n1 * 1.0;
        double auxn2 = n2 * 1.0;

        return Math.Round(auxn1 / auxn2, 2);
    }

    // 3. Faça um algoritmo em C# que:
    // leia do teclado o valor de uma compra e o valor em dinheiro dado pelo comprador (utilize
    // um procedimento);
    // calcule e exiba o valor do troco (utilize um procedimento). 

    static void LerCompras(out double compra, out double pagamento)
    {
        Console.Write("Informe o valor da compra: ");
        compra = double.Parse(Console.ReadLine());

        Console.Write("Informe o valor do pagamento: ");
        pagamento = double.Parse(Console.ReadLine());
    }

    static void CalcularTroco(double compra, double pagamento)
    {
        if (compra > pagamento) Console.WriteLine("Saldo insuficiente.");
        else if (pagamento >= compra) Console.WriteLine("Troco: R$ " + (pagamento - compra));
    }

    // 4. Faça um algoritmo em C# que:
    // a) leia três números reais (x, y e z) (utilize um procedimento);
    // b) calcule a média aritmética M dos três valores (utilize uma função);
    // c) exiba os valores de x, y, z e M (utilize um procedimento). 

    static void LerReais(out double x, out double y, out double z)
    {
        Console.Write("Informe o valor de X: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor de Y: ");
        y = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor de Z: ");
        z = double.Parse(Console.ReadLine());
    }

    static double MediaAritmetica(double x, double y, double z, out double m)
    {

        m = Math.Round((x + y + z) / 3, 2);
        return m;
    }

    static void ExibirValores(double x, double y, double z, double m)
    {
        Console.WriteLine("X: " + x);
        Console.WriteLine("Y: " + y);
        Console.WriteLine("Z: " + z);
        Console.WriteLine("M: " + m);
    }

    // 5. Faça procedimentos em C# que:
    // a) escrevam todos os números inteiros de x a y, onde x e y são parâmetros;
    // b) escrevam todos os números inteiros pares entre x e y (inclusive), onde x e y são
    // parâmetros;
    // c) escrevam todos os números inteiros múltiplos de 3 entre x e y (inclusive), onde x e y
    // são parâmetros;
    // d) escrevam todos os números inteiros que sejam pares e múltiplos de 3 x e y (inclusive),
    // onde x e y são parâmetros;

    static void NumerosExtremos(out int a, out int b)
    {
        Console.Write("Informe o valor de A: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor de B: ");
        b = int.Parse(Console.ReadLine());

        int aux = 0;

        if (b < a)
        {
            aux = b;
            b = a;
            a = aux;
        }

    }

    static void EscreveInteirosEntre(int a, int b)
    {
        Console.WriteLine("\nNúmeros Inteiros Entre A e B: ");

        for (int i = a + 1; i < b; i++)
        {
            Console.Write(i + " ");
        }
    }

    static void EscreveInteirosInclusive(int a, int b)
    {
        Console.WriteLine("\nNúmeros Inteiros Entre (e inclusive) A e B: ");

        for (int i = a; i <= b; i++)
        {
            Console.Write(i + " ");
        }
    }

    static void EscreveInteirosPares(int a, int b)
    {
        Console.WriteLine("\nNumeros Pares Entre (e inclusive) A e B: ");

        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0) Console.Write(i + " ");
        }
    }

    static void EscreveMultiploDeTres(int a, int b)
    {
        Console.WriteLine("\nNumeros Múltiplos de 3 Entre (e inclusive) A e B: ");

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0) Console.Write(i + " ");
        }
    }

    static void EscreveParesEMultiplosDeTres(int a, int b)
    {
        Console.WriteLine("\nNumeros Pares E Múltiplos de 3 Entre (e inclusive) A e B: ");

        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0 && i % 2 == 0) Console.Write(i + " ");
        }
    }

    static void Main()

    {
        NumerosExtremos(out int a, out int b);
        EscreveInteirosEntre(a, b);
        EscreveInteirosInclusive(a, b);
        EscreveInteirosPares(a, b);
        EscreveMultiploDeTres(a, b);
        EscreveParesEMultiplosDeTres(a, b);
    }
}