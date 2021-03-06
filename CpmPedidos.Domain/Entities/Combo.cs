using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class Combo : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int ImagemId { get; set; }
        public virtual Imagem Imagens { get; set; }
        public int ProdutoId { get; set; }
        public virtual List<Produto> Produtos { get; set; }
        public bool Ativo { get; set; }
    }
}
