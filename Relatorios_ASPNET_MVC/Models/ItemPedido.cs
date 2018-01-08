using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relatorios_ASPNET_MVC.Models
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int PedidoCabId { get; set; }
        public int ProdutoId { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorUnitario { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public string StatusItem { get; set; }
        public virtual PedidoCabecalho PedidoCabecalho { get; set; }
        public virtual Produto Produto { get; set; }
    }
}