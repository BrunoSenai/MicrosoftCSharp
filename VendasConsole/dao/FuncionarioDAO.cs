using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.models;

namespace VendasConsole.dao
{
    class FuncionarioDAO
    {
        private static List<Funcionario> funcionarioLista = new List<Funcionario>();
        private static Funcionario f = new Funcionario();

        public FuncionarioDAO()
        {
            funcionarioLista = new List<Funcionario>();
            f = new Funcionario();
        }

        public static void cadastrar(Funcionario funcionario)
        {
            funcionarioLista.Add(funcionario);
        }

        public static List<Funcionario> listar()
        {
            return funcionarioLista;
        }

        public static Funcionario buscarPorCpf(string cpf)
        {
            foreach (Funcionario funcionario in funcionarioLista)
            {
                if (funcionario.Cpf.Equals(cpf))
                {
                    return funcionario;
                }
            }
            return null;
        }
    }
}
