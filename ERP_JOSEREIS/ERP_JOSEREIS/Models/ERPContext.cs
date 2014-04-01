using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ERP_JOSEREIS.Models
{
    public class ERPContext : DbContext
    {
        public ERPContext() : base("ERP")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ERPContext>());
        }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoaFisica");
            modelBuilder.Entity<PessoaJuridica>().ToTable("PessoaJuridica");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionario");
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}