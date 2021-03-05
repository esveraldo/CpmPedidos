using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class ProdutoPedido : BaseDomain
    {
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}
