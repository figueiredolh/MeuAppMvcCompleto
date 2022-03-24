﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Models
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public Endereco Endereco { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public bool Ativo { get; set; }

        //EF Relation
        public IEnumerable<Produto> Produtos { get; set; }
    }
}