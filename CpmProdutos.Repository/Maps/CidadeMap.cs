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
    public class CidadeMap : BaseDomainMap<Cidade>
    {
        public CidadeMap() : base("tb_cidade")
        {
        }

        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.UF).HasColumnName("uf").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }
    }
}
