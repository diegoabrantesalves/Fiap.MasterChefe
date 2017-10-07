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

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.CategoriaReceita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<bool>("ExibirTelaPrincipal");

                    b.HasKey("Id");

                    b.ToTable("CategoriaReceita");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Ingrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<Guid?>("ReceitaId");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.ModoDePreparo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<short>("Ordem");

                    b.Property<Guid?>("ReceitaId");

                    b.HasKey("Id");

                    b.HasIndex("ReceitaId");

                    b.ToTable("ModoDePreparo");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Receita", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("CategoriaReceitaId");

                    b.Property<string>("Descricao");

                    b.Property<int>("Rendimento");

                    b.Property<int>("TempodePreparo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaReceitaId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Ingrediente", b =>
                {
                    b.HasOne("Fiap.MasterChefe.Dominio.Entidades.Receita", "Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaId");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.ModoDePreparo", b =>
                {
                    b.HasOne("Fiap.MasterChefe.Dominio.Entidades.Receita", "Receita")
                        .WithMany("ModosDePreparo")
                        .HasForeignKey("ReceitaId");
                });

            modelBuilder.Entity("Fiap.MasterChefe.Dominio.Entidades.Receita", b =>
                {
                    b.HasOne("Fiap.MasterChefe.Dominio.Entidades.CategoriaReceita", "CategoriaReceita")
                        .WithMany("Receitas")
                        .HasForeignKey("CategoriaReceitaId");
                });
#pragma warning restore 612, 618
        }
    }
}
