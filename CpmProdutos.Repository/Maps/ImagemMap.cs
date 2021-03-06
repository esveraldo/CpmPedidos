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
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        public ImagemMap() : base("tb_imagem")
        {
        }

        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.NomeArquivo).HasColumnName("nome_arquivo").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Principal).HasColumnName("principal").IsRequired();
        }
    }
}
