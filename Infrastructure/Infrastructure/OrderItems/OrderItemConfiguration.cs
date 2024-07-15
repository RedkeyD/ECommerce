using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.OrderItems
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.Id);
            builder.HasAlternateKey(oi => oi.PublicId);

            builder.Property( oi => oi.OrderId ).HasColumnName( nameof( OrderItem.OrderId ) ).IsRequired();
            builder.Property( oi => oi.ProductId ).HasColumnName( nameof( OrderItem.ProductId ) ).IsRequired();
            builder.Property( oi => oi.Quantity ).HasColumnName( nameof( OrderItem.Quantity ) ).IsRequired();
            builder.Property( oi => oi.Price ).HasColumnName( nameof( OrderItem.Price ) ).IsRequired();
            builder.Property( oi => oi.Currency ).HasColumnName( nameof( OrderItem.Currency ) ).IsRequired();

            builder
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems);

            builder
                .HasOne(oi => oi.Product)
                .WithMany();

        }
    }
}