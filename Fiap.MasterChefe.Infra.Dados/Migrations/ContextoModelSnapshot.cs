﻿// <auto-generated />
using Fiap.MasterChefe.Infra.Dados.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Fiap.MasterChefe.Infra.Dados.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Ingredientes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<Guid?>("ReceitaId");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<string>("MododePreparo");

                    b.Property<int>("Rendimento");

                    b.Property<int>("TempodePreparo");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Ingredientes", b =>
                {
                    b.HasOne("Fiap.MasterChefe.Dominio.Entidades.Receita", "Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaId");
                });
#pragma warning restore 612, 618
        }
    }
}
