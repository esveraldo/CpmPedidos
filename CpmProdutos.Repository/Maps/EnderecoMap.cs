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
    public class EnderecoMap : BaseDomainMap<Endereco>
    {
        public EnderecoMap() : base("tb_endereco")
        {
        }

        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Tipo).HasColumnName("tipo").IsRequired();
            builder.Property(x => x.Logradouro).HasColumnName("logradouro").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(10);
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(50);
            builder.Property(x => x.Cep).HasColumnName("cep").HasMaxLength(10);

            // 1: 1 com cliente
            builder.HasOne(x => x.Clientes).WithOne(x => x.Enderecos).HasForeignKey<Cliente>(x => x.EnderecoId);

            // 1 : n com cidade, sempre feito do lado 1 do relacionamento nesse caso endereço que só pode ter uma cidade
            builder.Property(x => x.CidadeId).HasColumnName("cidade_id").IsRequired();
            builder.HasOne(x => x.Cidades).WithMany().HasForeignKey(x => x.CidadeId);



        }
    }
}
