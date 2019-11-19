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
        public byte CantOperaciones;
        public int vari;
        public int n1;
        public int n2;
        string [] ope;
        string correcto;
        string incorrecto;
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
            correcto = "Correcto";
            incorrecto = "Incorrecto";

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

            if (vari == 1)
                lblOperacion.Text = "+";
            if (vari == 2)
                lblOperacion.Text = "-";
            if (vari == 3)
                lblOperacion.Text = "x";
            if (vari == 4)
                lblOperacion.Text = "/";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void Suma()
        {
            a = int.Parse(lblNumero1.Text) + int.Parse(lblNumero2.Text);
           
        }
        public void Resta()
        {
            if (int.Parse(lblNumero1.Text) < int.Parse(lblNumero2.Text))
                Resta();
            else
                a = int.Parse(lblNumero1.Text) - int.Parse(lblNumero2.Text);
          
        }
        public void Division()
        {
            if (int.Parse(lblNumero1.Text) < int.Parse(lblNumero2.Text) || int.Parse(lblNumero1.Text) < 0)
                Division();
            else
                a = int.Parse(lblNumero1.Text) / int.Parse(lblNumero2.Text);
           

        }
        public void Multiplicacion()
        {
            a = int.Parse(lblNumero1.Text) * int.Parse(lblNumero2.Text);
           
        }

      

        private void Prueba_Load(object sender, EventArgs e)
        {

        }

        private void btnNumMinNumMax_Click(object sender, EventArgs e)
        {
            n1 = int.Parse(txtBoxNumMinimo.Text);
            n2 = int.Parse(txtBoxNumMaximo.Text);
            groupBox1.Visible = false;
            RNG();
        }

        private void btnIgualar_Click_1(object sender, EventArgs e)
        {
            if (a == int.Parse(txtResultado.Text))
            {

                if (vari == 1)
                    Suma();
                if (vari == 2)
                    Resta();
                if (vari == 3)
                    Multiplicacion();
                if (vari == 4)
                    Division();
                ope[contador] = lblNumero1.Text + lblOperacion.Text + lblNumero2.Text + " = " + a.ToString() + correcto;
                contador++;
                RNG();
                CantOperaciones++;
            }


            else
            {
                if (vari == 1)
                    Suma();
                if (vari == 2)
                    Resta();
                if (vari == 3)
                    Multiplicacion();
                if (vari == 4)
                    Division();
                ope[contador] = lblNumero1.Text + lblOperacion.Text + lblNumero2.Text + " = " + a.ToString() + incorrecto;
                contador++;
                RNG();
                CantOperaciones++;
            }




            if (CantOperaciones == 10)
            {
                MessageBox.Show("Termino el examen");
                foreach (string x in ope)
                    Console.WriteLine(x);
                return;
            }
            txtResultado.Text = "";
        }
    }
}
