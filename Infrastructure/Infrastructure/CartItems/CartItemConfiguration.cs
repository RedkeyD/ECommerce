using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.CartItems
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(ci => ci.Id);
            builder.HasAlternateKey(ci => ci.PublicId);

            builder.Property(ci => ci.CartId).HasColumnName(nameof(CartItem.CartId)).IsRequired();
            builder.Property( ci => ci.ProductId ).HasColumnName( nameof( CartItem.ProductId ) ).IsRequired();
            builder.Property( ci => ci.Quantity ).HasColumnName( nameof( CartItem.Quantity ) ).IsRequired();

            builder
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems);

            builder
                .HasOne(ci => ci.Product)
                .WithMany();
        }
    }
}