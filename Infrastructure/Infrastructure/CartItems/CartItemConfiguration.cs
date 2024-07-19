using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.CartItems
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure( EntityTypeBuilder<CartItem> builder )
        {
            builder.ToTable( "cart_item" );

            builder.HasKey( ci => ci.Id );
            builder.HasAlternateKey( ci => ci.PublicId );

            builder.Property( ci => ci.Id ).HasColumnName( "id" ).IsRequired();
            builder.Property( ci => ci.PublicId ).HasColumnName( "public_id" ).IsRequired();
            builder.Property( ci => ci.CartId ).HasColumnName( "cart_id" ).IsRequired();
            builder.Property( ci => ci.ProductId ).HasColumnName( "product_id" ).IsRequired();
            builder.Property( ci => ci.Quantity ).HasColumnName( "quantity" ).IsRequired();

            builder
                .HasOne( ci => ci.Cart )
                .WithMany( c => c.CartItems );

            builder
                .HasOne( ci => ci.Product )
                .WithMany();
        }
    }
}