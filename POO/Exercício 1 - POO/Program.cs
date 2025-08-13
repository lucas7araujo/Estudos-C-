using System;

class Program
{
    static void Main()
    {
        // Instanciar um objeto da classe Aluno
        Aluno a = new Aluno();
        a.nome = "Lucas";
        a.nota1 = 2;
        a.nota2 = 7.2;
        a.RetornaMensagem();
    }
}