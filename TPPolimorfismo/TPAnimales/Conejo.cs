using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAnimales
{
    public class Conejo: Animal
    {
        public int cantidadZanahorias { get; set; }

        public Conejo(int Edad, double Altura, double Peso, int cantidadZanahorias) : base(Edad, Altura, Peso)
        {
            this.cantidadZanahorias = cantidadZanahorias;
        }
       

        public override string imprimirPropiedades()
        {
            return base.imprimirPropiedades() + "\nCantidad de zanahorias comidas: " + cantidadZanahorias;
        }
      
       

        public override string ImprimirComida()
        {
            return "Comer zanahoria";
        }
    }
}
