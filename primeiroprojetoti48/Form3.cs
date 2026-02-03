using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace primeiroprojetoti48
{
    public partial class Form3 : Form
    {
        List<Produtos> lista = new List<Produtos>();
        int proximoId = 1;

        Connection con = new Connection();

        public Form3()
        {
            InitializeComponent();
        }

        public class Connection
        {
            string connectionString = @"Server= .\BDSENAC; Database=AgendaDB; User Id= senaclivre; Password= senaclivre;";

            public SqlConnection Connect()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
        }

        /*
        =========================================
                    LIMPAR CAMPOS
        =========================================*/

        void LimparCampos()
        {
            Nometxt.Clear();
            Descricaotxt.Clear();
            Precotxt.Clear();
            Estoquetxt.Clear();
            Categoriatxt.SelectedIndex = -1;

            Nometxt.Focus();
        }

        void AtualizarGrid()
        {
            using (SqlConnection conn = con.Connect())
            {

                string sql = "SELECT * FROM Produtos ORDER BY ID";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                GridView.DataSource = dt;
            }
        }


        /*
        =========================================
                    ADICIONAR PRODUTOS
        =========================================*/
        private void Addbnt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nometxt.Text))
            {
                MessageBox.Show("Informe o nome do produto!");
                return;
            }

            try
            {
                using (SqlConnection conn = con.Connect())
                {

                    string sql = @"INSERT INTO Produtos (Nome, Descricao, Preco, Estoque, Categoria) VALUES (@Nome, @Descricao, @Preco, @Estoque, @Categoria)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Nome", Nometxt.Text);
                    cmd.Parameters.AddWithValue("@Descricao", Descricaotxt.Text);
                    cmd.Parameters.AddWithValue("@Preco", Precotxt.Text);
                    cmd.Parameters.AddWithValue("@Estoque", Estoquetxt.Text);
                    cmd.Parameters.AddWithValue("@Categoria", Categoriatxt.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Produto Cadastrado");
                AtualizarGrid();
                LimparCampos();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            LimparCampos();
        }



        /*
       =========================================
                   ALTERAR PRODUTOS
       =========================================*/
        private void Altbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um registro para alterar");
                return;
            }

            if (!decimal.TryParse(Precotxt.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(Estoquetxt.Text, out int estoque))
            {
                MessageBox.Show("Estoque inválido!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = @"UPDATE Produtos SET Nome=@Nome, Descricao=@Descricao, Preco=@Preco, Estoque=@Estoque, Categoria=@Categoria WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", IDtxt.Text);
                cmd.Parameters.AddWithValue("@Nome", Nometxt.Text);
                cmd.Parameters.AddWithValue("@Descricao", Descricaotxt.Text);
                cmd.Parameters.AddWithValue("@Preco", Precotxt.Text);
                cmd.Parameters.AddWithValue("@Estoque", Estoquetxt.Text);
                cmd.Parameters.AddWithValue("@Categoria", Categoriatxt.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Produto Alterado");
            AtualizarGrid();
            LimparCampos();
        }



        /*
       =========================================
                   EXCLUIR PRODUTOS
       =========================================*/
        private void Exbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um produto para excluir!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = "DELETE FROM Produtos WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", IDtxt.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Produto excluído!");
            AtualizarGrid();
            LimparCampos();
        }



        /*
       =========================================
                   CONSULTAR PRODUTOS
       =========================================*/
        private void Consultbnt_Click(object sender, EventArgs e)
        {
            string nomeBusca = Nometxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                MessageBox.Show("Informe o nome do produto para consultar!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = "SELECT * FROM Produtos WHERE Nome LIKE @Nome";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + Nometxt.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum Produto encontrado");
                    return;
                }

                GridView.DataSource = dt;
            }
        }


        /*
       =========================================
                    MOSTRAR PRODUTOS
       =========================================*/
        private void MostrarPbnt_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }



        /*
       =========================================
                       GRIDVIEW
       =========================================*/
        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IDtxt.Text = GridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                Nometxt.Text = GridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                Descricaotxt.Text = GridView.Rows[e.RowIndex].Cells["Descricao"].Value.ToString();
                Precotxt.Text = GridView.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
                Estoquetxt.Text = GridView.Rows[e.RowIndex].Cells["Estoque"].Value.ToString();
                Categoriatxt.Text = GridView.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();


            }
        }
    }
}
