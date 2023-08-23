using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismoInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal perro = new Perro("Bruno");
            IAnimal gato = new Gato("Pelusa");
            IAnimal burro = new Animal("Patiño");

            //Comunicarse(perro);
            perro.Comunicarse();
            Comunicarse(gato);
            Comunicarse(burro);
        }

        static void Comunicarse(IAnimal animal)
        {
            animal.Comunicarse();
        }
    }
}
