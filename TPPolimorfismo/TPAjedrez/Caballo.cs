using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAjedrez
{
    public class Caballo: PiezaAjedrez
    {
        public override string Mover()
        {
            return "Mover caballo en diagonal";
        }
    }
}
