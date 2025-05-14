using SistemaCadastro.Data;
using SistemaCadastro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();
        context.Database.EnsureCreated();

        while (true)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Excluir Aluno");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarAluno(context);
                    break;
                case "2":
                    ListarAlunos(context);
                    break;
                case "3":
                    ExcluirAluno(context);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void CadastrarAluno(AppDbContext ctx)
    {
        try
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

            Aluno aluno = new Aluno(nome, documento, matricula, curso, login, senha);
            ctx.Alunos.Add(aluno);
            ctx.SaveChanges();

            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            ctx.MensagensErro.Add(new MensagemErro(ex.Message));
            ctx.SaveChanges();
            Console.WriteLine("Erro ao cadastrar aluno.");
        }
    }

    static void ListarAlunos(AppDbContext ctx)
    {
        var alunos = ctx.Alunos.ToList(); // Adicionado 'using System.Linq'

        if (!alunos.Any()) 
        {
            Console.WriteLine("Nenhum aluno encontrado.");
            return;
        }

        Console.WriteLine("\nLista de Alunos:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.Nome}, Documento: {aluno.Documento}, Matrícula: {aluno.Matricula}, Curso: {aluno.Curso}");
        }
    }

    static void ExcluirAluno(AppDbContext ctx)
    {
        Console.Write("Digite o ID do aluno a ser excluído: ");
        if (int.TryParse(Console.ReadLine(), out int alunoId))
        {
            var aluno = ctx.Alunos.FirstOrDefault(a => a.Id == alunoId);
            if (aluno != null)
            {
                ctx.Alunos.Remove(aluno);
                ctx.SaveChanges();
                Console.WriteLine("Aluno excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido.");
        }
    }
}
