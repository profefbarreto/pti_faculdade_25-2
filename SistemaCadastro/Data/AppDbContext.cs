using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<MensagemErro> MensagensErro { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aluno>().HasKey(a => a.Id);
            modelBuilder.Entity<Funcionario>().HasKey(f => f.Id);
            modelBuilder.Entity<Administrador>().HasKey(adm => adm.Id);
        }
    }
}
