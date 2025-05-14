namespace SistemaCadastro.Models
{
    public abstract class Pessoa : Usuario
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        protected Pessoa(string nome, string documento, string login, string senha)
            : base(login, senha)
        {
            Nome = nome;
            Documento = documento;
        }
    }
}
