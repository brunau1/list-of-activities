using System;

class Program
{
    static void Main(string[] args)
    {

        int x = 1, y = 0, aux = 0;


        Console.WriteLine("Digite um número inteiro");
        aux = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite outro número inteiro");
        y = int.Parse(Console.ReadLine());

        while (y > 0)
        {
            x *= aux;
            y--;
        }

        Console.WriteLine(x);
        Console.ReadKey();

    }
}