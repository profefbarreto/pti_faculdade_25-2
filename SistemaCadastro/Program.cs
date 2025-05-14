using System;
using SistemaCadastro.Models;
using SistemaCadastro.Data;
using System.Linq;


class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            bool sair = false;
            while (!sair)
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL:");
                Console.WriteLine("1. Gerenciar Alunos");
                Console.WriteLine("2. Gerenciar Funcionários");
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
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }

    static void MenuAlunos(AppDbContext context)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.Clear();
            Console.WriteLine("MENU ALUNOS:");
            Console.WriteLine("1. Cadastrar Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Excluir Aluno");
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
                    voltar = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void MenuFuncionarios(AppDbContext context)
    {
        bool voltar = false;
        while (!voltar)
        {
            Console.Clear();
            Console.WriteLine("MENU FUNCIONÁRIOS:");
            Console.WriteLine("1. Cadastrar Funcionário");
            Console.WriteLine("2. Listar Funcionários");
            Console.WriteLine("3. Excluir Funcionário");
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
                    voltar = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void CadastrarAluno(AppDbContext context)
    {
        Console.Clear();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Documento: ");
        string documento = Console.ReadLine();
        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();
        Console.Write("Curso: ");
        string curso = Console.ReadLine();
        Console.Write("Login: ");
        string login = Console.ReadLine();
        Console.Write("Senha: ");
        string senha = Console.ReadLine();

        var aluno = new Aluno(nome, documento, matricula, curso, login, senha);
        context.Alunos.Add(aluno);
        context.SaveChanges();

        Console.WriteLine("Aluno cadastrado com sucesso!");
        Console.ReadKey();
    }

    static void ListarAlunos(AppDbContext context)
    {
        Console.Clear();
        var alunos = context.Alunos.ToList();
        foreach (var aluno in alunos)
        {
            Console.WriteLine($"ID: {aluno.Id}, Nome: {aluno.Nome}, Curso: {aluno.Curso}");
        }
        Console.ReadKey();
    }

    static void ExcluirAluno(AppDbContext context)
    {
        Console.Clear();
        Console.Write("Digite o ID do aluno a excluir: ");
        int id = int.Parse(Console.ReadLine());

        var aluno = context.Alunos.Find(id);
        if (aluno != null)
        {
            context.Alunos.Remove(aluno);
            context.SaveChanges();
            Console.WriteLine("Aluno excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Aluno não encontrado.");
        }
        Console.ReadKey();
    }

  static void CadastrarFuncionario(AppDbContext context)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    Console.Write("Documento: ");  // <- Adicione esta linha
    string documento = Console.ReadLine();  // <- Adicione esta linha

    Console.Write("Função: ");
    string funcao = Console.ReadLine();

    Console.Write("Login: ");
    string login = Console.ReadLine();

    Console.Write("Senha: ");
    string senha = Console.ReadLine();

    var funcionario = new Funcionario
    {
        Nome = nome,
        Documento = documento,  // <- Use o valor lido
        Funcao = funcao,
        Login = login,
        Senha = senha
    };

    context.Funcionarios.Add(funcionario);
    context.SaveChanges();

    Console.WriteLine("Funcionário cadastrado com sucesso!");
}


    static void ListarFuncionarios(AppDbContext context)
    {
        Console.Clear();
        var funcionarios = context.Funcionarios.ToList();
        foreach (var func in funcionarios)
        {
            Console.WriteLine($"ID: {func.Id}, Nome: {func.Nome}, Função: {func.Funcao}");
        }
        Console.ReadKey();
    }

    static void ExcluirFuncionario(AppDbContext context)
    {
        Console.Clear();
        Console.Write("Digite o ID do funcionário a excluir: ");
        int id = int.Parse(Console.ReadLine());

        var func = context.Funcionarios.Find(id);
        if (func != null)
        {
            context.Funcionarios.Remove(func);
            context.SaveChanges();
            Console.WriteLine("Funcionário excluído com sucesso.");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado.");
        }
        Console.ReadKey();
    }
}
