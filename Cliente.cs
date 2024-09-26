using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro_Cliente
{
    public class Cliente
    {
        private int id;
        private string nome;
        private int idade;
        private string telefone;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public void EditCliente(string newNome, int newIdade, string newTelefone, string newEmail)
        {
            Nome = newNome;
            Idade = newIdade;
            Telefone = newTelefone;
            Email = newEmail;
        }
    }
}
