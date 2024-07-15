using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Carts
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.PublicId);

            builder.Property( c => c.UserId ).HasColumnName( nameof( Cart.UserId ) ).IsRequired();
            builder.Property(c => c.CreatedDate).HasColumnName( nameof( Cart.CreatedDate ) ).IsRequired();

            builder
                .HasOne(c => c.User)
                .WithOne(u => u.Cart);

            builder
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId);
        }
    }
}