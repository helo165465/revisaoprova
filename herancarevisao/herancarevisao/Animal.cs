using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancarevisao
{
    internal class Animal
    {
        public double peso { get; set; }
        public double altura { get; set; }

        public Animal(){}
        public Animal(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
    }
}
