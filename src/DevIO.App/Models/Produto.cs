﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Models
{
    public class Produto
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        //EF Relation
        public Fornecedor Fornecedor { get; set; }
    }
}