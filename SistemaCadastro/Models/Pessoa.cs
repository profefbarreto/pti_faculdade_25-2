namespace SistemaCadastro.Models;

public abstract class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Documento { get; set; } = string.Empty;

    public virtual bool ValidarDocumento()
    {
        return Documento.Length >= 11;
    }
}
