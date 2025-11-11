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
        public Form1()
        {
            InitializeComponent();
        }      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double soma1 = double.Parse(num1.Text);
            double soma2 = double.Parse(num2.Text);
            double resultado = soma1 + soma2;
            result.Text = resultado.ToString();
        }

        private void Subtraçãobnt_Click(object sender, EventArgs e)
        {
            double subtracao1 = double.Parse(num1.Text);
            double subtracao2 = double.Parse(num2.Text);
            double resultado = subtracao1 - subtracao2;
            result.Text = resultado.ToString();
        }

        private void Multbnt_Click(object sender, EventArgs e)
        {
            double mult1 = double.Parse(num1.Text);
            double mult2 = double.Parse(num2.Text);
            double resultado = mult1 * mult2;
            result.Text = resultado.ToString();
        }

        private void Divibnt_Click(object sender, EventArgs e)
        {
            double dividir1 = double.Parse(num1.Text);
            double dividir2 = double.Parse(num2.Text);
            double resultado = dividir1 / dividir2;
            result.Text = resultado.ToString();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
