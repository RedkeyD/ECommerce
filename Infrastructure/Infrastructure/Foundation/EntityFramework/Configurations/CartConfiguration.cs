using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure( EntityTypeBuilder<Cart> builder )
        {
            builder.HasKey( c => c.Id );

            builder
                .HasOne( c => c.User )
                .WithOne( u => u.Cart );

            builder
                .HasMany( c => c.CartItems )
                .WithOne( ci => ci.Cart )
                .HasForeignKey( ci => ci.CartId );

        }
    }
}