using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoNiñosPrimaria
{
    public partial class EleccionPrueba : Form
    {
        public EleccionPrueba()
        {
            InitializeComponent();
            
        }

        private void EleccionPrueba_MouseHover(object sender, EventArgs e)
        {

        }
       
        
        private void PuertaCerrada_Click(object sender, EventArgs e) => PuertaCerrada.Hide();

       

        private void EleccionPrueba_Click_2(object sender, EventArgs e)
        {
            PuertaCerrada.Show();
        }
    }
}
