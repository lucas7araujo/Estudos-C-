using System;

class Aluno
{
    // Atributos

    public string nome;
    public double nota1, nota2;

    // Média
    public double RetornaMedia() => (nota1 + nota2) / 2;

    // Situação
    public string RetornaSituacao(double media) => (media >= 7) ? "Aprovado" : "Reprovado";

    // Mensagem
    public void RetornaMensagem()
    {
        double obterMedia = RetornaMedia();
        string obterSituacao = RetornaSituacao(obterMedia);

        Console.WriteLine($"Informações do aluno\nNome: {nome}\nMédia: {obterMedia:F2}\nSituação: {obterSituacao}");
    }
}