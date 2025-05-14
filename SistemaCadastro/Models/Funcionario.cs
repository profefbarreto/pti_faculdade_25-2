namespace SistemaCadastro.Models
{
    public class Funcionario : Pessoa
    {
        public string MatriculaFunc { get; set; }
        public string Setor { get; set; }
        public Usuario Usuario { get; set; }

        public Funcionario(string nome, string documento, string matriculaFunc, string setor, Usuario usuario)
            : base(nome, documento)
        {
            MatriculaFunc = matriculaFunc ?? throw new ArgumentNullException(nameof(matriculaFunc));
            Setor = setor ?? throw new ArgumentNullException(nameof(setor));
            Usuario = usuario ?? throw new ArgumentNullException(nameof(usuario));
        }

        // Implementação do método ValidarDocumento
        public override bool ValidarDocumento()
        {
            // Lógica de validação. Exemplo: validando um CPF (11 dígitos)
            return Documento.Length == 11;
        }

        public bool ConsultarCadastro()
        {
            return true;
        }

        public bool EditarCadastro()
        {
            return true;
        }

        public bool CadastrarAluno()
        {
            return true;
        }
    }
}
