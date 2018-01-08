using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relatorios_ASPNET_MVC.Models
{
    public class Produto
    {
        public Produto()
        {
            this.ItemPedido = new List<ItemPedido>();
        }

        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public Nullable<decimal> PrecoCompra { get; set; }
        public Nullable<decimal> PrecoVenda { get; set; }
        public Nullable<int> QtdeEstoque { get; set; }
        public Nullable<DateTime> DataCadastro { get; set; }
        public string StatusProduto { get; set; }
        public virtual ICollection<ItemPedido> ItemPedido { get; set; }

    }
}