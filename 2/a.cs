using System;

class Program
{
    static void Main(string[] args)
    {
        float[] numero = new float[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um número");
            numero[i] = float.Parse(Console.ReadLine())/2;
        }
        for (int i = 1; i < 10; i++)
        Console.WriteLine("{0}", numero[i]);

        Console.ReadKey();
    }
}