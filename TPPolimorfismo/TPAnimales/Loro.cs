using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAnimales
{
    public class Loro: Animal
    {
        public bool sabeHablar { get; set; }

        public Loro(int Edad, double Altura, double Peso, bool sabeHablar) : base(Edad, Altura, Peso)
        {
            this.sabeHablar = sabeHablar;
        }

        public override string ImprimirComida()
        {
            return "Comer semillas";
        }
    }
}
