using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure( EntityTypeBuilder<Order> builder )
        {
            builder.HasKey( o => o.Id );
            builder.HasAlternateKey( o => o.PublicId );

            builder.Property( o => o.Id ).HasColumnName( "id" );
            builder.Property( o => o.PublicId ).HasColumnName( "public_id" );
            builder.Property( o => o.UserId ).HasColumnName( "user_id" ).IsRequired();
            builder.Property( o => o.OrderDate ).HasColumnName( "order_date" ).IsRequired();
            builder.Property( o => o.Status ).HasConversion<int>().HasColumnName( "status" ).IsRequired();

            builder
                .HasOne( o => o.User )
                .WithMany( u => u.Orders );

            builder
                .HasMany( o => o.OrderItems )
                .WithOne( oi => oi.Order )
                .HasForeignKey( oi => oi.OrderId );
        }
    }
}