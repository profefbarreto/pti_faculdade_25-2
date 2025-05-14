using System;

namespace SistemaCadastro.Models
{
    public class Administrador : Usuario
    {
        // Outros atributos específicos de Administrador
        public string Funcao { get; set; }

        // Construtor do Administrador que passa o login e senha para o construtor da classe base (Usuario)
        public Administrador(string login, string senha, string funcao)
            : base(login, senha)  // Chama o construtor da classe base (Usuario)
        {
            Funcao = funcao;
        }

        // Métodos específicos do Administrador
        public bool GerenciarUsuarios()
        {
            // Lógica para gerenciar usuários
            return true;
        }
    }
}
