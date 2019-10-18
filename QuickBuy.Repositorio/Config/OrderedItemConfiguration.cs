using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;

namespace QuickBuy.Repositorio.Config
{
    public class OrderedItemConfiguration : IEntityTypeConfiguration<OrderedItem>
    {
        public void Configure(EntityTypeBuilder<OrderedItem> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ProductId)
                .IsRequired();
            builder.Property(i => i.Amount)
                .IsRequired();
        }
    }
}
