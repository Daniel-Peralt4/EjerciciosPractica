﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaPolimorfismoInterface
{
    internal class Animal : IAnimal
    {
        private string nombre;

        public Animal(string nombre) {

            this.nombre = nombre;
        }
        //public string getNombre() { return nombre; }
        //public void setNombre(string nombre) { this.nombre = nombre; }

        public virtual void Comunicarse()
        {
            Console.WriteLine("Hacer sonido");
        }
    }
}
