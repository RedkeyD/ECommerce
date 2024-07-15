using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure( EntityTypeBuilder<OrderItem> builder )
        {
            builder.HasKey( oi => oi.Id );

            builder
                .HasOne( oi => oi.Order )
                .WithMany( o => o.OrderItems );

            builder
                .HasOne( oi => oi.Product )
                .WithMany();

        }
    }
}