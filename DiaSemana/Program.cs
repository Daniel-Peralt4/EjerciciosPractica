using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el día de la semana: ");
            string dia = Console.ReadLine();

            switch (dia.ToUpper())
            {
                case "LUNES":
                case "MARTES":
                case "MIERCOLES":
                case "JUEVES":
                case "VIERNES":
                    Console.Write("No es fin de semana");
                    break;
                case "SABADO":
                case "DOMINGO":
                    Console.Write("Fin de semana");
                    break;
                default:
                    Console.Write("No se ingresó un día correcto");
                    break;
            }
            Console.ReadLine();
        }
    }
}
