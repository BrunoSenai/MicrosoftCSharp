using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.dao;
using VendasConsole.models;
using VendasConsole.utils;

namespace VendasConsole.views
{
    class FuncionarioView
    {

        private static Funcionario func = new Funcionario();

        public static void cadastrarFuncionario()
        {
            func = new Funcionario();

            Console.WriteLine("\nInforme seu CPF: ");
            func.Cpf = Console.ReadLine();

            if (Utils.validarCpf(func.Cpf))
            {
                if (FuncionarioDAO.buscarPorCpf(func.Cpf) != null)
                {
                    Console.WriteLine("\nFuncionario já possui cadastro no sistema!");
                }
                else
                {
                    Console.WriteLine("Informe seu nome: ");
                    func.Nome = Console.ReadLine();
                    FuncionarioDAO.cadastrar(func);
                    Console.WriteLine("\nFuncionario cadastrado com sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Cpf Invalido!");
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();

        }
        public static void listarFuncionarios()
        {
            foreach (Funcionario funcionario in FuncionarioDAO.listar())
            {
                Console.WriteLine(funcionario.ToString());
            }

            Console.WriteLine("\nAperte qualquer tecla para continuar...");
            Console.ReadKey();
        }


    }
}
