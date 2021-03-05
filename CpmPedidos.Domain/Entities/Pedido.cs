using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class Pedido : BaseDomain
    {
        public string Nome { get; set; }
        public decimal ValorTotal { get; set; }
        public TimeSpan Entrega { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<ProdutoPedido> Produtos { get; set; }
    }
}
