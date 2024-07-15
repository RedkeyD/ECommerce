using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.PublicId);

            builder.Property( c => c.Name ).HasColumnName( nameof( Category.Name ) ).HasMaxLength(50).IsRequired();
            builder.Property( c => c.Description ).HasColumnName( nameof( Category.Description ) ).HasMaxLength(1500);

            builder
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

        }
    }
}