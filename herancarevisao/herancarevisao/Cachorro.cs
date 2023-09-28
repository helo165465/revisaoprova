using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancarevisao
{
    internal class Cachorro : Animal
    {
        public string Raca;

        public Cachorro() { }
        public Cachorro(double peso, double altura, string raca):base(peso, altura)
        {
            Raca = raca;

        }
    }
}
