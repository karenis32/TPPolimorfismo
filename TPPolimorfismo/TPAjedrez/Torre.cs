using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPolimorfismo.TPAjedrez
{
    public class Torre: PiezaAjedrez
    {
        public override string Mover()
        {
            return "Mover torre en linea recta";
        }
    }
}
