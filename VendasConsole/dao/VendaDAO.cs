using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.models;

namespace VendasConsole.dao
{
    class VendaDAO
    {

        private static List<Venda> vendas = new List<Venda>();
        private static Venda venda = new Venda();

        public VendaDAO()
        {
            venda = new Venda();
            vendas = new List<Venda>();
        }

        public static void cadastrar(Venda venda)
        {
            vendas.Add(venda);
        }

        public static List<Venda> listar()
        {
            return vendas;
        }

    }
}
