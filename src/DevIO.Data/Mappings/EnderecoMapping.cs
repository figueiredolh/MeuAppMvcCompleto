﻿using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Logradouro)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(e => e.Cep)
                    .IsRequired()
                    .HasColumnType("varchar(8)");

            builder.Property(e => e.Bairro)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(e => e.Numero)
                   .IsRequired()
                   .HasColumnType("int");

            builder.Property(e => e.Cidade)
                   .IsRequired()
                   .HasColumnType("varchar(50)");

            builder.Property(e => e.Estado)
                   .IsRequired()
                   .HasColumnType("varchar(50)");
        }
    }

}
