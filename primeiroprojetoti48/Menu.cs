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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Clientes = new Form2(); 
            Clientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Produtos = new Form3();
            Produtos.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Vendas = new Form4();
            Vendas.Show();

        }
    }
}
