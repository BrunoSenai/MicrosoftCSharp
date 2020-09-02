using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.models;

namespace VendasConsole.dao
{
    class Dados
    {

        public static void IniciarDados()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Bruno Ribeiro",
                Cpf = "11259285901"
            };

            ClienteDAO.cadastrar(cliente);

            cliente = new Cliente
            {
                Nome = "Robison The Great",
                Cpf = "41562421026"
            };

            ClienteDAO.cadastrar(cliente);

            Funcionario funcionario = new Funcionario()
            {
                Nome = "Amandaa Batizada",
                Cpf = "11259285901"
            };

            FuncionarioDAO.cadastrar(funcionario);

            funcionario = new Funcionario()
            {
                Nome = "Tadeu",
                Cpf = "35905885001"
            };

            FuncionarioDAO.cadastrar(funcionario);

            Produto produto = new Produto()
            {
                Nome = "Chocolate",
                Preco = 3.50,
                Quantidade = 100
            };

            ProdutoDAO.cadastrar(produto);

            produto = new Produto()
            {
                Nome = "Bolacha",
                Preco = 2.90,
                Quantidade = 150
            };

            ProdutoDAO.cadastrar(produto);

            produto = new Produto()
            {
                Nome = "Arroz",
                Preco = 6.50,
                Quantidade = 80
            };

            ProdutoDAO.cadastrar(produto);

            produto = new Produto()
            {
                Nome = "Doce de Leite",
                Preco = 4.80,
                Quantidade = 50
            };

            ProdutoDAO.cadastrar(produto);

        }

    }
}
