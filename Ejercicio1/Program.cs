using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float var1 = 0;
            float var2 = 0;
            float var3 = 0;
            float suma = 0;

            Console.Write("Ingrese el primer numero: ");
            var1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            var2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer numero: ");
            var3 = float.Parse(Console.ReadLine());

            suma = var1 + var2 + var3;

            Console.Write("La suma de los 3 numeros es: " + suma);
            Console.ReadKey();
        }
    }
}
