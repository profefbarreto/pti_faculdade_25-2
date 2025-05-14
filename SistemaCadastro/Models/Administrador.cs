namespace SistemaCadastro.Models
{
    public class Administrador : Pessoa
    {
        public string NivelAcesso { get; set; }

        public Administrador(string nome, string documento, string nivelAcesso, string login, string senha)
            : base(nome, documento, login, senha)
        {
            NivelAcesso = nivelAcesso;
        }
    }
}
