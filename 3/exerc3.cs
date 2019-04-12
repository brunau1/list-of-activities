using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0, par = 0, impar = 0;

        while (num != -1)
        {
            Console.WriteLine("Digite um número inteiro");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            par++;
            if (num % 2 != 0 && num != -1)
            impar++;
        }
        Console.WriteLine("Pares: {0}", par);
        Console.WriteLine("Impares: {0}", impar);

        Console.ReadKey();
    }
}