using Fiap.MasterChefe.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fiap.MasterChefe.Infra.Dados.Mappings
{
    public class IngredientesMap : IEntityTypeConfiguration<Ingredientes>
    {
        public void Configure(EntityTypeBuilder<Ingredientes> builder)
        {
            builder.Property(c => c.Id)
               .HasColumnName("Id");
        }
    }
}
