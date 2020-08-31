using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.dao;
using VendasConsole.models;

namespace VendasConsole.views
{
    class ProdutoView
    {

        private static Produto produto = new Produto();

        public static void cadastrarProduto()
        {

            produto = new Produto();

            Console.WriteLine("\nInforme o nome:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("\nInforme o preço:");
            produto.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nInforme a quantidade em estoque:");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine());

            ProdutoDAO.cadastrar(produto);

        }

        public static void listarProdutos()
        {
            foreach (Produto produto in ProdutoDAO.listar())
            {
                Console.WriteLine(produto.ToString());
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }


    }
}
