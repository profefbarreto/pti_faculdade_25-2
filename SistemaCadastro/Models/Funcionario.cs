namespace SistemaCadastro.Models
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario(string nome, string documento, string cargo, string login, string senha)
            : base(nome, documento, login, senha)
        {
            Cargo = cargo;
        }
    }
}
