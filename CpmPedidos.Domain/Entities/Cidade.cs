using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class Cidade : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string UF { get; set; }
    }
}
