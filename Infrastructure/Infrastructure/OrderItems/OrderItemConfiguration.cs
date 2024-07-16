using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.OrderItems
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure( EntityTypeBuilder<OrderItem> builder )
        {
            builder.HasKey( oi => oi.Id );
            builder.HasAlternateKey( oi => oi.PublicId );

            builder.Property( oi => oi.OrderId ).HasColumnName( "order_id" ).IsRequired();
            builder.Property( oi => oi.ProductId ).HasColumnName( "product_id" ).IsRequired();
            builder.Property( oi => oi.Quantity ).HasColumnName( "quantity" ).IsRequired();
            builder.Property( oi => oi.Price ).HasColumnName( "price" ).IsRequired();
            builder.Property( oi => oi.Currency ).HasColumnName( "currency" ).IsRequired();

            builder
                .HasOne( oi => oi.Order )
                .WithMany( o => o.OrderItems );

            builder
                .HasOne( oi => oi.Product )
                .WithMany();
        }
    }
}