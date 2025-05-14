namespace SistemaCadastro.Models
{
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }
        public Usuario Usuario { get; set; }

        public Aluno(string nome, string documento, string matricula, string curso, Usuario usuario)
            : base(nome, documento)
        {
            Matricula = matricula ?? throw new ArgumentNullException(nameof(matricula));
            Curso = curso ?? throw new ArgumentNullException(nameof(curso));
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
        }

        // Implementação do método ValidarDocumento
        public override bool ValidarDocumento()
        {
            // Implementação simples, apenas um exemplo. Adicione sua lógica de validação aqui.
            return Documento.Length == 11; // Exemplo: validando um CPF (11 dígitos)
        }

        public bool ConsultarCadastro()
        {
            return true;
        }

        public bool EditarCadastro()
        {
            return true;
        }
    }
}
