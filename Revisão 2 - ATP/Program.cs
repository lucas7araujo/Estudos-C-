using System;

class Program
{
    //     🔹 Exercício 1 – Cadastro de Produto
    // a) Faça um procedimento para ler: nome do produto, preço e quantidade em estoque.
    // b) Crie um procedimento que exiba as informações na tela.
    // c) Crie uma função que calcule o valor total do estoque (preço * quantidade).
    // d) Exiba o valor total usando um procedimento.

    static void LerProduto(out string produto, out double preco, out int quantidade)
    {
        Console.Write("Informe o nome do produto: ");
        produto = Console.ReadLine();

        Console.Write("Informe o preço do produto: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Informe a quantidade de produtos no estoque: ");
        quantidade = int.Parse(Console.ReadLine());
    }

    static void ExibeProduto(string produto, double preco, int quantidade)
    {
        Console.WriteLine("\nProduto: " + produto);
        Console.WriteLine("Preço: R$ " + preco);
        Console.WriteLine("Quantidade disponível: " + quantidade);
    }

    static double CalculaEstoque(double preco, int quantidade, out double valortotal)
    {
        valortotal = preco * quantidade;
        valortotal = Math.Round(valortotal, 2);
        return valortotal;
    }

    static void ValorTotal(double valortotal)
    {
        Console.WriteLine("Valor total do estoque: R$ " + valortotal);
    }

    //     🔹 Exercício 2 – Temperatura
    // a) Crie um procedimento que leia uma temperatura em graus Celsius.
    // b) Crie uma função que converta essa temperatura para Fahrenheit.
    // c) Crie um procedimento que mostre as duas temperaturas.

    static void LerTemperatura(out double grausCelsius)
    {
        Console.Write("\nInforme a temperatura em graus Celsius: ");
        grausCelsius = double.Parse(Console.ReadLine());
    }
    static double CelsiusParaFahrenheit(out double grausFahrenheit, double grausCelsius)
    {
        grausFahrenheit = (grausCelsius * 1.8) + 32;
        return grausFahrenheit;
    }
    static void MostraTemperaturas(double grausFahrenheit, double grausCelsius)
    {
        Console.WriteLine("\nGraus Celsius: " + grausCelsius);
        Console.WriteLine("\nApós Conversão -> Graus Fahrenheit: " + grausFahrenheit);
    }


    // 🔹 Exercício 3 – Calculadora de IMC
    // a) Crie um procedimento para ler peso (kg) e altura (m) de uma pessoa.
    // b) Crie uma função que calcule o IMC: IMC = peso / (altura * altura)
    // c) Crie um procedimento que mostre o IMC e a classificação:

    // Abaixo de 18.5: Abaixo do peso

    // Entre 18.5 e 24.9: Peso normal

    // Entre 25 e 29.9: Sobrepeso

    // 30 ou mais: Obesidade

    static void LerPesoEAltura(out double peso, out double altura)
    {

        Console.Write("\nInforme o seu peso (kg): ");
        peso = double.Parse(Console.ReadLine());

        Console.Write("Informe sua Altura (m): ");
        altura = double.Parse(Console.ReadLine());
    }

    static double CalculaIMC(double peso, double altura, out double imc)
    {
        imc = peso / (altura * altura);
        imc = Math.Round(imc, 2);
        return imc;
    }

    static void ClassificaIMC(double imc)
    {
        if (imc < 18.5) Console.WriteLine("Abaixo do peso.");
        else if (imc >= 18.5 && imc < 25) Console.WriteLine("Peso normal.");
        else if (imc >= 25 && imc <= 29.9) Console.WriteLine("Sobrepeso.");
        else if (imc >= 30) Console.WriteLine("Obesidade.");
    }

    // 🔹 Exercício 4 – Vendas da Semana
    // a) Crie um procedimento que leia o valor total de vendas dos 7 dias da semana.
    // b) Crie uma função que calcule a média de vendas.
    // c) Crie um procedimento que mostre a média e diga se ela foi:

    // Abaixo de R$500 → "Baixo desempenho"

    // Entre R$500 e R$1000 → "Desempenho médio"

    // Acima de R$1000 → "Ótimo desempenho"

    static void VendasDaSemana(out double vendastotais)
    {
        vendastotais = 0;

        Console.Write("Informe as vendas de Domingo: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Segunda-feira: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Terça-feira: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Quarta-feira: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Quinta-feira: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Sexta-feira: ");
        vendastotais += double.Parse(Console.ReadLine());

        Console.Write("Informe as vendas de Sábado: ");
        vendastotais += double.Parse(Console.ReadLine());

    }

    static double MediaVendas(double vendastotais, out double mediavendas)
    {
        mediavendas = Math.Round(vendastotais / 7, 2);
        return mediavendas;
    }

    static void DesempenhoVendas(double mediavendas)
    {
        Console.WriteLine("\nMédia das Vendas: R$ " + mediavendas);
        if (mediavendas < 500) Console.WriteLine("Baixo Desempenho.");
        else if (mediavendas >= 500 && mediavendas <= 1000) Console.WriteLine("Desempenho Médio.");
        else if (mediavendas > 1000) Console.WriteLine("Ótimo desempenho.");

    }

    // 🔹 Exercício 5 – Verificação de Palíndromo
    // a) Crie um procedimento que leia uma palavra.
    // b) Crie uma função que verifique se a palavra é um palíndromo (ex: "radar", "ana").
    // c) Crie um procedimento que exiba a palavra e o resultado da verificação.

    static void LerPalavra(out string palavra)
    {
        Console.Write("Informe uma palavra: ");
        palavra = Console.ReadLine();
    }
    static bool VerificaPalindromo(string palavra, out bool resultado)
    {
        string palavrainvertida = "";

        for (int i = palavra.Length - 1; i >= 0; i--)
        {
            palavrainvertida += palavra[i];
        }

        resultado = palavra == palavrainvertida;
        return resultado;
    }
    static void PalavraEResultado(string palavra, bool resultado)
    {
        Console.WriteLine("Palavra: " + palavra);

        if (resultado) Console.WriteLine("É Palíndromo!");
        else Console.WriteLine("Não É Palíndromo!");
    }

    // 🔹 Exercício 6 – Número Perfeito
    // a) Crie um procedimento que leia um número inteiro.
    // b) Crie uma função que verifique se esse número é perfeito (a soma de seus divisores é igual a ele).
    // Exemplo: 6 → divisores 1, 2, 3 → 1+2+3 = 6
    // c) Crie um procedimento que exiba o número e se ele é perfeito ou não.

    static void LerNumeroInt(out int n)
    {
        Console.Write("Informe um número inteiro: ");
        n = int.Parse(Console.ReadLine());
    }

    static string VerificaNumeroInt(int n, out string resultado)
    {
        int soma = 0;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0) soma += i;
        }

        Console.WriteLine(soma);

        if (soma == n) resultado = ("Número Perfeito! ");
        else resultado = ("Número Imperfeito!");

        return resultado;
    }

    static void ResultadoNumeroInt(int n, string resultado)
    {
        Console.WriteLine("\nNúmero: " + n);
        Console.WriteLine("Resultado: " + resultado);
    }

    // 🔹 Exercício 7 – Salário com Bônus
    // a) Crie um procedimento que leia o salário base e o percentual de bônus (ex: 10%).
    // b) Crie uma função que calcule o salário final com bônus.
    // c) Crie um procedimento que mostre o salário base, bônus e salário final.

    static void LerSalario(out double salariobase, out double bonus)
    {
        Console.Write("Informe o salário base do funcionário: ");
        salariobase = double.Parse(Console.ReadLine());

        Console.Write("Informe o bonûs do funcionário (%): ");
        bonus = double.Parse(Console.ReadLine());
    }

    static void Main()
    {
        LerPalavra(out string palavra);
        VerificaPalindromo(palavra, out bool resultado);
        PalavraEResultado(palavra, resultado);
    }
}