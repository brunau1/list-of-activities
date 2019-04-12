using System;

class Program
{
    static void Main(string[] args)
    {
        double soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += Math.Pow(i,2);
            Console.WriteLine(i);
        }
        Console.WriteLine("soma: {0}",soma);

        Console.ReadKey();
    }
}