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
    public partial class Practica : Form
    {
        public Random rng;
        public int a;
        public byte contador;
        public int vari;

        public Practica()
        {
            InitializeComponent();
            rng = new Random();
            a = 0;
            contador = 0;
            vari = 0;
        }
        public void RNG()
        {
            int r = rng.Next(1, 10);
            lblNumero1.Text = Convert.ToString(r);
            r = rng.Next(1, 10);
            lblNumero2.Text = Convert.ToString(r);
        }

        private void Practica_Load(object sender, EventArgs e)
        {
        
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

       

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "-";

            RNG();
            
            a = int.Parse(lblNumero1.Text) - int.Parse(lblNumero2.Text);
            vari = 2;

        
        }

        private void lblNumero2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AprenderCalculando Volver = new AprenderCalculando();
            Volver.Show();
            this.Hide();
        }

        private void btnIgualar_Click(object sender, EventArgs e)
        {
            object r = sender;

            if (a == int.Parse(txtResultado.Text))
            {
               
                ptbUp2.Visible = true;
                ptbDown2.Visible = false;
                RNG();
                if (vari == 1)
                    sumaToolStripMenuItem_Click(r, e);
                if (vari == 2)
                    restaToolStripMenuItem_Click(r, e);
                if (vari == 3)
                    multiplicaciónXToolStripMenuItem_Click(r, e);
                if (vari == 4)
                    divisiónToolStripMenuItem_Click(r, e);
            }
               
                
            else
            {
               
                ptbUp2.Visible = false;
                ptbDown2.Visible = true;
                contador++;

            }

            


            if (contador == 3)
            {
                MessageBox.Show("La respuesta correcta es: " + a);

                contador = 0;
                return;
            }
            txtResultado.Text = "";
        }

        private void multiplicaciónXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "x";

            RNG();

           a = int.Parse(lblNumero1.Text) * int.Parse(lblNumero2.Text);
           vari = 3;
          
            
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "+";
            RNG();
            

            a = int.Parse(lblNumero1.Text) + int.Parse(lblNumero2.Text);
            vari = 1;
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "/";
            RNG();

            a = int.Parse(lblNumero1.Text) / int.Parse(lblNumero2.Text);
            vari = 4;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
