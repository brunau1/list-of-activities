using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListActivities
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, y=0, aux=0;

            
            Console.WriteLine("Digite um número inteiro");
            aux = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro");
            y = int.Parse(Console.ReadLine());

            while (y > 0)
            {

                --y;
                x += aux;
            }   

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
