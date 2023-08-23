using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismoInterface
{
    internal class Perro : Animal
    {
        public Perro(string nombre) : base(nombre)
        {

        }

        public override void Comunicarse()
        {
            Console.WriteLine("Ladrar: ¡Guau, guau!");
        }
    }
}
