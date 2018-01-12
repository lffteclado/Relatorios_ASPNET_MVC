using System.Data.Entity;

namespace Relatorios_ASPNET_MVC.Models
{
    public class VendaRelatorioDbContext : DbContext
    {
        static VendaRelatorioDbContext()
        {
            Database.SetInitializer<VendaRelatorioDbContext>(null);
        }

        public VendaRelatorioDbContext() : base("Name=VendaRelatorioDbContext")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<PedidoCabecalho> PedidoCabecalhos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ItemPedidoMap());
            modelBuilder.Configurations.Add(new PedidoCabecalhoMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
        }
    }
}