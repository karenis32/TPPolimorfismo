using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAnimales
{
    public class Leon: Animal
    {
        public bool tieneMelena { get; set; }

        public Leon(int Edad, double Altura, double Peso, bool tieneMelena) : base(Edad, Altura, Peso)
        {
            this.tieneMelena = tieneMelena;
        }

        public override string ImprimirComida()
        {
            return "Comer carne";
        }
    }
}
