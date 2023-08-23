using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            float num2 = float.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("El número " + num2 + " es mayor que " + num1);
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El número " + num1 + " es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("Los números son iguales");
            }
            Console.ReadKey();
        }
    }
}
