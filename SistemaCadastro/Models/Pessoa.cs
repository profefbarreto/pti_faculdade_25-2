namespace SistemaCadastro.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Documento { get; set; }

        // Construtor que recebe nome e documento
        public Pessoa(string nome, string documento)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Documento = documento ?? throw new ArgumentNullException(nameof(documento));
        }

        // Método para validar o documento (pode ser implementado posteriormente)
        public abstract bool ValidarDocumento();
    }
}
