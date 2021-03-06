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
    public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
    {
        public ProdutoPedidoMap() : base("tb_produto_pedido")
        {
        }

        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Quantidade).HasColumnName("quantidade").HasPrecision(2).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17, 2).IsRequired();

            // n : n unidirecional de pedido para produto(explicita)
            builder.Property(x => x.PedidoId).HasColumnName("pedido_id").IsRequired();
            builder.HasOne(x => x.Pedido).WithMany(x => x.Produtos).HasForeignKey(x => x.PedidoId);

            builder.Property(x => x.ProdutoId).HasColumnName("produto_id").IsRequired();
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);
        }
    }
}
