namespace SistemaCadastro.Models;

public class Administrador : Usuario
{
    public bool GerenciarUsuarios() => true;
    public bool EditarCadastro() => true;
    public bool CadastrarAluno() => true;
}
