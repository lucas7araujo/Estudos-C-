class Pessoa
{
    // O construtor deve ser público!
    public Pessoa()
    {
        Console.WriteLine("Construtor Executado");
    }

// Posso ter mais de um construtor -> Dependendo de quais parâmetros forem passados
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}!");
    }
}

