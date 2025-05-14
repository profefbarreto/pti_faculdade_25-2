namespace SistemaCadastro.Models;

public class MensagemErro
{
    public int CodigoErro { get; set; }
    public string Mensagem { get; set; } = string.Empty;

    public void ExibirMensagem()
    {
        Console.WriteLine($"Erro {CodigoErro}: {Mensagem}");
    }
}
