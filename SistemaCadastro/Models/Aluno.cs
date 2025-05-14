namespace SistemaCadastro.Models;

public class Aluno : Pessoa
{
    public string Matricula { get; set; } = string.Empty;
    public string Curso { get; set; } = string.Empty;

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }

    public bool ConsultarCadastro()
    {
        return true;
    }

    public bool EditarCadastro()
    {
        return true;
    }
}
