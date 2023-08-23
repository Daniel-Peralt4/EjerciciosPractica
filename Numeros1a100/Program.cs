using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros1a100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i += 2)
                Console.WriteLine(i);
            //int N = 1;
            //while (N <= 100)
            //{
            //    Console.WriteLine(N);
            //    if (N % 2 == 0)
            //    {
            //        Console.WriteLine("El número es par");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El número es impar");
            //    }
            //    N++;
            //}

            Console.ReadLine();
        }
    }
}