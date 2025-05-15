namespace SistemaCadastro.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string documento, string cargo, string email, string login, string senha)
        {
            Nome = nome;
            Documento = documento;
            Cargo = cargo;
            Email = email;
            Login = login;
            Senha = senha;
        }
    }
}
