using System;
using System.Linq;
using SistemaCadastro.Data;
using SistemaCadastro.Models;

using var context = new AppDbContext();
context.Database.EnsureCreated();

MenuPrincipal(context);

static void MenuPrincipal(AppDbContext context)
{
    while (true)
    {
        Console.WriteLine("\n===== MENU PRINCIPAL =====");
        Console.WriteLine("1. Alunos");
        Console.WriteLine("2. Funcionários");
        Console.WriteLine("0. Sair");
        Console.Write("Escolha uma opção: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                MenuAlunos(context);
                break;
            case "2":
                MenuFuncionarios(context);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

static void MenuAlunos(AppDbContext context)
{
    while (true)
    {
        Console.WriteLine("\n--- MENU ALUNOS ---");
        Console.WriteLine("1. Cadastrar");
        Console.WriteLine("2. Listar");
        Console.WriteLine("3. Excluir");
        Console.WriteLine("0. Voltar");
        Console.Write("Escolha uma opção: ");
        var opcao = Console.ReadLine();

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

static void MenuFuncionarios(AppDbContext context)
{
    while (true)
    {
        Console.WriteLine("\n--- MENU FUNCIONÁRIOS ---");
        Console.WriteLine("1. Cadastrar");
        Console.WriteLine("2. Listar");
        Console.WriteLine("3. Excluir");
        Console.WriteLine("0. Voltar");
        Console.Write("Escolha uma opção: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                CadastrarFuncionario(context);
                break;
            case "2":
                ListarFuncionarios(context);
                break;
            case "3":
                ExcluirFuncionario(context);
                break;
            case "0":
                return;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

static void CadastrarAluno(AppDbContext context)
{
    Console.Write("Nome: ");
    var nome = Console.ReadLine();
    Console.Write("Documento: ");
    var documento = Console.ReadLine();
    Console.Write("Matrícula: ");
    var matricula = Console.ReadLine();
    Console.Write("Curso: ");
    var curso = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Login: ");
    var login = Console.ReadLine();
    Console.Write("Senha: ");
    var senha = Console.ReadLine();

    var aluno = new Aluno(nome, documento, matricula, curso, email, login, senha);
    context.Alunos.Add(aluno);
    context.SaveChanges();

    Console.WriteLine("Aluno cadastrado com sucesso!");
}

static void ListarAlunos(AppDbContext context)
{
    var alunos = context.Alunos.ToList();

    Console.WriteLine("\n--- Lista de Alunos ---");
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.Nome}, Documento: {aluno.Documento}, Email: {aluno.Email}, Matrícula: {aluno.Matricula}, Curso: {aluno.Curso}");
    }
}

static void ExcluirAluno(AppDbContext context)
{
    Console.Write("ID do aluno a excluir: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        var aluno = context.Alunos.Find(id);
        if (aluno != null)
        {
            context.Alunos.Remove(aluno);
            context.SaveChanges();
            Console.WriteLine("Aluno excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
    }
}

static void CadastrarFuncionario(AppDbContext context)
{
    Console.Write("Nome: ");
    var nome = Console.ReadLine();
    Console.Write("Documento: ");
    var documento = Console.ReadLine();
    Console.Write("Cargo: ");
    var cargo = Console.ReadLine();
    Console.Write("Email: ");
    var email = Console.ReadLine();
    Console.Write("Login: ");
    var login = Console.ReadLine();
    Console.Write("Senha: ");
    var senha = Console.ReadLine();

    var funcionario = new Funcionario(nome, documento, cargo, email, login, senha);
    context.Funcionarios.Add(funcionario);
    context.SaveChanges();

    Console.WriteLine("Funcionário cadastrado com sucesso!");
}

static void ListarFuncionarios(AppDbContext context)
{
    var funcionarios = context.Funcionarios.ToList();

    Console.WriteLine("\n--- Lista de Funcionários ---");
    foreach (var f in funcionarios)
    {
        Console.WriteLine($"ID: {f.Id}, Nome: {f.Nome}, Documento: {f.Documento}, Email: {f.Email}, Cargo: {f.Cargo}");
    }
}

static void ExcluirFuncionario(AppDbContext context)
{
    Console.Write("ID do funcionário a excluir: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        var funcionario = context.Funcionarios.Find(id);
        if (funcionario != null)
        {
            context.Funcionarios.Remove(funcionario);
            context.SaveChanges();
            Console.WriteLine("Funcionário excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
    }
}
