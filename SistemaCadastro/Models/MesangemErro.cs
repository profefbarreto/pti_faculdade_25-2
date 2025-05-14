public class MensagemErro
{
    public string Mensagem { get; set; }

    // Construtor
    public MensagemErro(string mensagem)
    {
        Mensagem = mensagem ?? throw new ArgumentNullException(nameof(mensagem)); // Garante que a mensagem não seja nula
    }
}
