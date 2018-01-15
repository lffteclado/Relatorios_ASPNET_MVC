using System.Data.Entity.ModelConfiguration;

namespace Relatorios_ASPNET_MVC.Models
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.HasKey(t => t.ClienteId);
            this.Property(t => t.Nome).HasMaxLength(100);
            this.Property(t => t.CpfCnpj).HasMaxLength(18);
            this.Property(t => t.Endereco).HasMaxLength(200);
            this.Property(t => t.Bairro).HasMaxLength(40);
            this.Property(t => t.Cidade).HasMaxLength(40);
            this.Property(t => t.Cep).HasMaxLength(10);
            this.Property(t => t.Email).HasMaxLength(50);
            this.Property(t => t.Telefone).HasMaxLength(15);
            this.Property(t => t.StatusCliente).HasMaxLength(20);

            this.ToTable("Cliente");
            this.Property(t => t.ClienteId).HasColumnName("ClienteId");
            this.Property(t => t.Nome).HasColumnName("Nome");
            this.Property(t => t.CpfCnpj).HasColumnName("CpfCnpj");
            this.Property(t => t.Endereco).HasColumnName("Endereco");
            this.Property(t => t.Bairro).HasColumnName("Bairro");
            this.Property(t => t.Cidade).HasColumnName("Cidade");
            this.Property(t => t.Cep).HasColumnName("Cep");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Telefone).HasColumnName("Telefone");
            this.Property(t => t.StatusCliente).HasColumnName("StatusCliente");
            this.Property(t => t.DataCadastro).HasColumnName("DataCadastro");
        }
    }
}