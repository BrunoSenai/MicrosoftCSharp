using System;
using VendasConsole.dao;
using VendasConsole.models;
using VendasConsole.utils;

namespace VendasConsole.views
{
    class ClienteView
    {
        private static Cliente c = new Cliente();

        public static void cadastrarCliente()
        {
            c = new Cliente();

            Console.WriteLine("\nInforme seu CPF: ");
            c.Cpf = Console.ReadLine();

            if (Utils.validarCpf(c.Cpf))
            {
                if (ClienteDAO.buscarPorCpf(c.Cpf) != null)
                {
                    Console.WriteLine("\nCliente já possui cadastro no sistema!");
                }
                else
                {
                    Console.WriteLine("Informe seu nome: ");
                    c.Nome = Console.ReadLine();
                    ClienteDAO.cadastrar(c);
                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Cpf Invalido!");
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void listarClientes()
        {
            foreach (Cliente cliente in ClienteDAO.listar())
            {
                Console.WriteLine(cliente.ToString());
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        


    }
}
