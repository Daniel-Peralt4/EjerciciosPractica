using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un nombre: ");
            String nombre = Console.ReadLine();
            Console.Write("Ingrese una ciudad: ");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", bienvenido a " + ciudad + ".");
            Console.Write("Cuantos años tienes?: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años.");

            Console.ReadKey();
        }
    }
}
