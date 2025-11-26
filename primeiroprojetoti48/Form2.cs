using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form2 : Form
    {
        List<Contato> lista = new List<Contato>();
        int proximoId = 1;

        public class Contato
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public DateTime Dt { get; set; }
        }


        public Form2()
        {
            InitializeComponent();
        }

        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void LimparCampos()
        {
            IDtxt.Clear();
            Nometxt.Clear();
            Teltxt.Clear();
            Emailtxt.Clear();
            DataRegistro.Value = DateTime.Now;

            Nometxt.Focus();
        }

        private void AtualizarGrid()
        {
            GridView.DataSource = null;
            GridView.DataSource = lista;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Nometxt.Focus();
        }


        /*
        =========================================
                    BOTÃO ADICIONAR
        =========================================*/
        private void Addbnt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nometxt.Text))
            {
                MessageBox.Show("Informe o nome!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(Emailtxt.Text) && !EmailValido(Emailtxt.Text))
            {
                MessageBox.Show("Informe um email válido");
                return;

            }


            Contato c = new Contato();
            {
                c.ID = proximoId++;
                c.Nome = Nometxt.Text;
                c.Telefone = Teltxt.Text;
                c.Email = Emailtxt.Text;
                c.Dt = DataRegistro.Value;
            }

            lista.Add(c);
            AtualizarGrid();
            LimparCampos();
        }


        /*
        =========================================
                    BOTÃO ALTERAR
        =========================================*/
        private void Altbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um registro para alterar");
                return;
            }

            int ID = int.Parse(IDtxt.Text);
            var contato = lista.FirstOrDefault(c => c.ID == id);
            if (contato == null)
            {
                MessageBox.Show("Registro não encontrado!");
                return;
            }

            contato.Nome = Nometxt.Text;
            contato.Email = Emailtxt.Text;
            contato.Telefone = Teltxt.Text;
            contato.Dt = DataRegistro.Value;

            AtualizarGrid();
            LimparCampos();
            MessageBox.Show("Contato alterado com sucesso!");
        }


        /*
        =========================================
                    BOTÃO EXCLUIR
        =========================================*/
        private void Exbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um contato para excluir!");
                return;
            }

            var contato = lista.FirstOrDefault(c => c.ID == id);
            if (contato != null)
            {
                lista.Remove(contato);
                AtualizarGrid();
                LimparCampos();
                MessageBox.Show("Contato excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Contato não encontrado!");
            }
        }



        /*
        =========================================
                    BOTÃO CONSULTAR
        =========================================*/
        private void Consultbnt_Click(object sender, EventArgs e)
        {
            string nomeBusca = Nometxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                MessageBox.Show("Informe o nome para consultar!");
                return;
            }

            var resultados = lista.Where(c => c.Nome.ToLower().Contains(nomeBusca)).ToList();

            if (resultados.Count > 0)
            {
                GridView.DataSource = null;
                GridView.DataSource = resultados;
            }
            else
            {
                MessageBox.Show("Nenhum contato encontrado!");
            }
        }


        /*
        =========================================
                   BOTÃO MOSTRAR DADOS
        =========================================*/
        private void MDbnt_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var contato = lista[e.RowIndex];

                IDtxt.Text = contato.ID.ToString();
                Nometxt.Text = contato.Nome;
                Teltxt.Text = contato.Telefone;
                Emailtxt.Text = contato.Email;
                DataRegistro.Value = contato.Dt;

            }
        }


    }
}
