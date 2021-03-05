using CpmPedidos.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CpmPedidos.Domain.Entities
{
    public class Endereco : BaseDomain
    {
        public TipoEnderecoEnum Tipo { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }

        public int CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
