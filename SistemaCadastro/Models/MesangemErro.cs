using System;

namespace SistemaCadastro.Models
{
    public class MensagemErro
    {
        public int Id { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataHora { get; set; }

        public MensagemErro(string mensagem)
        {
            Mensagem = mensagem;
            DataHora = DateTime.Now;
        }
    }
}
