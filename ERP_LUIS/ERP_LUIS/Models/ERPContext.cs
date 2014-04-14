using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.Models
{
    public class ERPContext : DbContext
    {
        public ERPContext() : base("ERP")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ERPContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Evitar que heranças gerem todos os atributos em uma mesma tabela

            modelBuilder.Entity<Cargo>().ToTable("Cargo");
            modelBuilder.Entity<Cidade>().ToTable("Cidade");
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Conta>().ToTable("Conta");
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<Estado>().ToTable("Estado");
            modelBuilder.Entity<FormaPagamento>().ToTable("FormaPagamento");
            modelBuilder.Entity<Fornecedor>().ToTable("Fornecedor");
            modelBuilder.Entity<Funcionario>().ToTable("Funcionario");
            modelBuilder.Entity<FuncionarioPagamento>().ToTable("FuncionarioPagamento");

            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Lancamento>().ToTable("Lancamento");
            modelBuilder.Entity<LinhaItem>().ToTable("LinhaItem");
            modelBuilder.Entity<Movimento>().ToTable("Movimento");
            modelBuilder.Entity<MovimentoItem>().ToTable("MovimentoItem");
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<PessoaFisica>().ToTable("PessoaFisica");
            modelBuilder.Entity<PessoaJuridica>().ToTable("PessoaJuridica");
            modelBuilder.Entity<SalarioReajuste>().ToTable("SalarioReajuste");
            modelBuilder.Entity<TipoItem>().ToTable("TipoItem");
            modelBuilder.Entity<TipoMovimento>().ToTable("TipoMovimento");
            modelBuilder.Entity<Unidade>().ToTable("Unidade");
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioPagamento> FuncionariosPagamentos { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<LinhaItem> LinhasItem { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }
        public DbSet<MovimentoItem> MovimentosItem { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridicas { get; set; }
        public DbSet<SalarioReajuste> SalariosReajuste { get; set; }
        public DbSet<TipoItem> TiposItem { get; set; }
        public DbSet<TipoMovimento> TiposMovimento { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
    }
}