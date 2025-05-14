using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<MensagemErro> MensagensErro { get; set; }

        // Configuração da conexão com SQLite
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SistemaCadastro.db");
        }

        // Definição das chaves primárias
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
            modelBuilder.Entity<Funcionario>().HasKey(f => f.Id);
            modelBuilder.Entity<Administrador>().HasKey(adm => adm.Id);
            modelBuilder.Entity<MensagemErro>().HasKey(me => me.Id);
        }
    }
}

