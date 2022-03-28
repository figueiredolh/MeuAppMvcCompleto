using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Descricao)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(p => p.Imagem)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.Property(p => p.Valor)
                   .IsRequired()
                   .HasColumnType("decimal(5,2)");

            //Construir Tabela

            builder.ToTable("Produtos");
        }
    }
}
