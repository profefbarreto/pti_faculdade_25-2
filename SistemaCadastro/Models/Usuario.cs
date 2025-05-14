namespace SistemaCadastro.Models
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        protected Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}
