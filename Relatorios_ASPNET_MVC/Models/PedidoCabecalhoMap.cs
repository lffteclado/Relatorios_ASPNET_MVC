using System.Data.Entity.ModelConfiguration;

namespace Relatorios_ASPNET_MVC.Models
{
    public class PedidoCabecalhoMap : EntityTypeConfiguration<PedidoCabecalho>
    {
        public PedidoCabecalhoMap()
        {
            this.HasKey(t => t.PedidoCabId);
            this.Property(t => t.StatusPedido).HasMaxLength(20);

            this.ToTable("PedidoCabecalho");
            this.Property(t => t.PedidoCabId).HasColumnName("PedidoCabId");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");
            this.Property(t => t.ValorTotalPedido).HasColumnName("ValorTotalPedido");
            this.Property(t => t.QtdeItens).HasColumnName("QtdeItens");
            this.Property(t => t.StatusPedido).HasColumnName("StatusPedido");
            this.Property(t => t.DataPedido).HasColumnName("DataPedido");

            this.HasRequired(t => t.Cliente)
                .WithMany(t => t.PedidoCabecalho)
                .HasForeignKey(d => d.ClienteId);
        }
    }
}