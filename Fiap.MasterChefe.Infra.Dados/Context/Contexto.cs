using Fiap.MasterChefe.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Fiap.MasterChefe.Infra.Dados.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Receita> Receitas { get; set; }

        public DbSet<Ingredientes> Ingredientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.AddConfiguration(new CustomerMap());
            modelBuilder.Entity<Receita>().ToTable("Receita");
            modelBuilder.Entity<Ingredientes>().ToTable("Enrollment");
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
