using Fiap.MasterChefe.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.MasterChefe.Infra.Dados.Mappings
{
    public class CategoriaReceitaMap : IEntityTypeConfiguration<CategoriaReceita>
    {
        public void Configure(EntityTypeBuilder<CategoriaReceita> builder)
        {
            builder.Property(c => c.Id)
               .HasColumnName("Id");

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
