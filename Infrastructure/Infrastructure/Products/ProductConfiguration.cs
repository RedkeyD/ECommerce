using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasAlternateKey(p => p.PublicId);

            builder.Property( p => p.Name ).HasColumnName( nameof( Product.Name ) ).HasMaxLength(20).IsRequired();
            builder.Property( p => p.Description ).HasColumnName( nameof( Product.Description ) ).HasMaxLength( 1500 );
            builder.Property( p => p.Price ).HasColumnName( nameof( Product.Price ) ).IsRequired();
            builder.Property( p => p.CategoryId ).HasColumnName( nameof( Product.CategoryId ) ).IsRequired();
            builder.Property( p => p.ImageUrl ).HasColumnName( nameof( Product.ImageUrl ) ).IsRequired();

            builder
                .HasOne(p => p.Category)
                .WithMany(c => c.Products);

            builder
                .HasMany(p => p.Reviews)
                .WithOne(r => r.Product)
                .HasForeignKey(r => r.ProductId);

        }
    }
}