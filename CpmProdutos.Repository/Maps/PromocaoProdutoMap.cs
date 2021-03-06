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
    public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
    {
        public PromocaoProdutoMap() : base("tb_promocao_produto")
        {
        }

        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17, 2).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            // 1 : n com imagem, sempre feito do lado 1 do relacionamento nesse caso promocaproduto que só pode ter uma imagem
            builder.Property(x => x.ImagemId).HasColumnName("imagem_id").IsRequired();
            builder.HasOne(x => x.Imagem).WithMany().HasForeignKey(x =>x.ImagemId);

            // 1 : n com promocaoproduto, sempre feito do lado 1 do relacionamento nesse caso produto, relacionamento anbiguo
            builder.Property(x => x.ProdutoId).HasColumnName("produto_id").IsRequired();
            builder.HasOne(x => x.Produtos).WithMany(x => x.Promocoes).HasForeignKey(x => x.ProdutoId);
        }
    }
}
