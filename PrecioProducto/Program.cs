using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el precio de un producto: ");
            float precio = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la forma de pago: ");
            String metodo = Console.ReadLine();

            switch(metodo.ToUpper())
            {
                case "EFECTIVO":
                    Console.WriteLine("Pago con efectivo exitoso");
                    break;
                case "TARJETA":
                    Console.Write("Ingrese el No. de cuenta: ");
                    int NCuenta = int.Parse(Console.ReadLine());
                    Console.WriteLine("Pago con tarjeta exitoso");
                    break;
                default:
                    Console.Write("Ingrese una forma de pago válida");
                    break;
            }
            Console.ReadLine();
        }
    }
}
