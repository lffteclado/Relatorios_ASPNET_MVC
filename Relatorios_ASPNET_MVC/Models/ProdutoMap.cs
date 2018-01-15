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
            this.Property(t => t.Descricao).HasColumnName("Descricao");
            this.Property(t => t.PrecoCompra).HasColumnName("PrecoCompra");
            this.Property(t => t.PrecoVenda).HasColumnName("PrecoVenda");
            this.Property(t => t.QtdeEstoque).HasColumnName("QtdeEstoque");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
            this.Property(t => t.StatusProduto).HasColumnName("StatusProduto");
        }
    }
}