using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Products
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("product");

            builder.HasKey(p => p.Id);
            builder.HasAlternateKey(p => p.PublicId);

            builder.Property(p => p.Id).HasColumnName("id").IsRequired();
            builder.Property(p => p.PublicId).HasColumnName("public_id").IsRequired();
            builder.Property(p => p.Name).HasColumnName("name").HasMaxLength(20).IsRequired();
            builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(1500);
            builder.Property(p => p.Price).HasColumnName("price").IsRequired();
            builder.Property(p => p.CategoryId).HasColumnName("category_id").IsRequired();
            builder.Property(p => p.ImageUrl).HasColumnName("image_url").IsRequired();

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