
using SistemaCadastro_Cliente;
using System;
using System.Collections.Generic;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static int nextId = 1;

    static void Main(string[] args)
    {
        string opcao = "1";
        while (opcao != "0")
        {
            Console.WriteLine("SISTEMA CADASTRO DE CLIENTES:\n");
            Console.WriteLine("1- Fazer Cadastro:");
            Console.WriteLine("2- Atualizar Cadastro:");
            Console.WriteLine("3- Deletar Cadastro:");
            Console.WriteLine("4- Visualizar Cadastro:");
            Console.WriteLine("5- Sair:\n");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    CadastrarCliente();
                    break;
                case "2":
                    Console.Clear();
                    EditarCadastro();
                    break;
                case "3":
                    Console.Clear();
                    DeletarCadastro();
                    break;
                case "4":
                    Console.Clear();
                    VerCadastro();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Encerrando...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente:");
                    break;
            }
        }

        static void CadastrarCliente()
        {
            Console.WriteLine("Faça Seu Cadastro:\n");
            Cliente cadastro = new Cliente();
            cadastro.Id = nextId++;

            Console.WriteLine($"Seu Id é: {cadastro.Id}\n");

            Console.Write("Digite seu Nome: \n");
            cadastro.Nome = Console.ReadLine();
            Console.Write("Digite sua Idade: \n");
            cadastro.Idade = int.Parse(Console.ReadLine());
            Console.Write("Digite seu Telefone: \n");
            cadastro.Telefone = Console.ReadLine();
            Console.Write("Digite seu Email: \n");
            cadastro.Email = Console.ReadLine();

            clientes.Add(cadastro);
            Console.WriteLine("Seu cadastro foi um sucesso!");
            Console.Clear();
        }

        static void EditarCadastro()
        {
            if (clientes.Count != 0)
            {
                Console.Write("Digite o ID do cadastro que você quer EDITAR: ");
                int id = int.Parse(Console.ReadLine());
                Cliente cadastro = clientes.Find(c => c.Id == id);

                if (cadastro != null)
                {
                    Console.Write("Atualizar Nome:");
                    string nome = Console.ReadLine();
                    cadastro.Nome = nome;

                    Console.Write("Atualizar Idade: ");
                    int idade = int.Parse(Console.ReadLine());
                    cadastro.Idade = idade;

                    Console.Write("Atualizar Telefone: ");
                    string telefone = Console.ReadLine();
                    cadastro.Telefone = telefone;

                    Console.Write("Atualizar Email: ");
                    string email = Console.ReadLine();
                    cadastro.Email = email;

                    Console.WriteLine("Cadastro atualizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cadastro não encontrado.");

                }
            }
            else
            {
                Console.WriteLine("Nenhum Cliente Cadastrado no momento\n -Pressione para voltar ao Menu-");
                Console.ReadLine();
            }
            Console.Clear();
        }

        static void DeletarCadastro()
        {
            if (clientes.Count != 0)
            {
                Console.Write("Digite o ID do cliente que você quer DELETAR: ");
                int id = int.Parse(Console.ReadLine());
                Cliente cadastro = clientes.Find(client => client.Id == id);

                if (cadastro != null)
                {
                    clientes.Remove(cadastro);
                    Console.WriteLine("Cadastro removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Cadastro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Nenhum Cliente Cadastrado no momento\n -Pressione para voltar ao Menu-");
                Console.ReadLine();
            }
            Console.Clear();
        }

        static void VerCadastro()
        {
            if (clientes.Count != 0)
            {
                Console.WriteLine("Lista de Clientes:\n");
                foreach (var cadastro in clientes)
                {
                    Console.WriteLine($"ID: {cadastro.Id}, \nNome: {cadastro.Nome}, \nEndereço: {cadastro.Idade}, \nTelefone: {cadastro.Telefone}, \nEmail: {cadastro.Email} \n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Nenhum Cliente Cadastrado no momento\n -Pressione para voltar ao Menu-");
                Console.ReadLine();
            }
        }
    }
}

