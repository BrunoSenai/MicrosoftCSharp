using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.models
{
    class ListaVenda
    {
        public ListaVenda()
        {
            Produto = new Produto();
        }
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public override string ToString()
        {
            return $"Produto: {Produto.Nome} - Preço: R$ {Produto.Preco} - Quantidade: {Quantidade}\n";
        }

    }
}
