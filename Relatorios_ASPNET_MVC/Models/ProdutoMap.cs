using System.Data.Entity.ModelConfiguration;

namespace Relatorios_ASPNET_MVC.Models
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            this.HasKey(t => t.ProdutoId);

            this.Property(t => t.Descricao).HasMaxLength(100);
            this.Property(t => t.StatusProduto).HasMaxLength(20);

            this.ToTable("Produto");
            this.Property(t => t.ProdutoId).HasColumnName("ProdutoId");
            this.Property(t => t.ProdutoId).HasColumnName("Descricao");
            this.Property(t => t.ProdutoId).HasColumnName("PrecoCompra");
            this.Property(t => t.ProdutoId).HasColumnName("PrecoVenda");
            this.Property(t => t.ProdutoId).HasColumnName("QtdeEstoque");
            this.Property(t => t.ProdutoId).HasColumnName("DataCadastro");
            this.Property(t => t.ProdutoId).HasColumnName("StatusProduto");
        }
    }
}