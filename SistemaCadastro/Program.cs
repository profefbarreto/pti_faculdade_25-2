using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SistemaCadastro.Data;
using SistemaCadastro.Models;
using System;
using Microsoft.EntityFrameworkCore;


namespace SistemaCadastro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();
            var context = host.Services.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("\n--- Menu Principal ---");
                Console.WriteLine("1. Cadastrar Aluno");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CadastrarAluno(context);
                        break;
                    case "0":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void CadastrarAluno(AppDbContext ctx)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o documento do aluno: ");
            string documento = Console.ReadLine();

            Console.Write("Digite a matrícula do aluno: ");
            string matricula = Console.ReadLine();

            Console.Write("Digite o curso do aluno: ");
            string curso = Console.ReadLine();

            Console.Write("Digite o login do aluno: ");
            string login = Console.ReadLine();

            Console.Write("Digite a senha do aluno: ");
            string senha = Console.ReadLine();

            var aluno = new Aluno(nome, documento, matricula, curso, login, senha);
            ctx.Alunos.Add(aluno);
            ctx.SaveChanges();

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlite(connectionString));
                });
    }
}
