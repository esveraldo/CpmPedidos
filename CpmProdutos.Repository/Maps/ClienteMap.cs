using CpmPedidos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmProdutos.Repository.Maps
{
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base("tb_cliente")
        {
        }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Cpf).HasColumnName("cpf").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            // 1 : 1 com endereco
            builder.Property(x => x.EnderecoId).HasColumnName("endereco_id").IsRequired();
        }
    }
}
