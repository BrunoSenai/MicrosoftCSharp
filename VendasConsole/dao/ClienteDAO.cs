using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using VendasConsole.models;

namespace VendasConsole.dao
{
    class ClienteDAO
    {

        private static List<Cliente> clienteLista = new List<Cliente>();
        private static Cliente c = new Cliente();

        public ClienteDAO()
        {
            clienteLista = new List<Cliente>();
            c = new Cliente();
        }

        public static void cadastrar(Cliente cliente)
        {
            clienteLista.Add(cliente);
        }

        public static List<Cliente> listar()
        {
            return clienteLista;
        }

        public static Cliente buscarPorCpf(string cpf)
        {
            foreach (Cliente cliente in clienteLista)
            {
                if (cliente.Cpf.Equals(cpf))
                {
                    return cliente;
                }
            }
            return null;
        }
    }
}
