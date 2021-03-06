using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public abstract class BaseDomain
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Ativo { get; set; }
    }
}
