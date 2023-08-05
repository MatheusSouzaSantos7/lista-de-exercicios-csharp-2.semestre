using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio2_forms
{
    public partial class Form1 : Form
    {
        Valores valor = new Valores();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            valor.x = Convert.ToDouble(textBoxLadoX.Text);
            valor.y = Convert.ToDouble(textBoxLadoY.Text);
            valor.z = Convert.ToDouble(textBoxLadoZ.Text);
            labelResultado.Text = "Resultado: " + valor.Calcular();
        }
    }
}
