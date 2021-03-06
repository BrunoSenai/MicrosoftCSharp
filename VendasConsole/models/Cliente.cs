﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.models
{
    class Cliente
    {
        public Cliente()
        {
            CriadoEm = DateTime.Now;
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Data de Cadastro: {CriadoEm}";
        }


    }
}
