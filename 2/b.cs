using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i;
            Console.WriteLine(i);
        }
        Console.WriteLine("soma: {0}",soma);

        Console.ReadKey();
    }
}

