using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entities;
namespace QuickBuy.Repositorio.Config
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.DateRequest)
                .IsRequired();
            builder.Property(r => r.DeliveryForecast)
                .IsRequired();
            builder.Property(r => r.CEP)
                .IsRequired()
                .HasMaxLength(10);
            builder.Property(r => r.City)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(r => r.State)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(r => r.Address)
                .IsRequired()
                .HasMaxLength(200);
            builder.Property(r => r.AddressNumber)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
