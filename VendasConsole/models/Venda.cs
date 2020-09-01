using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.models
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            Carrinho = new List<ListaVenda>();
        }

        public Cliente Cliente { get; set; }

        public Funcionario Funcionario { get; set; }

        public List<ListaVenda> Carrinho { get; set; }

        public double PrecoFinal { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            string notaFiscal = "";

            foreach (ListaVenda carro in Carrinho)
            {
                notaFiscal = notaFiscal + carro.ToString();
            }

            return $"Cliente: {Cliente.Nome}\n\nFuncionario: {Funcionario.Nome}\n\n{notaFiscal}\nTotal: R$ {PrecoFinal}";
        }

    }
}
