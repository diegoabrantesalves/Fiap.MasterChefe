using Fiap.MasterChefe.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.MasterChefe.Infra.Dados.Mappings
{
    public class ModoDePreparoMap : IEntityTypeConfiguration<ModoDePreparo>
    {
        public void Configure(EntityTypeBuilder<ModoDePreparo> builder)
        {
            builder.Property(c => c.Id)
               .HasColumnName("Id");

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(300)")
                .HasMaxLength(300)
                .IsRequired();
        }
    }
}
