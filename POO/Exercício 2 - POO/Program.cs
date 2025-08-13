using System;

class Program
{
    static void Main()
    {
        Pessoa a = new Pessoa();
        a.nome = "Lucas";
        a.peso = 74.5;
        a.altura = 1.73;

        a.RetornaMensagem();
    }
}