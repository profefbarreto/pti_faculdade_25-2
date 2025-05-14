using System;

namespace SistemaCadastro.Models
{
    public abstract class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        // Construtor para garantir que Login e Senha sejam fornecidos
        public Usuario(string login, string senha)
        {
            Login = login ?? throw new ArgumentNullException(nameof(login), "Login não pode ser nulo.");
            Senha = senha ?? throw new ArgumentNullException(nameof(senha), "Senha não pode ser nula.");
        }

        // Método para autenticar o usuário
        public bool Autenticar()
        {
            // Lógica de autenticação (exemplo simples)
            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Senha))
            {
                // Aqui você pode adicionar a lógica de autenticação
                // (ex: verificar login e senha em um banco de dados)
                return true; // Retorna verdadeiro se a autenticação for bem-sucedida
            }
            return false; // Caso contrário, retorna falso
        }
    }
}
