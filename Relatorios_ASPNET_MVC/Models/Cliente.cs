using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relatorios_ASPNET_MVC.Models
{
    public class Cliente
    {
        //VendaRelatorioDbContext _db = new VendaRelatorioDbContext();

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


        //public void criaClientes()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        Cliente cli = new Cliente();

        //        cli.Nome = "CLIENTE" + i;
        //        cli.CpfCnpj = "123456789" + i;
        //        cli.Endereco = "ENDERECO CLIENTE" + i;
        //        cli.Bairro = "BAIRRO CLIENTE" + i;
        //        cli.Cidade = "CIDADE CLIENTE" + i;
        //        cli.Cep = "12122" + i;
        //        cli.Email = "CLIENTE" + i + "@TESTE.COM.BR";
        //        cli.Telefone = "3198318089" + i;
        //        cli.StatusCliente = "ATIVO";
        //        cli.DataCadastro = DateTime.Now;

        //        _db.Clientes.Add(cli);
        //        _db.SaveChanges();
        //    }
        //}

    }
}