using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relatorios_ASPNET_MVC.Models
{
    public class PedidoCabecalho
    {
        public PedidoCabecalho()
        {
            this.ItemPedido = new List<ItemPedido>();
        }

        public int PedidoCabId { get; set; }
        public int ClienteId { get; set; }
        public Nullable<decimal> ValorTotalPedido { get; set; }
        public Nullable<int> QtdeItens { get; set; }
        public string StatusPedido { get; set; }
        public Nullable<DateTime> DataPedido { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemPedido> ItemPedido { get; set; }
    }
}