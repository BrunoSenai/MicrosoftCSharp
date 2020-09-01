using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.models;

namespace VendasConsole.dao
{
    class ProdutoDAO
    {

        private static List<Produto> produtos = new List<Produto>();
        private static Produto produto = new Produto();

        public ProdutoDAO()
        {
            produtos = new List<Produto>();
            produto = new Produto();
        }

        public static void cadastrar(Produto produto)
        {
            produtos.Add(produto);
        }

        public static List<Produto> listar()
        {
            return produtos;
        }

        public static Produto buscarProduto(string nome)
        {
            foreach (Produto produto in produtos)
            {
                if (produto.Nome.Equals(nome))
                {
                    return produto;
                }
            }
            return null;
        }

    }
}
