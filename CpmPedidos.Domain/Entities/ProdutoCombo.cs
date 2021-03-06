using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class ProdutoCombo
    {
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int ComboId { get; set; }
        public virtual Combo Combo { get; set; }
    }
}
