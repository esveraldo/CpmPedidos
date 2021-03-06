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
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        public ProdutoMap() : base("tb_produto")
        {
        }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Codigo).HasColumnName("codigo").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17, 2).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            // 1 : n com categoria, sempre feito do lado 1 do relacionamento nesse caso produto, relacionamento anbiguo
            builder.Property(x => x.CategoriaId).HasColumnName("categoria_id").IsRequired();
            builder.HasOne(x => x.Categorias).WithMany(x => x.Produtos).HasForeignKey(x => x.CategoriaId);
        }
    }
}
