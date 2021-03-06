using CpmPedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class Cliente : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Enderecos { get; set; }
        public bool Ativo { get; set; }
        public virtual List<Pedido> Pedidos { get; set; }
    }
}
