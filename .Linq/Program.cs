using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var fruits = new List<string>();
        fruits.Add("Banana");
        fruits.Add("Maçã");
        fruits.Add("Pêssego");
        fruits.Add("Tomate");

        string s = string.Join(" ", fruits);
        string t = string.Join(" ", s.Split(' ').Reverse());
        Console.WriteLine(t);

    }
}