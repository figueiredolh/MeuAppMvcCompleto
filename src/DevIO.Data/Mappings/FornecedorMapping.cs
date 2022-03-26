using DevIO.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(f => f.Documento)
                   .IsRequired()
                   .HasColumnType("varchar(14)");

            //Fornecedor <-> Endereco --- Relacionamento 1 : 1

            builder.HasOne(f => f.Endereco)
                   .WithOne(e => e.Fornecedor);                 

            //Fornecedor <-> Produto --- Relacionamento 1 : N

            builder.HasMany(f => f.Produtos)
                   .WithOne(p => p.Fornecedor)
                   .HasForeignKey(p => p.FornecedorId);

            builder.ToTable("Fornecedores");
        }
    }

}
