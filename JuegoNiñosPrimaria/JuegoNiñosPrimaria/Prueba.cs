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
    public partial class Prueba : Form
    {
        public Random rng;
        public Random op;
        public int a;
        public byte contador;
        public int vari;
        public int n1;
        public int n2;
        string [] ope; 
    public Prueba()
        {
            InitializeComponent();
            rng = new Random();
            op = new Random();
            a = 0;
            contador = 0;
            vari = 0;
            n1 = 0;
            n2 = 0;
            groupBox1.Visible = true;
            ope = new string[10];
        }

        public void RNG()
        {
            int r = rng.Next(n1, n2);
            lblNumero1.Text = Convert.ToString(r);
            r = rng.Next(n1, n2);
            lblNumero2.Text = Convert.ToString(r);
            ORG();
        
        }

        public void ORG()
        {
            vari = rng.Next(1, 4);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void Suma()
        {

        }
        public void Resta()
        {

        }
        public void Division()
        {

        }
        public void Multiplicacion()
        {

        }

        private void btnIgualar_Click(object sender, EventArgs e)
        {
            object r = sender;

            if (a == int.Parse(txtResultado.Text))
            {

              
                RNG();

                if (vari == 1)
                    Suma();
                if (vari == 2)
                    Resta();
                if (vari == 3)
                    Multiplicacion();
                if (vari == 4)
                   Division();
                ope[contador] = lblNumero1.Text + lblOperacion.Text + lblNumero2.Text + " = " + a.ToString();
                contador++;
                ORG();
            }


            else
            {

                

               
            }




            if (contador == 3)
            {
                MessageBox.Show("La respuesta correcta es: " + a);

                contador = 0;
                return;
            }
            txtResultado.Text = "";
        }
    }
}
