using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data;

public class AppDbContext : DbContext
{
    public DbSet<Aluno> Alunos => Set<Aluno>();
    public DbSet<Funcionario> Funcionarios => Set<Funcionario>();
    public DbSet<Administrador> Administradores => Set<Administrador>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host=localhost;Database=SistemaCadastroDB;Username=seu_usuario;Password=sua_senha");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().UseTptMappingStrategy();
        modelBuilder.Entity<Pessoa>().UseTptMappingStrategy();
    }
}
