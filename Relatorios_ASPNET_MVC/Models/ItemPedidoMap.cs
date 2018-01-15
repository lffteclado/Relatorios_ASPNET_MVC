using System.Data.Entity.ModelConfiguration;

namespace Relatorios_ASPNET_MVC.Models
{
    public class ItemPedidoMap : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoMap()
        {
            this.HasKey(t => t.ItemPedidoId);
            this.Property(t => t.StatusItem).HasMaxLength(20);

            this.ToTable("ItemPedido");
            this.Property(t => t.ItemPedidoId).HasColumnName("ItemPedidoId");
            this.Property(t => t.PedidoCabId).HasColumnName("PedidoCabId");
            this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
            this.Property(t => t.Quantidade).HasColumnName("Quantidade");
            this.Property(t => t.ValorUnitario).HasColumnName("ValorUnitario");
            this.Property(t => t.SubTotal).HasColumnName("SubTotal");
            this.Property(t => t.StatusItem).HasColumnName("StatusItem");

            this.HasRequired(t => t.PedidoCabecalho)
                .WithMany(t => t.ItemPedido)
                .HasForeignKey(d => d.PedidoCabId);

            this.HasRequired(t => t.Produto)
                .WithMany(t => t.ItemPedido)
                .HasForeignKey(d => d.ProdutoId);
        }
    }
}