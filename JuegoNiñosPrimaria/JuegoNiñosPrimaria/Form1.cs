﻿using System;
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
    public partial class AprenderCalculando : Form
    {
        public AprenderCalculando()
        {
            InitializeComponent();
        }

        private void btnPracticar_Click(object sender, EventArgs e)
        {
            Practica MenuPractica = new Practica();
            MenuPractica.Show();
            this.Hide();
            
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Prueba MenuPrueba = new Prueba();
            MenuPrueba.Show();
            this.Hide();
        }

        private void AprenderCalculando_Load(object sender, EventArgs e)
        {

        }
    }
}
