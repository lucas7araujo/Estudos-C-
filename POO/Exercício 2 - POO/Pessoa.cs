using System;

class Pessoa
{
    public string nome;
    public double altura, peso;
    public double RetornaIMC() => peso / Math.Pow(altura, 2);

    public string RetornaSituacao(double imc)
    {
        if (imc <= 18.5) return "Abaixo do peso";
        else if (imc < 25) return "Peso normal";
        else if (imc < 30) return "Acima do peso";
        else if (imc < 35) return "Obesidade I";
        else if (imc < 40) return "Obesidade II";
        else if (imc >= 40) return "Obesidade III";
        else return "Erro de compilação";
    }

    public void RetornaMensagem()
    {
        double imc = RetornaIMC();
        string situacao = RetornaSituacao(imc);
        Console.WriteLine($"Nome do paciente: {nome} | Peso: {peso} - Altura:{altura}\nIMC: {imc:F2}\nSituação: {situacao}");
    }
}