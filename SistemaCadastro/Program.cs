using System;
using Microsoft.Extensions.Configuration;
using SistemaCadastro.Data;

namespace SistemaCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carrega a configuração do appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Lê a connection string do arquivo de configuração
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            Console.WriteLine($"Connection String: {connectionString}");

            // Aqui você pode iniciar a lógica do seu sistema
            // Exemplo: instanciar o contexto do banco, carregar menus, etc.
            using var db = new AppDbContext(configuration);
            Console.WriteLine("Sistema iniciado com sucesso!");

            // TODO: implementar menu de ações
        }
    }
}
