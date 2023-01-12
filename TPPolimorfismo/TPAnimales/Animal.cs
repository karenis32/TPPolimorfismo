using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAnimales
{
    public abstract class Animal
    {
        public int Edad { get; }
        public double Altura { get; }
        public double Peso { get; }

        public Animal(int Edad, double Altura, double Peso)
        {
            this.Edad = Edad;
            this.Altura = Altura;
            this.Peso = Peso;
        }

        public virtual string imprimirPropiedades()
        {
            return "Conejo\nEdad:" + Edad + "\nAltura: " + Altura + "\nPeso: " + Peso;
        }

        public abstract string ImprimirComida();
    }
}

