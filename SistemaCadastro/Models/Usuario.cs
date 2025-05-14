namespace SistemaCadastro.Models;

public abstract class Usuario
{
    public int Id { get; set; }
    public string Login { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;

    public virtual bool Autenticar()
    {
        // Autenticação básica (exemplo)
        return !string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Senha);
    }
}
