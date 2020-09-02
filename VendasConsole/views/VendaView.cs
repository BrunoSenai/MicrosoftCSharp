using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.dao;
using VendasConsole.models;

namespace VendasConsole.views
{
    class VendaView
    {
        public static void cadastrarVenda()
        {
            string confirma = "";


            Venda venda = new Venda();
            Cliente cliente = new Cliente();
            Funcionario funcionario = new Funcionario();
            Produto produto = new Produto();
            ListaVenda LV = new ListaVenda();


            Console.WriteLine("\nInforme o CPF do cliente: ");
            cliente.Cpf = Console.ReadLine();

            cliente = ClienteDAO.buscarPorCpf(cliente.Cpf);

            if (cliente != null)
            {
                venda.Cliente = cliente;

                Console.WriteLine("\nInforme o CPF do funcionario: ");
                funcionario.Cpf = Console.ReadLine();

                funcionario = FuncionarioDAO.buscarPorCpf(funcionario.Cpf);

                if (funcionario != null)
                {
                    venda.Funcionario = funcionario;

                    do
                    {
                        LV = new ListaVenda();
                        produto = new Produto();

                        Console.WriteLine("\nInforme o nome do produto: ");
                        produto.Nome = Console.ReadLine();

                        produto = ProdutoDAO.buscarProduto(produto.Nome);

                        if (produto != null)
                        {
                            LV.Produto = produto;

                            Console.WriteLine("\nInforme a quantidade do produto: ");
                            LV.Quantidade = Convert.ToInt32(Console.ReadLine());

                            LV.Preco = produto.Preco;

                            venda.PrecoFinal = venda.PrecoFinal + (LV.Preco * LV.Quantidade);
                            venda.Carrinho.Add(LV);

                            Console.WriteLine("\nDeseja continuar comprando? Digite S ou N");
                            confirma = Console.ReadLine();

                            if (!confirma.Equals("S"))
                            {
                                VendaDAO.cadastrar(venda);
                                Console.WriteLine("\nCompra realizada com sucesso!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nProduto não encontrado!");
                            Console.ReadKey();
                        }
                    } while (confirma.Equals("S"));
                }
                else
                {
                    Console.WriteLine("\nFuncionario não encontrado!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\nCliente não encontrado!");
                Console.ReadKey();
            }
        }

        public static void listarVendas(List<Venda> vendas)
        {
            foreach (Venda venda in vendas)
            {
                Console.WriteLine("\n---------------------------------------\n");
                Console.WriteLine(venda.ToString());
            }
            Console.ReadKey();
        }


    }
}
