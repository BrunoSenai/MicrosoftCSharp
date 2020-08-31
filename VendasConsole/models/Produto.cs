using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.models
{
    class Produto
    {

        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Preço: {Preco} | Quantidade em estoque: {Quantidade}";
        }
    }
}
