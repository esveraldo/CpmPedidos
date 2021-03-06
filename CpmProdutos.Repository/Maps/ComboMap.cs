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
    public class ComboMap : BaseDomainMap<Combo>
    {
        public ComboMap() : base("tb_combo")
        {
        }

        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(150).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17, 2).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

            // 1 : n com imagem, sempre feito do lado 1 do relacionamento nesse caso promocaproduto que só pode ter uma imagem
            builder.Property(x => x.ImagemId).HasColumnName("imagem_id").IsRequired();
            builder.HasOne(x => x.Imagens).WithMany().HasForeignKey(x => x.ImagemId);

            // n : n com combo e produto(explicita, tem duas listas uma em cada entidade)
            builder.HasMany(x => x.Produtos).WithMany(x => x.Combos).UsingEntity<ProdutoCombo>(
                x => x.HasOne(p => p.Produto).WithMany().HasForeignKey(p => p.ProdutoId),
                x => x.HasOne(c => c.Combo).WithMany().HasForeignKey(c => c.ComboId),
                x =>
                {
                    x.ToTable("tb_produto_combo");

                    x.HasKey(f => new { f.ComboId, f.ProdutoId });

                    x.Property(x => x.ProdutoId).HasColumnName("produto_id").IsRequired();
                    x.Property(x => x.ComboId).HasColumnName("combo_id").IsRequired();
                }
            );

        }
    }
}
