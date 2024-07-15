using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure( EntityTypeBuilder<CartItem> builder )
        {
            builder.HasKey( ci => ci.Id );

            builder
                .HasOne( ci => ci.Cart )
                .WithMany( c => c.CartItems );

            builder
                .HasOne( ci => ci.Product )
                .WithMany();
        }
    }
}