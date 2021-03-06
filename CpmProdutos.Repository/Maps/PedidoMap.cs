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
    public class PedidoMap : BaseDomainMap<Pedido>
    {
        public PedidoMap() : base("tb_pedido")
        {
        }

        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(150).IsRequired();
            builder.Property(x => x.ValorTotal).HasColumnName("valor_total").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Entrega).HasColumnName("entrega");

            // 1 : n com cliente, sempre feito do lado 1 do relacionamento nesse caso pedido, relacionamento anbiguo
            builder.Property(x => x.ClienteId).HasColumnName("cliente_id").IsRequired();
            builder.HasOne(x => x.Cliente).WithMany(x => x.Pedidos).HasForeignKey(x =>x.ClienteId);
        }
    }
}
