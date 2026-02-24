using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiroprojetoti48
{
  
        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descricao { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }
            public string Categoria { get; set; }
        }

        public class Contatos
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public DateTime Dt { get; set; }
        }
        public class Venda
        {
            public int VendaID { get; set; }
            public int ClienteID { get; set; }
            public DateTime DataVenda { get; set; }
            public decimal Desconto { get; set; }
            public decimal ValorTotal { get; set; }

            public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();
        }

        public class ItemVenda
        {
            public int VendaID { get; set; }
            public int IDProduto { get; set; }
            public string NomeProduto { get; set; }
            public int Quantidade { get; set; }
            public decimal PrecoUnitario { get; set; }
        }

}
