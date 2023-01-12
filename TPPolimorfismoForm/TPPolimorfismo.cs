using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPPolimorfismo.TPAjedrez;
using TPPolimorfismo.TPAnimales;

namespace TPPolimorfismo
{
    public partial class TPPolimorfismo : Form
    {
        public TPPolimorfismo()
        {
            InitializeComponent();
        }

        private void btn_impPropiedades_Click(object sender, EventArgs e)
        {
            Conejo conejo = new Conejo(2, 0.50, 2.300, 4);

            MessageBox.Show(conejo.imprimirPropiedades());
        } 
        
        private void btn_alimentarConejo_Click(object sender, EventArgs e)
        {
            Conejo conejo2 = new Conejo(2, 0.50, 2.300, 4);

            MessageBox.Show(conejo2.ImprimirComida());
        }

        private void btn_alimentarLeon_Click(object sender, EventArgs e)
        {
            Leon leon = new Leon(4, 0.80, 2.500, true);

            MessageBox.Show(leon.ImprimirComida());

        }

        private void btn_alimentarLoro_Click(object sender, EventArgs e)
        {
            Loro loro = new Loro(4, 0.70, 1.500, true);

            MessageBox.Show(loro.ImprimirComida());
        }

       

        private void btn_moverCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();

            MessageBox.Show(caballo.Mover());
        }

        private void btn_moverTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();

            MessageBox.Show(torre.Mover());
        }

        private void bnt_moverPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();

            MessageBox.Show(peon.Mover());
        }
    }
}
