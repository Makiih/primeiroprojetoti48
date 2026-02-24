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

    /* CREATE DATABASE AgendaDB;
USE AgendaDB

CREATE TABLE Contatos
(
 ID INT IDENTITY(1,1) PRIMARY KEY,
 Nome NVARCHAR(100),
 Telefone NVARCHAR(20),
 Email NVARCHAR(100),
 Dt DATE
);


CREATE TABLE Produtos
(
 ID INT IDENTITY(1,1) PRIMARY KEY,
 Nome NVARCHAR(100),
 Descricao NVARCHAR(300),
 Preco DECIMAL(10,2) NOT NULL,
 Estoque INT NOT NULL,
 Categoria NVARCHAR(150)
);

CREATE TABLE Vendas 
(
 VendaID INT IDENTITY(1,1) PRIMARY KEY,
 IDCliente INT NOT NULL,
 DataVenda DATETIME,
 ValorTotal DECIMAL(10,2) NOT NULL,
 Desconto DECIMAL(5,2)
 CONSTRAINT FK_Vendas_Contatos FOREIGN KEY (IDCliente) REFERENCES Contatos(ID)

);


CREATE TABLE ItensVendas 
(
 ItensVendaID INT IDENTITY(1,1) PRIMARY KEY,
 VendaID INT NOT NULL,
 IDProduto INT NOT NULL,
 Quantidade INT NOT NULL,
 PrecoUnitario DECIMAL(10,2) NOT NULL
 CONSTRAINT FK_ItensVendas_Vendas FOREIGN KEY (VendaID) REFERENCES Vendas(VendaID),
 CONSTRAINT FK_ItensVendas_Produtos FOREIGN KEY (IDProduto) REFERENCES Produtos(ID)
);


SELECT* FROM Contatos
SELECT* FROM Produtos
SELECT* FROM Vendas
SELECT* FROM ItensVendas





*/
}
