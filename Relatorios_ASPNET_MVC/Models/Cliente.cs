using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relatorios_ASPNET_MVC.Models
{
    public class Cliente
    {
        public Cliente()
        {
            this.PedidoCabecalho = new List<PedidoCabecalho>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string StatusCliente { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<PedidoCabecalho> PedidoCabecalho { get; set; }

    }
}