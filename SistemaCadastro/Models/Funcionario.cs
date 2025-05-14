namespace SistemaCadastro.Models;

public class Funcionario : Pessoa
{
    public string MatriculaFunc { get; set; } = string.Empty;
    public string Setor { get; set; } = string.Empty;

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }

    public bool ConsultarCadastro() => true;
    public bool EditarCadastro() => true;
    public bool CadastrarAluno() => true;
}
