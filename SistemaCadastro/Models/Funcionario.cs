namespace SistemaCadastro.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Funcao { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string documento, string funcao, string login, string senha)
        {
            Nome = nome;
            Documento = documento;
            Funcao = funcao;
            Login = login;
            Senha = senha;
        }
    }
}
