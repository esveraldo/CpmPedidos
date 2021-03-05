﻿using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class PromocaoProduto : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int ImagemId { get; set; }
        public virtual Imagem Imagem { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public bool Ativo { get; set; }
    }
}
