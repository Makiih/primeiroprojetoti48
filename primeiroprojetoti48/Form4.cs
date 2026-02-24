using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroprojetoti48
{
    public partial class Form4 : Form
    {
        Connection con = new Connection();
        decimal totalVenda = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
            ConfigurarGrid();
            CarregarClientes();
            DataCompra.Value = DateTime.Now;

            txtProduto.Enabled = false;
            txtQtd.Enabled = false;
            btnAdicionar.Enabled = false;
            btnFinalizar.Enabled = false;


        }

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


        void CarregarProdutos()
        {
            using (SqlConnection conn = con.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ID, Nome, Preco FROM Produtos", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                txtProduto.DisplayMember = "Nome";
                txtProduto.ValueMember = "ID";
                txtProduto.DataSource = dt;
            }
        }

        void ConfigurarGrid()
        {
            GridView.Columns.Clear();

            GridView.Columns.Add("IDProduto", "ID Produto");
            GridView.Columns.Add("Produto", "Produto");
            GridView.Columns.Add("Quantidade", "Quantidade");
            GridView.Columns.Add("Preco", "Preço Unitário");
            GridView.Columns.Add("Subtotal", "Subtotal");

            GridView.Columns["IDProduto"].Visible = false;
            GridView.AllowUserToAddRows = false;
        }



        /*   COMBO BOX   */
        private void txtProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtProduto.SelectedValue == null) return;

            using (SqlConnection conn = con.Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Preco FROM Produtos WHERE ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", txtProduto.SelectedValue);
                txtPrecoU.Text = cmd.ExecuteScalar().ToString();
                txtIDProduto.Text = txtProduto.SelectedValue.ToString();

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQtd.Text, out int qtd))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }
            decimal preco = decimal.Parse(txtPrecoU.Text);
            decimal subtotal = qtd * preco;
            totalVenda += subtotal;

            GridView.Rows.Add(
                txtIDProduto.Text,
                txtProduto.Text,
                qtd,
                preco.ToString("N2"),
                subtotal.ToString("N2")
            );
            txtValorTotal.Text = totalVenda.ToString("N2");
            txtQtd.Clear();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDesconto.Text, out decimal desconto))

            {
                decimal valorFinal = totalVenda - (totalVenda * desconto / 100);
                txtValorTotal.Text = valorFinal.ToString("N2");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridView.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum item na venda!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
                {
                    MessageBox.Show("Selecione um cliente antes de finalizar a venda!");
                    return;
                }

                // Converter valores para decimal
                if (!decimal.TryParse(txtValorTotal.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal valorTotal))
                {
                    MessageBox.Show("Valor total inválido!");
                    return;
                }

                decimal desconto = 0;
                if (!string.IsNullOrWhiteSpace(txtDesconto.Text))
                {
                    if (!decimal.TryParse(txtDesconto.Text, NumberStyles.Any, new CultureInfo("pt-BR"), out desconto))
                    {
                        MessageBox.Show("Desconto inválido!");
                        return;
                    }
                }

                using (SqlConnection conn = con.Connect())
                {
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmdVenda = new SqlCommand(
                            @"INSERT INTO Vendas  
                      (IDCliente, DataVenda, ValorTotal, Desconto) 
                      OUTPUT INSERTED.VendaID 
                      VALUES (@Cliente, @Data, @Total, @Desconto)",
                            conn, trans);

                        cmdVenda.Parameters.AddWithValue("@Cliente", txtIDCliente.Text);
                        cmdVenda.Parameters.AddWithValue("@Data", DataCompra.Value);
                        cmdVenda.Parameters.AddWithValue("@Total", valorTotal);
                        cmdVenda.Parameters.AddWithValue("@Desconto", desconto);

                        int vendaId = (int)cmdVenda.ExecuteScalar();

                        foreach (DataGridViewRow row in GridView.Rows)
                        {
                            if (row.IsNewRow) continue; // Ignorar a linha de nova inserção

                            SqlCommand cmdItem = new SqlCommand(
                                @"INSERT INTO Itens_Vendas 
                          (VendaID, IDProduto, Quantidade, PrecoUnitario) 
                          VALUES (@Venda, @Produto, @Qtd, @Preco)",
                                conn, trans);

                            cmdItem.Parameters.AddWithValue("@Venda", vendaId);

                            var idProdutoObj = row.Cells["IDProduto"].Value;
                            if (idProdutoObj == null)
                                throw new Exception("IDProduto inválido na linha do Grid.");

                            cmdItem.Parameters.AddWithValue("@Produto", idProdutoObj);

                            if (!int.TryParse(row.Cells["Quantidade"].Value?.ToString(), out int quantidade))
                                throw new Exception("Quantidade inválida na linha do Grid.");

                            cmdItem.Parameters.AddWithValue("@Qtd", quantidade);

                            string precoStr = row.Cells["Preco"].Value?.ToString();
                            if (string.IsNullOrWhiteSpace(precoStr))
                                throw new Exception("Preço unitário inválido na linha do Grid.");

                            if (!decimal.TryParse(precoStr, NumberStyles.Any, new CultureInfo("pt-BR"), out decimal precoUnitario))
                                throw new Exception("Erro ao converter preço unitário.");

                            cmdItem.Parameters.AddWithValue("@Preco", precoUnitario);

                            cmdItem.ExecuteNonQuery();

                            SqlCommand cmdEstoque = new SqlCommand(
                                "UPDATE Produtos SET Estoque = Estoque - @Qtd WHERE ID=@ID",
                                conn, trans);

                            cmdEstoque.Parameters.AddWithValue("@Qtd", quantidade);
                            cmdEstoque.Parameters.AddWithValue("@ID", idProdutoObj);
                            cmdEstoque.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Venda finalizada com sucesso!");
                        btnIniciarVendas_Click(null, null);
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Erro na transação: " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message);
            }
        }
        



        private void btnIniciarVendas_Click(object sender, EventArgs e)
        {
            GridView.Rows.Clear();
            totalVenda = 0;

            txtQtd.Clear();
            txtPrecoU.Clear();
            txtDesconto.Clear();
            txtValorTotal.Clear();

            DataCompra.Value = DateTime.Now;
            txtProduto.Enabled = true;
            txtQtd.Enabled = true;
            btnAdicionar.Enabled = true;
            btnFinalizar.Enabled = true;

            MessageBox.Show("Venda iniciada!");
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIDProduto.Text = GridView.Rows[e.RowIndex].Cells["IDProduto"].Value.ToString();
                txtProduto.Text = GridView.Rows[e.RowIndex].Cells["Produto"].Value.ToString();
                txtQtd.Text = GridView.Rows[e.RowIndex].Cells["Quantidade"].Value.ToString();
                txtPrecoU.Text = GridView.Rows[e.RowIndex].Cells["Preco"].Value.ToString();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (GridView.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item!");
                return;
            }

            int novaQtd = int.Parse(txtQtd.Text);
            decimal preco = decimal.Parse(txtPrecoU.Text);
            decimal subtotalAntigo = decimal.Parse(

            GridView.CurrentRow.Cells["Subtotal"].Value.ToString());
            totalVenda -= subtotalAntigo;

            decimal novoSubtotal = novaQtd * preco;
            totalVenda += novoSubtotal;

            GridView.CurrentRow.Cells["Quantidade"].Value = novaQtd;
            GridView.CurrentRow.Cells["Subtotal"].Value = novoSubtotal.ToString("N2");
            txtValorTotal.Text = totalVenda.ToString("N2");

            MessageBox.Show("Venda alterada!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (GridView.CurrentRow == null) return;

            decimal subtotal = decimal.Parse(

                GridView.CurrentRow.Cells["Subtotal"].Value.ToString());

            totalVenda -= subtotal;
            txtValorTotal.Text = totalVenda.ToString("N2");

            GridView.Rows.Remove(GridView.CurrentRow);
        }

        void ConfigurarGridVendas()
        {
            GridView.Columns.Clear();

            GridView.Columns.Add("VendaID", "ID Venda");
            GridView.Columns.Add("Cliente", "Cliente");
            GridView.Columns.Add("Data", "Data da Venda");
            GridView.Columns.Add("Total", "Valor Total");
            GridView.Columns.Add("Desconto", "Desconto");

            GridView.AllowUserToAddRows = false;
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            ConfigurarGridVendas();
            GridView.Rows.Clear();

            using (SqlConnection conn = con.Connect())
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT VendaID,IDCliente,DataVenda,ValorTotal,Desconto FROM Vendas",
                    conn);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    GridView.Rows.Add(
                        dr["VendaID"],
                        dr["IDCliente"],
                        Convert.ToDateTime(dr["DataVenda"]).ToString("dd/MM/yyyy"),
                        Convert.ToDecimal(dr["ValorTotal"]).ToString("N2"),
                        dr["Desconto"]
                    );
                }
            }

            MessageBox.Show("Todas as vendas carregadas!");
        }

        void CarregarClientes()
        {
            using (SqlConnection conn = con.Connect())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ID, Nome FROM Contatos",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                txtCliente.DisplayMember = "Nome";
                txtCliente.ValueMember = "ID";
                txtCliente.DataSource = dt;
            }
        }

        private void txtCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCliente.SelectedValue == null) return;

            txtIDCliente.Text = txtCliente.SelectedValue.ToString();
        }
    }
}

