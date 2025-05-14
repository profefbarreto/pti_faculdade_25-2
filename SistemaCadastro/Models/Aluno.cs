namespace SistemaCadastro.Models
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, string documento, string matricula, string curso, string login, string senha)
            : base(nome, documento, login, senha)
        {
            Matricula = matricula;
            Curso = curso;
        }
    }
}
