using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form1 : Form
    {
        double resultado, valor1, valor2, porcentagem;
        string operacao;

        public Form1()
        {
            InitializeComponent();
        }      
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  


        //Operações
        private void Somabnt_Click(object sender, EventArgs e)
        {
            operacao = "Adicao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " + ";
            txtDisplay.Clear();
            
        }

        private void Subtraçãobnt_Click(object sender, EventArgs e)
        {
            operacao = "Subtracao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " - ";
            txtDisplay.Clear();
        }

        private void Multbnt_Click(object sender, EventArgs e)
        {
            operacao = "Multiplicacao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " x ";
            txtDisplay.Clear();
        }

        private void Divibnt_Click(object sender, EventArgs e)
        {
            operacao = "Divisao";
            valor1 = double.Parse(txtDisplay.Text);
            txtResultado.Text = valor1.ToString() + " / ";
            txtDisplay.Clear();
        }
        
        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            double porcentagem = resultado / 100;
            txtDisplay.Text = porcentagem.ToString() + " % ";
        }
       
        private void btnApagarDigito_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtDisplay.Text);
            valor1 *= -1;
            txtDisplay.Clear();
            txtDisplay.Text = valor1.ToString();

        }



        //Layout - Números
        private void Form1_Load(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt5.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt4.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt1.Text;
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt7.Text;
        }

        private void bnt2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt2.Text;
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt3.Text;
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt9.Text;
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt8.Text;
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt6.Text;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtResultado.Clear();
        }      

        private void bnt0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bnt0.Text;
        }
       
        private void bntvirgula_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += bntvirgula.Text;
        }

               

        //Igual
        private void bntigual_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "Adicao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 + valor2;
                    txtResultado.Text = valor1.ToString() + " + " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Subtracao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 - valor2;
                    txtResultado.Text = valor1.ToString() + " - " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Multiplicacao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 * valor2;
                    txtResultado.Text = valor1.ToString() + " x " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

                case "Divisao":
                    valor2 = double.Parse(txtDisplay.Text);
                    resultado = valor1 / valor2;
                    txtResultado.Text = valor1.ToString() + " / " + valor2.ToString();
                    txtDisplay.Text = resultado.ToString();
                    break;

               
            }
        }
    }
}
