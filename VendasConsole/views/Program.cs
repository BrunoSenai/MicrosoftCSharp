using System;
using System.Runtime.InteropServices;
using VendasConsole.dao;
using VendasConsole.models;
using VendasConsole.views;

namespace VendasConsole.views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("PROJETO VENDAS");
                Console.WriteLine("\n\nMENU ------");
                Console.WriteLine("\n1 - Cadastrar Cliente");
                Console.WriteLine("\n2 - Listar Clientes");
                Console.WriteLine("\n3 - Cadastrar Funcionario");
                Console.WriteLine("\n4 - Listar Funcionarios");
                Console.WriteLine("\n5 - Cadastrar Produto");
                Console.WriteLine("\n6 - Listar Produtos");
                Console.WriteLine("\n\n0 - Sair");

                Console.WriteLine("\n\nInforme a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nSaindo..");
                        break;
                    case 1:
                        Console.WriteLine("CADASTRAR CLIENTE ------ \n");
                        ClienteView.cadastrarCliente();
                        break;
                    case 2:
                        Console.WriteLine("LISTAGEM DE CLIENTES ------ \n");
                        ClienteView.listarClientes();
                        break;
                    case 3:
                        Console.WriteLine("CADASTRAR FUNCIONÁRIO ------ \n");
                        FuncionarioView.cadastrarFuncionario();
                        break;
                    case 4:
                        Console.WriteLine("LISTAGEM DE FUNCIONÁRIOS ------ \n");
                        FuncionarioView.listarFuncionarios();
                        break;
                    case 5:
                        Console.WriteLine("CADASTRAR PRODUTO ------ \n");
                        ProdutoView.cadastrarProduto();
                        break;
                    case 6:
                        Console.WriteLine("LISTAGEM DE PRODUTOS ------ \n");
                        ProdutoView.listarProdutos();
                        break;
                    default:
                        Console.WriteLine("\nOpção Invalida. Tente novamente!\n");
                        break;
                }
                Console.Clear();

            } while (opcao != 0);



        }
    }
}
