using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;

        Console.WriteLine("Digite um número inteiro");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        if(n%i==0)
        Console.WriteLine(i);

        Console.ReadKey();
    }
}