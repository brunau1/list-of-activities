using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(Math.Pow(i,2));
        }
        Console.ReadKey();
    }
}