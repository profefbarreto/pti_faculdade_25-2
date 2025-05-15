namespace SistemaCadastro.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public string Email { get; set; }     // Novo campo
        public string Login { get; set; }
        public string Senha { get; set; }

        public Aluno() { }

        public Aluno(string nome, string documento, string matricula, string curso, string email, string login, string senha)
        {
            Nome = nome;
            Documento = documento;
            Matricula = matricula;
            Curso = curso;
            Email = email;
            Login = login;
            Senha = senha;
        }
    }
}
