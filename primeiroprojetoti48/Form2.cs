using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        List<Contatos> lista = new List<Contatos>();

        Connection con = new Connection();

        public Form2()
        {
            InitializeComponent();
        }


        //CLASSES      

        public class Connection
        {
            string connectionString = @"Server=.\BDSENAC; Database=AgendaDB; User ID=senaclivre; Password=senaclivre;";

            public SqlConnection Connect()
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
        }



        /*
        =========================================
                    VALIDAR EMAIL
        =========================================*/
        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }


        /*
        =========================================
                    LIMPAR CAMPOS
        =========================================*/
        void LimparCampos()
        {
            IDtxt.Clear();
            Nometxt.Clear();
            Teltxt.Clear();
            Emailtxt.Clear();
            DataRegistro.Value = DateTime.Now;

            Nometxt.Focus();
        }

        void AtualizarGrid()
        {
            using (SqlConnection conn = con.Connect())
            {
               
                string sql = "SELECT * FROM Contatos ORDER BY ID";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                GridView.DataSource = dt;
            }
        }

        void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                IDtxt.Text = GridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                Nometxt.Text = GridView.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                Teltxt.Text = GridView.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();
                Emailtxt.Text = GridView.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                DataRegistro.Value = Convert.ToDateTime(GridView.Rows[e.RowIndex].Cells["Dt"].Value);

            }
        }


        void Form2_Load(object sender, EventArgs e)
        {
            Nometxt.Focus();
            AtualizarGrid();
        }


        /*
        =========================================
                    BOTÃO ADICIONAR
        =========================================*/
        void Addbnt_Click(object sender, EventArgs e)
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

            try
            {
                using (SqlConnection conn = con.Connect())
                {
                    string sql = @"INSERT INTO Contatos (Nome, Telefone, Email, Dt) VALUES (@Nome, @Telefone, @Email, @Dt)";
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Nome", Nometxt.Text);
                    cmd.Parameters.AddWithValue("@Telefone", Teltxt.Text);
                    cmd.Parameters.AddWithValue("@Email", Emailtxt.Text);
                    cmd.Parameters.AddWithValue("@Dt", DataRegistro.Value);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro inserido!");
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
                    BOTÃO ALTERAR
        =========================================*/
        void Altbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um registro para alterar");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = @"UPDATE Contatos SET Nome=@Nome, Telefone=@Telefone, Email=@Email, Dt=@Dt WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID", IDtxt.Text);
                cmd.Parameters.AddWithValue("@Nome", Nometxt.Text);
                cmd.Parameters.AddWithValue("@Telefone", Teltxt.Text);
                cmd.Parameters.AddWithValue("@Email", Emailtxt.Text);
                cmd.Parameters.AddWithValue("@Dt", DataRegistro.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro alterado!");
            AtualizarGrid(); ;
            LimparCampos();
        }


        /*
        =========================================
                    BOTÃO EXCLUIR
        =========================================*/
        void Exbnt_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IDtxt.Text, out int id))
            {
                MessageBox.Show("Selecione um contato para excluir!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = "DELETE FROM Contatos WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", IDtxt.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Registro excluído!");
            AtualizarGrid();
            LimparCampos();
        }



        /*
        =========================================
                    BOTÃO CONSULTAR
        =========================================*/
        void Consultbnt_Click(object sender, EventArgs e)
        {
            string nomeBusca = Nometxt.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                MessageBox.Show("Informe o nome para consultar!");
                return;
            }

            using (SqlConnection conn = con.Connect())
            {
                string sql = "SELECT * FROM Contatos WHERE Nome LIKE @Nome";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nome", "%" + Nometxt.Text + "%");

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum contato encontrado");
                    return;
                }

                GridView.DataSource = dt;
            }
        }


        /*
        =========================================
                   BOTÃO MOSTRAR DADOS
        =========================================*/
        void MDbnt_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

    }
}
